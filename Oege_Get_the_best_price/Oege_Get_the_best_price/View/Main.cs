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
            try
            {
                tabControl.TabPages.Add(new frmParsing());
            }
            catch(ArgumentNullException ex)
            {
                MessageBox.Show("Fehler beim Laden des Fensters\n" + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl_SelectedTabChanged(object sender, EventArgs e)
        {
            activeForm = (Form)tabControl.SelectedForm;
            int hash = activeForm.GetHashCode();

            
        }

        private void addPage()
        {
            try
            {
                tabControl.TabPages.Add(new frmParsing());
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Fehler beim Laden des Fensters\n" + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void schnellstartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPage();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void excelListeImportierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activeForm.GetType() == typeof(frmParsing))
            {
                frmParsing frm = ((frmParsing)activeForm);
                if(!frm.hasData())
                    ((frmParsing)activeForm).importExcelFile();
                else
                {
                    addPage();
                    ((frmParsing)activeForm).importExcelFile();
                }
            }
                
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(activeForm.GetType() == typeof(frmParsing))
                ((frmParsing)activeForm).exportData();
        }

        private void projektÖffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activeForm.GetType() == typeof(frmParsing))
                ((frmParsing)activeForm).importData();
        }

        private void einzelneEanSuchenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchSingleEan frmSearch = new frmSearchSingleEan();
            frmSearch.Show(this);
        }
    }
}
