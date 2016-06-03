using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Oege_Get_the_best_price.Model;
using System.Windows.Forms;
using Oege_Get_the_best_price.View;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace Oege_Get_the_best_price.Controller.Parsing.Ebay
{
    class ParsingControllerEbay
    {
        int guiHash;
        int level;
        private delegate void progressBarDelegate(frmParsing.Platform platform, int percent);

        private HtmlNode rootNode;

        public ParsingControllerEbay(int hash, int level)
        {
            this.guiHash = hash;
            this.level = level;

        }

        public void startExcelList()
        {
            List<Data> listData = Controller.Instance().getDataController(guiHash, level).DataHolding.ListData;
            Form frm = Controller.Instance().getFormController(guiHash, level).Frm;
            frmParsing frmPar = null;
            
            if (frm.GetType() == typeof(frmParsing))
            {
                frmPar = ((frmParsing)frm);
            }

            progressBarDelegate del = new progressBarDelegate(frmPar.updateProgressBar);
            int listCount = listData.Count();
            int counter = 0;
            int percent = 0;

            foreach (Data element in listData)
            {
                Data tmp = element;
                BeginParsing(ref tmp);
                element.UrlEbay = tmp.UrlEbay;
                element.DiscriptionEbay = tmp.DiscriptionEbay;
                element.PriceEbay = tmp.PriceEbay;
                element.EbayShipping = tmp.EbayShipping;
                Thread.Sleep(20);
                percent = ++counter * 100 / listCount;

                if (frmPar != null)                    
                    frmPar.BeginInvoke(del, new object[] { frmParsing.Platform.Ebay, percent });
            }
            Controller.Instance().getDataController(guiHash, level).DataHolding.mergeList(DataHolding.Platform.Ebay, listData);
        }

        private void BeginParsing(ref Data tmp)
        {
            rootNode = GetRootNode(tmp.Ean);

            var resultNode = rootNode.SelectSingleNode("//span[@class='listingscnt']");

            if (ArticleFound(resultNode, tmp.Ean))
            {
                //resultNode = rootNode.SelectSingleNode("//div[@id='Results']");
                resultNode = rootNode.SelectSingleNode("//ul[@id='ListViewInner']");
                if(resultNode != null)
                {
                    resultNode = resultNode.ChildNodes.First(a => a.Name == "li");

                    HtmlNode titleNode = resultNode.SelectSingleNode("//h3[@class='lvtitle']");
                    string innerHtml = titleNode.InnerHtml;
                    string title = titleNode.InnerText.Trim();
                    string url = "";

                    

                    int index = innerHtml.IndexOf("href=\"");
                    url = innerHtml.Substring(index + ("href=\"").Length);
                    index = url.IndexOf("\" class");
                    url = url.Substring(0, index);

                    tmp.DiscriptionEbay = title;
                    tmp.UrlEbay = url;

                    HtmlNode priceNode = resultNode.SelectSingleNode("//li[@class='lvprice prc']");

                    string innerText = priceNode.InnerText.Trim();
                    innerText = innerText.Replace("EUR ", "");

                    string priceString = "";
                    for (int i = 0; i < innerText.Length; i++)
                    {
                        if (innerText[i] == '\n')
                            break;
                        if (innerText[i] == 44 || IsNumber(innerText[i]))
                            priceString += innerText[i];
                    }

                    double price;
                    bool parse = Double.TryParse(priceString, out price);

                    tmp.PriceEbay = parse ? price : 0.0;

                    HtmlNode shippingNode = resultNode.SelectSingleNode("//li[@class='lvshipping']");

                    innerText = shippingNode.InnerText.Trim();

                    if (innerText.Contains("Kostenloser Versand"))
                        tmp.EbayShipping = 0.0;
                    else
                    {
                        Match match = Regex.Match(innerText, "[0-9]*,[0-9]{1,2}");
                        if (match.Success)
                        {
                            priceString = "";
                            for (int i = 0; i < innerText.Length; i++)
                            {
                                if (innerText[i] == '\n')
                                    break;
                                if (innerText[i] == 44 || IsNumber(innerText[i]))
                                    priceString += innerText[i];
                            }

                            double shipping;
                            parse = Double.TryParse(priceString, out shipping);

                            tmp.EbayShipping = parse ? shipping : 0.0;
                        }
                    }
                }
                
            }
        }

        private bool IsNumber(char number)
        {
            return number >= 48 && number <= 57 ? true : false;
        }


        private HtmlNode GetRootNode(string ean)
        {
            string url = "http://www.ebay.de/sch/i.html?_from=R40&_sacat=0&_sop=15&_nkw=" + ean + "&rt=nc&LH_BIN=1";
            //string url = "http://www.ebay.de/sch/i.html?LH_BIN=1&_from=R40&_sacat=0&_nkw=handy&_sop=16";
            HtmlWeb client = new HtmlWeb();
            client.UserAgent = "Chrome/50.0";
            client.UseCookies = true;

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc = client.Load(url);

            return doc.DocumentNode;
        }

        private bool ArticleFound(HtmlNode articleNode, string ean)
        {
            if (articleNode.InnerText.StartsWith("0"))
                return false;

            return true;
        }
    }
}
