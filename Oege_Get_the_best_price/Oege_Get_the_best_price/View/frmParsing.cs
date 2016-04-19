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
        Controller.Controller controller;
        Controller.DataController dataController;
        Controller.ExcelController excelController;
        Controller.FormController formController;
        Controller.Parsing.ParsingController parsingController;
        const short level = 1;

        public frmParsing()
        {
            InitializeComponent();
            frmCounter++;

            controller = Controller.Controller.Instance();
            controller.Register(this, level);
            int hash = this.GetHashCode();
            dataController = controller.getDataController(hash, level);
            if (dataController == null)
            {
                MessageBox.Show("Fehler beim Laden des Fensters", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
                
            excelController = controller.getExcelController(hash, level);
            if (excelController == null)
            {
                MessageBox.Show("Fehler beim Laden des Fensters", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            formController = controller.getFormController(hash, level);
            if (formController == null)
            {
                MessageBox.Show("Fehler beim Laden des Fensters", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            parsingController = controller.getParsingController(hash, level);
            if (parsingController == null)
            {
                MessageBox.Show("Fehler beim Laden des Fensters", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void frmParsing_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmCounter == 1)
                e.Cancel = true;
            else
            {
                frmCounter--;
                controller.Unregister(this, level);
            }
                
                
        }

    }
}
