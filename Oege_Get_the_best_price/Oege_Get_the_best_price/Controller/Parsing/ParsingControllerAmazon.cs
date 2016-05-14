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
        private delegate void progressBarDelegate(int percentAmazon, int percentEbay, int percentIdealo);

        private HtmlNode rootNode;

        public ParsingControllerAmazon(int hash, int level)
        {
            this.guiHash = hash;
            this.level = level;
        }

        public void start()
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
                    if (element.UrlAmazon != "")
                    {
                        GetPrice(tmp.UrlAmazon, ref tmp);
                    }
                        
                    Thread.Sleep(20);
                    percent = ++counter * 100 / listCount;
                    if (frmPar != null)
                        frmPar.BeginInvoke(del, new object[] { percent, -1, -1 });
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

        private void BeginParsing(ref Data tmp)
        {
            rootNode = GetRootNode(tmp.Ean);
            //rootNode = GetRootNode("4210201105657");
            var resultNode = rootNode.SelectSingleNode("//div[@id='atfResults']");

            if (ArticleFound(resultNode, tmp.Ean))
            {
                var resultOne = resultNode.SelectSingleNode("//li[@id='result_0']");
                var fixedLeftGrid = resultOne.SelectSingleNode("//div[@class='a-fixed-left-grid-col a-col-right']");
                HtmlNodeCollection offerCollection = fixedLeftGrid.SelectSingleNode("//div[@class='a-column a-span7']").ChildNodes;
                string innerHtml = fixedLeftGrid.InnerHtml;
                int index = innerHtml.IndexOf("title=\"");
                innerHtml = innerHtml.Substring(index + ("title=\"").Length);
                index = innerHtml.IndexOf("\" href");
                innerHtml = innerHtml.Substring(0, index);
                tmp.DiscriptionAmazon = innerHtml;

                HtmlNode matchNode = null;
                foreach (HtmlNode node in offerCollection)
                {
                    bool match = Regex.Match(node.InnerText, "Andere AngeboteEUR [0-9]*,[0-9]{1,2}neu").Success;

                    if(match)
                    {
                        matchNode = node;
                        break;
                    }
                }

                if (matchNode != null)
                {
                    innerHtml = matchNode.InnerHtml;
                    index = innerHtml.IndexOf("href=\"");
                    innerHtml = innerHtml.Substring(index + ("href=\"").Length);
                    index = innerHtml.IndexOf("\"><");
                    innerHtml = innerHtml.Substring(0 , index);
                    tmp.UrlAmazon = innerHtml;
                }
            }
        }

        private HtmlNode GetRootNode(string ean)
        {
            string url =
                "http://www.amazon.de/s/ref=sr_st_price-asc-rank?__mk_de_DE=%C3%85M%C3%85Z%C3%95%C3%91&keywords=4005808747405&sort=price-asc-rank";
            
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
