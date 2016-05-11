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
        private string urlAmazon;
        private string urlEbay;
        private string urlIdealo;
        private double priceAmazon;
        private double priceEbay;
        private double priceIdealo;
        private double shippingAmazon;
        private double shippingEbay;
        private double shippingIdealo;
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

        public string UrlAmazon
        {
            get
            {
                return urlAmazon;
            }

            set
            {
                urlAmazon = value;
            }
        }

        public string UrlEbay
        {
            get
            {
                return urlEbay;
            }

            set
            {
                urlEbay = value;
            }
        }

        public string UrlIdealo
        {
            get
            {
                return urlIdealo;
            }

            set
            {
                urlIdealo = value;
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

        public double ShippingAmazon
        {
            get
            {
                return shippingAmazon;
            }

            set
            {
                shippingAmazon = value;
            }
        }

        public double ShippingEbay
        {
            get
            {
                return shippingEbay;
            }

            set
            {
                shippingEbay = value;
            }
        }

        public double ShippingIdealo
        {
            get
            {
                return shippingIdealo;
            }

            set
            {
                shippingIdealo = value;
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
            this.urlAmazon= "";
            this.urlEbay = "";
            this.urlIdealo = "";
            this.priceAmazon = 0;
            this.priceEbay = 0;
            this.PriceIdealo = 0;
            this.ownPrice = 0;
        }
        public Data(string ean, string articel, double ownPrice)
        {
            this.ean = ean;
            this.aritcel = articel;
            this.urlAmazon = "";
            this.urlEbay = "";
            this.urlIdealo = "";
            this.priceAmazon = 0;
            this.priceEbay = 0;
            this.priceIdealo = 0;
            this.shippingAmazon = 0;
            this.shippingEbay = 0;
            this.shippingIdealo = 0;
            this.ownPrice = ownPrice;
        }

        public Data(string ean, string articel, string urlAmazon, string urlEbay, string urlIdealo, double priceAmazon, double priceEbay, double priceIdealo, double shippingAmazon, double shippingEbay, double shippingIdealo, double ownPrice)
        {
            this.ean = ean;
            this.aritcel = articel;
            this.urlAmazon = urlAmazon;
            this.urlEbay = urlEbay;
            this.urlIdealo = urlIdealo;
            this.priceAmazon = priceAmazon;
            this.priceEbay = priceEbay;
            this.priceIdealo = priceIdealo;
            this.shippingAmazon = shippingAmazon;
            this.shippingEbay = shippingEbay;
            this.shippingIdealo = shippingIdealo;
            this.ownPrice = ownPrice;
        }
    }
}
