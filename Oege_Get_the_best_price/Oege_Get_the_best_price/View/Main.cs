using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oege_Get_the_best_price.View.Main
{
    public partial class Main : Form, IFormHandler
    {
        List<Form> listForms = new List<Form>();
        Form activeForm;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            tabControl.TabPages.Add(new frmParsing(this));
        }

        private void tabControl_SelectedTabChanged(object sender, EventArgs e)
        {
            activeForm = (Form)tabControl.SelectedForm;
            int hash = activeForm.GetHashCode();
        }

        private void schnellstartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Add(new frmParsing(this));
        }

        public void delete(int hash)
        {
            Form del = (from frm in listForms where frm.GetHashCode() == hash select frm).First();
            listForms.Remove(del);
        }

        public void add(Form frm)
        {
            listForms.Add(frm);
        }
    }
}
