using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Currency_Control
{
    public partial class CurrencyControl: TextBox
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

                NumberFormatInfo numberFormatInfo = CultureInfo.CurrentCulture.NumberFormat;
                string decimalSeparator = numberFormatInfo.NumberDecimalSeparator;
                string currencySymbolEuro = numberFormatInfo.CurrencySymbol;
                string currencySymbolPfound = CultureInfo.CreateSpecificCulture("en-EN").NumberFormat.CurrencySymbol;

                string keyInput = e.KeyChar.ToString();
                if (keyInput.Length == 1)
                {
                    char key = e.KeyChar;

                    if (Char.IsDigit(key))
                    {
                        if (this.Text.Contains(decimalSeparator))
                        {
                            int index = this.Text.IndexOf(decimalSeparator);

                            if ((this.Text.Length - index) == 3)
                                e.Handled = true;

                        }

                        if (this.Text.Contains(currencySymbolEuro) || this.Text.Contains(currencySymbolPfound))
                            e.Handled = true;

                    }
                    else if (keyInput.Equals(decimalSeparator))
                    {
                        if ((keyInput.Equals(decimalSeparator) && (this.Text.Contains(decimalSeparator) || this.Text.Length == 0))
                            || (this.Text.Contains(currencySymbolEuro) || this.Text.Contains(currencySymbolPfound)))
                            e.Handled = true;
                        // Decimal separator is OK
                    }
                    else if (keyInput.Equals(currencySymbolEuro) || keyInput.Equals(currencySymbolPfound))
                    {
                        if ((this.Text.Contains(currencySymbolEuro) || this.Text.Contains(currencySymbolPfound)) || this.Text.Length == 0)
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
}
