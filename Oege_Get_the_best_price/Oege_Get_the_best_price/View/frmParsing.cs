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

        public enum Shipping
        {
            Shipping = 1,
            NoShipping = 2
            
        };

        public enum NettoBrutto
        {
            Brutto = 4,
            Netto = 8
        };

        private enum SortOrder
        {
            Ascending,
            Descending,
            None,
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
        KeyValuePair<int, SortOrder> currentSortedHeader = new KeyValuePair<int, SortOrder>(0, SortOrder.Ascending);
        Data actuellData = null;

        private const string EAN = "EAN";
        private const string articleDiscription = "Artikelbeschreibung";
        private const string UrlAmazon = "UrlAmazon";
        private const string UrlEbay = "UrlEbay";
        private const string UrlIdealo = "UrlIdealo";
        private const string articleDiscriptionAmazon = "ArtikelbeschreibungAmazon";
        private const string articleDiscriptionEbay = "ArtikelbeschreibungEbay";
        private const string articleDiscriptionIdealo = "ArtikelbeschreibungIdealo";
        private const string priceAmazon = "PreisAmazon";
        private const string priceEbay = "PreisEbay";
        private const string priceIdealo = "PreisIdealo";
        private const string shippingAmazon = "VersantkostenAmazon";
        private const string shippingEbay = "VersantkostenEbay";
        private const string shippingIdealo = "VersantkostenIdealo";
        private const string ownPrice = "EigenerPreis";

        private const string header = EAN + ";" + articleDiscription + ";" + UrlAmazon + ";" + UrlEbay + ";" +
            UrlIdealo + ";" + articleDiscriptionAmazon + ";" + articleDiscriptionEbay + ";" + articleDiscriptionIdealo + ";" +
            priceAmazon + ";" + priceEbay + ";" + priceIdealo + ";" + shippingAmazon + ";" + shippingEbay + ";" +
            shippingIdealo + ";" + ownPrice;

        const short level = 1;

        int priceCalculator;

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

            setPriceCalculator();
        }
        #endregion

        #region Events
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                string ean = listView.SelectedItems[0].Text;

                actuellData = dataController.DataHolding.getData(ean);

                if (actuellData != null)
                {
                    txtEan.Text = actuellData.Ean;
                    txtArtikel.Text = actuellData.Aritcel;
                    txtPriceOwn.Text = actuellData.OwnPrice.ToString();

                    txtArtikelAmazon.Text = actuellData.DiscriptionAmazon;
                    txtPriceAmazon.Text = actuellData.PriceAmazon.ToString();
                    txtShippingAmazon.Text = actuellData.AmazonShipping.ToString();

                    if(actuellData.UrlAmazon != "")
                    {
                        butAmazon.Text = "Artikel öffnen";
                    }
                    else
                    {
                        butAmazon.Text = "Artikel suchen";
                    }

                    txtArticleEbay.Text = actuellData.DiscriptionEbay;
                    txtPriceEaby.Text = actuellData.PriceEbay.ToString();
                    txtShippingEbay.Text = actuellData.EbayShipping.ToString();

                    if (actuellData.UrlEbay != "")
                    {
                        butEbay.Text = "Artikel öffnen";
                    }
                    else
                    {
                        butEbay.Text = "Artikel suchen";
                    }


                }
            }
        }

        private void backgroundWorkerExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            List<object> param = (List<object>)e.Argument;
            if (param != null)
                excelController.readExcelFile((string)param[0], level, (string)param[4], (string)param[1], (string)param[2], (double)param[3]);
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

        public bool hasData()
        {
            return (listView.Items.Count > 0);
        }

        private ListViewItem searchItem(string searchValue)
        {
            return listView.FindItemWithText(searchValue, false, 0, true);
        }

        public void importExcelFile()
        {
            List<object> param = new List<object>();
            if ((new frmChooseColumn(hash, level, ref param)).ShowDialog() == DialogResult.OK)
            {
                backgroundWorkerExcel.RunWorkerAsync(param);
            }
        }

        public void importData()
        {

            List<Model.Data> tmp = new List<Data>();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV|*.csv";
            openFileDialog.Title = "Laden einer CSV-Datei";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String fileName = @openFileDialog.FileName;

                var sr = new StreamReader(@fileName);

                var reader = new CsvReader(sr);
                reader.Configuration.Delimiter = ";";


                reader.Read();
                string[] headers = reader.FieldHeaders;
                while (reader.Read())
                {
                    Data data = null;

                    for (int i = 0; i < headers.Count(); i++)
                    {
                        switch (i)
                        {
                            case 0:
                                data = new Data(reader.GetField(headers[i]));
                                break;
                            case 1:
                                data.Aritcel = reader.GetField(headers[i]);
                                break;
                            case 2:
                                data.UrlAmazon = reader.GetField(headers[i]);
                                break;
                            case 3:
                                data.UrlEbay = reader.GetField(headers[i]);
                                break;
                            case 4:
                                data.UrlIdealo = reader.GetField(headers[i]);
                                break;
                            case 5:
                                data.DiscriptionAmazon = reader.GetField(headers[i]);
                                break;
                            case 6:
                                data.DiscriptionEbay = reader.GetField(headers[i]);
                                break;
                            case 7:
                                data.DiscriptionIdealo = reader.GetField(headers[i]);
                                break;
                            case 8:
                                data.PriceAmazon = parseDouble(reader.GetField(headers[i]));
                                break;
                            case 9:
                                data.PriceEbay = parseDouble(reader.GetField(headers[i]));
                                break;
                            case 10:
                                data.PriceIdealo = parseDouble(reader.GetField(headers[i]));
                                break;
                            case 11:
                                data.AmazonShipping = parseDouble(reader.GetField(headers[i]));
                                break;
                            case 12:
                                data.EbayShipping = parseDouble(reader.GetField(headers[i]));
                                break;
                            case 13:
                                data.ShippingIdealo = parseDouble(reader.GetField(headers[i]));
                                break;
                            case 14:
                                data.OwnPrice = parseDouble(reader.GetField(headers[i]));
                                break;
                        }
                    }

                    tmp.Add(data);
                }

                dataController.DataHolding.ListData = tmp;
                sr.Close();
                reader.Dispose();

                updateListView();
            }
        }

        private double parseDouble(string value)
        {
            double retVal;
            bool parse = double.TryParse(value, out retVal);

            if (parse)
                return retVal;
            else
                return 0.0;
        }

        public void exportData()
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV|*.csv";
            saveFileDialog.Title = "Speichern einer CSV-Datei";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = null;

                writer = new StreamWriter(@saveFileDialog.FileName);

                var csv = new CsvWriter(writer);
                csv.Configuration.Delimiter = ";";


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

        private void setPriceCalculator()
        {
            priceCalculator = 0;

            if (rdioButBrutto.Checked == true)
                priceCalculator |= (int)NettoBrutto.Brutto;
            else
                priceCalculator |= (int)NettoBrutto.Netto;

            if (rdioButShipping.Checked == true)
                priceCalculator |= (int)Shipping.Shipping;
            else
                priceCalculator |= (int)Shipping.NoShipping;
        }

        public void updateListView()
        {
            listView.Items.Clear();

            int colorSwitcher = 0;

            setPriceCalculator();

            dataController.DataHolding.sortList(currentSortedHeader.Key, (int)currentSortedHeader.Value, priceCalculator);

            foreach (Data data in dataController.DataHolding.ListData)
            {
                Color currentBackColor;
                ListViewItem lvi = new ListViewItem(data.Ean);
                lvi.UseItemStyleForSubItems = false;

                if (colorSwitcher++ % 2 == 0)
                    currentBackColor = Color.Gray;
                else
                    currentBackColor = Color.White;

                lvi.BackColor = currentBackColor;

                lvi.SubItems.Add(data.Aritcel, Color.Black, currentBackColor, new Font("Arial", 12));
                double MwSt = 0.19; 

                double amazonPrice = 0.0;
                double ebayPrice = 0.0;

                switch(priceCalculator)
                {
                    //Brutto and shipping
                    case 5:
                        amazonPrice = data.PriceAmazon + data.AmazonShipping;
                        ebayPrice = data.PriceEbay + data.EbayShipping;
                        break;
                    //Brutto and no shipping
                    case 6:
                        amazonPrice = data.PriceAmazon;
                        ebayPrice = data.PriceEbay;
                        break;
                    //Netto and shipping
                    case 9:
                        amazonPrice = (data.PriceAmazon / (1 + MwSt)) + data.AmazonShipping;
                        ebayPrice = (data.PriceEbay / (1 + MwSt)) + data.EbayShipping;
                        break;
                    //Netto and no shipping
                    case 10:
                        amazonPrice = (data.PriceAmazon / (1 + MwSt));
                        ebayPrice = (data.PriceEbay / (1 + MwSt));
                        break;
                }

                amazonPrice = Math.Round(amazonPrice, 2);
                ebayPrice = Math.Round(ebayPrice, 2);

                Dictionary<Platform, double> dic = new Dictionary<Platform, double>();

                dic.Add(Platform.Amazon, amazonPrice);
                dic.Add(Platform.Ebay, ebayPrice);
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
                foreach (KeyValuePair<Platform, double> element in myList)
                {
                    Color backColor;
                    switch (element.Key)
                    {
                        case Platform.Amazon:
                            backColor = getBackColor(counter, ref colorSet, amazonPrice, currentBackColor);
                            subitemAmazon = new ListViewItem.ListViewSubItem(lvi, amazonPrice.ToString(), Color.Black, backColor, new Font("Arial", 12));
                            break;

                        case Platform.Ebay:
                            backColor = getBackColor(counter, ref colorSet, ebayPrice, currentBackColor);
                            subitemEbay = new ListViewItem.ListViewSubItem(lvi, ebayPrice.ToString(), Color.Black, backColor, new Font("Arial", 12));
                            break;

                        case Platform.Own:
                            backColor = getBackColor(counter, ref colorSet, data.OwnPrice, currentBackColor);
                            subitemOwn = new ListViewItem.ListViewSubItem(lvi, data.OwnPrice.ToString(), Color.Black, backColor, new Font("Arial", 12));
                            break;
                    }

                    counter++;
                }

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

            if (percentProgressAmazon < 50)
                lblProgressAmazon.ForeColor = Color.Red;
            else if (percentProgressAmazon >= 50 && percentProgressAmazon < 100)
                lblProgressAmazon.ForeColor = Color.Orange;
            else if (percentProgressAmazon >= 100)
                lblProgressAmazon.ForeColor = Color.Green;

            if (percentProgressEbay < 50)
                lblProgressEbay.ForeColor = Color.Red;
            else if (percentProgressEbay >= 50 && percentProgressEbay < 100)
                lblProgressEbay.ForeColor = Color.Orange;
            else if (percentProgressEbay >= 100)
                lblProgressEbay.ForeColor = Color.Green;

            progressBarParsing.Value = (percentProgressAmazon + percentProgressEbay) / 2;
        }



        #endregion

        private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            int clickedIndex = -1;
            bool parse = int.TryParse(e.Column.ToString(), out clickedIndex);

            if (parse)
            {
                if (e.Column == currentSortedHeader.Key)
                {
                    if (currentSortedHeader.Value == SortOrder.Ascending)
                    {
                        currentSortedHeader = new KeyValuePair<int, SortOrder>(e.Column, SortOrder.Descending);
                    }
                    else
                    {
                        currentSortedHeader = new KeyValuePair<int, SortOrder>(e.Column, SortOrder.Ascending);
                    }
                }
                else
                {
                    // Set the column number that is to be sorted; default to ascending.
                    currentSortedHeader = new KeyValuePair<int, SortOrder>(e.Column, SortOrder.Ascending);
                }

                listView.Items.Clear();

                updateListView();
            }
        }

        private void butSearchEan_Click(object sender, EventArgs e)
        {
            ListViewItem searchResult = searchItem(txtSearchEan.Text);
            if (searchResult != null)
            {
                txtSearchEan.Clear();
                listView.Focus();
                listView.Items[searchResult.Index].Selected = true;
                listView.Items[searchResult.Index].Focused = true;
                listView.TopItem = searchResult;
            }

        }

        private void butAmazon_Click(object sender, EventArgs e)
        {
            if(actuellData != null)
            {
                if(actuellData.UrlAmazon == "")
                {
                    string discription = actuellData.Aritcel;

                    int indexAnd = discription.IndexOf("&");

                    if (indexAnd > -1)
                    {
                        discription = discription.Replace("&", "");

                        if (discription[indexAnd].ToString() == " ")
                            discription = discription.Remove(indexAnd, 1);
                    }

                    string url = "http://www.amazon.de/s/&field-keywords=" + discription;


                    Process.Start(url);
                }
                else
                {
                    Process.Start(actuellData.UrlAmazon);
                }
            }
            
        }

        private void butEbay_Click(object sender, EventArgs e)
        {
            // = "http://www.ebay.de/sch/i.html?_from=R40&_sacat=0&_sop=15&_nkw=" + ean + "&rt=nc&LH_BIN=1";

            if (actuellData != null)
            {
                if (actuellData.UrlEbay == "")
                {
                    string discription = actuellData.Aritcel;

                    int indexAnd = discription.IndexOf("&");

                    if(indexAnd > -1)
                    {
                        discription = discription.Replace("&", "");

                        if (discription[indexAnd].ToString() == " ")
                            discription = discription.Remove(indexAnd, 1);
                    }                    

                    string url = "http://www.ebay.de/sch/i.html?_from=R40&_sacat=0&_sop=15&_nkw=" + discription + "&rt=nc&LH_BIN=1";

                    Process.Start(url);
                }
                else
                {
                    Process.Start(actuellData.UrlEbay);
                }
            }
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            
            updateListView();
        }
    }
}
