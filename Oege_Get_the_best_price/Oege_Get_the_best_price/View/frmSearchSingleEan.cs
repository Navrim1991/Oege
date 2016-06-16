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
            linkLblAmazon.Text = "";
            linkLblEbay.Text = "";

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

            if (linkLblAmazon.Links.Count > 0)
                linkLblAmazon.Links.RemoveAt(0);

            linkLblAmazon.Text = "";

            txtArticleEbay.Clear();
            txtPriceEaby.Clear();
            txtShippingEbay.Clear();

            if (linkLblEbay.Links.Count > 0)
                linkLblEbay.Links.RemoveAt(0);

            linkLblEbay.Text = "";
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

                if (linkLblAmazon.Links.Count > 0)
                    linkLblAmazon.Links.RemoveAt(0);

                if (data.UrlAmazon != "")
                {
                    linkLblAmazon.Text = "Artikel in Amazon anschauen";
                    LinkLabel.Link linkAmazon = new LinkLabel.Link();
                    linkAmazon.LinkData = data.UrlAmazon;
                    linkLblAmazon.Links.Add(linkAmazon);
                }
                else
                {
                    linkLblAmazon.Text = "";
                }

                txtArticleEbay.Text = data.DiscriptionEbay;
                txtPriceEaby.Text = data.PriceEbay.ToString();
                txtShippingEbay.Text = data.EbayShipping.ToString();

                if (linkLblEbay.Links.Count > 0)
                    linkLblEbay.Links.RemoveAt(0);

                if (data.UrlEbay != "")
                {
                    linkLblEbay.Text = "Artikel in Ebay anschauen";
                    LinkLabel.Link linkEbay = new LinkLabel.Link();
                    linkEbay.LinkData = data.UrlEbay;
                    linkLblEbay.Links.Add(linkEbay);
                }
                else
                {
                    linkLblEbay.Text = "";
                }
            }

            this.Cursor = Cursors.Default;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtShippingAmazon_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLblAmazon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblAmazonArtikel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtArticleEbay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtShippingEbay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
