using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oege_Get_the_best_price.View
{
    public partial class Main : Form
    {
        List<Form> listForms = new List<Form>();
        Form activeForm;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            tabControl.TabPages.Add(new frmParsing());
        }

        private void tabControl_SelectedTabChanged(object sender, EventArgs e)
        {
            activeForm = (Form)tabControl.SelectedForm;
            int hash = activeForm.GetHashCode();
        }

        private void schnellstartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Add(new frmParsing());
        }
    }
}
