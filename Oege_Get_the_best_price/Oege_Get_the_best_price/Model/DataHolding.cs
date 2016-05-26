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

        public void sortList(int index, int order)
        {
            //order = 1 asc
            //order = 2 desc
            switch (index)
            {
                    case 0:
                        if (order == 1)
                            listData = (from p in listData orderby p.Ean select p).ToList();
                        else if (order == 2)
                            listData = (from p in listData orderby p.Ean descending select p).ToList();
                        break;
                    case 1:
                        if (order == 1)
                            listData = (from p in listData orderby p.Aritcel select p).ToList();
                        else if (order == 2)
                            listData = (from p in listData orderby p.Aritcel descending select p).ToList();
                        break;
                    case 2:
                        if (order == 1)
                            listData = (from p in listData orderby p.PriceAmazon select p).ToList();
                        else if (order == 2)
                            listData = (from p in listData orderby p.PriceAmazon descending select p).ToList();
                        break;
                    case 3:
                        if (order == 1)
                            listData = (from p in listData orderby p.PriceEbay select p).ToList();
                        else if (order == 2)
                            listData = (from p in listData orderby p.PriceEbay descending select p).ToList();
                        break;
                    case 4:
                    if (order == 1)
                        listData = (from p in listData orderby p.OwnPrice select p).ToList();
                    else if (order == 2)
                        listData = (from p in listData orderby p.OwnPrice descending select p).ToList();
                    break;
            }
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
