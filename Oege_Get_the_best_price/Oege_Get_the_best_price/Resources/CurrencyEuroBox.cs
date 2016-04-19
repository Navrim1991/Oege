using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oege_Get_the_best_price.Resources
{
    class CurrencyEuroBox : TextBox
    {
        private System.ComponentModel.IContainer components;
        public CurrencyEuroBox()
        {
            this.TextAlign = HorizontalAlignment.Right;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);


            NumberFormatInfo numberFormatInfo = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
            string decimalSeparator = numberFormatInfo.NumberDecimalSeparator;
            string currencySymbol = numberFormatInfo.CurrencySymbol;

            string keyInput = e.KeyChar.ToString();
            if(keyInput.Length == 1)
            {
                char key = e.KeyChar;

                if (Char.IsDigit(key))
                {
                    if(this.Text.Contains(decimalSeparator))
                    {
                        int index = this.Text.IndexOf(decimalSeparator);

                        if ((this.Text.Length - index) == 3)
                            e.Handled = true;
                        
                    }

                    if (this.Text.Contains(currencySymbol))
                        e.Handled = true;

                }
                else if (keyInput.Equals(decimalSeparator))
                {
                    if ((keyInput.Equals(decimalSeparator) && (this.Text.Contains(decimalSeparator) || this.Text.Length == 0)) 
                        || this.Text.Contains(currencySymbol))
                        e.Handled = true;                      
                    // Decimal separator is OK
                }
                else if (keyInput.Equals(currencySymbol))
                {
                    if (this.Text.Contains(currencySymbol) || this.Text.Length == 0)
                        e.Handled = true;
                }
                else if (key == '\b')
                {
                    // Backspace key is OK
                }
                else
                {
                    // Swallow this invalid key and beep
                    e.Handled = true;
                    //    MessageBeep();
                }
            }

            
        }

        public int IntValue
        {
            get
            {               
                return Int32.Parse(this.Text);
            }
        }

        public decimal DecimalValue
        {
            get
            {
                return Decimal.Parse(this.Text);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
