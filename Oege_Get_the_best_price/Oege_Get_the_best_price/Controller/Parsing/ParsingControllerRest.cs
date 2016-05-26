using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

using RestSharp;

namespace Oege_Get_the_best_price.Controller.Parsing.AmazonRest
{
    class ParsingControllerRest
    {

        int guiHash;
        int level;

        private HtmlNode rootNode;

        public ParsingControllerRest(int hash, int level)
        {
            this.guiHash = hash;
            this.level = level;
        }

        public void test()
        {
            var client = new RestClient("http://www.amazon.de/s/");

            var request = new RestRequest(Method.POST);
            request.AddParameter("field-keywords", "4005808747405");
            request.AddParameter("sort", "price-asc-rank");
            IRestResponse response = client.Execute(request);
            var content = response.Content;
        }
    }
}
