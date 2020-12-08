using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebSklad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using WebSklad.App_code;
using DbManager;
using System.Text.RegularExpressions;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using ClosedXML.Extensions;

namespace WebSklad.Controllers
{
    public class DeliveryController : Controller
    {
       private IHostingEnvironment _env;
        StoreContext db;
        DeliveryManager deliveryManager;
        public DeliveryController(StoreContext context, IHostingEnvironment env)
        {
            db = context;
            deliveryManager = new DeliveryManager();
            _env = env;
        }

        public IActionResult Income(int id) //Незавершенные акты приема 
        {
            deliveryManager.GetContract(id, out Contract contract);
            List<DropDownItem> dropDownDeliveryActItems = new List<DropDownItem>();
            foreach (var item in deliveryManager.GetDeliveryActs(contract, "в работе", "прием на склад"))
            {
                dropDownDeliveryActItems.Add(new DropDownItem { Id = item.Id, Name = "Акт приема №" + item.Id + " от " + item.Date.ToShortDateString() + " создал: " + item.User.Name });
            }
            SelectList listItems = new SelectList(dropDownDeliveryActItems, "Id", "Name");

            ViewBag.listItems = listItems;
            ViewBag.contract = contract;
            return View();
        } 

        public ActionResult OpenDeliveryAct(int deliveryActId) //открытие акта 
        {
            if (Int32.TryParse(Request.Form["deliveryActId"], out int id) && Request.Form["deliveryActId"] != "")
            {
                deliveryManager.GetDeliveryAct(id, out DeliveryAct act);
                if (act != null)
                {
                    ViewBag.str = "Акт №" + act.Id + " от " + act.Date.ToShortDateString();
                    return Redirect("/Delivery/DeliveryAct/" + id);
                }
            }
            else
            {
                ViewData["error"] = "Не возможно открыть выбранный акт";
            }
            return View("Delivery");
        }

        public ActionResult CreateDeliveryAct(string dType) //создание акта
        {
            Int32.TryParse(Request.Form["contractId"], out int contractId);
            deliveryManager.GetUserId(User.Identity.Name, out int userId);
            string id = deliveryManager.NewDeliveryAct(dType, userId, contractId);
          
            if (Regex.IsMatch(id, @"^\d+"))
                return Redirect("~/Delivery/DeliveryAct/" + id);
            else
            {
                ViewData["error"] = id;
                return View("~/Views/Shared/_ErrorPage.cshtml"); 
            }

        }

        public ActionResult DeliveryAct(int id) //акт 
        {
            List<DropDownItem> dropDownMaterialItems = new List<DropDownItem>();
            deliveryManager.GetDeliveryAct(id, out DeliveryAct act);
            User user = act.User;
            SelectList listMaterials = new SelectList(dropDownMaterialItems, "Id", "Name");
            if (act != null)
            {
                ViewBag.state = act.DeliveryState.Description;
                ViewBag.actType = act.DeliveryType.Description;
                if(act.ContractId != null && act.ContractId != 0)
                    ViewBag.contractId = act.Contract.Id;
                ViewBag.actId = act.Id;
                ViewBag.listMaterials = listMaterials;
                ViewBag.deliveryAct = act;

                if (act.WorkerId != null)
                {
                    Worker worker = deliveryManager.GetWorker((int)act.WorkerId);
                    if (act.Worker != null)
                        ViewBag.worker = worker.Surname + " " + worker.Name + " " + worker.MIddlename;
                }
                else
                {
                    if (user.Name != null && user.Name != "")
                        ViewBag.worker = user.Name;
                    else
                        ViewBag.worker = user.Login;
                }

                if (act.DeliveryType.Description == "прием на склад")
                {
                    ViewBag.str = "Акт приема на склад №" + act.Id + " " + act.Contract.Name + " от " + act.Date.ToShortDateString();
                    ViewBag.buttonText = "Принять";
                    foreach (var item in db.MaterialTypes)
                    {
                        dropDownMaterialItems.Add(new DropDownItem { Id = item.Id, Name = item.Name + "     [" + item.Unit.Name + "]" });
                    }

                    if (act.DeliveryState.Description == "проведен")
                        return View("DeliveryActView", new DeliveryModel(act.Id, db));
                   else
                        return View(new DeliveryModel(act.Id, db));

                }

                if (act.DeliveryType.Description == "выдача со склада")
                {
                    ViewBag.str = "Акт выдачи со склада №" + act.Id + " " + act.Contract.Name + " от " + act.Date.ToShortDateString();
                    ViewBag.buttonText = "Выдать";

                    //список материалов для выдачи
                    foreach (var item in db.Materials.Where(m => m.ContractId == act.ContractId))
                    {
                        dropDownMaterialItems.Add(new DropDownItem { Id = item.Id, Name = item.MaterialType.Name + " [" + item.Volume + "] [" + item.MaterialType.Unit.Name + "]" });
                    }

                    //список комплектов для выдачи
                    List<DropDownItem> dropDownDeliveryActItems = new List<DropDownItem>();
                    foreach (var item in deliveryManager.GetDeliveryActs((int)act.ContractId,"в работе", "комплект"))
                    {
                        dropDownDeliveryActItems.Add(new DropDownItem { Id = item.Id, Name = "Комплект " + item.SetName });
                    }
                    SelectList setItems = new SelectList(dropDownDeliveryActItems, "Id", "Name");


                    //Список работников для выдачи
                    List<DropDownItem> dropDownWorkerItems = new List<DropDownItem>();
                    dropDownWorkerItems.Add(new DropDownItem { Name ="Выберите работника", Id = 0 });
                    foreach (var item in db.Workers.Where(w => w.WorkerType.Description == "монтажник" || w.WorkerType.Description == "пнр"))
                    {
                        dropDownWorkerItems.Add(new DropDownItem { Name = item.Surname + " " + item.Name + " " + item.MIddlename, Id = item.Id });
                    }
                    SelectList workerList = new SelectList(dropDownWorkerItems, "Id", "Name");

                    ViewBag.workers = workerList;
                    ViewBag.setItems = setItems;

                    if (act.DeliveryState.Description == "проведен")
                        return View("DeliveryActView", new DeliveryModel(act.Id, db));
                    else
                        return View("DeliveryActOutcome", new DeliveryModel(act.Id, db));
                }

                if (act.DeliveryType.Description == "комплект")
                {
                    ViewBag.str = "Комплект " + act.SetName + " " + act.Contract.Name;
                    ViewBag.buttonText = "Сохранить";
                    foreach (var item in db.Materials.Where(m => m.ContractId == act.ContractId))
                    {
                        dropDownMaterialItems.Add(new DropDownItem { Id = item.Id, Name = item.MaterialType.Name + " [" + item.MaterialType.Unit.Name + "]" });
                    }
                    return View("DeliveryActSet", new DeliveryModel(act.Id, db));
                }

                if (act.DeliveryType.Description == "брак")
                {
                    ViewBag.str = "Акт выбраковки №" + act.Id + " " + act.Contract.Name + " от " + act.Date.ToShortDateString();
                    ViewBag.buttonText = "Провести";

                    if (act.DeliveryState.Description == "проведен")
                       return View("DeliveryActView", new DeliveryModel(act.Id, db));
                      else
                        return View("DeliveryActDefect", new DeliveryModel(act.Id, db));
                }

                if (act.DeliveryType.Description == "выдача на сборку")
                {
                    ViewBag.buttonText = "Провести";
                    ViewBag.str = "Акт выдачи на сборку №" + act.Id + " " + act.Contract.Name + " от " + act.Date.ToShortDateString();
                    List<DropDownItem> dropDownWorkerItems = new List<DropDownItem>();
                    foreach (var item in db.Workers.Where(w => w.WorkerType.Description == "сборщик"))
                    {
                        dropDownWorkerItems.Add(new DropDownItem { Name = item.Surname + " " + item.Name + " " + item.MIddlename, Id = item.Id });
                    }
                    SelectList workerList = new SelectList(dropDownWorkerItems, "Id", "Name");
                    ViewBag.workers = workerList;

                    List<DropDownItem> dropDownDeliveryActItems = new List<DropDownItem>();
                    dropDownDeliveryActItems.Add(new DropDownItem { Id = 0, Name = "Отсутствует" });
                    foreach (var item in deliveryManager.GetDeliveryActs((int)act.ContractId, "в работе", "комплект"))
                    {
                        dropDownDeliveryActItems.Add(new DropDownItem { Id = item.Id, Name = "Комплект " + item.SetName });
                    }
                    SelectList setItems = new SelectList(dropDownDeliveryActItems, "Id", "Name");
                    ViewBag.setItems = setItems;
                    if (act.DeliveryState.Description == "проведен")
                        return View("DeliveryActView", new DeliveryModel(act.Id, db));
                    else
                        return View("~/Views/Delivery/DeviceMoving/DeliveryActToAssembly.cshtml", new DeliveryModel(act.Id, db));
                }

                if (act.DeliveryType.Description == "выдача на настройку")
                {
                    ViewBag.str = "Акт выдачи на настройку №" + act.Id + " " + act.Contract.Name + " от " + act.Date.ToShortDateString();
                    ViewBag.buttonText = "Выдать";

                    List<DropDownItem> dropDownWorkerItems = new List<DropDownItem>();
                    foreach (var item in db.Workers.Where(w => w.WorkerType.Description == "настройщик"))
                    {
                        dropDownWorkerItems.Add(new DropDownItem { Name = item.Surname + " " + item.Name + " " + item.MIddlename, Id = item.Id });
                    }
                    SelectList workerList = new SelectList(dropDownWorkerItems, "Id", "Name");
                    ViewBag.workers = workerList;

                    if (act.DeliveryState.Description == "проведен")
                        return View("DeliveryActView", new DeliveryModel(act.Id, db));
                    else
                        return View("~/Views/Delivery/DeviceMoving/DeliveryActDeviceMoving.cshtml", new DeliveryModel(act.Id, db));
                }

                if (act.DeliveryType.Description == "возврат со сборки")
                {
                    ViewBag.str = "Акт возврата со сборки №" + act.Id + " " + act.Contract.Name + " от " + act.Date.ToShortDateString();
                    ViewBag.buttonText = "Провести";

                    SelectList workerList = null;
                    ViewBag.workers = workerList;

                    if (act.DeliveryState.Description == "проведен")
                        return View("DeliveryActView", new DeliveryModel(act.Id, db));
                    else
                        return View("~/Views/Delivery/DeviceMoving/DeliveryActDeviceMoving.cshtml", new DeliveryModel(act.Id, db));
                }

                if (act.DeliveryType.Description == "возврат с настройки")
                {
                    ViewBag.str = "Акт возврата с настройки №" + act.Id + " " + act.Contract.Name + " от " + act.Date.ToShortDateString();
                    ViewBag.buttonText = "Провести";
                    SelectList workerList = null;
                    ViewBag.workers = workerList;
                    if (act.DeliveryState.Description == "проведен")
                        return View("DeliveryActView", new DeliveryModel(act.Id, db));
                    else
                        return View("~/Views/Delivery/DeviceMoving/DeliveryActDeviceMoving.cshtml", new DeliveryModel(act.Id, db));
                }

                if (act.DeliveryType.Description == "возврат на склад")
                {
                    ViewBag.str = "Акт возврата на склад №" + act.Id + " " + act.Contract.Name + " от " + act.Date.ToShortDateString();
                    ViewBag.buttonText = "Возврат";

                    ViewBag.str = "Акт возврата на склад №" + act.Id + " " + act.Contract.Name + " от " + act.Date.ToShortDateString();

                    foreach (var item in db.Materials.Where(m => m.ContractId == act.ContractId))
                    {
                        dropDownMaterialItems.Add(new DropDownItem { Id = item.Id, Name = item.MaterialType.Name + " [" + item.Volume + "] [" + item.MaterialType.Unit.Name + "]" });
                    }

                    List<DropDownItem> dropDownDeliveryActItems = new List<DropDownItem>();
                    foreach (var item in deliveryManager.GetDeliveryActs((int)act.ContractId, "в работе", "комплект"))
                    {
                        dropDownDeliveryActItems.Add(new DropDownItem { Id = item.Id, Name = "Комплект " + item.SetName });
                    }
                    SelectList setItems = new SelectList(dropDownDeliveryActItems, "Id", "Name");
                    List<DropDownItem> dropDownWorkerItems = new List<DropDownItem>();

                    foreach (var item in db.Workers.Where(w => w.WorkerType.Description == "монтажник" || w.WorkerType.Description == "пнр"))
                    {
                        dropDownWorkerItems.Add(new DropDownItem { Name = item.Surname + " " + item.Name + " " + item.MIddlename, Id = item.Id });
                    }
                    SelectList workerList = new SelectList(dropDownWorkerItems, "Id", "Name");

                    ViewBag.workers = workerList;
                    ViewBag.setItems = setItems;

                    if (act.DeliveryState.Description == "проведен")
                        return View("DeliveryActView", new DeliveryModel(act.Id, db));
                   
                    else
                        return View("DeliveryActOutcome", new DeliveryModel(act.Id, db));
                }

                if (act.DeliveryType.Description == "прием инструмента и сиз")
                {
                    ViewBag.str = "Акт приема инструмента и СИЗ №" + act.Id + " от " + act.Date.ToShortDateString();
                    ViewBag.buttonText = "Принять";
                    foreach (var item in db.PPEs)
                    {
                        dropDownMaterialItems.Add(new DropDownItem { Id = item.Id, Name = item.Name});
                    }

                    if (act.DeliveryState.Description == "проведен")
                        return View("DeliveryActView", new DeliveryModel(act.Id, db));

                    else
                        return View("~/Views/Tools/DeliveryActPPE.cshtml", new DeliveryModel(act.Id, db));
                }

                if (act.DeliveryType.Description == "выдача инструмента и сиз")
                {
                    ViewBag.str = "Акт выдачи инструмента и СИЗ №" + act.Id + " от " + act.Date.ToShortDateString();
                    ViewBag.buttonText = "Выдать";
                    foreach (var item in db.PPEs)
                    {
                        dropDownMaterialItems.Add(new DropDownItem { Id = item.Id, Name = item.Name });
                    }
                    List<DropDownItem> dropDownWorkerItems = new List<DropDownItem>();

                    foreach (var item in db.Workers)
                    {
                        dropDownWorkerItems.Add(new DropDownItem { Name = item.Surname + " " + item.Name + " " + item.MIddlename, Id = item.Id });
                    }
                    SelectList workerList = new SelectList(dropDownWorkerItems, "Id", "Name");
                    ViewBag.workers = workerList;
                    if (act.DeliveryState.Description == "проведен")
                        return View("DeliveryActView", new DeliveryModel(act.Id, db));

                    else
                        return View("~/Views/Tools/DeliveryActPPE.cshtml", new DeliveryModel(act.Id, db));
                }

                if (act.DeliveryType.Description == "возврат производителю")
                {
                    ViewBag.str = "Акт возврата производителю №" + act.Id + " " + act.Contract.Name + " от " + act.Date.ToShortDateString();
                    ViewBag.buttonText = "Возврат";

                   
                    foreach (var item in db.Materials.Where(m => m.ContractId == act.ContractId))
                    {
                        dropDownMaterialItems.Add(new DropDownItem { Id = item.Id, Name = item.MaterialType.Name + " [" + item.Volume + "] [" + item.MaterialType.Unit.Name + "]" });
                    }

                    List<DropDownItem> dropDownDeliveryActItems = new List<DropDownItem>();
                    foreach (var item in deliveryManager.GetDeliveryActs((int)act.ContractId, "в работе", "комплект"))
                    {
                        dropDownDeliveryActItems.Add(new DropDownItem { Id = item.Id, Name = "Комплект " + item.SetName });
                    }
                    SelectList setItems = new SelectList(dropDownDeliveryActItems, "Id", "Name");
                 
         

                    if (act.DeliveryState.Description == "проведен")
                        return View("DeliveryActView", new DeliveryModel(act.Id, db));

                    else
                        return View("DeliveryActReturnToMnfc", new DeliveryModel(act.Id, db));
                }

            }
            return View(new DeliveryModel(act.Id, db));
        }

        public ActionResult AddMaterial(DeliveryActModel model) //добавление материала в таблицу 
        {
            DeliveryAct act = db.DeliveryActs.Find(model.ActId);
            MaterialType type = db.MaterialTypes.Find(model.MaterialId);
            if (act != null)
            {
                type = db.MaterialTypes.Find(model.MaterialTypeId);
                double volume = 0;
                if (act.DeliveryType.Description == "выдача со склада" || act.DeliveryType.Description == "возврат производителю")
                {
                    volume = 0 - model.Volume;
                }
                else volume = model.Volume;

               

                foreach (var item in act.MaterialDeliveries)
                {
                    if (model.MaterialTypeId == item.MaterialTypeId)
                    {
                        item.Volume += volume;
                        db.SaveChanges();
                        return PartialView("_DeliveryTable", new DeliveryModel(act.Id, db)); ;
                    }

                }

                if (act.DeliveryType.Description == "выдача со склада")
                {
                    Material material = db.Materials.Find(model.MaterialId);
                    type = material.MaterialType;
                    db.MaterialDeliveries.Add(new MaterialDelivery { MaterialTypeId = type.Id, MaterialType = type, Volume = volume, DeliveryActId = model.ActId, Other = model.Other });
                }

                if (act.DeliveryType.Description == "прием на склад")
                {
                    db.MaterialDeliveries.Add(new MaterialDelivery { MaterialTypeId = type.Id, Volume = volume, DeliveryActId = model.ActId, Other = model.Other });
                }
                if (act.DeliveryType.Description == "комплект")
                {
                    Material material = db.Materials.Find(model.MaterialId);
                    type = material.MaterialType;
                    volume = model.Volume;
                    db.MaterialDeliveries.Add(new MaterialDelivery { MaterialTypeId = type.Id, MaterialType = type, Volume = volume, DeliveryActId = model.ActId, Other = model.Other });
                }
                if (act.DeliveryType.Description == "возврат на склад")
                {
                    Material material = db.Materials.Find(model.MaterialId);
                    type = material.MaterialType;
                    db.MaterialDeliveries.Add(new MaterialDelivery { MaterialId = model.MaterialId, MaterialTypeId = type.Id, Volume = volume, DeliveryActId = model.ActId, Other = model.Other });
                }

                if (act.DeliveryType.Description == "возврат производителю")
                {
                    Material material = db.Materials.Find(model.MaterialId);
                    type = material.MaterialType;
                    db.MaterialDeliveries.Add(new MaterialDelivery { MaterialId = model.MaterialId, MaterialTypeId = type.Id, Volume = volume, DeliveryActId = model.ActId, Other = model.Other });
                }


                // db.MaterialDeliveries.Add(new MaterialDelivery { MaterialTypeId = type.Id, MaterialType = type, Volume = volume, DeliveryActId = model.ActId, Other = model.Other });
            }
            db.SaveChanges();
            List<DeliveryModel> deliveryModels = new List<DeliveryModel>();

            return PartialView("_DeliveryTable", new DeliveryModel(act.Id, db));
        }

        public ActionResult AddDevice(DeliveryActModel model) //добавление оборудования в таблицу 
        {
            deliveryManager.GetDeliveryAct(model.ActId, out DeliveryAct act);
            string error = "";
           
            error = deliveryManager.NewDeviceDelivery(model.SerialNumber, act, model.SetId, model.Defect);
            

            if(error != string.Empty)
                ViewData["error"] = error;

            if (act.DeliveryType.Description == "брак")
                return PartialView("_DeliveryTableDefects", new DeliveryModel(act.Id, db));
            if (act.DeliveryType.Description == "выдача на настройку")
                return PartialView("_DeliveryTableDeviceMoving", new DeliveryModel(act.Id, db));

            if (act.DeliveryType.Description == "выдача на сборку")
                return PartialView("_DeliveryTableToAssemble", new DeliveryModel(act.Id, db));

            return PartialView("_DeliveryTable", new DeliveryModel(act.Id, db));
        }

        public ActionResult DeleteDeviceFromDeliveryTable(int DeliveryId, int ActId) //удаление оборудования из таблицы 
        {
            string error = deliveryManager.DeleteDeviceDelivery(DeliveryId);
            DeliveryAct act = deliveryManager.GetDeliveryAct(ActId);
            if (error != string.Empty)
                ViewData["error"] = error;

            if (act.DeliveryType.Description == "брак")
                return PartialView("_DeliveryTableDefects", new DeliveryModel(act.Id, db));
            if (act.DeliveryType.Description == "выдача на настройку")
                return PartialView("_DeliveryTableDeviceMoving", new DeliveryModel(act.Id, db));

            if (act.DeliveryType.Description == "выдача на сборку")
                return PartialView("_DeliveryTableToAssemble", new DeliveryModel(act.Id, db));

            return PartialView("_DeliveryTable", new DeliveryModel(act.Id, db));
        }

        public ActionResult DeleteMaterialFromDeliveryTable() //удаление материала из таблицы 
        {
            Int32.TryParse(Request.Form["DeliveryId"], out int deliveryId);
            Int32.TryParse(Request.Form["ActId"], out int actId);
            MaterialDelivery delivery = db.MaterialDeliveries.FirstOrDefault(d => d.Id == deliveryId);
            if (delivery != null)
            {
                db.MaterialDeliveries.Remove(delivery);
                db.SaveChanges();
            }
            else
            {
                ViewData["error"] = "Невозможно удалить";
            }

            DeliveryAct act = db.DeliveryActs.FirstOrDefault(a => a.Id == actId);

            return PartialView("_DeliveryTable", new DeliveryModel(act.Id, db));
        }

        public ActionResult ProcessDelivery(DeliveryActModel model) //проведение акта 
        {
            Int32.TryParse(Request.Form["id"], out int actId);
            string error = deliveryManager.ProcessDeliveryAct(actId, model.WorkerId, Request.Form["SetName"], deliveryManager.GetUserId(User.Identity.Name));
            if (error != string.Empty)
            {
                ViewData["error"] = error;
                return View("~/Views/Shared/_ErrorPage.cshtml");
            }
            return Redirect("~/Delivery/DeliveryAct/" + actId);
            

        }

        public ActionResult DeleteDeliveryAct(int id) //удаление акта 
        {
            string error = deliveryManager.DeleteDeliveryAct(id);
            if (error != string.Empty)
            {
                ViewData["error"] = error;
                return View("~/Delivery/DeliveryAct/" + id);
            }
            else return Redirect("~/Home/Index");

        }

        public ActionResult Remainings(int id, string date) //остатки 
        {
            DateTime dateTime;
            if (date == null)
                dateTime = DateTime.Now;

            else
            {
                DateTime.TryParseExact(date, "dd.MM.yyyy", new CultureInfo("ru-RU"), DateTimeStyles.None, out dateTime);
                dateTime = dateTime.AddHours(23.0);
                dateTime = dateTime.AddMinutes(50.0);
            }
            Contract contract = db.Contracts.FirstOrDefault(c => c.Id == id);
            ViewBag.contract = contract;

            List<DeviceRemanings> deviceRemanings = new List<DeviceRemanings>();
           
            var dRemainings = from dt in db.DeviceTypes
                              from d in dt.Devices
                              where d.ContractId == id && d.DeviceDeliveries.First().DeliveryAct.Date <= dateTime && (d.CurrentState == "прием на склад" || d.CurrentState == "выдача на настройку" || d.CurrentState == "выдача на сборку" || d.CurrentState == "возврат на склад")
                              select new
                              {
                                  dt,
                                  d
                              };
            foreach(var item in dRemainings.GroupBy(d => d.dt.Name))
            {
                deviceRemanings.Add(new DeviceRemanings { Name = item.Key, Count = item.Count() });
            }
            

            //foreach(var g in dRemainings.GroupBy(d => d.TypeName))
            //{
            //    deviceRemanings.Add(new DeviceRemanings { Name = g.Key, Count = g.Count() });
            //}
            ViewBag.devices = deviceRemanings;

            List<MaterialRemanings> materialRemanings = new List<MaterialRemanings>();

            var mRemainings = from m in db.Materials
                              where m.ContractId == id
                              select new
                              {
                                  m,
                                  m.MaterialType,
                                  m.MaterialDeliveries
                              };
            var mR = mRemainings.ToList();
            foreach (var material in mR)
            {
                double volume = 0;
                foreach (var materialDelivery in material.MaterialDeliveries)
                {
                    if (materialDelivery.DeliveryAct.Date <= dateTime)
                        volume += materialDelivery.Volume;
                }
                materialRemanings.Add(new MaterialRemanings { Id = material.m.Id, Name = material.MaterialType.Name, Volume = volume, Unit = material.MaterialType.Unit.Name });
            }
            
            ViewBag.materials = materialRemanings;
            ViewBag.date = dateTime;
            return View();

        }

        public ActionResult MaterialMovingByDate (int id, string date)
        {
            DateTime.TryParseExact(date.Substring(0,10), "dd.MM.yyyy", new CultureInfo("ru-RU"), DateTimeStyles.None, out DateTime startDate);
            DateTime.TryParseExact(date.Substring(13,10), "dd.MM.yyyy", new CultureInfo("ru-RU"), DateTimeStyles.None, out DateTime endDate);
            endDate = endDate.AddHours(23.0);
            endDate = endDate.AddMinutes(50.0);

            var materials = from m in db.MaterialDeliveries
                            where m.DeliveryAct.Date <= endDate && m.DeliveryAct.Date >= startDate && m.DeliveryAct.ContractId == id
                            select new
                            {
                                m,
                                m.Material,
                                m.DeliveryAct,
                                m.Material.MaterialType,
                                m.MaterialType.Unit
                            };
            var deliveries = materials.ToList();
            var result = new List<MaterialMoving>();

            bool materialFound = false;

            foreach(var item in deliveries)
            {
                if (item.Material != null)
                {
                    foreach (var material in result)
                    {
                        if (item.Material.Id == material.Id)
                        {
                            materialFound = true;
                            if (item.m.Volume > 0)
                                material.Income += item.m.Volume;
                            else
                                material.Outcome += item.m.Volume;
                        }
                    }
                    if (!materialFound)
                    {
                        var tmp = new MaterialMoving { Id = item.Material.Id, Unit = item.MaterialType.Unit.Name, Name = item.MaterialType.Name };
                        if (item.m.Volume > 0)
                            tmp.Income += item.m.Volume;
                        else tmp.Outcome += item.m.Volume;
                        result.Add(tmp);
                    }
                    materialFound = false;
                }
            }
            ViewBag.dates = date;
            ViewBag.contract = db.Contracts.Find(id);
            ViewBag.materials = result;

            return View("/Views/Delivery/MaterialMovingByDate.cshtml");
        }

        public ActionResult Outcome(int id) //выдача 
        {
            Contract contract = db.Contracts.FirstOrDefault(c => c.Id == id);

            List<DropDownItem> dropDownDeliveryActItems = new List<DropDownItem>();

            foreach (var item in db.DeliveryActs.Where(p => p.DeliveryType.Description == "выдача со склада" && p.User.Login == User.Identity.Name && p.ContractId == id && p.DeliveryState.Description == "в работе"))
            {

                dropDownDeliveryActItems.Add(new DropDownItem { Id = item.Id, Name = "Акт выдачи №" + item.Id + " от " + item.Date.ToShortDateString() + " создал: " + item.User.Name });
            }
            SelectList listItems = new SelectList(dropDownDeliveryActItems, "Id", "Name");

            ViewBag.contracts = ContractsList();
            ViewBag.listItems = listItems;
            ViewBag.contract = contract;
            return View();
        }

        public async Task<ActionResult> AddSet(DeliveryActModel model) //Добавление комплекта 
        {
            DeliveryAct set = await db.DeliveryActs.FindAsync(model.SetId);
            DeliveryAct act = await db.DeliveryActs.FindAsync(model.ActId);
            foreach (var item in set.MaterialDeliveries)
            {
                MaterialDelivery delivery = new MaterialDelivery
                {
                    DeliveryActId = act.Id,
                    Other = item.Other,
                    Volume = 0 - (item.Volume * model.Volume),
                    MaterialType = item.MaterialType,
                    Material = item.Material
                };
                act.MaterialDeliveries.Add(delivery);
            }
            await db.SaveChangesAsync();

            return PartialView("_DeliveryTable", new DeliveryModel(act.Id, db));
        }
      
        public IActionResult MaterialMoving(int id) //график движение материалов 
        {
            var lineChart = new List<LineChartModel>();
            Material material = db.Materials.Find(id);
            double firstVolume = material.MaterialDeliveries.FirstOrDefault().Volume;

            lineChart.Add(new LineChartModel() { DimensionOne = material.MaterialDeliveries.FirstOrDefault().DeliveryAct.Date.ToString(), Quantity = firstVolume });

            List<MaterialDelivery> materialDeliveries = material.MaterialDeliveries.ToList();
            for (int i = 1; i < materialDeliveries.Count; i++)
            {
                firstVolume += materialDeliveries[i].Volume;


                lineChart.Add(new LineChartModel
                {
                    DimensionOne = materialDeliveries[i].DeliveryAct.Date.ToString(),
                    Quantity = firstVolume

                });
            }
            ViewBag.materialName = material.MaterialType.Name;
            ViewBag.contract = material.Contract.Name;
            ViewBag.unit = material.MaterialType.Unit.Name;
            return View(lineChart);
        }

        public ActionResult Sets(int id) //наборы 
        {
            Contract contract = db.Contracts.Find(id);

            List<DropDownItem> dropDownDeliveryActItems = new List<DropDownItem>();

            foreach (var item in db.DeliveryActs.Where(p => p.DeliveryType.Description == "комплект" && p.ContractId == id && p.DeliveryState.Description == "в работе"))
            {
                dropDownDeliveryActItems.Add(new DropDownItem { Id = item.Id, Name = "Комплект " + item.SetName });
            }
            SelectList listItems = new SelectList(dropDownDeliveryActItems, "Id", "Name");


            ViewBag.listItems = listItems;
            ViewBag.contract = contract;
            return View();
        }

        public ActionResult Defect (int id) //Брак 
        {
            Contract contract = db.Contracts.FirstOrDefault(c => c.Id == id);

            List<DropDownItem> dropDownDeliveryActItems = new List<DropDownItem>();

            foreach (var item in db.DeliveryActs.Where(p => p.DeliveryType.Description == "брак" && p.ContractId == id && p.DeliveryState.Description == "в работе"))
            {

                dropDownDeliveryActItems.Add(new DropDownItem { Id = item.Id, Name = "Акт выбраковки №" + item.Id + " от " + item.Date.ToShortDateString() + " создал: " + item.User.Name });
            }
            SelectList listItems = new SelectList(dropDownDeliveryActItems, "Id", "Name");

            
            ViewBag.listItems = listItems;
            ViewBag.contract = contract;
            return View();
        }

        public ActionResult DefectList (int id) //список брака по контракту 
        {
            ViewBag.contract = db.Contracts.Find(id);
            List<DeliveryActModel> model = new List<DeliveryActModel>();
            foreach(var item in db.Devices.Where(d => d.ContractId == id && d.CurrentState == "брак"))
            {
                model.Add(new DeliveryActModel
                {
                    DeviceTypeName = item.DeviceType.Name,
                    SerialNumber = item.SerialNumber,
                    Defect = item.DeviceDeliveries.FirstOrDefault(d => d.DeliveryAct.DeliveryType.Description == "брак").Comment
                });
            }
            ViewBag.noPrint = true;
            return View(model);
        }

        public ActionResult DeleteDefect(string serialNumber, int contractId) //Удаление оборудования из брака
        {
            Device device = db.Devices.FirstOrDefault(d => d.SerialNumber == serialNumber);
            DeliveryState state = db.DeliveryStates.FirstOrDefault(s => s.Description == "проведен");
            DeliveryType type = db.DeliveryTypes.FirstOrDefault(t => t.Description == "удаление из брака");
            User user = db.Users.FirstOrDefault(u => u.Login == User.Identity.Name);
            DeliveryAct act = new DeliveryAct
            {
                Date = DateTime.Now,
                DeliveryStateId = state.Id,
                DeliveryTypeId = type.Id,
                UserId = user.Id,
                ContractId = contractId
            };

            if (device != null & state != null && type != null && user != null)
            {
                db.DeliveryActs.Add(act);
                db.SaveChanges();

                db.DeviceDeliveries.Add(new DeviceDelivery
                {
                    Comment = "Удален из брака",
                    DeliveryActId = act.Id,
                    DeviceId = device.Id
                });
                device.CurrentState = "прием на склад";
                db.SaveChanges();
            }

            return Redirect("/Delivery/DefectList/" + contractId);
        }

        public ActionResult ToTune (int id)
        {
            Contract contract = db.Contracts.Find(id);
            ViewBag.contract = contract;

            List<DropDownItem> dropDownDeliveryActItems = new List<DropDownItem>();

            foreach (var item in db.DeliveryActs.Where(p => p.DeliveryType.Description == "выдача на настройку" && p.ContractId == id && p.DeliveryState.Description == "в работе"))
            {

                dropDownDeliveryActItems.Add(new DropDownItem { Id = item.Id, Name = "Акт выдачи на настройку №" + item.Id + " от " + item.Date.ToShortDateString() + " создал: " + item.User.Name });
            }
            SelectList listItems = new SelectList(dropDownDeliveryActItems, "Id", "Name");


            ViewBag.listItems = listItems;

            return View("~/Views/Delivery/DeviceMoving/ToTune.cshtml");
        }

        public ActionResult ToAssembly (int id)
        {
            Contract contract = db.Contracts.Find(id);
            ViewBag.contract = contract;

            List<DropDownItem> dropDownDeliveryActItems = new List<DropDownItem>();

            foreach (var item in db.DeliveryActs.Where(p => p.DeliveryType.Description == "выдача на сборку" && p.ContractId == id && p.DeliveryState.Description == "в работе"))
            {

                dropDownDeliveryActItems.Add(new DropDownItem { Id = item.Id, Name = "Акт выдачи на сборку №" + item.Id + " от " + item.Date.ToShortDateString() + " создал: " + item.User.Name });
            }
            SelectList listItems = new SelectList(dropDownDeliveryActItems, "Id", "Name");


            ViewBag.listItems = listItems;

            return View("~/Views/Delivery/DeviceMoving/ToAssembly.cshtml");
        }

        public ActionResult FromAssembly(int id)
        {
            Contract contract = db.Contracts.Find(id);
            ViewBag.contract = contract;

            List<DropDownItem> dropDownDeliveryActItems = new List<DropDownItem>();
            foreach (var item in db.DeliveryActs.Where(p => p.DeliveryType.Description == "возврат со сборки" && p.ContractId == id && p.DeliveryState.Description == "в работе"))
            {
                dropDownDeliveryActItems.Add(new DropDownItem { Id = item.Id, Name = "Акт возврата со сборки №" + item.Id + " от " + item.Date.ToShortDateString() + " создал: " + item.User.Name });
            }
            SelectList listItems = new SelectList(dropDownDeliveryActItems, "Id", "Name");

            ViewBag.listItems = listItems;
            return View("~/Views/Delivery/DeviceMoving/FromAssembly.cshtml");
        }

        public ActionResult FromTune(int id)
        {
            Contract contract = db.Contracts.Find(id);
            ViewBag.contract = contract;

            List<DropDownItem> dropDownDeliveryActItems = new List<DropDownItem>();
            foreach (var item in db.DeliveryActs.Where(p => p.DeliveryType.Description == "возврат с настройки" && p.ContractId == id && p.DeliveryState.Description == "в работе"))
            {
                dropDownDeliveryActItems.Add(new DropDownItem { Id = item.Id, Name = "Акт возврата с настройки №" + item.Id + " от " + item.Date.ToShortDateString() + " создал: " + item.User.Name });
            }
            SelectList listItems = new SelectList(dropDownDeliveryActItems, "Id", "Name");

            ViewBag.listItems = listItems;
            return View("~/Views/Delivery/DeviceMoving/FromTune.cshtml");
        }

        public ActionResult ReturnToStore(int id)
        {
            Contract contract = db.Contracts.Find(id);
            ViewBag.contract = contract;

            List<DropDownItem> dropDownDeliveryActItems = new List<DropDownItem>();

            foreach (var item in db.DeliveryActs.Where(p => p.DeliveryType.Description == "возврат на склад" && p.ContractId == id && p.DeliveryState.Description == "в работе"))
            {
                dropDownDeliveryActItems.Add(new DropDownItem { Id = item.Id, Name = "Акт возврата на склад №" + item.Id + " от " + item.Date.ToShortDateString() + " создал: " + item.User.Name });
            }
            SelectList listItems = new SelectList(dropDownDeliveryActItems, "Id", "Name");

            ViewBag.listItems = listItems;
            return View();
        }

        public async Task<ActionResult> ReturnToMnfc(int id)
        {
            Contract contract = await db.Contracts.FindAsync(id);
            ViewBag.contract = contract;
            List<DropDownItem> dropDownDeliveryActItems = new List<DropDownItem>();
            foreach (var item in db.DeliveryActs.Where(p => p.DeliveryType.Description == "возврат производителю" && p.ContractId == id && p.DeliveryState.Description == "в работе"))
            {
                dropDownDeliveryActItems.Add(new DropDownItem { Id = item.Id, Name = "Акт возврата производителю №" + item.Id + " от " + item.Date.ToShortDateString() + " создал: " + item.User.Name });
            }
            SelectList listItems = new SelectList(dropDownDeliveryActItems, "Id", "Name");

            ViewBag.listItems = listItems;
            return View();
        }

        [HttpPost]
        public string CheckWorker(int workerid)
        {
            Worker worker = db.Workers.Find(workerid);
            if(worker != null)
            {
                if (!worker.DeliveryAvailible)
                {
                    return "Выдача для " + worker.Surname + " " + worker.Name + " " + worker.MIddlename + " заблокирована!";
                }
                else return string.Empty;
            }
            return "Работник не найден в БД!";
        }

       
        public ActionResult GenerateExcelOutcomeAct(int id)
        {
            return ExcelReportGenerator.GenerateOutcomeAct(id, db, _env, false);
        }

        public ActionResult GenerateExcelPPEAct(int id)
        {
            return ExcelReportGenerator.GeneratePPEAct(id, db, _env);
        }

        public ActionResult GenerateExcelReturnAct(int id)
        {
            return ExcelReportGenerator.GenerateOutcomeAct(id, db, _env, true);
        }

        private List<string> ContractsList()
        {
            var contracts = new List<string>();
            foreach (Contract c in db.Contracts)
            {
                contracts.Add(c.Name);
            }

            return contracts;
        }

    }
}