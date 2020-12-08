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

namespace WebSklad.Controllers
{
    public class DeviceController : Controller
    {
        StoreContext db;
        DeliveryManager deliveryManager;
        public DeviceController(StoreContext context)
        {
            db = context;
            deliveryManager = new DeliveryManager();
        }

        public IActionResult Device(int deviceId)
        {
            Device device = db.Devices.Find(deviceId);
            List<DropDownItem> dropDownDeliveryActItems = new List<DropDownItem>();
            dropDownDeliveryActItems.Add(new DropDownItem { Id = 0, Name = "Отсутствует" });
            foreach (var item in deliveryManager.GetDeliveryActs(device.ContractId, "в работе", "комплект"))
            {
                dropDownDeliveryActItems.Add(new DropDownItem { Id = item.Id, Name = "Комплект " + item.SetName });
            }
            SelectList setItems = new SelectList(dropDownDeliveryActItems, "Id", "Name");

            Link link = db.Links.FirstOrDefault(l => l.DeviceId == deviceId);
            if (link != null)
            {
                ViewBag.PhoneNumber = link.PhoneNumber;
            }
            else ViewBag.PhoneNumber = null;

            if (device.KDEId != null)
            {
                ViewBag.KDE = device.KDE;
            }
            else ViewBag.KDE = null;

            ViewBag.SetId = device.SetId;
            ViewBag.Device = device;
            ViewBag.Contract = device.Contract;
            ViewBag.setItems = setItems;
            ViewBag.States = db.DeviceStates.Where(d => d.DeviceId == device.Id);
            ViewBag.Deliveries = db.DeviceDeliveries.Where(d => d.SerialNumber == device.SerialNumber);
            return View();
        }
        [HttpGet]
        public ActionResult DeviceTypes()
        {
            return View(db.DeviceTypes.ToList());
        }

        [HttpPost]
        public IActionResult AddDeviceType(DeviceType deviceType)
        {
            if (deviceType.Name != null && deviceType.ModelCode != null)
            {
                var tmpDeviceType = db.DeviceTypes.FirstOrDefault(d => d.Name == deviceType.Name);
                if (tmpDeviceType == null)
                {
                    db.DeviceTypes.Add(deviceType);
                    db.SaveChanges();
                }
                else ViewBag.error = "Этот вид оборудования уже есть в БД!";
            }
            return PartialView("_DeviceTypesTable", db.DeviceTypes.ToList());
        }

        [HttpPost]
        public IActionResult DeleteDeviceType(DeviceType deviceType)
        {
            var c = db.DeviceTypes.Find(deviceType.Id);
            if (c != null)
            {
                db.DeviceTypes.Remove(c);
                db.SaveChanges();
            }
            return PartialView("_DeviceTypesTable", db.DeviceTypes.ToList());
        }

        public IActionResult DeviceTypeEdit(int Id)
        {
            DeviceType type = db.DeviceTypes.Find(Id);
            return View(type);
        }

        [HttpPost]
        public IActionResult DeviceTypeEdit(DeviceType model)
        {
            string error = string.Empty;
            DeviceType device = db.DeviceTypes.Find(model.Id);
            if (device != null)
            {
                if (model.Name != device.Name)
                {
                    if (db.DeviceTypes.FirstOrDefault(m => m.Name == model.Name) != null) error = "Оборудование с таким наименованием уже существует в БД!";
                    else device.Name = model.Name;
                }

                if (model.ModelCode != device.ModelCode)
                {
                    if (db.DeviceTypes.FirstOrDefault(m => m.ModelCode == model.ModelCode) != null) error = "Оборудование с таким кодом уже существует в БД!";
                    else device.ModelCode = model.ModelCode;
                }

                if (error == string.Empty)
                {
                    device.AccuracyClass = model.AccuracyClass;
                    device.Description = model.Description;
                    device.EnergyType = model.EnergyType;
                    device.INom = model.INom;
                    //device.ModelCode = model.ModelCode;
                    device.Price = model.Price;
                    device.TestInterval = model.TestInterval;
                    device.Type = model.Type;
                    device.UNom = model.UNom;
                    db.SaveChanges();
                    return RedirectToAction("DeviceTypes", "Device");
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

        [HttpPost]
        public string ChangeSetId(int setId, int deviceId)
        {
            Device device = db.Devices.Find(deviceId);
            if (device == null) return "Оборудование не найдено в БД!";
            if (device.CurrentState == "возврат производителю") return "Оборудование было возвращено производителю!";
            else
            {
                if (setId != 0)
                {
                    DeliveryAct set = db.DeliveryActs.Find(setId);
                    if (set == null) return "комплект не найден!";
                }

                device.SetId = setId;
                db.SaveChanges();
                return "Привязка комплекта сохранена!";
            }
        }

        [HttpPost]
        public string ChangePhoneNumber(string phoneNumber, int deviceId)
        {
            Device device = db.Devices.Find(deviceId);
            if (device == null) return "Оборудование не найдено в БД!";
            if (device.CurrentState == "возврат производителю") return "Оборудование было возвращено производителю!";
            else
            {
                DeviceType type = device.DeviceType;
                string linkType = "";
                switch (type.Type)
                {
                    case "УСПД":
                        linkType = "Внешний GSM модем";
                        break;
                    case "ПУ":
                        if (type.Description.Contains("GSM"))
                        {
                            linkType = "Встроенный GSM-модуль";
                            break;
                        }
                        if (type.ModelCode == "008984")
                        {
                            linkType = "Внешний GSM модем";
                            break;
                        }
                        return "Недопустимый тип ПУ";
                    default:
                        return "Недопустимый тип ПУ";

                }

                Link link = db.Links.FirstOrDefault(l => l.DeviceId == device.Id);
                if (link == null)
                {
                    db.Links.Add(new Link { PhoneNumber = phoneNumber, DeviceId = device.Id, LinkType = linkType });
                    db.SaveChanges();
                }
                else
                {
                    db.Links.Remove(link);
                    db.Links.Add(new Link { PhoneNumber = phoneNumber, DeviceId = device.Id, LinkType = linkType });
                    db.SaveChanges();
                }
                return "Номер сохранен!";
            }
        }
    }
}
