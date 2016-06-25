using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oege_Get_the_best_price.Controller.Parsing;
using System.Text.RegularExpressions;

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
        private static object syncLock;

        #endregion

        #region Singleton
        private Controller()
        {
            syncLock = new object();
        }

        public static Controller Instance()
        {
            if (instance == null)
            {
                instance = new Controller();
            }

            return instance;
        }
        #endregion

        #region helper

        public string makeEan(string ean)
        {
            string tmp = ean;

            if (tmp.Length == 8 || tmp.Length == 13)
                return ean;

            if (tmp.Length < 8)
            {
                do
                {
                    tmp = "0" + tmp;
                } while (tmp.Length < 8);
            }
            else if(tmp.Length < 13)
            {
                do
                {
                    tmp = "0" + tmp;
                } while (tmp.Length < 13);
            }

            return tmp;
        }

        public bool checkEan(string ean)
        {
            if(ean.Length == 13 ||  ean.Length == 8)
                return Regex.Match(ean, "[0-9]" + "{" + ean.Length + "}(?!00000000)(?!0000000000000)").Success;

            return false;
        }

        public string selectSubstring(string str, string headEscape, string tailEscape)
        {
            int index = str.IndexOf(headEscape);
            string subString = str.Substring(index + headEscape.Length);
            index = subString.IndexOf(tailEscape);
            return subString.Substring(0, index);

        }

        public string selectSubstring(string str, string headEscape)
        {
            int index = str.IndexOf(headEscape);
            return str.Substring(index + headEscape.Length);
        }

        public double parseDouble(string value)
        {
            bool parse;
            double returnValue;
            value = value.Replace(".", ",");
            parse = Double.TryParse(value, out returnValue);

            if (parse)
                return returnValue;

            return 0.0;
        }

        public double parseDouble(string value, double defaultValue)
        {
            bool parse;
            double returnValue;
            value = value.Replace(".", ",");
            parse = Double.TryParse(value, out returnValue);

            if (parse)
                return returnValue;

            return defaultValue;
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
            lock(syncLock)
            {
                switch (level)
                {
                    case 1:
                        registerLevelOne(frm, level);
                        break;
                    case 10:
                        registerLevelTen(frm, level);
                        break;
                    default:
                        break;
                }
            }
        }

        private void registerLevelOne(Form frm, int level)
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
            listFormController.Add(new FormController(frm));
            listParsingController.Add(new ParsingController(frm.GetHashCode(), level));
        }

        private void registerLevelTen(Form frm, int level)
        {
            if (listParsingController == null)
                listParsingController = new List<ParsingController>();

            listParsingController.Add(new ParsingController(frm.GetHashCode(), level));
        }

        #endregion

        #region Unregister
        public void Unregister(Form frm, int level)
        {
            lock(syncLock)
            {
                switch (level)
                {
                    case 1:
                        unregisterLevelOne(frm);
                        break;
                    case 10:
                        unregisterLevelTen(frm);
                        break;
                    default:
                        break;
                }
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

        private void unregisterLevelTen(Form frm)
        {
            if (listParsingController != null)
            {
                ParsingController delParsingCon = (from parsingController in listParsingController where frm.GetHashCode() == parsingController.GuiHash select parsingController).First();
                listParsingController.Remove(delParsingCon);
            }
        }

        #endregion
    }
}
