using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Oege_Get_the_best_price.Controller.Parsing
{
    class ParsingController
    {
        int guiHash;

        Amazon.ParsingControllerAmazon parsingControllerAmazon;
        Ebay.ParsingControllerEbay parsingControllerEbay;
        Idealo.ParsingControllerIdealo parsingControllerIdealo;

        public ParsingController(int hash, int level)
        {
            this.guiHash = hash;

            this.parsingControllerAmazon = new Amazon.ParsingControllerAmazon(hash, level);
            this.parsingControllerEbay = new Ebay.ParsingControllerEbay(hash, level);
            this.parsingControllerIdealo = new Idealo.ParsingControllerIdealo(hash, level);
        }

        public int GuiHash
        {
            get
            {
                return guiHash;
            }
        }

        #region Get Parsingcontroller

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

        #endregion

        public void start()
        {
            Thread amazonThread = new Thread(parsingControllerAmazon.start);
            Thread ebayThread = new Thread(parsingControllerEbay.start);
            Thread idealoThread = new Thread(parsingControllerIdealo.start);

            amazonThread.Start();
            ebayThread.Start();
            //idealoThread.Start();

            amazonThread.Join();
            ebayThread.Join();

        }

    }
}
