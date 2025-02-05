using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Drawing;

namespace WinFormsPrintTest
{

    public class ReceiptPrinter
    {
        PrintDocument pd;

        public string PrinterToUse { get; set; }
        private string printData;
        public string Data { 
            protected get { return printData; } 
            set {
                printData = value;
                pd.Print();
            } 
        }
        public Font UseFont { get; set; } = new Font("Arial", 12); 

        public ReceiptPrinter() {

            pd = new PrintDocument();

            pd.PrintPage += new PrintPageEventHandler(this.Pd_PrintPage);
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Get the Graphics object  
            Graphics g = e.Graphics;
            Font font = UseFont;
            //Create a solid brush with black color  
            SolidBrush brush = new SolidBrush(Color.Black);

            if (g != null)
            {
                SizeF size = g.MeasureString(printData, font);
                g.DrawString( printData,
                font, brush,
                new Rectangle(20, 20, (int)size.Width, (int)size.Height));
            }
        }

    }
}
