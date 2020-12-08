using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebSklad.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using DbManager;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;
using ClosedXML.Excel;

namespace WebSklad.App_code
{
    public class ExcelProcessor
    {
        StoreContext _db;
        IHostingEnvironment _env;
        public ExcelProcessor(StoreContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }

        public UpdateInfo GetUpdateInfo(string filePath)
        {
            int _count = 0;
            int _newItems = 0;
            int _updatedUnits = 0;
            int _updatedPrice = 0;
            XLWorkbook wb;
            IXLWorksheet ws;

            List<UpdateItem> updateItems = new List<UpdateItem>();
            try
            {
                wb = new XLWorkbook(filePath);
                ws = wb.Worksheet(1);
            }
            catch
            {
                return new UpdateInfo { Error = "Ошибка открытия файла" };
            }
            int row = 2;
            bool fileEnd = false;
            while (!fileEnd)
            {
                if (ws.Cell("A" + row).Value.ToString() == "")
                {
                    fileEnd = true;
                    break;
                }
                if(ws.Cell("C" + row).Value.ToString() == "" || ws.Cell("B" + row).Value.ToString() == "" || ws.Cell("A" + row).Value.ToString() == "")
                    return new UpdateInfo { Error = "Ошибка данных в ряду " + row };
                if (double.TryParse(ws.Cell("C" + row).Value.ToString(), out double price))
                {
                    
                    updateItems.Add(new UpdateItem { Name = ws.Cell("A" + row).Value.ToString(), Unit = ws.Cell("B" + row).Value.ToString(), Price = price });
                    row++;
                }
                else return new UpdateInfo { Error = "Ошибка чтения стоимости в ряду " + row };
            }
            _count = updateItems.Count();

            List<UpdateUnits> _updateUnits = new List<UpdateUnits>();
            List<UpdatePrice> _updatePrices = new List<UpdatePrice>();
            List<NewMaterials> _newMaterials = new List<NewMaterials>();
            if (updateItems.Count > 0)
            {
                int index = 2;
                foreach (var item in updateItems)
                {
                    MaterialUnit unit = _db.MaterialUnits.FirstOrDefault(u => u.Name == item.Unit);
                    MaterialType type = _db.MaterialTypes.FirstOrDefault(t => t.Name == item.Name);

                    if (unit == null) return new UpdateInfo { Error = "Ошибка, неопределенная еденица измерения в ряду " + index };
                    if (type == null)
                    {
                        _newItems++;
                        _newMaterials.Add(new NewMaterials { Name = item.Name, Unit = item.Unit, Price = item.Price });
                    }
                    else
                    {
                        if (type.Unit.Name != item.Unit)
                        {
                            _updatedUnits++;
                            _updateUnits.Add(new UpdateUnits { Name = item.Name, OldUnit = type.Unit.Name, NewUnit = item.Unit });

                        }

                        if (type.Price != item.Price)
                        {
                            _updatedPrice++;
                            _updatePrices.Add(new UpdatePrice { Name = item.Name, OldPrice = type.Price, NewPrice = item.Price });
                        }
                    }
                    index++;
                }
            }

            return new UpdateInfo { Count = _count, NewItems = _newItems, UpdatedUnits = _updatedUnits, UpdatePrice = _updatedPrice, UpdateUnits = _updateUnits, UpdatePrices = _updatePrices, NewMaterials = _newMaterials };
        }

        public string UpdateMaterials (string filePath)
        {
            int _count = 0;
            int _newItems = 0;
            int _updatedUnits = 0;
            int _updatedPrice = 0;
            XLWorkbook wb;
            IXLWorksheet ws;

            List<UpdateItem> updateItems = new List<UpdateItem>();
            try
            {
                wb = new XLWorkbook(filePath);
                ws = wb.Worksheet(1);
            }
            catch
            {
                return "Ошибка открытия файла";
            }
            int row = 2;
            bool fileEnd = false;
            while (!fileEnd)
            {
                if (ws.Cell("A" + row).Value.ToString() == "")
                {
                    fileEnd = true;
                    break;
                }
                if (ws.Cell("C" + row).Value.ToString() == "" || ws.Cell("B" + row).Value.ToString() == "" || ws.Cell("A" + row).Value.ToString() == "")
                    return "Ошибка данных в ряду " + row ;
                if (double.TryParse(ws.Cell("C" + row).Value.ToString(), out double price))
                {

                    updateItems.Add(new UpdateItem { Name = ws.Cell("A" + row).Value.ToString(), Unit = ws.Cell("B" + row).Value.ToString(), Price = price });
                    row++;
                }
                else return  "Ошибка чтения стоимости в ряду " + row ;
            }
            _count = updateItems.Count();

           
            if (updateItems.Count > 0)
            {
                int index = 2;
                foreach (var item in updateItems)
                {
                    MaterialUnit unit = _db.MaterialUnits.FirstOrDefault(u => u.Name == item.Unit);
                    MaterialType type = _db.MaterialTypes.FirstOrDefault(t => t.Name == item.Name);

                    if (unit == null) return "Ошибка, неопределенная еденица измерения в ряду " + index;
                    if (type == null) 
                    {
                        _newItems++;
                        _db.MaterialTypes.Add(new MaterialType { Name = item.Name, Price = item.Price, MaterialUnitId = unit.Id });
                        _db.SaveChanges();
                    }
                    else
                    {
                        if (type.Unit.Name != item.Unit)
                        {
                            _updatedUnits++;
                            type.MaterialUnitId = unit.Id;
                            _db.SaveChanges();
                          

                        }

                        if (type.Price != item.Price)
                        {
                            _updatedPrice++;
                            type.Price = item.Price;
                            _db.SaveChanges();
                        }
                    }
                    index++;
                }
            }

            return "Добавлено новых материалов: " + _newItems + ", обновлений цен: " + _updatedPrice + ", обновлений ед. изм.: " + _updatedUnits;
        }

    }


    public class ErrorResult
    {
        public string Error { get; set; }
    }

    public class UpdateItem
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Price { get; set; }
    }

}