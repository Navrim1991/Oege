using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Text.RegularExpressions;
using System.Windows;
using Excel = Microsoft.Office.Interop.Excel;

namespace Oege_Get_the_best_price.Controller
{
    class ExcelController
    {
        int guiHash;
        double currencConversion;
        public int GuiHash
        {
            get
            {
                return guiHash;
            }
        }

        public ExcelController(int guiHash)
        {
            this.guiHash = guiHash;
        }

        public double CurrencConversion
        {
            get
            {
                return currencConversion;
            }
            set
            {
                currencConversion = value;
            }
        }

        public void readExcelFile(string filePath, int level, int indexEan, int indexDiscription, int indexPrice, double currencyConversion)
        {
            Excel.Application app;
            Excel.Workbook workBook;
            Excel.Worksheet workSheet;
            object misValue = System.Reflection.Missing.Value;

            app = new Excel.Application();
            //xlWorkBook = xlApp.Workbooks.Open("csharp.net-informations.xls", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            workBook = app.Workbooks.Open(@filePath);
            workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

            int rows = workSheet.UsedRange.Rows.Count;
            int columns = workSheet.UsedRange.Columns.Count;

            List<Model.Data> tmp = new List<Model.Data>();

            Controller controller = Controller.Instance();

            for (int i = 1; i < rows; i++)
            {
                if(columns >= indexEan)
                {
                    object discription = "";
                    object price = 0.0;
                    object ean = (object)(workSheet.Cells[i, indexEan] as Excel.Range).Value;


                    if (ean != null)
                    {
                        string eanString = ean.ToString();
                        eanString = controller.makeEan(eanString);

                        if(controller.checkEan(eanString))
                        {
                            Model.Data data = new Model.Data(eanString);

                            if (indexDiscription > 0 && columns >= indexDiscription)
                                discription = (object)(workSheet.Cells[i, indexDiscription] as Excel.Range).Value;

                            if (indexPrice > 0 && columns >= indexPrice)
                                price = (object)(workSheet.Cells[i, indexPrice] as Excel.Range).Value;

                            data.Aritcel = discription.ToString();

                            data.OwnPrice =  controller.parseDouble(price.ToString()) * currencyConversion;

                            tmp.Add(data);
                        }

                    }
                }
            }
            workBook.Close(false);
            app.Quit();

            releaseObject(workSheet);
            releaseObject(workBook);
            releaseObject(app);

            Controller.Instance().getDataController(guiHash, level).DataHolding.ListData = tmp;

            Controller.Instance().getParsingController(guiHash, level).start();

        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        /*public void readExcelFile(string filePath, int level, int indexEan, int indexDiscription, int indexPrice)
        {
            List<Model.Data> tmp = new List<Model.Data>();
            Workbook workBook;
            SharedStringTable sharedStrings;
            IEnumerable<Sheet> workSheets;
            WorksheetPart workSheet;
            string workSheetId;
            try
            {
                using (SpreadsheetDocument document = SpreadsheetDocument.Open(@filePath, true))
                {
                    workBook = document.WorkbookPart.Workbook;
                    workSheets = workBook.Descendants<Sheet>();
                    sharedStrings = document.WorkbookPart.SharedStringTablePart.SharedStringTable;

                    workSheetId = workSheets.First().Id;
                    workSheet = (WorksheetPart)document.WorkbookPart.GetPartById(workSheetId);

                    IEnumerable<Row> dataRows = from row in workSheet.Worksheet.Descendants<Row>() where row.RowIndex > 1 select row;

                    foreach (Row row in dataRows)
                    {
                        IEnumerable<String> textValues =
                        from cell in row.Descendants<Cell>()
                        where cell.CellValue != null
                        select
                        (cell.DataType != null
                         && cell.DataType.HasValue
                         && cell.DataType == CellValues.SharedString
                         ? sharedStrings.ChildElements[int.Parse(cell.CellValue.InnerText)].InnerText
                         : cell.CellValue.InnerText);
                        //Check to verify the row contained data.
                        if (textValues.Count() > 0 && textValues.Count() > indexEan)
                        {
                            String[] textArray = textValues.ToArray();

                            Match regExMatch = Regex.Match(textArray[indexEan], "[0-9]{13}|(?:[0-9]{8})");
                            if (regExMatch.Success)
                            {
                                if (textArray[indexEan].Length == 8 || textArray[indexEan].Length == 13)
                                {
                                    Model.Data data = new Model.Data(textArray[indexEan]);

                                    if (indexDiscription > -1 && textValues.Count() > indexDiscription)
                                        data.Aritcel = textArray[indexDiscription];

                                    if (indexPrice > -1 && textValues.Count() > indexPrice)
                                    {
                                        double tmpPrice;
                                        string tmpString = textArray[indexPrice];

                                        regExMatch = null;
                                        regExMatch = Regex.Match(tmpString, "[0-9]*(?:.[0-9]{1,2})");
                                        if (regExMatch.Success)
                                        {
                                            tmpString = regExMatch.Groups[0].Value;

                                            tmpString = tmpString.Replace(".", ",");
                                            bool ret = double.TryParse(tmpString, out tmpPrice);

                                            if (ret)
                                                data.OwnPrice = tmpPrice;
                                            else
                                                data.OwnPrice = 0;

                                            string s = Convert.ToString(data.OwnPrice);
                                        }
                                        else
                                            data.OwnPrice = 0;
                                    }

                                    tmp.Add(data);
                                }
                                else
                                {
                                    //If no cells, then you have reached the end of the table.
                                    break;
                                }
                            }
                        }
                    }
                }

                Controller.Instance().getDataController(guiHash, level).DataHolding.ListData = tmp;

                Controller.Instance().getParsingController(guiHash, level).start();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Fehler beim Laden der Excel-Datei\n" + ex.Message + "\n" + ex.StackTrace, "Fehler beim Laden der Excel-Datei", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }*/
    }
}
