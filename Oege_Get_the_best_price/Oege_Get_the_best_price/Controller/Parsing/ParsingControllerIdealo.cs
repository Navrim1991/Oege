using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Oege_Get_the_best_price.Model;
using System.Windows.Forms;
using Oege_Get_the_best_price.View;

namespace Oege_Get_the_best_price.Controller.Parsing.Idealo
{
    class ParsingControllerIdealo
    {
        int guiHash;
        int level;
        private delegate void progressBarDelegate(frmParsing.Platform platform, int percent);

        public ParsingControllerIdealo(int hash, int level)
        {
            this.guiHash = hash;
            this.level = level;
        }

        public void start()
        {
            List<Data> listData = Controller.Instance().getDataController(guiHash, level).DataHolding.ListData;
            Form frm = Controller.Instance().getFormController(guiHash, level).Frm;
            frmParsing frmPar = null;
            
            if (frm.GetType() == typeof(frmParsing))
            {
                frmPar = ((frmParsing)frm);
            }

            progressBarDelegate del = new progressBarDelegate(frmPar.updateProgressBar);
            int listCount = listData.Count();
            int counter = 0;
            int percent = 0;

            foreach (Data element in listData)
            {
                Thread.Sleep(100);
                percent = ++counter * 100 / listCount;
                if (frmPar != null)
                    frmPar.BeginInvoke(del, new object[] { frmParsing.Platform.Idealo, percent });

            }
        }
    }
}
