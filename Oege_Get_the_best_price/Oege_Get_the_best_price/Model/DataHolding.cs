using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oege_Get_the_best_price.Resources;

namespace Oege_Get_the_best_price.Model
{
    class DataHolding
    {       
        #region attributes
        List<Data> listData;
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
        }

    }
}
