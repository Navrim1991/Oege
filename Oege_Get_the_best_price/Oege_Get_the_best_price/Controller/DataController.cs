using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oege_Get_the_best_price.Model;

namespace Oege_Get_the_best_price.Controller
{
    class DataController
    {
        int guiHash;
        DataHolding data;

        public int GuiHash
        {
            get
            {
                return guiHash;
            }
        }

        public DataHolding Data
        {
            get
            {
                return data;
            }
        }

        public DataController(int guiHash)
        {
            this.guiHash = guiHash;
            data = new DataHolding();
        }

    }
}
