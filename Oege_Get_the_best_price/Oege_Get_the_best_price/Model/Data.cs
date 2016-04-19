using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oege_Get_the_best_price.Model
{
    class Data
    {
        #region attributes
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

        #endregion

        public Data(string ean, string articel)
        {
            this.ean = ean;
            this.aritcel = articel;
            this.priceAmazon = 0;
            this.priceEbay = 0;
            this.PriceIdealo = 0;
        }

        public Data(string ean, string articel, decimal priceAmazon, decimal priceEbay, decimal priceIdealo)
        {
            this.ean = ean;
            this.aritcel = articel;
            this.priceAmazon = priceAmazon;
            this.priceEbay = priceEbay;
            this.priceIdealo = priceIdealo;
        }
    }
}
