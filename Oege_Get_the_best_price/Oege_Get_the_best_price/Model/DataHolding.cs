using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
