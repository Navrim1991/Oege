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
                    element.UrlAmazon = beginParsing(element);
                    if(element.UrlAmazon != "")
                        element.PriceAmazon = getPrice(element.UrlAmazon);
                    Thread.Sleep(100);
                    percent = ++counter * 100 / listCount;
                    if (frmPar != null)
                        frmPar.BeginInvoke(del, new object[] { percent, -1, -1 });
                }
            }
        }

        private HtmlNodeCollection getNodes(HtmlNode node, string xPath)
        {
            try
            {
                return node.SelectSingleNode(xPath).ChildNodes;
            }
            catch (Exception e)
            {
                
            }

            return null;
        }

        private double getPrice(string url)
        {
            HtmlWeb client = new HtmlWeb();
            client.UserAgent = "Chrome/50.0";
            client.UseCookies = true;

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc = client.Load(url);

            HtmlNode node = doc.DocumentNode.SelectSingleNode("//div[@class='a-section a-spacing-double-large']");

            HtmlNodeCollection nodeCollection = node.SelectNodes("//div[@class='a-row a-spacing-mini olpOffer']");



            return 0.0;
        }

        private string beginParsing(Data element)
        {
            //rootNode = getRootNode(element.Ean);
            rootNode = getRootNode("4005808647682");
            var resultNode = rootNode.SelectSingleNode("//div[@id='rightResultsATF']");

            if (ArticleFound(resultNode.InnerHtml, element.Ean))
            {
                var resultOne = resultNode.SelectSingleNode("//li[@id='result_0']");
                var fixedLeftGrid = resultOne.SelectSingleNode("//div[@class='a-fixed-left-grid-col a-col-right']");
                HtmlNodeCollection offerCollection = fixedLeftGrid.SelectSingleNode("//div[@class='a-column a-span7']").ChildNodes;
                
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
                    string innerHtml = matchNode.InnerHtml;
                    int index = innerHtml.IndexOf("href=\"");
                    innerHtml = innerHtml.Substring(index + ("href=\"").Length);
                    index = innerHtml.IndexOf("\"><");
                    innerHtml = innerHtml.Substring(0 , index);
                    return innerHtml;
                }
            }

            return "";
        }

        private HtmlNode getRootNode(string ean)
        {
            String url = "http://www.amazon.de/s/ref=nb_sb_noss?__mk_de_DE=%C3%85M%C3%85%C5%BD%C3%95%C3%91&url=search-alias%3Daps&field-keywords=" + ean +"&rh=i%3Aaps%2Ck%3A" + ean;
            HtmlWeb client = new HtmlWeb();
            client.UserAgent = "Chrome/50.0";
            client.UseCookies = true;

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc=client.Load(url);

            return doc.DocumentNode;
        }

        private bool ArticleFound(string innerHtml, string ean)
        {
            bool a = Regex.Match(innerHtml, "Ihre Suche nach|" + ean + "|ergab leider keine Produkttreffer").Success;
            return !a;
        }
    }
}
