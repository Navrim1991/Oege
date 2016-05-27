using Oege_Get_the_best_price.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oege_Get_the_best_price.Controller.Parsing
{
    class ParsingController
    {
        int guiHash;

        Amazon.ParsingControllerAmazon parsingControllerAmazon;
        Ebay.ParsingControllerEbay parsingControllerEbay;
        Idealo.ParsingControllerIdealo parsingControllerIdealo;

        private delegate void listViewDelegate();

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
            Thread amazonThread = new Thread(parsingControllerAmazon.startExcelList);
            Thread ebayThread = new Thread(parsingControllerEbay.startExcelList);
            Thread idealoThread = new Thread(parsingControllerIdealo.start);

            amazonThread.Start();
            ebayThread.Start();
            //idealoThread.Start();

            amazonThread.Join();
            ebayThread.Join();

            Form frm = Controller.Instance().getFormController(guiHash, 1).Frm;
            frmParsing frmPar = null;

            if (frm.GetType() == typeof(frmParsing))
                frmPar = ((frmParsing)frm);

            if(frmPar != null)
            {
                listViewDelegate del = new listViewDelegate(frmPar.updateListView);
                frmPar.BeginInvoke(del);
            }

        }

    }
}
