using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oege_Get_the_best_price.Model
{
    class DataHolding
    {       
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

        public void mergeList(List<Data> threadList, int id)
        {
            lock(syncLock)
            {
                int count = listData.Count;
                for(int i = 0; i < count; i++)
                {
                    listData[i].PriceAmazon = threadList[i].PriceAmazon;
                    //TODO usw.....
                }
            }            
        }
    }
}
