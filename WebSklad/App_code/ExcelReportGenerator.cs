using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML;
using ClosedXML.Excel;
using ClosedXML.Extensions;
using DbManager;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace WebSklad.App_code
{
    public static class ExcelReportGenerator
    {
        public static ActionResult GenerateOutcomeAct(int actId, StoreContext db, IHostingEnvironment env, bool isReturnAct)
        {
            DeliveryAct act = db.DeliveryActs.Find(actId);
            WorkerManager workerManager = new WorkerManager(db);
            EmploymentContract employmentContract = null;
            if (db.EmploymentContracts.Where(c => c.WorkerId == act.WorkerId).Count() > 0)
            {
                employmentContract = db.EmploymentContracts.Where(c => c.WorkerId == act.WorkerId).Last();
            }
            string template = env.WebRootPath + "/Files/Templates/";
            string header;
            int row = 16;
            if (isReturnAct)
            {
                template += "ReturnActTemplate.xlsx";
                header = "Aкт №" + act.Id + Environment.NewLine + "возврата материальных ценностей";
                row = 15;
            }
            else
            {
                header = "Aкт №" + act.Id + Environment.NewLine + "приема-передачи материальных ценностей работнику";
                template += "ActTemplate.xlsx";
                row = 16;
            }
                
            var workbook = new XLWorkbook(template);

            var ws = workbook.Worksheet(1);
            ws.PageSetup.Header.Center.Clear();
           

            var richText = ws.PageSetup.Header.Center.AddText(header);
            richText.FontName = "Times New Roman";
            richText.FontSize = 14;
            string filePath = BarCodeGenerator(act.Id.ToString(), env, 250, 55);
            var image = ws.AddPicture(filePath).MoveTo(ws.Cell("F"+1), 14, 4);
            //image.MoveTo(ws.Cell("F" + 1), 10, 4);

            ws.Cell("B" + 1).Value = act.Date.ToShortDateString() + "г.";
            ws.Cell("A" + 7).Value = workerManager.GetWorkerName(act.Worker);

            if (employmentContract != null)
            {
                ws.Cell("D" + 10).Value = "№ " + employmentContract.Number;
                ws.Cell("F" + 10).Value = "от " + employmentContract.Date.ToShortDateString() + "г.";
            }
           
           
            int count = 1;
            List<DeviceDelivery> deviceDeliveries = act.DeviceDeliveries.ToList();
            List<MaterialDelivery> materialDeliveries = act.MaterialDeliveries.ToList();
            foreach (var item in deviceDeliveries)
            {
                ws.Cell("A" + row).Value = count;

                ws.Range("B" + row, "D" + row).Merge();
                ws.Cell("B" + row).Value = item.DeviceType.Name;

                ws.Range("E" + row, "F" + row).Merge();
                ws.Cell("E" + row).Style.NumberFormat.NumberFormatId = 13;
                ws.Cell("E" + row).Value = "'" + item.SerialNumber;

                ws.Cell("G" + row).Value = "шт";
                ws.Cell("H" + row).Value = "1";
                if (item.DeviceType.Price != 0)
                    ws.Cell("I" + row).Value = item.DeviceType.Price;
                ws.Row(row).InsertRowsBelow(1);
                ws.Range("A" + row, "I" + row).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                ws.Range("A" + row, "I" + row).Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                row++;
                count++;
            }

            foreach (var item in materialDeliveries)
            {
                ws.Cell("A" + row).Value = count;

                ws.Range("B" + row, "D" + row).Merge();
                ws.Cell("B" + row).Value = item.MaterialType.Name;

                ws.Range("E" + row, "F" + row).Merge();
                ws.Cell("E" + row).Value = "отсутствует";

                ws.Cell("G" + row).Value = item.MaterialType.Unit.Name;
                ws.Cell("H" + row).Value = Math.Abs(item.Volume);
                if (item.MaterialType.Price != 0)
                    ws.Cell("I" + row).Value = item.MaterialType.Price * Math.Abs(item.Volume);
                ws.Row(row).InsertRowsBelow(1);
                ws.Range("A" + row, "I" + row).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                ws.Range("A" + row, "I" + row).Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                row++;
                count++;
            }

            ws.Cell("H" + (row + 7)).Value = workerManager.GetShortWorkerName(act.Worker);
            return workbook.Deliver("Act" + act.Id + ".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
        }

        public static ActionResult GeneratePPEAct(int actId, StoreContext db, IHostingEnvironment env)
        {
            DeliveryAct act = db.DeliveryActs.Find(actId);
            WorkerManager workerManager = new WorkerManager(db);

            var wb = new XLWorkbook(env.WebRootPath + "/Files/Templates/PPEAct1Template.xlsx");
            var ws1 = wb.Worksheet(1);
            var ws2 = wb.Worksheet(2);
            string name= workerManager.GetWorkerName(act.Worker);
            ws1.Cell("A" + 6).Value = name;
            int row = 12;
            foreach(var item in act.PPEDeliveries)
            {
                ws1.Range("A" + row, "C" + row).Merge();
                ws1.Cell("A" + row).Value = item.PPE.Name;
                ws1.Cell("E" + row).Value = act.Date.ToShortDateString();
                ws1.Cell("F" + row).Value = Math.Abs(item.Volume);
                ws1.Range("A" + row, "M" + row).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                ws1.Range("A" + row, "M" + row).Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                ws1.Range("A" + row, "M" + row).Style.Font.FontSize = 10;
               row++;
            }

            row = 16;
            int i = 1;
            ws2.Cell("G" + 1).Value = "Ведомость №" + act.Id;
            ws2.Cell("I" + 9).Value = act.Date.ToShortDateString();
            foreach(var item in act.PPEDeliveries)
            {
                ws2.Range("B" + row, "D" + row).Merge();
                ws2.Range("F" + row, "H" + row).Merge();
                ws2.Cell("B" + row).Value = name;
                ws2.Cell("F" + row).Value = item.PPE.Name;
                ws2.Cell("L" + row).Value = Math.Abs(item.Volume);
                ws2.Cell("M" + row).Value = act.Date.ToShortDateString();
                ws2.Range("A" + row, "O" + row).Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                ws2.Range("A" + row, "O" + row).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                ws2.Range("A" + row, "O" + row).Style.Font.FontSize = 10;
                ws2.Row(row+1).InsertRowsBelow(1);
                row++;
            }
            return wb.Deliver("ActPPE" + act.Id + ".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
        }

        public static ActionResult GenerateStickers (List<Worker> workers, StoreContext db, IHostingEnvironment env)
        {
            WorkerManager manager = new WorkerManager(db);

            var workbook = new XLWorkbook();
            var ws = workbook.Worksheets.Add("Стикеры");

            int row = 1;
            foreach(var item in workers)
            {
                IXLCell start = ws.Cell("A" + row);
                ws.Range("A" + row, "D" + row).Merge();
                ws.Cell("A" + row).Value = manager.GetWorkerName(item);
                
                string filePath = BarCodeGenerator(item.Id.ToString(), env, 250, 75);
                ws.Range("A" + (row + 1), "D" + (row + 5)).Merge();
                var image = ws.AddPicture(filePath).MoveTo(ws.Cell("A" + (row+1)), 6, 4);
                var end = ws.Cell("D" + (row +5));
                ws.Range(start, end).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                row += 7;
            }
            return workbook.Deliver("Stickers.xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
        }

        private static string BarCodeGenerator(string input, IHostingEnvironment env, int iwidth, int iheight)
        {
            Random rnf = new Random();
            var width = iwidth;
            var height = iheight;
            var barCodeWriter = new ZXing.BarcodeWriterPixelData
            {
                Format = ZXing.BarcodeFormat.CODE_128,
                Options = new ZXing.Common.EncodingOptions
                {
                    Height = height,
                    Width = width,
                    Margin = 0
                }
            };
            var pixelData = barCodeWriter.Write(input);
            using (var bitmap = new Bitmap(pixelData.Width, pixelData.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb))
            {
                using (var memoryStream = new MemoryStream())
                {
                    var bitmapData = bitmap.LockBits(new Rectangle(0, 0, pixelData.Width, pixelData.Height),
                        System.Drawing.Imaging.ImageLockMode.WriteOnly,
                        System.Drawing.Imaging.PixelFormat.Format32bppRgb);
                    try
                    {
                        System.Runtime.InteropServices.Marshal.Copy(pixelData.Pixels, 0, bitmapData.Scan0, pixelData.Pixels.Length);
                    }
                    finally
                    {
                        bitmap.UnlockBits(bitmapData);
                    }
                    bitmap.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                    string filePath = env.WebRootPath + "/Files/Temp/" + input +"_"+ rnf.Next(1000, 999999).ToString()  + ".png";
                    bitmap.Save(filePath);
                    return filePath;

                }
            }
        }
    }
}


