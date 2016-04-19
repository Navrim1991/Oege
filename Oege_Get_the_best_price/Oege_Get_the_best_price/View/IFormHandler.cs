using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oege_Get_the_best_price.View
{
    public interface IFormHandler
    {
        void delete(int hash);
        void add(Form frm);
    }
}
