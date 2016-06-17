using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oege_Get_the_best_price.Model
{
    class DataHolding
    {
        public enum Platform
        {
            Amazon,
            Ebay,
            Idealo,
            None
        };

        #region attributes
        volatile List<Data> listData;
        private readonly object syncLock;
        #endregion

        #region properties

        public List<Data> ListData
        {
            get
            {
                return listData;
            }

            set
            {
                listData = value;
            }
        }
        #endregion

        public DataHolding()
        {
            listData = new List<Data>();
            syncLock = new object();
        }

        public void sortList(int index, int order, int priceCalculator)
        {
            //order = 1 asc
            //order = 2 desc
            switch (index)
            {
                    case 0:
                        sortEan(order);
                    break;
                    case 1:
                        sortArticle(order);
                    break;
                    case 2:
                        sortPriceAmazon(order, priceCalculator);
                    break;
                    case 3:
                        sortPriceEbay(order, priceCalculator);
                        break;
                    case 4:
                        sortOwnPrice(order);
                    break;
            }
        }

        private void sortEan(int order)
        {
            
            if (order == 0)
            {                
                listData = (from p in listData orderby p.Ean select p).ToList();
            }
                
            else if (order == 1)
                listData = (from p in listData orderby p.Ean descending select p).ToList();
        }

        private void sortArticle(int order)
        {
            if (order == 0)
                listData = (from p in listData orderby p.Aritcel select p).ToList();
            else if (order == 1)
                listData = (from p in listData orderby p.Aritcel descending select p).ToList();
        }

        private void sortPriceAmazon(int order, int priceCalculator)
        {
            double MwSt = 0.19;
            if (order == 0)
            {
                switch (priceCalculator)
                {
                    //Brutto and shipping
                    case 5:
                        //amazonPrice = data.PriceAmazon + data.AmazonShipping;
                        listData = (from p in listData orderby (p.PriceAmazon + p.AmazonShipping) select p).ToList();
                        break;
                    //Brutto and no shipping
                    case 6:
                        //amazonPrice = data.PriceAmazon;
                        listData = (from p in listData orderby p.PriceAmazon select p).ToList();
                        break;
                    //Netto and shipping
                    case 9:
                        //amazonPrice = (data.PriceAmazon / (1 + MwSt)) + data.AmazonShipping; 
                        listData = (from p in listData orderby ((p.PriceAmazon / 1 + MwSt) + p.AmazonShipping) select p).ToList();
                        break;
                    //Netto and no shipping
                    case 10:
                        listData = (from p in listData orderby ((p.PriceAmazon / 1 + MwSt)) select p).ToList();
                        break;
                }
            }                
            else if (order == 1)
            {
                switch (priceCalculator)
                {
                    //Brutto and shipping
                    case 5:
                        //amazonPrice = data.PriceAmazon + data.AmazonShipping;
                        listData = (from p in listData orderby (p.PriceAmazon + p.AmazonShipping) descending select p).ToList();
                        break;
                    //Brutto and no shipping
                    case 6:
                        //amazonPrice = data.PriceAmazon;
                        listData = (from p in listData orderby p.PriceAmazon descending select p).ToList();
                        break;
                    //Netto and shipping
                    case 9:
                        //amazonPrice = (data.PriceAmazon / (1 + MwSt)) + data.AmazonShipping; 
                        listData = (from p in listData orderby ((p.PriceAmazon / 1 + MwSt) + p.AmazonShipping) descending select p).ToList();
                        break;
                    //Netto and no shipping
                    case 10:
                        listData = (from p in listData orderby ((p.PriceAmazon / 1 + MwSt)) descending select p).ToList();
                        break;
                }
            }
        }

        private void sortPriceEbay(int order, int priceCalculator)
        {
            double MwSt = 0.19;
            if (order == 0)
            {
                switch (priceCalculator)
                {
                    //Brutto and shipping
                    case 5:
                        //EbayPrice = data.PriceEbay + data.EbayShipping;
                        listData = (from p in listData orderby (p.PriceEbay + p.EbayShipping) select p).ToList();
                        break;
                    //Brutto and no shipping
                    case 6:
                        //EbayPrice = data.PriceEbay;
                        listData = (from p in listData orderby p.PriceEbay select p).ToList();
                        break;
                    //Netto and shipping
                    case 9:
                        //EbayPrice = (data.PriceEbay / (1 + MwSt)) + data.EbayShipping; 
                        listData = (from p in listData orderby ((p.PriceEbay / 1 + MwSt) + p.EbayShipping) select p).ToList();
                        break;
                    //Netto and no shipping
                    case 10:
                        listData = (from p in listData orderby ((p.PriceEbay / 1 + MwSt)) select p).ToList();
                        break;
                }
            }
            else if (order == 1)
            {
                switch (priceCalculator)
                {
                    //Brutto and shipping
                    case 5:
                        //EbayPrice = data.PriceEbay + data.EbayShipping;
                        listData = (from p in listData orderby (p.PriceEbay + p.EbayShipping) descending select p).ToList();
                        break;
                    //Brutto and no shipping
                    case 6:
                        //EbayPrice = data.PriceEbay;
                        listData = (from p in listData orderby p.PriceEbay descending select p).ToList();
                        break;
                    //Netto and shipping
                    case 9:
                        //EbayPrice = (data.PriceEbay / (1 + MwSt)) + data.EbayShipping; 
                        listData = (from p in listData orderby ((p.PriceEbay / 1 + MwSt) + p.EbayShipping) descending select p).ToList();
                        break;
                    //Netto and no shipping
                    case 10:
                        listData = (from p in listData orderby ((p.PriceEbay / 1 + MwSt)) descending select p).ToList();
                        break;
                }
            }
        }

        private void sortOwnPrice(int order)
        {
            if (order == 0)
                listData = (from p in listData orderby p.OwnPrice select p).ToList();
            else if (order == 1)
                listData = (from p in listData orderby p.OwnPrice descending select p).ToList();
        }

        public Data getData(string ean)
        {
            return listData.Where(id => id.Ean == ean).Select(data => data).First();
        }

        public void mergeList(Platform platform, List<Data> threadList)
        {
            lock(syncLock)
            {
                int count = listData.Count;
                switch (platform)
                {
                    case Platform.Amazon:
                        for (int i = 0; i < count; i++)
                        {
                            listData[i].PriceAmazon = threadList[i].PriceAmazon;
                            listData[i].AmazonShipping = threadList[i].AmazonShipping;
                            listData[i].UrlAmazon = threadList[i].UrlAmazon;
                        }
                        break;
                    case Platform.Ebay:
                        for (int i = 0; i < count; i++)
                        {
                            listData[i].PriceEbay = threadList[i].PriceEbay;
                            listData[i].EbayShipping = threadList[i].EbayShipping;
                            listData[i].UrlEbay = threadList[i].UrlEbay;
                            listData[i].DiscriptionEbay = threadList[i].DiscriptionEbay;
                        }
                        break;
                    default:
                        break;
                }
            }            
        }
    }
}
