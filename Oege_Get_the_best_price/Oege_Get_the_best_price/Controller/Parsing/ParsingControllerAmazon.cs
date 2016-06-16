using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Oege_Get_the_best_price.Model;
using System.Windows.Forms;
using Oege_Get_the_best_price.View;
using System.Text.RegularExpressions;
using System.Windows.Media.TextFormatting;

namespace Oege_Get_the_best_price.Controller.Parsing.Amazon
{
    class ParsingControllerAmazon
    {
        int guiHash;
        int level;
        private delegate void progressBarDelegate(frmParsing.Platform platform, int percent);
        Controller controller = Controller.Instance();

        private HtmlNode rootNode;

        public ParsingControllerAmazon(int hash, int level)
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
                frmPar = ((frmParsing)frm);

            if(frmPar != null)
            {
                progressBarDelegate del = new progressBarDelegate(frmPar.updateProgressBar);
                int listCount = listData.Count();
                int counter = 0;
                int percent = 0;

                foreach (Data element in listData)
                {
                    Data tmp = element;
                    BeginParsing(ref tmp);                   
                        
                    Thread.Sleep(20);
                    percent = ++counter * 100 / listCount;
                    if (frmPar != null)
                        frmPar.BeginInvoke(del, new object[] { frmParsing.Platform.Amazon ,percent });
                }

                Controller.Instance().getDataController(guiHash, level).DataHolding.mergeList(DataHolding.Platform.Amazon, listData);
            }
        }
        private void GetPrice(string url, ref Data tmp)
        {
            HtmlWeb client = new HtmlWeb();
            client.UserAgent = "Chrome/50.0";
            client.UseCookies = true;

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc = client.Load(url);

            HtmlNode node = doc.DocumentNode.SelectSingleNode("//div[@id='soldByThirdParty']");
            //TODO Kosten hier
            if(node == null)
            {
                node = doc.DocumentNode.SelectSingleNode("//tr[@id='priceblock_ourprice_row']");

                if(node != null)
                {
                    //TODO Versantkosten
                    string tmpPriceString = node.InnerText.ToLower();

                    if (tmpPriceString.Contains("kostenlose lieferung"))
                        tmp.AmazonShipping = 0.0;

                    node = doc.DocumentNode.SelectSingleNode("//span[@id='priceblock_ourprice']");

                    string priceString = node.InnerText.Replace("EUR ", "");

                    tmp.PriceAmazon = controller.parseDouble(priceString);
                }
                else
                {

                    HtmlNode tmpNode = doc.DocumentNode.SelectSingleNode("//div[@class='a-section a-spacing-double-large']");
                    if (tmpNode != null)
                        GetPriceOtherOffer(tmpNode, ref tmp);                    
                }      
            }
            else
            {
                HtmlNode tmpNode = node.SelectSingleNode("//span[@class='a-color-price price3P  a-text-bold']");

                string priceString = selectPriceFromString(tmpNode.InnerText);

                tmp.PriceAmazon = controller.parseDouble(priceString);

                tmpNode = node.SelectSingleNode("//span[@class='a-size-small a-color-secondary shipping3P']");

                priceString = selectPriceFromString(tmpNode.InnerText);

                tmp.AmazonShipping = controller.parseDouble(priceString);
            }
        }

        private void GetPriceOtherOffer(HtmlNode node, ref Data tmp)
        {
            HtmlNodeCollection nodeCollection = node.SelectNodes("//div[@class='a-row a-spacing-mini olpOffer']");
            HtmlNode shippingNode = nodeCollection.First();
            String innerText = nodeCollection.First().InnerText;

            innerText = innerText.Trim();
            innerText = innerText.Replace("EUR ", "");

            string priceString = "";
            for (int i = 0; i < innerText.Length; i++)
            {
                if (innerText[i] == 32)
                    break;
                if (innerText[i] == 44 || IsNumber(innerText[i]))
                    priceString += innerText[i];
            }

            double price;
            bool parse = Double.TryParse(priceString, out price);

            if (parse)
                tmp.PriceAmazon = price;
            else
                tmp.PriceAmazon = 0.0;

            HtmlNodeCollection shippingNodeCollection = shippingNode.SelectNodes("//span[@class='a-color-secondary']");
            shippingNode = shippingNodeCollection.First();

            if (shippingNode != null && shippingNode.InnerText.Contains("& bestellbar mit kostenlosem Premiumversand."))
            {
                tmp.AmazonShipping = 0.0;
                return;
            }


            if (shippingNode != null)
            {
                string shippingInnerText = shippingNode.InnerText.ToLower();

                if (shippingInnerText.Contains("kostenlose lieferung") || shippingInnerText.Contains("kostenfreie lieferung"))
                {
                    tmp.AmazonShipping = 0.0;
                    return;
                }
            }


            Match match = Regex.Match(shippingNode.InnerText, "EUR [0-9]*,[0-9]{1,2}|Versandkosten");

            if (match.Success)
            {
                priceString = "";
                priceString = match.Value.Replace("EUR ", "");

                parse = Double.TryParse(priceString, out price);

                if (parse)
                    tmp.AmazonShipping = price;
                else
                    tmp.AmazonShipping = 0.0;
            }
        }

        private void GetPriceOtherOffer(string url, ref Data tmp)
        {
            HtmlWeb client = new HtmlWeb();
            client.UserAgent = "Chrome/50.0";
            client.UseCookies = true;

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc = client.Load(url);

            HtmlNode node = doc.DocumentNode.SelectSingleNode("//div[@class='a-section a-spacing-double-large']");

            HtmlNodeCollection nodeCollection = node.SelectNodes("//div[@class='a-row a-spacing-mini olpOffer']");
            HtmlNode shippingNode = nodeCollection.First();
            String innerText = nodeCollection.First().InnerText;

            innerText = innerText.Trim();
            innerText = innerText.Replace("EUR ", "");

            string priceString = "";
            for (int i = 0; i < innerText.Length; i++)
            {
                if (innerText[i] == 32)
                    break;
                if (innerText[i] == 44 || IsNumber(innerText[i]))
                    priceString += innerText[i];
            }

            double price;
            bool parse = Double.TryParse(priceString, out price);

            if (parse)
                tmp.PriceAmazon = price;
            else
                tmp.PriceAmazon = 0.0;

            HtmlNodeCollection shippingNodeCollection = shippingNode.SelectNodes("//span[@class='a-color-secondary']");
            shippingNode = shippingNodeCollection.First();

            if (shippingNode != null && shippingNode.InnerText.Contains("& bestellbar mit kostenlosem Premiumversand."))
            {
                tmp.AmazonShipping = 0.0;
                return;
            }
                

            if (shippingNode != null)
            {
                string shippingInnerText = shippingNode.InnerText.ToLower();

                if (shippingInnerText.Contains("kostenlose lieferung") || shippingInnerText.Contains("kostenfreie lieferung") )
                {
                    tmp.AmazonShipping = 0.0;
                    return;
                }
            }


            Match match = Regex.Match(shippingNode.InnerText, "EUR [0-9]*,[0-9]{1,2}|Versandkosten");

            if (match.Success)
            {
                priceString = "";
                priceString = match.Value.Replace("EUR ", "");

                parse = Double.TryParse(priceString, out price);

                if (parse)
                    tmp.AmazonShipping = price;
                else
                    tmp.AmazonShipping = 0.0;
            }
        }

        private bool IsNumber(char number)
        {
            return number >= 48 && number <= 57 ? true : false;
        }

        public void BeginParsing(ref Data tmp)
        {
            rootNode = GetRootNode(tmp.Ean);

            if (ArticleFound(rootNode, tmp.Ean))
            {
               //var resultNode = rootNode.SelectSingleNode("//div[@id='atfResults']");

                HtmlNode searchResults = rootNode.SelectSingleNode("//ul[@id='s-results-list-atf']");

                string url = "";
                bool otherOffer = false;
                double price = -1;
                string discription = "";

                foreach(HtmlNode _node in searchResults.ChildNodes)
                {
                    HtmlNode result = _node.ChildNodes.First().ChildNodes.First().ChildNodes.First();
                    HtmlNodeCollection priceNodes = result.ChildNodes[1].ChildNodes[2].FirstChild.ChildNodes;

                    foreach(HtmlNode _priceNode in priceNodes)
                    {
                        HtmlNode test = _priceNode;

                        if (_priceNode.Name != "div")
                            continue;

                        if (_priceNode.InnerText.Contains("Abo")|| _priceNode.InnerHtml.ToLower().Contains("pantry"))
                            continue;

                        if (_priceNode.InnerText.Contains("EUR"))
                        {                            
                            string subtring = controller.selectSubstring(_priceNode.InnerText, "EUR ");

                            string priceString = selectPriceFromString(subtring);

                            double tmpPrice = controller.parseDouble(priceString);

                            if(tmpPrice > 0.0)
                            {
                                if (price == -1)
                                {
                                    price = tmpPrice;

                                    if (_priceNode.InnerText.Contains("Andere Angebote"))
                                        otherOffer = true;
                                    else
                                        otherOffer = false;

                                    url = controller.selectSubstring(_priceNode.InnerHtml, "href=\"", "\"><span");

                                    discription = getDiscription(result);
                                }                                    
                                else
                                {
                                    if(tmpPrice < price)
                                    {
                                        price = tmpPrice;

                                        if (_priceNode.InnerText.Contains("Andere Angebote"))
                                            otherOffer = true;
                                        else
                                            otherOffer = false;

                                        url = controller.selectSubstring(_priceNode.InnerHtml, "href=\"", "\"><span");

                                        discription = getDiscription(result);
                                    }
                                }
                            }
                        }
                    }
                }

                tmp.DiscriptionAmazon = discription;
                tmp.UrlAmazon = url;

                if(tmp.UrlAmazon != "")
                {
                    if (otherOffer)
                        GetPriceOtherOffer(tmp.UrlAmazon, ref tmp);
                    else
                        GetPrice(tmp.UrlAmazon, ref tmp);
                }
                    
            }
        }

        private string getDiscription(HtmlNode node)
        {
            HtmlNode discription = node.SelectSingleNode("//a[@class='a-link-normal s-access-detail-page  a-text-normal']");

            return discription.InnerText;
        }        

        private string selectPriceFromString(string priceString)
        {
            Match match = Regex.Match(priceString, "[0-9]*,[0-9]{1,2}");

            if (match.Success)
                return match.Value;

            return "";
        }

        private HtmlNode GetRootNode(string ean)
        {
            string url = "http://www.amazon.de/s/&field-keywords=" + ean + "&sort=price-asc-rank";
            HtmlWeb client = new HtmlWeb();
            client.UserAgent = "Chrome/50.0";
            client.UseCookies = true;

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc=client.Load(url);

            return doc.DocumentNode;
        }

        private bool ArticleFound(HtmlNode articleNode, string ean)
        {
            HtmlNode tmp = articleNode.SelectSingleNode("//h1[@id='noResultsTitle']");

            if (tmp == null)
                return true;

            return false;
        }
    }
}
