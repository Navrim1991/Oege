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

        private string _discriptionAmazon;
        private string _discriptionEbay;
        private string _discriptionIdealo;

        #endregion
        #region properties
        public string Ean { get; set; }

        public string Aritcel { get; set; }

        public string UrlAmazon { get; set; }

        public string UrlEbay { get; set; }

        public string UrlIdealo { get; set; }

        public string DiscriptionAmazon { get; set; }

        public string DiscriptionEbay { get; set; }

        public string DiscriptionIdealo { get; set; }

        public double PriceAmazon { get; set; }

        public double PriceEbay { get; set; }

        public double PriceIdealo { get; set; }

        public double AmazonShipping { get; set; }

        public double EbayShipping { get; set; }

        public double ShippingIdealo { get; set; }

        public double OwnPrice { get; set; }

        #endregion

        public Data(string ean)
        {
            this.Ean = ean;
            this.Aritcel = "";
            this.UrlAmazon= "";
            this.UrlEbay = "";
            this.UrlIdealo = "";
            this.PriceAmazon = 0;
            this.PriceEbay = 0;
            this.PriceIdealo = 0;
            this.OwnPrice = 0;
        }
        public Data(string ean, string articel, double ownPrice)
        {
            this.Ean = ean;
            this.Aritcel = articel;
            this.UrlAmazon = "";
            this.UrlEbay = "";
            this.UrlIdealo = "";
            this.PriceAmazon = 0;
            this.PriceEbay = 0;
            this.PriceIdealo = 0;
            this.AmazonShipping = 0;
            this.EbayShipping = 0;
            this.ShippingIdealo = 0;
            this.OwnPrice = ownPrice;
        }

        public Data(string ean, string articel, string urlAmazon, string urlEbay, string urlIdealo, double priceAmazon, double priceEbay, double priceIdealo, double _amazonShipping, double ebayShipping, double shippingIdealo, double ownPrice)
        {
            this.Ean = ean;
            this.Aritcel = articel;
            this.UrlAmazon = urlAmazon;
            this.UrlEbay = urlEbay;
            this.UrlIdealo = urlIdealo;
            this.PriceAmazon = priceAmazon;
            this.PriceEbay = priceEbay;
            this.PriceIdealo = priceIdealo;
            this.AmazonShipping = _amazonShipping;
            this.EbayShipping = ebayShipping;
            this.ShippingIdealo = shippingIdealo;
            this.OwnPrice = ownPrice;
        }
    }
}
