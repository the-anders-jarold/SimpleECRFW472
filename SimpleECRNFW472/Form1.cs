using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Configuration;
using System.Windows.Forms;
using SwpTrmLib;
using SwpTrmLib.NexoTypes;
using WinFormsPrintTest;
using System.Drawing.Printing;
using SwpTrmLib.Nexo;
using System.Xml.Serialization;

namespace SwpTrmIfDemo
{
    public partial class Form1 : Form, ISwpTrmCallbackInterface
    {

        ISwPTrmIf_1 Pax;
        string FormTitle;
        string LogPath;
        bool SaveConfiguration = false;
        bool RePostOnFailedCardAcq = false;
        string SaleCapabilities;
        ReceiptPrinter receiptPrinter = null;
        bool SendPrintRequestToA920 = false;
        private string terminalIPnPort = string.Empty;
        public string TerminalIPnPort { 
            set { if (Pax != null) Pax.TerminalAddress = value; } }
        public bool Started { get; set; } = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SaveConfiguration)
                updateConfiguration();

            if (POIIDBox.Text == "")
            {
                MessageBox.Show("Enter a POIID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!Started)
            {
                SwpIfConfig cfg = new SwpIfConfig() 
                {
                    TerminalRxPort = int.Parse(ListenerPort.Text),
                    UICulture = UICultures.Text,
                };
                Pax = PAXTrmImp_1.Create(cfg, this);

                Pax.OnNewStatus += Pax_OnNewStatus;
//                Pax.OnPrintRequest += Pax_OnPrintRequest;
                Pax.OnTerminalAddressObtained += Pax_OnTerminalAddressObtained;

                if (DraftCapture.Checked == false && overrideHostAddr.Checked == true)
                {
                    //Pax.OverrideSpdhHostAddress = SPDHAddr.Text;
                }

                if (ClientOnlyBox.Checked)
                {
                    SaleCapabilities = "PrinterReceipt";
                }
                else
                {
                    SaleCapabilities = "CashierStatus CashierError CashierDisplay POIReplication CustomerAssistance CashierInput PrinterReceipt";
                }

                Pax.Start(new SaleApplInfo
                {
                    ProviderIdentification = "Demo",
                    SoftwareVersion = "1.0",
                    ApplicationName = "Test SwpIf",
                    POIID = POIIDBox.Text,
                    SaleCapabilities = SaleCapabilities,
                    SaleTerminalEnvironment = SaleTerminalEnvironment.Attended,
                });
                //OperatorLanguage = (OperatorLanguages)Enum.Parse(typeof(OperatorLanguages),operatorLanguages.Text)
                textBox1.AppendText("Init call finished!" + Environment.NewLine);
                openButton.Text = "Open";
                button1.Text = "Stop";
                Started = true;
            }
            else
            {
                Started = false;
                button1.Text = "Init";
                Pax.Stop();
                Pax = null;
            }
        }

        private void Pax_OnPrintRequest(bool TxnEnded, ReceiptData ReceiptData)
        {
            textBox1.AppendText(Environment.NewLine + "--------Receipt---------" + Environment.NewLine);
            textBox1.AppendText(ReceiptData.Blob + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine + "--------Receipt---------" + Environment.NewLine);

            if (TxnEnded)
            {
                textBox1.AppendText("Transaction Ended" + Environment.NewLine);
                textBox1.AppendText("----------------" + Environment.NewLine);
            }
        }

        private void Pax_OnTerminalAddressObtained(string ip4, int port)
        {
            textBox1.AppendText($"TerminalAddress: {ip4}:{port}" + Environment.NewLine);
            TerminalAddress.Text = ip4 + ":" + port.ToString();
        }

        private void Pax_OnPaymentResult(NexoResponseResult result, Newtonsoft.Json.Linq.JObject ReceiptData, Newtonsoft.Json.Linq.JObject SettlementData)
        {
            textBox1.AppendText($"Payment Result: {result}" + Environment.NewLine);
            textBox1.AppendText($"Receipt data: {ReceiptData}" + Environment.NewLine);
            textBox1.AppendText($"Settlement data: {SettlementData}" + Environment.NewLine);
        }

        private void Pax_OnPaymentInstrument(CardTypes type, string brand, string PAN, string CNA)
        {
            textBox1.AppendText($"PaymentInstrument: {type}, {brand}, {PAN}, {CNA}" + Environment.NewLine);
        }

        private void Pax_OnNewStatus(TrmStatus status)
        {
            textBox1.AppendText($"New status: {status}" + Environment.NewLine);


            switch (status)
            {
                case TrmStatus.Open: textBox1.AppendText($"terminal opened version: {Pax.TerminalVersion}" + Environment.NewLine); break;
                case TrmStatus.Closed: openButton.Text = "Open"; textBox1.AppendText("Closed" + Environment.NewLine); break;
                case TrmStatus.WaitForPaymentInstrument: textBox1.AppendText("Wait for card" + Environment.NewLine); break;
                case TrmStatus.CustomerKnown: textBox1.AppendText("Customer known" + Environment.NewLine); break;
                default: textBox1.AppendText("Unknown status occurred!" + Environment.NewLine); break;
            }

        }

        private void Pax_OnTerminalDisplay(string message)
        {
            textBox1.AppendText(message + Environment.NewLine);
        }

        private async void openButton_click(object sender, EventArgs e)
        {
            if (SaveConfiguration)
                updateConfiguration();

            if (TerminalAddress.Text != "" && Pax != null)
            {
                Pax.TerminalAddress = TerminalAddress.Text;
            }
            OpenResult result = await Pax?.OpenAsync(POIIDBox.Text);
            if (result.Result == ResponseResult.Success)
            {
                Text = $"{FormTitle}  Terminal: {result.SerialNumber}   Ver. {result.SoftwareVersion}";
                textBox1.AppendText($"Terminal {result.SerialNumber} Application version {result.SoftwareVersion}" + Environment.NewLine);
                if (result.SerialNumber.Substring(0, 3) == "185")
                {
                    SendPrintRequestToA920 = true;
                }
            }
            else
            {
                textBox1.AppendText($"Login failed: {result.Text}" + Environment.NewLine);
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var result = await Pax.GetPaymentInstrumentAsync();
            if (result.Result == NexoResponseResult.Failure)
            {
                textBox1.AppendText($"{result.ErrorCondition} {result.Text}" + Environment.NewLine);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Pax?.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (TerminalAddress.Text != "" && Pax != null)
            {
                Pax.TerminalAddress = TerminalAddress.Text;
            }

            Pax?.CloseAsync(MaintenanceAllowed.Checked);
        }
        private void SendAmountBtn_Click(object sender, EventArgs e)
        {

        }
        private async void NewCustomerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool xit = false;
                while (!xit)
                {
                    var result = await Pax?.GetPaymentInstrumentAsync();
                    if (result.Result == NexoResponseResult.Success)
                    {
                        xit = true;
                        textBox1.AppendText($"Customer known: {result.PAN} {Environment.NewLine}{result.CNA}{Environment.NewLine}");
                    }
                    else if (!RePostOnFailedCardAcq)
                    {
                        xit = true;
                        textBox1.AppendText($"{result.ErrorCondition}{Environment.NewLine}");
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("skrutt!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void refundBtn_Click(object sender, EventArgs e)
        {
            decimal amnt, total, cashBack;

            Amount_Leave(Total, e);
            amnt = decimal.Parse(Amount.Text, new CultureInfo("en-US"));
            total = decimal.Parse(Total.Text, new CultureInfo("en-US"));

            cashBack = total - amnt;

            string reference = GetTransactionReference("Omni reference:", "");

            var r = await Pax?.RefundAsync(amnt, reference);
            if (r.CustomerReceiptData != null)
            {
                textBox1.AppendText(r.CustomerReceiptData.ToString() + Environment.NewLine);
                textBox1.AppendText(Environment.NewLine + "--------Receipt---------" + Environment.NewLine);
                textBox1.AppendText(r.ReceiptBlob + Environment.NewLine);
                textBox1.AppendText("----------------" + Environment.NewLine);
            }
            if (r.ErrorCondition != null)
            {
                textBox1.AppendText(r.ErrorCondition + Environment.NewLine);
            }
            if (r.ResponseText != null)
            {
                textBox1.AppendText(r.ResponseText + Environment.NewLine);
            }
        }

        private async void purchaseBtn_Click(object sender, EventArgs e)
        {
            decimal amnt, total, cashBack;

            //                Amount_Leave(Amount, e);
            CultureInfo ci = new CultureInfo("en-US");

            Amount_Leave(Total, e);
            amnt = decimal.Parse(Amount.Text, ci);
            total = decimal.Parse(Total.Text, ci);

            cashBack = total - amnt;

            //Pax?.Payment(total, cashBack);
            var r = await Pax?.PaymentAsync(total, cashBack, (string)Currency.SelectedItem);
            if (r.ResponseResult == NexoResponseResult.Success)
            {
                textBox1.AppendText("Godkänt" + Environment.NewLine);
            }
            else
            {
                textBox1.AppendText("Nekat" + Environment.NewLine);
            }
            if (r.CustomerReceiptData != null)
            {
                var tip = r.TipAmount;
                textBox1.AppendText(r.CustomerReceiptData.ToString() + Environment.NewLine);
                if (PrintBox.Checked)
                {
                    PrintResult(r);
                }
                else
                {
                    textBox1.AppendText(Environment.NewLine + "--------Receipt---------" + Environment.NewLine);
                    textBox1.AppendText(r.ReceiptBlob + Environment.NewLine);
                    textBox1.AppendText("----------------" + Environment.NewLine);
                    textBox1.AppendText(r.ReceiptBlobNoHeader + Environment.NewLine);
                    textBox1.AppendText("----------------" + Environment.NewLine);
                    textBox1.AppendText($"ProductName: {r.ProductName}"+Environment.NewLine);
                    if (tip > 0) textBox1.AppendText($"Tip included: {tip}" + Environment.NewLine);
                    if (!string.IsNullOrEmpty(r.APMReference)) textBox1.AppendText($"APM reference: {r.APMReference}" + Environment.NewLine);
                    if (!string.IsNullOrEmpty(r.APMType)) textBox1.AppendText($"APM reference: {r.APMType}" + Environment.NewLine);
                    textBox1.AppendText("----------------" + Environment.NewLine);
                }
            }
            if (r.ErrorCondition != null)
            {
                textBox1.AppendText(r.ErrorCondition + Environment.NewLine);
            }
            if (r.ResponseText != null)
            {
                textBox1.AppendText(r.ResponseText + Environment.NewLine);
            }
        }

        private void Amount_Leave(object sender, EventArgs e)
        {
            TextBox tmp = (TextBox)sender;

            if (tmp != null)
            {
                if (tmp.Text.Length == 0)
                {
                    tmp.Text = "0.00";
                }
                else
                {
                    int pos = tmp.Text.LastIndexOf('.');
                    if (pos == -1)
                    {
                        tmp.Text += ".00";
                    }
                    else if ((pos + 1) > tmp.Text.Length)
                    {
                        tmp.Text += "0";
                        if ((pos + 1) > tmp.Text.Length)
                        {
                            tmp.Text += "0";
                        }
                    }
                }
                if (tmp.Name == "Amount")
                    Total.Text = tmp.Text;
            }
        }
        private void Amount_keydown(object sender, KeyEventArgs e)
        {
            TextBox tmp = (TextBox)sender;

            if (tmp != null)
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (tmp.Name == "Amount")
                    {
                        Total.Focus();
                    }
                    else if (tmp.Name == "Total")
                        newCustomerBtn.Focus();
                }
            }
        }

        private async void AbortBtn_Click(object sender, EventArgs e)
        {
            AbortRequestResult r = await Pax?.AbortAsync();
            if (r.ResponseResult == NexoResponseResult.Success)
            {
                textBox1.AppendText("Aborted" + Environment.NewLine);
            }
        }

        private async void updateTerminalBtn_Click(object sender, EventArgs e)
        {
            await Pax?.UpdateTerminalAsync();
            await Pax?.CloseAsync();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormTitle = Text = "Test texts";
            TerminalAddress.Text = ConfigurationManager.AppSettings["LogPath"];
            DraftCapture.Checked = ConfigurationManager.AppSettings["HostProtocol"] == "NexoACQ";
            ListenerPort.Text = ConfigurationManager.AppSettings["ListenerPort"];
            TerminalAddress.Text = ConfigurationManager.AppSettings["TerminalIP"];
            if (!String.IsNullOrEmpty(ConfigurationManager.AppSettings["POIID"])) {
                int ix = POIIDBox.Items.Add(ConfigurationManager.AppSettings["POIID"]);
                POIIDBox.SelectedIndex = ix;
            }
            LogPath = ConfigurationManager.AppSettings["LogPath"];
            RePostOnFailedCardAcq = Boolean.Parse(ConfigurationManager.AppSettings["RePostOnFailedCardAcq"] ?? "false");
            SaleCapabilities = ConfigurationManager.AppSettings["SaleCapabilities"];
            Currency.SelectedIndex = 0;

            UICultures.Text = CultureInfo.CurrentCulture.Name;
            UICultures.Items.Add(UICultures.Text);
            UICultures.Items.Add("nb-NO");
            UICultures.Items.Add("da-DK");
            UICultures.Items.Add("fi-FI");
            UICultures.SelectedIndex = 0;

            operatorLanguages.Text = CultureInfo.CurrentCulture.Name.Substring(0, 2);
            operatorLanguages.Items.Add(operatorLanguages.Text);
            operatorLanguages.Items.Add("sv");
            operatorLanguages.Items.Add("no");
            operatorLanguages.Items.Add("da");
            operatorLanguages.Items.Add("fi");
            operatorLanguages.SelectedIndex = 0;
        }

        private void clearsnfBtn_Click(object sender, EventArgs e)
        {
            Pax?.ClearSnFAsync();

        }

        private void DraftCapture_CheckedChanged(object sender, EventArgs e)
        {

            if (sender.GetType() == typeof(CheckBox))
            {
                CheckBox cbx = (CheckBox)sender;

                overrideHostAddr.Visible = !cbx.Checked;
                SPDHAddr.Visible = !cbx.Checked;
            }
            SaveConfiguration = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void ConfirmationHandler(string text, IConfirmationResult callback)
        {
            textBox1.AppendText($"Request for confirmation: {text}" + Environment.NewLine);
            DialogResult result = MessageBox.Show(text, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                callback.Confirmation(true);
            }
            else
            {
                callback.Confirmation(false);
            }
        }
        public void EventNotificationHandler(EventToNotifyEnumeration type, string text)
        {
            textBox1.AppendText($"{type} {text}" + Environment.NewLine);
        }

        private async void ReverseBtn_Click(object sender, EventArgs e)
        {
            var result = await Pax?.ReverseLastAsync();
            if (result.ResponseResult == NexoResponseResult.Success)
            {
                textBox1.AppendText(result.CustomerReceiptData.ToString() + Environment.NewLine);
                textBox1.AppendText("----------------" + Environment.NewLine);
                textBox1.AppendText(result.ReceiptBlob + Environment.NewLine);

            }
            else
            {
                textBox1.AppendText("Unable to reverse!" + Environment.NewLine);
                textBox1.AppendText(result.ResponseText + Environment.NewLine);
            }
        }

        private async void getCustomerConfirmationBtn_Click(object sender, EventArgs e)
        {

            var result = await Pax?.RequestCustomerConfirmationAsync(promptForText());
            textBox1.AppendText($"Response {result.Confirmation}" + Environment.NewLine);
        }

        private async void displayMessageBtn_Click(object sender, EventArgs e)
        {
            _ = await Pax?.RequestToDisplayAsync(promptForText());
        }
        private string promptForText()
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "enter text for terminal",
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = "Text to display" };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (xsender, xe) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "En text";
        }
        private void POIID_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfigurationChanged(object sender, EventArgs e)
        {
            TerminalIPnPort = TerminalAddress.Text;
            SaveConfiguration = true;
        }
        private void updateConfiguration()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["TerminalIP"].Value = TerminalAddress.Text;
            config.AppSettings.Settings["HostProtocol"].Value = DraftCapture.Checked ? "NexoACQ" : "SPDH";
            config.AppSettings.Settings["ListenerPort"].Value = ListenerPort.Text;
            config.AppSettings.Settings["POIID"].Value = POIIDBox.Text;

            config.Save(ConfigurationSaveMode.Modified);

            SaveConfiguration = false;

        }
        public static string GetTransactionReference(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ListenerLabel.Visible = ListenerPort.Visible = !ClientOnlyBox.Checked;
        }

        private void KeyInCardData_Click(object sender, EventArgs e)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Enter card data",
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = "format: [number]<=YYMM>" };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (s, e1) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            string data = prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            if (data != "")
            {
                Pax?.SetPaymentInstrument(data);
            }

        }

        private async void ContinueBtn_Click(object sender, EventArgs e)
        {
            await Pax?.ContinueAsync();
        }

        private async void LastResultBtn_Click(object sender, EventArgs e)
        {
            var r = await Pax?.GetLastTransactionResultAsync();
            if (r.ResponseResult == NexoResponseResult.Success)
            {
                textBox1.AppendText("Status request succeded!" + Environment.NewLine);
                textBox1.AppendText($"Transaction result: {r.TransactionResult}" + Environment.NewLine);
                textBox1.AppendText(r.ReceiptBlob + Environment.NewLine);
            }
            else
            {
                textBox1.AppendText("Status request failed!" + Environment.NewLine);
            }

        }

        private async void inputDigitsBtn_Click(object sender, EventArgs e)
        {
            var result = await Pax?.RequestCustomerDigitStringAsync("Ange siffror:");
            if (result.ResponseResult == NexoResponseResult.Success)
            {
                textBox1.AppendText($"Response {result.DigitString}" + Environment.NewLine);
            }
            else
            {
                textBox1.AppendText($"Nothing entered" + Environment.NewLine);
            }
        }

        private void POIIDBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.AppendText("POIID selected" + Environment.NewLine);

        }

        private void POIIDBox_Leave(object sender, EventArgs e)
        {
            if (!POIIDBox.Items.Contains(POIIDBox.Text))
            {
                int ix = POIIDBox.Items.Add(POIIDBox.Text);
                POIIDBox.SelectedIndex = ix;
            }
        }

        public void SyncRequestResult(object result)
        {
            throw new NotImplementedException();
        }

        public void EventCallback(EventCallbackObject eventObject)
        {
            switch (eventObject.type)
            {
                case EventCallbackTypes.DisplayEventCallback:
                    textBox1.AppendText((eventObject as DisplayEventCallback).Text + Environment.NewLine);
                    break;
                case EventCallbackTypes.PrintRequestEventCallback:
                    PrintRequestEventCallback po = (eventObject as PrintRequestEventCallback);
                    Pax_OnPrintRequest(po.TxnEnded, po.ReceiptData);
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PrintBox_CheckedChanged(object sender, EventArgs e)
        {
            PrinterSelectionBox.Enabled = PrintBox.Checked;
            if (PrintBox.Checked)
            {
                PrinterSelectionBox.Items.Clear();
                foreach (String printer in PrinterSettings.InstalledPrinters)
                {
                    PrinterSelectionBox.Items.Add(printer.ToString());
                }
                receiptPrinter = new ReceiptPrinter();
                PrinterSelectionBox.Focus();
            }
        }

        private void PrinterSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (receiptPrinter != null) { receiptPrinter.PrinterToUse = PrinterSelectionBox.Text; }
        }

        private async void PrintOnTrmBtn_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.FormClosed += Form2OnClose;
            var dr = form.ShowDialog();
            var r = await Pax.RequestToPrintAsync(form.GetOutputTexts());
        }
        private async void Form2OnClose(object sender, EventArgs e)
        {

        }
        private void collectSaleItems(List<OutputText> items)
        {
            items.Add(new OutputText()
            {
                Alignment = OutputText.Alignments.Centred,
                Content = "The Best Shop",
                Height = OutputText.CharacterHeights.DoubleHeight,
                Width = OutputText.CharacterWidths.DoubleWidth,
            });
            items.Add(new OutputText()
            {
                StartRow = 20,
                Alignment = OutputText.Alignments.Left,
                Content = "Phone: 88888888",
            });
            items.Add(new OutputText()
            {
                Alignment = OutputText.Alignments.Left,
                Content = "org.nr: 999999-9999",
            });
            items.Add(new OutputText()
            {
                StartRow = 30,
            });

            items.Add(new OutputText()
            {
                Alignment = OutputText.Alignments.Justified,
                Content = $"A ship full of IPA\t{Total.Text}"
            });
        }
        private async void PrintResult(PaymentRequestResult r)
        {
            
            List<OutputText> items = new List<OutputText>();

            collectSaleItems(items);

            items.Add(new OutputText()
            {
                Content = r.ReceiptBlobNoHeader,
                StartRow = 50,
            });

            if (PrintBox.Checked)
            {
                if (SendPrintRequestToA920)
                {
                    printOnA920(items);
                }
                else
                {
                    printOnWindowsPrinter(items);
                }
            }
        }
        private void printOnWindowsPrinter(List<OutputText> items)
        {
            StringBuilder sb = new StringBuilder();
            foreach (OutputText item in items) { sb.AppendLine(item.Content); }

            if (!string.IsNullOrEmpty(receiptPrinter.PrinterToUse)) 
            {
                receiptPrinter.Data = sb.ToString();
            }
            

        }
        private async void printOnA920(List<OutputText> items) 
        {
            bool xit = false;
            do
            {
                NexoRequestResult prr = await Pax.RequestToPrintAsync(items);
                if (prr.ResponseResult == NexoResponseResult.Failure &&
                        prr.ErrorCondition == ErrorConditionEnumeration.Busy.ToString())
                {
                    textBox1.AppendText("Retry print after delay...");
                    await Task.Delay(1000);
                }
                else xit = true;

            } while (!xit);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UICultures_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void operatorLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
