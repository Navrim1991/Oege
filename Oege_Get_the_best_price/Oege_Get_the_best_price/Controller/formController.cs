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
        Form frm;

        public int GuiHash
        {
            get
            {
                return guiHash;
            }
        }

        public Form Frm
        {
            get
            {
                return frm;
            }
        }

        public FormController(Form frm)
        {
            this.frm = frm;
            this.guiHash = frm.GetHashCode();
        }
    }
}
