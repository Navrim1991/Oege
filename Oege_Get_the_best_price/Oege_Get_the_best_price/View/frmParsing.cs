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
using CsvHelper;
using System.IO;
using System.Diagnostics;

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
        private ListViewColumnSorter lvwColumnSorter;

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

            lvwColumnSorter = new ListViewColumnSorter();
            this.listView.ListViewItemSorter = lvwColumnSorter;

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


            linkLblAmazon.Text = "";
            linkLblEbay.Text = "";
        }
        #endregion

        #region Events
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView.SelectedItems.Count > 0)
            {
                string ean = listView.SelectedItems[0].Text;

                Data data = dataController.DataHolding.getData(ean);

                if (data != null)
                {
                    txtEan.Text = data.Ean;
                    txtArtikel.Text = data.Aritcel;
                    txtPriceOwn.Text = data.OwnPrice.ToString();

                    txtArtikelAmazon.Text = data.DiscriptionAmazon;
                    txtPriceAmazon.Text = data.PriceAmazon.ToString();
                    txtShippingAmazon.Text = data.AmazonShipping.ToString();

                    if(linkLblAmazon.Links.Count > 0)
                        linkLblAmazon.Links.RemoveAt(0);

                    if (data.UrlAmazon != "")
                    {
                        linkLblAmazon.Text = "Artikel in Amazon anschauen";
                        LinkLabel.Link linkAmazon = new LinkLabel.Link();
                        linkAmazon.LinkData = data.UrlAmazon;
                        linkLblAmazon.Links.Add(linkAmazon);
                        butAmazon.Visible = false;                        
                    }
                    else
                    {
                        linkLblAmazon.Text = "";                        
                        butAmazon.Visible = true;
                    }

                    txtArticleEbay.Text = data.DiscriptionEbay;
                    txtPriceEaby.Text = data.PriceEbay.ToString();
                    txtShippingEbay.Text = data.EbayShipping.ToString();

                    if(linkLblEbay.Links.Count > 0)
                        linkLblEbay.Links.RemoveAt(0);

                    if (data.UrlEbay != "")
                    {
                        linkLblEbay.Text = "Artikel in Ebay anschauen";
                        LinkLabel.Link linkEbay = new LinkLabel.Link();
                        linkEbay.LinkData = data.UrlEbay;
                        linkLblEbay.Links.Add(linkEbay);
                        butEbay.Visible = false;
                    }
                    else
                    {
                        linkLblEbay.Text = "";
                        
                        butEbay.Visible = true;
                    }
                }
            }            
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

        public void exportData()
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV|*.csv";
            saveFileDialog.Title = "Speichern einer CSV-Datei";

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = null;

                writer = new StreamWriter(@saveFileDialog.FileName);

                var csv = new CsvWriter(writer);
                csv.Configuration.Delimiter = ";";

                string header = "EAN;Artikelbeschreibung;UrlAmazon;UrlEbay;UrlIdealo;ArtikelbeschreibungAmazon;ArtikelbeschreibungEbay;ArtikelbeschreibungIdealo;PreisAmazon;PreisEbay;PreisIdealo;VersantkostenAmazon;VersantkostenEaby;VersantkostenIdealo;EigenerPreis;";
                writer.WriteLine(header);                

                foreach (var item in dataController.DataHolding.ListData)
                {
                    csv.WriteRecord(item);
                }

                writer.Close();
                csv.Dispose();
            }
        }

        private Color getBackColor(short counter, ref short colorSet, double value, Color currentBackColor)
        {
            if (value <= 0.0)
                return currentBackColor;

            switch (counter)
            {
                case 0:
                    colorSet++;
                    return Color.Green;
                case 1:                    
                        if (colorSet > 0)
                        {                            
                            colorSet++;
                            return Color.Orange;
                        }
                        else
                        {                            
                            colorSet++;
                            return Color.Green;
                        }
                case 2:
                    if (colorSet >= 1)
                        return Color.Red;
                    else
                        return Color.Green;
            }

            return currentBackColor;
        }

        public void updateListView()
        {
            listView.Items.Clear();

            int colorSwitcher = 0;
            foreach(Data data in dataController.DataHolding.ListData)
            {
                Color currentBackColor;
                ListViewItem lvi = new ListViewItem(data.Ean);
                lvi.UseItemStyleForSubItems = false;

                if (colorSwitcher++ % 2 == 0)
                    currentBackColor = Color.Gray;
                else
                    currentBackColor = Color.White;

                lvi.BackColor = currentBackColor;

                lvi.SubItems.Add(data.Aritcel,Color.Black, currentBackColor, new Font("Arial", 12));

                Dictionary<Platform, double> dic = new Dictionary<Platform, double>();

                dic.Add(Platform.Amazon, data.PriceAmazon);
                dic.Add(Platform.Ebay, data.PriceEbay);
                dic.Add(Platform.Own, data.OwnPrice);



                ListViewItem.ListViewSubItem subitemAmazon = null;
                ListViewItem.ListViewSubItem subitemEbay = null;
                ListViewItem.ListViewSubItem subitemOwn = null;

                List<KeyValuePair<Platform, double>> myList = dic.ToList();

                myList.Sort(
                    delegate (KeyValuePair<Platform, double> pair1,
                    KeyValuePair<Platform, double> pair2)
                    {
                        return pair1.Value.CompareTo(pair2.Value);
                    }
                );

                short counter = 0;
                short colorSet = 0;
                foreach(KeyValuePair<Platform, double> element in myList)
                {
                    Color backColor;
                    switch (element.Key)
                    {
                        case Platform.Amazon:
                            backColor = getBackColor(counter, ref colorSet, data.PriceAmazon, currentBackColor);
                            subitemAmazon = new ListViewItem.ListViewSubItem(lvi, data.PriceAmazon.ToString(), Color.Black, backColor, new Font("Arial", 12));
                            break;

                        case Platform.Ebay:
                            backColor = getBackColor(counter, ref colorSet, data.PriceEbay, currentBackColor);
                            subitemEbay = new ListViewItem.ListViewSubItem(lvi, data.PriceEbay.ToString(), Color.Black, backColor, new Font("Arial", 12));
                            break;
                            
                        case Platform.Own:
                            backColor = getBackColor(counter, ref colorSet, data.OwnPrice, currentBackColor);
                            subitemOwn = new ListViewItem.ListViewSubItem(lvi, data.OwnPrice.ToString(), Color.Black, backColor, new Font("Arial", 12));
                            break;
                    }

                    counter++;
                }
                //ListViewItem.ListViewSubItem subitemAmazon = new ListViewItem.ListViewSubItem(lvi, amazonPrice.ToString(), Color.Black, amazonColor, new Font("Arial", 12));
                //ListViewItem.ListViewSubItem subitemEbay = new ListViewItem.ListViewSubItem(lvi, ebayPrice.ToString(), Color.Black, ebayColor, new Font("Arial", 12));

                lvi.SubItems.Add(subitemAmazon);
                lvi.SubItems.Add(subitemEbay);
                lvi.SubItems.Add(subitemOwn);

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

        private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            int clickedIndex = -1;
            bool parse = int.TryParse(e.Column.ToString(), out clickedIndex);

            if (parse)
            {
                if (e.Column == lvwColumnSorter.SortColumn)
                {
                    // Reverse the current sort direction for this column.
                    if (lvwColumnSorter.Order == SortOrder.Ascending)
                    {
                        lvwColumnSorter.Order = SortOrder.Descending;
                    }
                    else
                    {
                        lvwColumnSorter.Order = SortOrder.Ascending;
                    }
                }
                else
                {
                    // Set the column number that is to be sorted; default to ascending.
                    lvwColumnSorter.SortColumn = e.Column;
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }

                // Perform the sort with these new sort options.
                this.listView.Sort();

                /*Color backColor;
                for(int i = 0; i < listView.Items.Count; i++)
                {
                    if (i % 2 == 0)
                        backColor = Color.Gray;
                    else
                        backColor = Color.White;

                    listView.Items[i].BackColor = backColor;

                    for(int j = 0; j < listView.Items[i].SubItems.Count; j++)
                    {
                        double value;
                        parse = Double.TryParse(listView.Items[i].SubItems[j].Text, out value);
                        if (parse)
                            if (value == 0)
                                listView.Items[i].SubItems[j].BackColor = backColor;
                        else
                            listView.Items[i].SubItems[j].BackColor = backColor;
                    }


                }*/
                dataController.DataHolding.sortList(clickedIndex, (int)lvwColumnSorter.Order);
            }            
        }

        private void linkLblAmazon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }

        private void linkLblEbay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }
    }
}
