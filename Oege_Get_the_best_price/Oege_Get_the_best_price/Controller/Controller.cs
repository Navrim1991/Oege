using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oege_Get_the_best_price.Controller.Parsing;

namespace Oege_Get_the_best_price.Controller
{
    class Controller
    {
        #region Attributs

        private static Controller instance = null;
        private static List<DataController> listDataController;
        private static List<ExcelController> listExcelController;
        private static List<FormController> listFormController;
        private static List<ParsingController> listParsingController;

        #endregion

        #region Singleton
        private Controller() { }

        public static Controller Instance()
        {
            if (instance == null)
            {
                instance = new Controller();
            }

            return instance;
        }
        #endregion
        
        #region Get Controller

        public DataController getDataController(int hash, int level)
        {
            if (level <= 10 && listDataController != null)
            {
                DataController dataCon = (from dataController in listDataController where hash == dataController.GuiHash select dataController).First();
                return dataCon;
            }

            return null;
        }

        public ExcelController getExcelController(int hash, int level)
        {
            if (level <= 10 && listExcelController != null)
            {
                ExcelController excelCon = (from excelController in listExcelController where hash == excelController.GuiHash select excelController).First();
                return excelCon;
            }

            return null;
        }

        public FormController getFormController(int hash, int level)
        {
            if (level <= 10 && listFormController != null)
            {
                FormController formCon = (from formController in listFormController where hash == formController.GuiHash select formController).First();
                return formCon;
            }

            return null;
        }

        public ParsingController getParsingController(int hash, int level)
        {
            if (level <= 10 && listParsingController != null)
            {
                ParsingController parsingCon = (from parsingController in listParsingController where hash == parsingController.GuiHash select parsingController).First();
                return parsingCon;
            }

            return null;
        }

        #endregion

        #region Register

        public void Register(Form frm, int level)
        {
            switch (level)
            {
                case 1:
                    registerLevelOne(frm);
                    break;
                default:
                    break;
            }

        }

        private void registerLevelOne(Form frm)
        {
            if (listExcelController == null)
                listExcelController = new List<ExcelController>(); ;

            if (listDataController == null)
                listDataController = new List<DataController>();

            if (listFormController == null)
                listFormController = new List<FormController>();

            if (listParsingController == null)
                listParsingController = new List<ParsingController>();

            listDataController.Add(new DataController(frm.GetHashCode()));
            listExcelController.Add(new ExcelController(frm.GetHashCode()));
            listFormController.Add(new FormController(frm.GetHashCode()));
            listParsingController.Add(new ParsingController(frm.GetHashCode()));
        }

        #endregion

        #region Unregister
        public void Unregister(Form frm, int level)
        {
            switch (level)
            {
                case 1:
                    unregisterLevelOne(frm);
                    break;
                default:
                    break;
            }
        }

        private void unregisterLevelOne(Form frm)
        {
            if (listDataController != null)
            {
                DataController delDataCon = (from dataController in listDataController where frm.GetHashCode() == dataController.GuiHash select dataController).First();
                listDataController.Remove(delDataCon);
            }

            if (listExcelController != null)
            {
                ExcelController delExcelCon = (from excelController in listExcelController where frm.GetHashCode() == excelController.GuiHash select excelController).First();
                listExcelController.Remove(delExcelCon);
            }

            if (listFormController != null)
            {
                FormController delFromCon = (from formController in listFormController where frm.GetHashCode() == formController.GuiHash select formController).First();
                listFormController.Remove(delFromCon);
            }

            if (listParsingController != null)
            {
                ParsingController delParsingCon = (from parsingController in listParsingController where frm.GetHashCode() == parsingController.GuiHash select parsingController).First();
                listParsingController.Remove(delParsingCon);
            }
        }

        #endregion
    }
}
