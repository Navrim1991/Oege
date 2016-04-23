using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oege_Get_the_best_price.View
{
    public partial class frmParsing : Form
    {

        #region Attributs

        private static int frmCounter = 0;
        Controller.Controller controller;
        Controller.DataController dataController;
        Controller.ExcelController excelController;
        Controller.FormController formController;
        Controller.Parsing.ParsingController parsingController;
        private static int percentProgressAmazon;
        private static int percentProgressEbay;
        private static int percentProgressIdealo;

        const short level = 1;

        #endregion

        #region Constructor
        public frmParsing()
        {
            
            InitializeComponent();
            frmCounter++;

            percentProgressAmazon = 0;
            percentProgressEbay = 0;
            percentProgressIdealo = 0;

            controller = Controller.Controller.Instance();
            controller.Register(this, level);
            int hash = this.GetHashCode();

            dataController = controller.getDataController(hash, level);
            if (dataController == null)
                throw new ArgumentNullException("dataController", "dataController ist null");

            excelController = controller.getExcelController(hash, level);
            if (excelController == null)
                throw new ArgumentNullException("excelController", "excelController ist null");

            formController = controller.getFormController(hash, level);
            if (formController == null)
                throw new ArgumentNullException("formController", "formController ist null");

            parsingController = controller.getParsingController(hash, level);
            if (parsingController == null)
                throw new ArgumentNullException("parsingController", "parsingController ist null");

        }
        #endregion

        #region Events

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

        #endregion

        #region methods

        public void importExcelFile()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<object> param = new List<object>();
                param.Add(openFileDialog.FileName);

                //TODO Form für Spaltenauswahl

                backgroundWorkerExcel.RunWorkerAsync(param);
                

            }
        }

        public void updateListView()
        {
            listView.Items.Clear();
        }


        #endregion

        private void frmParsing_Load(object sender, EventArgs e)
        {

        }

        public void updateProgressBar(int percentAmazon, int percentEbay, int percentIdealo)
        {
            if (percentAmazon != -1)
                percentProgressAmazon = percentAmazon;
            else if (percentEbay != -1)
                percentProgressEbay = percentEbay;
            else if (percentIdealo != -1)
                percentProgressIdealo = percentIdealo;

            switch(percentProgressAmazon)
            {
                case 0:
                    lblProgressAmazon.ForeColor = Color.Red;
                    break;
                case 50:
                    lblProgressAmazon.ForeColor = Color.Orange;
                    break;
                case 100:
                    lblProgressAmazon.ForeColor = Color.Green;
                    break;
            }

            switch (percentProgressEbay)
            {
                case 0:
                    lblProgressEbay.ForeColor = Color.Red;
                    break;
                case 50:
                    lblProgressEbay.ForeColor = Color.Orange;
                    break;
                case 100:
                    lblProgressEbay.ForeColor = Color.Green;
                    break;
            }

            switch (percentProgressIdealo)
            {
                case 0:
                    lblProgressIdealo.ForeColor = Color.Red;
                    break;
                case 50:
                    lblProgressIdealo.ForeColor = Color.Orange;
                    break;
                case 100:
                    lblProgressIdealo.ForeColor = Color.Green;
                    break;
            }

            progressBarParsing.Value = (percentProgressAmazon + percentProgressEbay + percentProgressIdealo) / 3;
        }

        private void backgroundWorkerExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            List<object> param = (List<object>)e.Argument;
            if(param != null)
                excelController.readExcelFile((string)param[0], level, 3, 1, 7);
        }
    }
}
