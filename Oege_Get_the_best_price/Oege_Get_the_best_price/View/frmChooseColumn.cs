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
        Controller.ExcelController excelController;
        Controller.Controller controller;
        short level;
        Process excelProcess;
        int eanColumn = -1;
        int discriptionColumn = -1;
        int priceColumn = -1;
        List<object> param;
        string fileName = "";

        public frmChooseColumn(int hash, short level,ref List<object> param)
        {
            this.level = level;            

            this.param = param;

            InitializeComponent();
        }

        private void frmChooseColumn_Load(object sender, EventArgs e)
        {

        }

        private void butOk_Click(object sender, EventArgs e)
        {
            if(excelProcess != null)
            {
                excelProcess.Kill();

                Thread.Sleep(100);
            }

            if (txtDiscription.Text != "")
                param.Add(txtDiscription.Text.ToLower().First() - 96);
            else
                param.Add(-1);

            if (txtPrice.Text != "")
                param.Add(txtPrice.Text.ToLower().First() - 96);
            else
                param.Add(-1);

            if (txtEan.Text != "")
                param.Add(txtEan.Text.ToLower().First() - 96);              
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
        }

        private void frmChooseColumn_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult a = this.DialogResult;

            if (a != DialogResult.OK)
            {
                MessageBox.Show("Bitte geben Sie die Spalte der EAN an", "Fehlerhafte Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                excelProcess = Process.Start(fileName);
                e.Cancel = true;
            }
                
        }
    }
}
