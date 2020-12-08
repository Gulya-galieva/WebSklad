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
using WebSklad.App_code;

namespace WebSklad.Controllers
{
    public class MaterialController : Controller
    {
        StoreContext db;
        MaterialManager materialManager;
        IHostingEnvironment _env;
        public MaterialController(StoreContext context, IHostingEnvironment env)
        {
            db = context;
            materialManager = new MaterialManager();
            _env = env;
        }
        [HttpGet]
        public ActionResult MaterialTypes()
        {
            List<DropDownItem> dropDownItems = new List<DropDownItem>();

            foreach (var item in db.MaterialUnits)
            {

                dropDownItems.Add(new DropDownItem { Id = item.Id, Name = item.Name});
            }
            SelectList listItems = new SelectList(dropDownItems, "Id", "Name");
            ViewBag.listItems = listItems;
            return View(db.MaterialTypes.ToList());
        }

        [HttpPost]
        public IActionResult AddMaterialType(string Name, int MaterialUnitId, double Price)
        {
            if(!materialManager.NewMaterialType(Name, MaterialUnitId, Price))
                ViewBag.error = "Невозможно доавить " + Name  + "!";
            
             return PartialView("_MaterialTypesTable", db.MaterialTypes.ToList());
        }

        [HttpPost]
        public IActionResult DeleteMaterialType(int id)
        {
            var c = db.MaterialTypes.Find(id);
            if (c != null)
            {
                db.MaterialTypes.Remove(c);
                db.SaveChanges();
            }
            return PartialView("_MaterialTypesTable", db.MaterialTypes.ToList());
        }

        public IActionResult MaterialTypeEdit (int id)
        {
            MaterialType type = db.MaterialTypes.Find(id);
            List<DropDownItem> dropDownItems = new List<DropDownItem>();

            foreach (var item in db.MaterialUnits)
            {

                dropDownItems.Add(new DropDownItem { Id = item.Id, Name = item.Name });
            }
            SelectList listItems = new SelectList(dropDownItems, "Id", "Name");
            ViewBag.listItems = listItems;
            return View(type);
        }

        [HttpPost]
        public IActionResult MaterialTypeEdit (MaterialType type)
        {
            string error = string.Empty;
            MaterialType material = db.MaterialTypes.Find(type.Id);
            if(material != null)
            {
                if (type.Name != material.Name)
                {
                    if (db.MaterialTypes.FirstOrDefault(m => m.Name == type.Name) != null) error = "Материал с таким наименованием уже существует в БД!";
                    else material.Name = type.Name;

                }
                if (error == string.Empty)
                {
                    material.MaterialUnitId = type.MaterialUnitId;
                    material.Price = type.Price;
                    db.SaveChanges();
                    return RedirectToAction("MaterialTypes", "Material");
                }
                else
                {
                    ViewData["error"] = error;
                    return View("~/Views/Shared/_ErrorPage.cshtml");
                }
            }
            else
            {
                ViewData["error"] = "Невозможно сохранить изменения";
                return View("~/Views/Shared/_ErrorPage.cshtml");
            }

        }

        public async Task<IActionResult> UpdatePrice()
        {
            return View();
        }

        public async Task<IActionResult> UploadPrice (IFormFile file)
        {
            var filePath = _env.WebRootPath + "/Files/Temp/Price.xlsx";
            if(file.Length > 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }
            ExcelProcessor excelProcessor = new ExcelProcessor(db, _env);
            ViewBag.Info = excelProcessor.GetUpdateInfo(filePath);
            return View("~/Views/Material/UpdatePrice.cshtml");
        }

        public string UpdateMaterials ()
        {
            ExcelProcessor excelProcessor = new ExcelProcessor(db, _env);
            return excelProcessor.UpdateMaterials(_env.WebRootPath + "/Files/Temp/Price.xlsx");

        }
    }
}