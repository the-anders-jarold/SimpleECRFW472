
namespace SwpTrmIfDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.purchaseBtn = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.Amount = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.newCustomerBtn = new System.Windows.Forms.Button();
            this.refundBtn = new System.Windows.Forms.Button();
            this.AbortBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.updateTerminalBtn = new System.Windows.Forms.Button();
            this.DraftCapture = new System.Windows.Forms.CheckBox();
            this.TerminalAddress = new System.Windows.Forms.TextBox();
            this.clearsnfBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ListenerPort = new System.Windows.Forms.TextBox();
            this.ListenerLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.overrideHostAddr = new System.Windows.Forms.CheckBox();
            this.SPDHAddr = new System.Windows.Forms.TextBox();
            this.ReverseBtn = new System.Windows.Forms.Button();
            this.getCustomerConfirmationBtn = new System.Windows.Forms.Button();
            this.displayMessageBtn = new System.Windows.Forms.Button();
            this.ClientOnlyBox = new System.Windows.Forms.CheckBox();
            this.KeyInCardData = new System.Windows.Forms.Button();
            this.ContinueBtn = new System.Windows.Forms.Button();
            this.LastResultBtn = new System.Windows.Forms.Button();
            this.inputDigitsBtn = new System.Windows.Forms.Button();
            this.POIIDBox = new System.Windows.Forms.ComboBox();
            this.MaintenanceAllowed = new System.Windows.Forms.CheckBox();
            this.Currency = new System.Windows.Forms.ComboBox();
            this.PrintBox = new System.Windows.Forms.CheckBox();
            this.PrinterSelectionBox = new System.Windows.Forms.ComboBox();
            this.PrintOnTrmBtn = new System.Windows.Forms.Button();
            this.operatorLanguages = new System.Windows.Forms.ComboBox();
            this.UICultures = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Init";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(166, 202);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(474, 1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(477, 497);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseBtn.Location = new System.Drawing.Point(328, 329);
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.Size = new System.Drawing.Size(131, 46);
            this.purchaseBtn.TabIndex = 4;
            this.purchaseBtn.Text = "Purchase";
            this.purchaseBtn.UseVisualStyleBackColor = true;
            this.purchaseBtn.Click += new System.EventHandler(this.purchaseBtn_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(247, 202);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Amount
            // 
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(328, 251);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(131, 20);
            this.Amount.TabIndex = 6;
            this.Amount.Text = "0,00";
            this.Amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Amount_keydown);
            this.Amount.Leave += new System.EventHandler(this.Amount_Leave);
            // 
            // Total
            // 
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(328, 303);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(131, 20);
            this.Total.TabIndex = 7;
            this.Total.Text = "0,00";
            this.Total.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Amount_keydown);
            this.Total.Leave += new System.EventHandler(this.Amount_Leave);
            // 
            // newCustomerBtn
            // 
            this.newCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCustomerBtn.Location = new System.Drawing.Point(166, 235);
            this.newCustomerBtn.Name = "newCustomerBtn";
            this.newCustomerBtn.Size = new System.Drawing.Size(156, 88);
            this.newCustomerBtn.TabIndex = 8;
            this.newCustomerBtn.Text = "Wait for Customer";
            this.newCustomerBtn.UseVisualStyleBackColor = true;
            this.newCustomerBtn.Click += new System.EventHandler(this.NewCustomerBtn_Click);
            // 
            // refundBtn
            // 
            this.refundBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refundBtn.Location = new System.Drawing.Point(328, 381);
            this.refundBtn.Name = "refundBtn";
            this.refundBtn.Size = new System.Drawing.Size(131, 50);
            this.refundBtn.TabIndex = 9;
            this.refundBtn.Text = "Refund";
            this.refundBtn.UseVisualStyleBackColor = true;
            this.refundBtn.Click += new System.EventHandler(this.refundBtn_Click);
            // 
            // AbortBtn
            // 
            this.AbortBtn.Location = new System.Drawing.Point(167, 455);
            this.AbortBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AbortBtn.Name = "AbortBtn";
            this.AbortBtn.Size = new System.Drawing.Size(156, 34);
            this.AbortBtn.TabIndex = 10;
            this.AbortBtn.Text = "Abort";
            this.AbortBtn.UseVisualStyleBackColor = true;
            this.AbortBtn.Click += new System.EventHandler(this.AbortBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "POIID";
            // 
            // updateTerminalBtn
            // 
            this.updateTerminalBtn.Location = new System.Drawing.Point(16, 408);
            this.updateTerminalBtn.Name = "updateTerminalBtn";
            this.updateTerminalBtn.Size = new System.Drawing.Size(128, 23);
            this.updateTerminalBtn.TabIndex = 13;
            this.updateTerminalBtn.Text = "Update terminal";
            this.updateTerminalBtn.UseVisualStyleBackColor = true;
            this.updateTerminalBtn.Click += new System.EventHandler(this.updateTerminalBtn_Click);
            // 
            // DraftCapture
            // 
            this.DraftCapture.AutoSize = true;
            this.DraftCapture.Checked = true;
            this.DraftCapture.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DraftCapture.Location = new System.Drawing.Point(13, 89);
            this.DraftCapture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DraftCapture.Name = "DraftCapture";
            this.DraftCapture.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DraftCapture.Size = new System.Drawing.Size(73, 17);
            this.DraftCapture.TabIndex = 14;
            this.DraftCapture.Text = "NexoACQ";
            this.DraftCapture.UseVisualStyleBackColor = true;
            this.DraftCapture.CheckedChanged += new System.EventHandler(this.DraftCapture_CheckedChanged);
            // 
            // TerminalAddress
            // 
            this.TerminalAddress.Location = new System.Drawing.Point(166, 35);
            this.TerminalAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TerminalAddress.Name = "TerminalAddress";
            this.TerminalAddress.Size = new System.Drawing.Size(156, 20);
            this.TerminalAddress.TabIndex = 15;
            this.TerminalAddress.TextChanged += new System.EventHandler(this.ConfigurationChanged);
            // 
            // clearsnfBtn
            // 
            this.clearsnfBtn.Location = new System.Drawing.Point(17, 437);
            this.clearsnfBtn.Name = "clearsnfBtn";
            this.clearsnfBtn.Size = new System.Drawing.Size(128, 23);
            this.clearsnfBtn.TabIndex = 16;
            this.clearsnfBtn.Text = "Clear S&&F";
            this.clearsnfBtn.UseVisualStyleBackColor = true;
            this.clearsnfBtn.Click += new System.EventHandler(this.clearsnfBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Terminal IP and port";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ListenerPort
            // 
            this.ListenerPort.Location = new System.Drawing.Point(166, 60);
            this.ListenerPort.Name = "ListenerPort";
            this.ListenerPort.Size = new System.Drawing.Size(100, 20);
            this.ListenerPort.TabIndex = 18;
            this.ListenerPort.Text = "11000";
            this.ListenerPort.TextChanged += new System.EventHandler(this.ConfigurationChanged);
            // 
            // ListenerLabel
            // 
            this.ListenerLabel.AutoSize = true;
            this.ListenerLabel.Location = new System.Drawing.Point(13, 60);
            this.ListenerLabel.Name = "ListenerLabel";
            this.ListenerLabel.Size = new System.Drawing.Size(65, 13);
            this.ListenerLabel.TabIndex = 19;
            this.ListenerLabel.Text = "Listener port";
            this.ListenerLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(325, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Total:";
            // 
            // overrideHostAddr
            // 
            this.overrideHostAddr.AutoSize = true;
            this.overrideHostAddr.Checked = true;
            this.overrideHostAddr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.overrideHostAddr.Location = new System.Drawing.Point(16, 111);
            this.overrideHostAddr.Name = "overrideHostAddr";
            this.overrideHostAddr.Size = new System.Drawing.Size(149, 17);
            this.overrideHostAddr.TabIndex = 22;
            this.overrideHostAddr.Text = "Override SPDH host addr.";
            this.overrideHostAddr.UseVisualStyleBackColor = true;
            this.overrideHostAddr.Visible = false;
            // 
            // SPDHAddr
            // 
            this.SPDHAddr.Location = new System.Drawing.Point(177, 108);
            this.SPDHAddr.Name = "SPDHAddr";
            this.SPDHAddr.Size = new System.Drawing.Size(106, 20);
            this.SPDHAddr.TabIndex = 23;
            this.SPDHAddr.Text = "164.10.203.25:6035";
            this.SPDHAddr.Visible = false;
            // 
            // ReverseBtn
            // 
            this.ReverseBtn.BackColor = System.Drawing.Color.DarkRed;
            this.ReverseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReverseBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ReverseBtn.Location = new System.Drawing.Point(328, 437);
            this.ReverseBtn.Name = "ReverseBtn";
            this.ReverseBtn.Size = new System.Drawing.Size(131, 52);
            this.ReverseBtn.TabIndex = 24;
            this.ReverseBtn.Text = "Reverse";
            this.ReverseBtn.UseVisualStyleBackColor = false;
            this.ReverseBtn.Click += new System.EventHandler(this.ReverseBtn_Click);
            // 
            // getCustomerConfirmationBtn
            // 
            this.getCustomerConfirmationBtn.Location = new System.Drawing.Point(16, 291);
            this.getCustomerConfirmationBtn.Name = "getCustomerConfirmationBtn";
            this.getCustomerConfirmationBtn.Size = new System.Drawing.Size(128, 23);
            this.getCustomerConfirmationBtn.TabIndex = 25;
            this.getCustomerConfirmationBtn.Text = "Get Confirmation";
            this.getCustomerConfirmationBtn.UseVisualStyleBackColor = true;
            this.getCustomerConfirmationBtn.Click += new System.EventHandler(this.getCustomerConfirmationBtn_Click);
            // 
            // displayMessageBtn
            // 
            this.displayMessageBtn.Location = new System.Drawing.Point(17, 262);
            this.displayMessageBtn.Name = "displayMessageBtn";
            this.displayMessageBtn.Size = new System.Drawing.Size(128, 23);
            this.displayMessageBtn.TabIndex = 26;
            this.displayMessageBtn.Text = "Display message";
            this.displayMessageBtn.UseVisualStyleBackColor = true;
            this.displayMessageBtn.Click += new System.EventHandler(this.displayMessageBtn_Click);
            // 
            // ClientOnlyBox
            // 
            this.ClientOnlyBox.AutoSize = true;
            this.ClientOnlyBox.Location = new System.Drawing.Point(16, 31);
            this.ClientOnlyBox.Name = "ClientOnlyBox";
            this.ClientOnlyBox.Size = new System.Drawing.Size(76, 17);
            this.ClientOnlyBox.TabIndex = 27;
            this.ClientOnlyBox.Text = "Client Only";
            this.ClientOnlyBox.UseVisualStyleBackColor = true;
            this.ClientOnlyBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // KeyInCardData
            // 
            this.KeyInCardData.Location = new System.Drawing.Point(166, 383);
            this.KeyInCardData.Name = "KeyInCardData";
            this.KeyInCardData.Size = new System.Drawing.Size(156, 46);
            this.KeyInCardData.TabIndex = 28;
            this.KeyInCardData.Text = "Key in Card Data";
            this.KeyInCardData.UseVisualStyleBackColor = true;
            this.KeyInCardData.Click += new System.EventHandler(this.KeyInCardData_Click);
            // 
            // ContinueBtn
            // 
            this.ContinueBtn.Location = new System.Drawing.Point(167, 329);
            this.ContinueBtn.Name = "ContinueBtn";
            this.ContinueBtn.Size = new System.Drawing.Size(156, 46);
            this.ContinueBtn.TabIndex = 29;
            this.ContinueBtn.Text = "Continue";
            this.ContinueBtn.UseVisualStyleBackColor = true;
            this.ContinueBtn.Click += new System.EventHandler(this.ContinueBtn_Click);
            // 
            // LastResultBtn
            // 
            this.LastResultBtn.Location = new System.Drawing.Point(17, 466);
            this.LastResultBtn.Name = "LastResultBtn";
            this.LastResultBtn.Size = new System.Drawing.Size(127, 23);
            this.LastResultBtn.TabIndex = 30;
            this.LastResultBtn.Text = "Last Result";
            this.LastResultBtn.UseVisualStyleBackColor = true;
            this.LastResultBtn.Click += new System.EventHandler(this.LastResultBtn_Click);
            // 
            // inputDigitsBtn
            // 
            this.inputDigitsBtn.Location = new System.Drawing.Point(17, 321);
            this.inputDigitsBtn.Name = "inputDigitsBtn";
            this.inputDigitsBtn.Size = new System.Drawing.Size(127, 23);
            this.inputDigitsBtn.TabIndex = 31;
            this.inputDigitsBtn.Text = "Ask for digits";
            this.inputDigitsBtn.UseVisualStyleBackColor = true;
            this.inputDigitsBtn.Click += new System.EventHandler(this.inputDigitsBtn_Click);
            // 
            // POIIDBox
            // 
            this.POIIDBox.FormattingEnabled = true;
            this.POIIDBox.Location = new System.Drawing.Point(338, 35);
            this.POIIDBox.Name = "POIIDBox";
            this.POIIDBox.Size = new System.Drawing.Size(121, 21);
            this.POIIDBox.TabIndex = 32;
            this.POIIDBox.SelectedIndexChanged += new System.EventHandler(this.POIIDBox_SelectedIndexChanged);
            this.POIIDBox.Leave += new System.EventHandler(this.POIIDBox_Leave);
            // 
            // MaintenanceAllowed
            // 
            this.MaintenanceAllowed.AutoSize = true;
            this.MaintenanceAllowed.Checked = true;
            this.MaintenanceAllowed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MaintenanceAllowed.Location = new System.Drawing.Point(338, 207);
            this.MaintenanceAllowed.Name = "MaintenanceAllowed";
            this.MaintenanceAllowed.Size = new System.Drawing.Size(125, 17);
            this.MaintenanceAllowed.TabIndex = 33;
            this.MaintenanceAllowed.Text = "MaintenanceAllowed";
            this.MaintenanceAllowed.UseVisualStyleBackColor = true;
            // 
            // Currency
            // 
            this.Currency.FormattingEnabled = true;
            this.Currency.Items.AddRange(new object[] {
            "SEK",
            "NOK",
            "DKK",
            "EUR"});
            this.Currency.Location = new System.Drawing.Point(338, 58);
            this.Currency.Name = "Currency";
            this.Currency.Size = new System.Drawing.Size(121, 21);
            this.Currency.TabIndex = 34;
            this.Currency.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PrintBox
            // 
            this.PrintBox.AutoSize = true;
            this.PrintBox.Location = new System.Drawing.Point(16, 143);
            this.PrintBox.Name = "PrintBox";
            this.PrintBox.Size = new System.Drawing.Size(87, 17);
            this.PrintBox.TabIndex = 35;
            this.PrintBox.Text = "Print receipts";
            this.PrintBox.UseVisualStyleBackColor = true;
            this.PrintBox.CheckedChanged += new System.EventHandler(this.PrintBox_CheckedChanged);
            // 
            // PrinterSelectionBox
            // 
            this.PrinterSelectionBox.FormattingEnabled = true;
            this.PrinterSelectionBox.Location = new System.Drawing.Point(162, 139);
            this.PrinterSelectionBox.Name = "PrinterSelectionBox";
            this.PrinterSelectionBox.Size = new System.Drawing.Size(297, 21);
            this.PrinterSelectionBox.TabIndex = 36;
            this.PrinterSelectionBox.SelectedIndexChanged += new System.EventHandler(this.PrinterSelectionBox_SelectedIndexChanged);
            // 
            // PrintOnTrmBtn
            // 
            this.PrintOnTrmBtn.Location = new System.Drawing.Point(16, 350);
            this.PrintOnTrmBtn.Name = "PrintOnTrmBtn";
            this.PrintOnTrmBtn.Size = new System.Drawing.Size(127, 23);
            this.PrintOnTrmBtn.TabIndex = 37;
            this.PrintOnTrmBtn.Text = "Print on Terminal";
            this.PrintOnTrmBtn.UseVisualStyleBackColor = true;
            this.PrintOnTrmBtn.Click += new System.EventHandler(this.PrintOnTrmBtn_Click);
            // 
            // operatorLanguages
            // 
            this.operatorLanguages.FormattingEnabled = true;
            this.operatorLanguages.Location = new System.Drawing.Point(338, 107);
            this.operatorLanguages.Name = "operatorLanguages";
            this.operatorLanguages.Size = new System.Drawing.Size(121, 21);
            this.operatorLanguages.TabIndex = 38;
            this.operatorLanguages.SelectedIndexChanged += new System.EventHandler(this.operatorLanguages_SelectedIndexChanged);
            // 
            // UICultures
            // 
            this.UICultures.FormattingEnabled = true;
            this.UICultures.Location = new System.Drawing.Point(338, 82);
            this.UICultures.Name = "UICultures";
            this.UICultures.Size = new System.Drawing.Size(121, 21);
            this.UICultures.TabIndex = 39;
            this.UICultures.SelectedIndexChanged += new System.EventHandler(this.UICultures_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 501);
            this.Controls.Add(this.UICultures);
            this.Controls.Add(this.operatorLanguages);
            this.Controls.Add(this.PrintOnTrmBtn);
            this.Controls.Add(this.PrinterSelectionBox);
            this.Controls.Add(this.PrintBox);
            this.Controls.Add(this.Currency);
            this.Controls.Add(this.MaintenanceAllowed);
            this.Controls.Add(this.POIIDBox);
            this.Controls.Add(this.inputDigitsBtn);
            this.Controls.Add(this.LastResultBtn);
            this.Controls.Add(this.ContinueBtn);
            this.Controls.Add(this.KeyInCardData);
            this.Controls.Add(this.ClientOnlyBox);
            this.Controls.Add(this.displayMessageBtn);
            this.Controls.Add(this.getCustomerConfirmationBtn);
            this.Controls.Add(this.ReverseBtn);
            this.Controls.Add(this.SPDHAddr);
            this.Controls.Add(this.overrideHostAddr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ListenerLabel);
            this.Controls.Add(this.ListenerPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearsnfBtn);
            this.Controls.Add(this.TerminalAddress);
            this.Controls.Add(this.DraftCapture);
            this.Controls.Add(this.updateTerminalBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AbortBtn);
            this.Controls.Add(this.refundBtn);
            this.Controls.Add(this.newCustomerBtn);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.purchaseBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "ISwPIf TestPOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button purchaseBtn;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Button newCustomerBtn;
        private System.Windows.Forms.Button refundBtn;
        private System.Windows.Forms.Button AbortBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateTerminalBtn;
        private System.Windows.Forms.CheckBox DraftCapture;
        private System.Windows.Forms.TextBox TerminalAddress;
        private System.Windows.Forms.Button clearsnfBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ListenerPort;
        private System.Windows.Forms.Label ListenerLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox overrideHostAddr;
        private System.Windows.Forms.TextBox SPDHAddr;
        private System.Windows.Forms.Button ReverseBtn;
        private System.Windows.Forms.Button getCustomerConfirmationBtn;
        private System.Windows.Forms.Button displayMessageBtn;
        private System.Windows.Forms.CheckBox ClientOnlyBox;
        private System.Windows.Forms.Button KeyInCardData;
        private System.Windows.Forms.Button ContinueBtn;
        private System.Windows.Forms.Button LastResultBtn;
        private System.Windows.Forms.Button inputDigitsBtn;
        private System.Windows.Forms.ComboBox POIIDBox;
        private System.Windows.Forms.CheckBox MaintenanceAllowed;
        private System.Windows.Forms.ComboBox Currency;
        private System.Windows.Forms.CheckBox PrintBox;
        private System.Windows.Forms.ComboBox PrinterSelectionBox;
        private System.Windows.Forms.Button PrintOnTrmBtn;
        private System.Windows.Forms.ComboBox operatorLanguages;
        private System.Windows.Forms.ComboBox UICultures;
    }
}

