using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oege_Get_the_best_price.Controller.Parsing
{
    class ParsingController
    {
        int guiHash;

        Amazon.ParsingControllerAmazon parsingControllerAmazon;
        Ebay.ParsingControllerEbay parsingControllerEbay;
        Idealo.ParsingControllerIdealo parsingControllerIdealo;

        public ParsingController(int hash)
        {
            this.guiHash = hash;

            this.parsingControllerAmazon = new Amazon.ParsingControllerAmazon(hash);
            this.parsingControllerEbay = new Ebay.ParsingControllerEbay(hash);
            this.parsingControllerIdealo = new Idealo.ParsingControllerIdealo(hash);
        }

        public int GuiHash
        {
            get
            {
                return guiHash;
            }
        }

        public Amazon.ParsingControllerAmazon ParsingControllerAmazon
        {
            get
            {
                return parsingControllerAmazon;
            }
        }

        public Ebay.ParsingControllerEbay ParsingControllerEbay
        {
            get
            {
                return parsingControllerEbay;
            }
        }

        public Idealo.ParsingControllerIdealo ParsingControllerIdealo
        {
            get
            {
                return parsingControllerIdealo;
            }
        }
    }
}
