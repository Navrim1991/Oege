using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oege_Get_the_best_price.Controller
{
    class ExcelController
    {
        int guiHash;

        public int GuiHash
        {
            get
            {
                return guiHash;
            }
        }
        public ExcelController(int guiHash)
        {
            this.guiHash = guiHash;
        }

        public void readExcelFile(string filePath, int level)
        {
            List<Oege_Get_the_best_price.Model.Data> tmp = new List<Oege_Get_the_best_price.Model.Data>();

            Controller.Instance().getDataController(guiHash, level).DataHolding.ListData = tmp;
        }
    }
}
