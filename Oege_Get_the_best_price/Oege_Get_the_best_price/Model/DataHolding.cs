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
        List<DataHolding> listData;
        private string ean;
        private string aritcel;
        private decimal priceAmazon;
        private decimal priceEbay;
        private decimal priceIdealo;
        #endregion

        #region properties
        public string Ean
        {
            get
            {
                return ean;
            }

            set
            {
                ean = value;
            }
        }

        public string Aritcel
        {
            get
            {
                return aritcel;
            }

            set
            {
                aritcel = value;
            }
        }

        public decimal PriceAmazon
        {
            get
            {
                return priceAmazon;
            }

            set
            {
                priceAmazon = value;
            }
        }

        public decimal PriceEbay
        {
            get
            {
                return priceEbay;
            }

            set
            {
                priceEbay = value;
            }
        }

        public decimal PriceIdealo
        {
            get
            {
                return priceIdealo;
            }

            set
            {
                priceIdealo = value;
            }
        }

        public List<DataHolding> ListData
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
            listData = new List<DataHolding>();
        }

        public DataHolding(string ean, string articel)
        {
            this.ean = ean;
            this.aritcel = articel;
            this.priceAmazon = 0;
            this.priceEbay = 0;
            this.PriceIdealo = 0;
        }
    }
}
