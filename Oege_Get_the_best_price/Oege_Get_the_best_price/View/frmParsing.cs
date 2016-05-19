using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oege_Get_the_best_price.Model;

namespace Oege_Get_the_best_price.View
{
    public partial class frmParsing : Form
    {

        public enum Platform
        {
            Amazon,
            Ebay,
            Idealo,
            Own,
            None
        };


        #region Attributs

        private static int frmCounter = 0;
        Controller.Controller controller;
        Controller.DataController dataController;
        Controller.ExcelController excelController;
        Controller.FormController formController;
        Controller.Parsing.ParsingController parsingController;
        private int percentProgressAmazon;
        private int percentProgressEbay;
        private int percentProgressIdealo;
        int hash;

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
            hash = this.GetHashCode();

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
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvlArtikel_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorkerExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            List<object> param = (List<object>)e.Argument;
            if (param != null)
                excelController.readExcelFile((string)param[0], level, (int)param[3], (int)param[1], (int)param[2]);
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

        #endregion

        #region methods

        public void importExcelFile()
        {
            List<object> param = new List<object>();
            if((new frmChooseColumn(hash, level,ref param)).ShowDialog() == DialogResult.OK)
            {
                backgroundWorkerExcel.RunWorkerAsync(param);
            }
        }

        public void updateListView()
        {
            listView.Items.Clear();

            foreach(Data data in dataController.DataHolding.ListData)
            {
                ListViewItem lvi = new ListViewItem(data.Ean);
                lvi.UseItemStyleForSubItems = false;
                lvi.SubItems.Add(data.Aritcel);
                double amazonPrice = data.PriceAmazon + data.AmazonShipping;
                double ebayPrice = data.PriceEbay + data.EbayShipping;
                Color ebayColor = Color.White;
                Color amazonColor = Color.White;

                if(amazonPrice > ebayPrice)
                {
                    amazonColor = Color.Red;
                    ebayColor = Color.Green;
                }
                else if(amazonPrice < ebayPrice)
                {
                    amazonColor = Color.Green;
                    ebayColor = Color.Red;
                }

                ListViewItem.ListViewSubItem subitemAmazon = new ListViewItem.ListViewSubItem(lvi, amazonPrice.ToString(), Color.Black, amazonColor, new Font("Arial", 12));
                ListViewItem.ListViewSubItem subitemEbay = new ListViewItem.ListViewSubItem(lvi, ebayPrice.ToString(), Color.Black, ebayColor, new Font("Arial", 12));

                lvi.SubItems.Add(subitemAmazon);
                lvi.SubItems.Add(subitemEbay);

                listView.Items.Add(lvi);
            }
        }

        public void updateProgressBar(Platform platform, int percent)
        {
            switch (platform)
            {
                case Platform.Amazon:
                    percentProgressAmazon = percent;
                    break;
                case Platform.Ebay:
                    percentProgressEbay = percent;
                    break;
                case Platform.Idealo:
                    percentProgressIdealo = percent;
                    break;
            }

            switch (percentProgressAmazon)
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

            /*switch (percentProgressIdealo)
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
            }*/

            progressBarParsing.Value = (percentProgressAmazon + percentProgressEbay) / 2;
        }
        #endregion




    }
}
