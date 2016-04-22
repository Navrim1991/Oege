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
        private string url;
        private double priceAmazon;
        private double priceEbay;
        private double priceIdealo;
        private double ownPrice;
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

        public string Url
        {
            get
            {
                return Url;
            }

            set
            {
                Url = value;
            }
        }

        public double PriceAmazon
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

        public double PriceEbay
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

        public double PriceIdealo
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

        public double OwnPrice
        {
            get
            {
                return ownPrice;
            }

            set
            {
                ownPrice = value;
            }
        }

        #endregion

        public Data(string ean)
        {
            this.ean = ean;
            this.aritcel = "";
            this.url= "";
            this.priceAmazon = 0;
            this.priceEbay = 0;
            this.PriceIdealo = 0;
            this.ownPrice = 0;
        }
        public Data(string ean, string articel, double ownPrice)
        {
            this.ean = ean;
            this.aritcel = articel;
            this.priceAmazon = 0;
            this.priceEbay = 0;
            this.PriceIdealo = 0;
            this.ownPrice = ownPrice;
        }

        public Data(string ean, string articel, string url, double priceAmazon, double priceEbay, double priceIdealo, double ownPrice)
        {
            this.ean = ean;
            this.aritcel = articel;
            this.url = url;
            this.priceAmazon = priceAmazon;
            this.priceEbay = priceEbay;
            this.priceIdealo = priceIdealo;
            this.ownPrice = ownPrice;
        }
    }
}
