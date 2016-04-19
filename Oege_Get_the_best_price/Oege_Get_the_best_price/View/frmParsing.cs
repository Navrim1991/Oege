using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oege_Get_the_best_price.Resources;

namespace Oege_Get_the_best_price.View
{
    public partial class frmParsing : Form
    {
        private static int frmCounter = 0;
        int hash;
        IFormHandler formHandler;

        public frmParsing(IFormHandler formHandler)
        {
            InitializeComponent();
            frmCounter++;
            hash = this.GetHashCode();
            this.formHandler = formHandler;
            formHandler.add(this);
        }

        private void frmParsing_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmCounter == 1)
                e.Cancel = true;
            else
            {
                frmCounter--;
                formHandler.delete(this.GetHashCode());
            }
                
        }

    }
}
