using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oege_Get_the_best_price.Controller
{
    class FormController
    {
        int guiHash;

        public int GuiHash
        {
            get
            {
                return guiHash;
            }
        }

        public FormController(int guiHash)
        {
            this.guiHash = guiHash;
        }
    }
}
