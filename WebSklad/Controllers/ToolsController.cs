using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbManager;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebSklad.Models;

namespace WebSklad.Controllers
{
    public class ToolsController : Controller
    {
        StoreContext db;
        MaterialManager materialManager;
        public ToolsController(StoreContext context)
        {
            db = context;
            materialManager = new MaterialManager();
        }

        public ActionResult PPE()
        {
            List<DropDownItem> dropDownWorkerItems = new List<DropDownItem>();

            foreach (var item in db.Workers.Where(w => w.WorkerType.Description == "монтажник" || w.WorkerType.Description == "пнр"))
            {
                dropDownWorkerItems.Add(new DropDownItem { Name = item.Surname + " " + item.Name + " " + item.MIddlename, Id = item.Id });
            }
            SelectList workerList = new SelectList(dropDownWorkerItems, "Id", "Name");

            ViewBag.workers = workerList;
            ViewBag.Model = db.PPEs.ToList();

            return View();

        }

        public ActionResult PPETypes()
        {
          

            return View(db.PPEs.ToList());
        }

        public ActionResult AddPPEType (string Name)
        {
            db.PPEs.Add(new PPE { Name = Name, Volume = 0 });
            db.SaveChanges();
            return PartialView("_PPETypesTable", db.PPEs.ToList()); 
        }

        public ActionResult DeletePPEType (int id)
        {
            PPE ppe = db.PPEs.Find(id);
            if (ppe != null)
            {
                db.PPEs.Remove(ppe);
                db.SaveChanges();
            }
            else
                ViewData["error"] = "Невозможно удалить!";
            return PartialView("_PPETypesTable", db.PPEs.ToList());
        }

        public ActionResult PPEIncome ()
        {
            List<DropDownItem> dropDownDeliveryActItems = new List<DropDownItem>();
            foreach (var item in db.DeliveryActs.Where(p => p.DeliveryType.Description == "прием инструмента и сиз" && p.DeliveryState.Description == "в работе"))
            {
                dropDownDeliveryActItems.Add(new DropDownItem { Id = item.Id, Name = "Акт приема инструментов и СИЗ №" + item.Id + " от " + item.Date.ToShortDateString() + " создал: " + item.User.Name });
            }
            SelectList listItems = new SelectList(dropDownDeliveryActItems, "Id", "Name");
            
            ViewBag.listItems = listItems;

            return View();
        }

        public ActionResult PPEOutcome()
        {
            List<DropDownItem> dropDownDeliveryActItems = new List<DropDownItem>();
            foreach (var item in db.DeliveryActs.Where(p => p.DeliveryType.Description == "выдача инструмента и сиз" && p.DeliveryState.Description == "в работе"))
            {
                dropDownDeliveryActItems.Add(new DropDownItem { Id = item.Id, Name = "Акт выдачи инструментов и СИЗ №" + item.Id + " от " + item.Date.ToShortDateString() + " создал: " + item.User.Name });
            }
            SelectList listItems = new SelectList(dropDownDeliveryActItems, "Id", "Name");

            ViewBag.listItems = listItems;

            return View();
        }

        public ActionResult AddPPE(DeliveryActModel model)
        {
            DeliveryAct act = db.DeliveryActs.Find(model.ActId);
            PPE ppe = db.PPEs.Find(model.PPEId);
            int volume = 0;
            if (ppe != null)
            {
                if (act.DeliveryType.Description == "прием инструмента и сиз")
                {
                    volume = Convert.ToInt32(model.Volume);
                }
                if (act.DeliveryType.Description == "выдача инструмента и сиз")
                {
                    volume = 0 - Convert.ToInt32(model.Volume);
                }
                
                foreach (var item in act.PPEDeliveries)
                {
                    if (item.PPEId == model.PPEId)
                    {
                        item.Volume += volume;
                        db.SaveChanges();
                        return PartialView("_DeliveryTablePPE", new DeliveryModel(act.Id, db));
                    }
                }

                db.PPEDeliveries.Add(new PPEDelivery { DeliveryActId = model.ActId, PPEId = ppe.Id, Volume = volume, PPE = ppe });
                db.SaveChanges();
            }
            return PartialView("_DeliveryTablePPE", new DeliveryModel(act.Id, db));
        }

        public ActionResult DeletePPE (int DeliveryId, int ActId)
        {
            PPEDelivery delivery = db.PPEDeliveries.Find(DeliveryId);
            if (delivery != null)
            {
                db.PPEDeliveries.Remove(delivery);
                db.SaveChanges();
            }
            else ViewData["error"] = "невозможно удалить!";

            return PartialView("_DeliveryTablePPE", new DeliveryModel(ActId, db));
        }

        public ActionResult MakeWorkerReport (int workerId)
        {
            Worker worker = db.Workers.Find(workerId);
            List<DeliveryAct> acts = db.DeliveryActs.Where(a => a.DeliveryType.Description.Contains("инструмент") && a.WorkerId == worker.Id).ToList();
            List<PPEReportModel> model = new List<PPEReportModel>();
            List<PPEDelivery> deliveries = new List<PPEDelivery>();
            bool found = false;

            if (worker != null)
            {
                foreach (var item in acts)
                {
                    foreach (var PPEDeliveryact in item.PPEDeliveries)
                    {
                        deliveries.Add(PPEDeliveryact);
                    }
                }

                model.Add(new PPEReportModel { Name = db.PPEs.Find(deliveries[0].PPEId).Name, Volume = deliveries[0].Volume });
                deliveries.RemoveAt(0);

                foreach (var delivery in deliveries)
                {

                    PPE ppe = db.PPEs.Find(delivery.PPEId);
                    if (ppe != null)
                    {
                        foreach (var item in model)
                        {
                            if (item.Name == ppe.Name)
                            {
                                item.Volume += delivery.Volume;
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            model.Add(new PPEReportModel { Name = ppe.Name, Volume = delivery.Volume });
                        }
                        found = false;
                    }
                }
                ViewBag.worker = worker.Surname + " " + worker.Name + " " + worker.MIddlename;
            }
            else
                ViewData["error"] = "Работник не найднен в БД!";
            return PartialView("_WorkerReportPPE", model);
        }
    }
}