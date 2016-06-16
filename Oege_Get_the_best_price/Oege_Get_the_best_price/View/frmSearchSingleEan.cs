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
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Oege_Get_the_best_price.View
{
    public partial class frmSearchSingleEan: Form
    {
        Controller.Controller controller;
        Controller.Parsing.ParsingController parsingController;
        const short level = 10;
        int hash;

        Data data;
        public frmSearchSingleEan()
        {
            InitializeComponent();

            controller = Controller.Controller.Instance();
            controller.Register(this, level);
            hash = this.GetHashCode();

            parsingController = controller.getParsingController(hash, level);
            if (parsingController == null)
                throw new ArgumentNullException("parsingController", "parsingController ist null");
        }

        private void frmSearchSingleEan_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.Unregister(this, level);
        }

        private void butSearchEan_Click(object sender, EventArgs e)
        {           
            string eanString = controller.makeEan(txtSearchEan.Text);

            if (controller.checkEan(eanString))
            {
                data = new Data(eanString);
                this.Cursor = Cursors.WaitCursor;
                clearData();
                backgroundWorker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Keine gültige Ean eingetragen", "Ean fehlerhaft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clearData()
        {
            txtArtikelAmazon.Clear();
            txtPriceAmazon.Clear();
            txtShippingAmazon.Clear();

            txtArticleEbay.Clear();
            txtPriceEaby.Clear();
            txtShippingEbay.Clear();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            
            parsingController.ParsingControllerAmazon.BeginParsing(ref data);
            parsingController.ParsingControllerEbay.BeginParsing(ref data);
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (data != null)
            {
                txtArtikelAmazon.Text = data.DiscriptionAmazon;
                txtPriceAmazon.Text = data.PriceAmazon.ToString();
                txtShippingAmazon.Text = data.AmazonShipping.ToString();

                txtArticleEbay.Text = data.DiscriptionEbay;
                txtPriceEaby.Text = data.PriceEbay.ToString();
                txtShippingEbay.Text = data.EbayShipping.ToString();

                if (data.UrlAmazon == "")
                    butAmazon.Enabled = false;
                else
                    butAmazon.Enabled = true;

                if (data.UrlEbay == "")
                    butEbay.Enabled = false;
                else
                    butEbay.Enabled = true;
            }

            this.Cursor = Cursors.Default;
        }

        private void butAmazon_Click(object sender, EventArgs e)
        {
            if (data !=  null && data.UrlAmazon != "")
                Process.Start(data.UrlAmazon);
        }

        private void butEbay_Click(object sender, EventArgs e)
        {
            if (data != null && data.UrlEbay != "")
                Process.Start(data.UrlEbay);
        }
    }
}
