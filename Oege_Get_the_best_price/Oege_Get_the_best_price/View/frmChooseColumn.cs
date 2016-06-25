using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oege_Get_the_best_price.Model;
using Oege_Get_the_best_price.Controller;
using System.Threading;

namespace Oege_Get_the_best_price.View
{
    public partial class frmChooseColumn : Form
    {
        short level;
        Process excelProcess;
        List<object> param;
        string fileName = "";
        int guiHash;

        public frmChooseColumn(int hash, short level, ref List<object> param)
        {
            this.guiHash = hash;
            this.level = level;

            this.param = param;

            InitializeComponent();
        }

        private void frmChooseColumn_Load(object sender, EventArgs e)
        {

        }

        private void butOk_Click(object sender, EventArgs e)
        {
            param.Clear();
            param.Add(fileName);
            if (excelProcess != null)
            {
                excelProcess.Kill();
                //excelProcess.WaitForExit();

                Thread.Sleep(100);
            }

            if (txtDiscription.Text != "")
                param.Add(txtDiscription.Text.ToLower());
            else
                param.Add(-1);

            if (txtPrice.Text != "")
                param.Add(txtPrice.Text.ToLower());
            else
                param.Add(-1);

            param.Add(Controller.Controller.Instance().parseDouble(txtCurrencyConversion.Text, 1.0));

            if (txtEan.Text != "")
                param.Add(txtEan.Text.ToLower());
            else
                this.DialogResult = DialogResult.Cancel;


        }

        private void frmChooseColumn_Shown(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = @openFileDialog.FileName;
                excelProcess = Process.Start(fileName);
                param.Add(fileName);
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
        }

        private void frmChooseColumn_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult a = this.DialogResult;

            if (a == DialogResult.Cancel)
            {
                MessageBox.Show("Bitte geben Sie die Spalte der EAN an", "Fehlerhafte Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = @openFileDialog.FileName;
                    excelProcess = Process.Start(fileName);
                    param.Add(fileName);
                    e.Cancel = true;
                }
                else
                {
                    this.DialogResult = DialogResult.Abort;
                }

            }

        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
