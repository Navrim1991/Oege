﻿using System;
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
    public partial class frmParsing : Form
    {
        #region Attributs

        private static int frmCounter = 0;
        Controller.Controller controller;
        Controller.DataController dataController;
        Controller.ExcelController excelController;
        Controller.FormController formController;
        Controller.Parsing.ParsingController parsingController;
        const short level = 1;

        #endregion

        #region Constructor
        public frmParsing()
        {
            
            InitializeComponent();
            frmCounter++;

            controller = Controller.Controller.Instance();
            controller.Register(this, level);
            int hash = this.GetHashCode();

            dataController = controller.getDataController(hash, level);
            if (dataController == null)
                throw new ArgumentNullException("dataController", "dataController ist null");

            excelController = controller.getExcelController(hash, level);
            if (excelController == null)
                throw new ArgumentNullException("excelController", "excelController ist null");

            formController = controller.getFormController(hash, level);
            if (formController == null)
                throw new ArgumentNullException("formController", "formController ist null");

            parsingController = controller.getParsingController(hash, level);
            if (parsingController == null)
                throw new ArgumentNullException("parsingController", "parsingController ist null");

        }
        #endregion

        #region Events

        private void frmParsing_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmCounter == 1)
                e.Cancel = true;
            else
            {
                frmCounter--;
                controller.Unregister(this, level);
            }
        }

        #endregion

        #region methods

        public void importExcelFile()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<object> param = new List<object>();
                param.Add(openFileDialog.FileName);

                //TODO Form für Spaltenauswahl

                backgroundWorkerExcel.RunWorkerAsync(param);
                

            }
        }

        public void updateListView()
        {
            listView.Items.Clear();
        }


        #endregion

        private void frmParsing_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorkerExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            List<object> param = (List<object>)e.Argument;
            if(param != null && param.Count > 1)
                excelController.readExcelFile((string)param[0], level, 3, 1, 7);
        }
    }
}
