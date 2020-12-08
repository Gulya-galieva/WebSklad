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
using Microsoft.AspNetCore.Mvc.Rendering;
using DbManager;
using WebSklad.App_code;
using Microsoft.AspNetCore.Hosting;

namespace WebSklad.Controllers
{
    public class HomeController : Controller
    {
        StoreContext db;// = new StoreContext()
        IHostingEnvironment _env;
        public int contractsId;
        public HomeController(StoreContext context, IHostingEnvironment env)
        {
            db = context;
            _env = env;
        }
        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            ViewBag.contracts = db.Contracts.ToList() ;
            return View();
        }

        [HttpGet]
        [Authorize]
        public IActionResult Contracts()
        {
            return View(db.Contracts.ToList());
        }

        [HttpPost]
        [Authorize(Roles ="administrator")]
        public ActionResult AddContract(Contract contract)
        {
            if (contract.Name != null && contract.Description != null)
            {
                Contract c = db.Contracts.FirstOrDefault(f => f.Name == contract.Name);
                if (c == null)
                {
                    db.Contracts.Add(contract);
                    db.SaveChanges();
                   
                }
                else
                {
                    ViewData["error"] = "Контракт с таким именем уже есть в БД";
                    
                }
            }
            return PartialView("_ContractsTable", db.Contracts.ToList());

        }

        [HttpPost]
        [Authorize(Roles = "administrator")]
        public ActionResult DeleteContract (Contract contract)
        {
            try
            {
                var c = db.Contracts.Find(contract.Id);
                if (c != null)
                {
                    db.Contracts.Remove(c);
                    db.SaveChanges();
                }
            }
            catch
            { }
            finally
            {
                ViewData["error"] = "Невозможно удалить контракт";
            }
            return PartialView("_ContractsTable", db.Contracts.ToList());
        }

        [HttpGet]
        [Authorize]
        public ActionResult Workers()
        {
            List<string> workerTypes = new List<string>();
            foreach (WorkerType type in db.WorkerTypes)
            {
                workerTypes.Add(type.Description);
            }
            ViewBag.WorkerTypes = workerTypes;
            List<WorkerModel> workers = PrepareWorkersModel();
            return View(workers);
        }

        [HttpPost]
        [Authorize]
        public ActionResult AddWorker(WorkerModel worker)
        {
            if (worker.Name != null && worker.Surname != null)
            {
                Worker tmpWorker = db.Workers.FirstOrDefault(w => w.Name == worker.Name && w.Surname == worker.Surname);
                if (tmpWorker == null)
                {
                    Worker newWworker = new Worker { Name = worker.Name, Surname = worker.Surname, MIddlename = worker.Middlename, DeliveryAvailible = true };
                    WorkerType type = db.WorkerTypes.FirstOrDefault(t => t.Description == worker.Type);
                    type.Workers.Add(newWworker);
                    db.SaveChanges();
                    EmploymentContract employmentContract = new EmploymentContract() { Date = worker.ContractDate, Number = worker.ContractNumber, WorkerId = newWworker.Id };
                    db.EmploymentContracts.Add(employmentContract);
                    db.SaveChanges();
                }
                else ViewData["error"] = "Этот работник уже есть в БД";
            }
            return PartialView("_WorkersTable", PrepareWorkersModel());
        }

        [HttpPost]
        [Authorize]
        public ActionResult DeleteWorker (WorkerModel worker)
        {
            Worker tmpWorker = db.Workers.FirstOrDefault(w => w.Id == worker.Id);
            db.Workers.Remove(tmpWorker);
            db.SaveChanges();
            return PartialView("_WorkersTable", PrepareWorkersModel());
        }

        public ActionResult ContractMenu(int id)
        {
            Contract contract = db.Contracts.Find(id);
            ViewBag.contract = contract;
            return View();
        }

        public ActionResult ContractDeviceMoving(int id)
        {
            Contract contract = db.Contracts.Find(id);
            ViewBag.contract = contract;

            List<DropDownItem> dropDownWorkerItems = new List<DropDownItem>();

            foreach (var item in db.Workers.Where(w => w.WorkerType.Description == "сборщик" || w.WorkerType.Description == "настройщик"))
            {
                dropDownWorkerItems.Add(new DropDownItem { Name = item.Surname + " " + item.Name + " " + item.MIddlename + " [" + item.WorkerType.Description + "]", Id = item.Id });
            }
            SelectList workerList = new SelectList(dropDownWorkerItems, "Id", "Name");

            ViewBag.workers = workerList;

            return View();
        }

        public ActionResult MakeWorkerReport(int contractId, int workerId)
        {
            int inWork = 0;
            int totalCount = 0;

            Contract contract = db.Contracts.Find(contractId);
            Worker worker = db.Workers.Find(workerId);
            WorkerType workerType = db.WorkerTypes.Find(worker.WorkerTypeId);
            
            List<DeviceDelivery> deliveries = new List<DeviceDelivery>();

            int n = worker.DeliveryActs.Count();
            
            if (workerType.Description == "сборщик")
            {
                
                foreach (var item in worker.DeliveryActs)
                {
                    foreach (var deviceDelivery in item.DeviceDeliveries)
                    {
                        Device device = deviceDelivery.Device;
                        if (device != null && device.ContractId == contract.Id)
                        {
                            if (device.CurrentState == "выдача на сборку")
                            {
                                deliveries.Add(deviceDelivery);
                                inWork++;
                            }
                            totalCount++;
                        }
                    }
                }
            }

            if (workerType.Description == "настройщик")
            {

                foreach (var item in worker.DeliveryActs)
                {
                    foreach (var deviceDelivery in item.DeviceDeliveries)
                    {
                        Device device = deviceDelivery.Device;
                        Contract contracts = contract; //Гуля
                        if (device != null && device.ContractId == contract.Id)
                        {
                            if (device.CurrentState == "выдача на настройку")
                            {
                                deliveries.Add(deviceDelivery);
                                inWork++;
                            }
                            totalCount++;
                        }
                    }
                }
            }
            ViewBag.returned = totalCount - inWork;
            ViewBag.inWork = inWork;
            ViewBag.totalCount = totalCount;
            return PartialView("_WorkerReportTable", deliveries);//, new DeliveryModel(act.Id, db));
        }

        public ActionResult MounterReport (int id)
        {
            Contract contract = db.Contracts.Find(id);
            ViewBag.contract = contract;
            ViewBag.reportType = "mounter";
            List<DropDownItem> dropDownItems = new List<DropDownItem>();
            foreach (var item in db.Workers.Where(w => w.WorkerType.Description == "монтажник"))
            {
                dropDownItems.Add(new DropDownItem { Name = item.Surname + " " + item.Name + " " + item.MIddlename + " [" + item.WorkerType.Description + "]", Id = item.Id });
            }
            SelectList workerList = new SelectList(dropDownItems, "Id", "Name");
            ViewBag.workers = workerList;
            ViewBag.contratct = contract;
            return View();
        }

        public ActionResult MakeMounterReport (int contractId, int workerId)
        {
            ViewBag.reportType = "mounter";
            int inWork = 0;
            int totalCount = 0;
            int mounted = 0;
            int returned = 0;

            List<MounterReportModel> deliveries = new List<MounterReportModel>();

            Worker worker = db.Workers.Find(workerId);
            Contract contract = db.Contracts.Find(contractId); //Гуля
            contractsId = contract.Id;
            if (worker != null)
            {
                WorkerType workerType = db.WorkerTypes.Find(worker.WorkerTypeId);
                int n = worker.DeliveryActs.Count();
                if (!worker.DeliveryAvailible)
                    ViewData["error"] = "Выдача заблокирована!";


                WorkerManager workerManager = new WorkerManager(db);
                List<Device> devices = workerManager.GetWorkerDevices(worker) ;
                List<DeviceDelivery> mounterDeliveries = workerManager.GetDeviceDeliveries(worker);
                foreach (var deviceDelivery in mounterDeliveries)
                {
                    Device device = deviceDelivery.Device;
                    if (device != null && device.DeviceType.Type == "ПУ" && device.ContractId == contract.Id)
                    {
                        string RowColorCode = "";
                        TimeSpan span = DateTime.Now - deviceDelivery.DeliveryAct.Date;
                        if (span.Days > 12 && device.CurrentState == "выдача со склада" || device.CurrentState == "включен в отчет")
                        {
                            RowColorCode = "#fdc8c8";
                        }
                        else
                        {
                            RowColorCode = "#FFFFFF";
                        }
                        if (device.CurrentState == "выдача со склада" || device.CurrentState == "включен в отчет")
                        {
                            deliveries.Add(new MounterReportModel
                            {
                                Serial = deviceDelivery.SerialNumber,
                                DeviceType = deviceDelivery.DeviceType.Name,
                                Date = deviceDelivery.DeliveryAct.Date,
                                RowColorCode = RowColorCode
                            });
                            inWork++;
                        }
                        if (device.CurrentState == "привязан к ту" && device.ContractId == contract.Id)
                        {
                            mounted++;
                        }
                        if (device.CurrentState == "возврат на склад" && device.ContractId == contract.Id)
                        {
                            returned++;
                        }

                        totalCount++;
                    }
                }
                returned = 0;
                inWork = 0;
                mounted = 0;
                //totalCount = 0;
                foreach (var item in devices)
                {
                    if ((item.CurrentState == "выдача со склада" || item.CurrentState == "включен в отчет") && item.ContractId == contract.Id) inWork++;
                    if (item.CurrentState == "возврат на склад" && item.ContractId == contract.Id) returned++;
                    if (item.CurrentState == "привязан к ту" && item.ContractId == contract.Id) mounted++;

                }

                //Материалы
                List<WorkerMaterials> workerMaterials = new List<WorkerMaterials>();
                bool materialFound = false;
                foreach (var item in workerManager.GetWorkerDeliveryActs(worker))
                {
                    foreach (var delivery in item.MaterialDeliveries)
                    {
                        foreach (var workerMaterial in workerMaterials)
                        {
                            if (delivery.MaterialType.Name == workerMaterial.Name && delivery.DeliveryAct.ContractId == contract.Id)
                            {
                                materialFound = true;
                                if (item.DeliveryType.Description == "выдача со склада")
                                    workerMaterial.Volume += Math.Abs(delivery.Volume);
                                if (item.DeliveryType.Description == "возврат на склад")
                                    workerMaterial.Volume -= Math.Abs(delivery.Volume);
                            }
                        }
                        if (!materialFound && delivery.DeliveryAct.ContractId == contract.Id)
                        {
                            WorkerMaterials tmp = new WorkerMaterials { Name = delivery.MaterialType.Name, Unit = delivery.MaterialType.Unit.Name };
                            if (item.DeliveryType.Description == "выдача со склада")
                                tmp.Volume += Math.Abs(delivery.Volume);
                            if (item.DeliveryType.Description == "возврат на склад")
                                tmp.Volume -= Math.Abs(delivery.Volume);
                            workerMaterials.Add(tmp);
                            materialFound = false;
                        }
                        materialFound = false;
                    }
                }

                //totalCount = devices.Count();
                ViewBag.returned = workerManager.GetReturnsCount(worker);
                ViewBag.inWork = inWork;
                ViewBag.mounted = mounted;
                ViewBag.totalCount = totalCount;
                ViewBag.materials = workerMaterials;
                ViewBag.contratct = contract;


                return PartialView("_MounterReportTable", deliveries);//, new DeliveryModel(act.Id, db));
            }
            else
            {
                ViewData["error"] = "Работник не найден";
                return View("~/Views/Shared/_ErrorPage.cshtml");
            }

        }

        public ActionResult WorkerMenu(int id)
        {
            Worker worker = db.Workers.Find(id);
            WorkerModel model = null;
            if (worker != null)
            {
                EmploymentContract employmentContract = null;
                if (db.EmploymentContracts.Where(c => c.WorkerId == worker.Id).Count() > 0)
                {
                    employmentContract = db.EmploymentContracts.Where(c => c.WorkerId == worker.Id).Last();
                }
                
               model = new WorkerModel { Name = worker.Name, Surname = worker.Surname, Middlename = worker.MIddlename, DeliveryAvaliable = worker.DeliveryAvailible, Type = worker.WorkerType.Description, Id = worker.Id };

                if (employmentContract != null)
                {
                    model.ContractDate = employmentContract.Date;
                    model.ContractNumber = employmentContract.Number;
                }

            }

            List<DropDownItem> dropDownDeliveryActItems = new List<DropDownItem>();
            foreach (var item in db.WorkerTypes)
            {
                dropDownDeliveryActItems.Add(new DropDownItem { Id = item.Id, Name = item.Description });
            }
            SelectList listItems = new SelectList(dropDownDeliveryActItems, "Id", "Name");
            ViewBag.WorkerTypes = listItems;
            ViewBag.TypeId = worker.WorkerTypeId;
                       
            return View(model);
        }

        public IActionResult EditWorker(WorkerModel model)
        {
            Worker worker = db.Workers.Find(model.Id);
            if (worker != null)
            {
                EmploymentContract employmentContract = db.EmploymentContracts.Where(c => c.WorkerId == worker.Id).Last();
                if (model.Middlename != worker.MIddlename || model.Name != worker.Name || model.Surname != worker.Surname) // Если менялось имя работника
                {
                    Worker NewWorker = db.Workers.FirstOrDefault(w => w.MIddlename == model.Middlename && w.Name == model.Name && w.Surname == model.Surname);
                    if (NewWorker == null)
                    {
                        worker.MIddlename = model.Middlename;
                        worker.Name = model.Name;
                        worker.Surname = model.Surname;
                        db.SaveChanges();
                    }
                    else
                    {
                        ViewData["error"] = "Работник с такими ФИО уже существует в БД!";
                        return View("~/Views/Shared/_ErrorPage.cshtml");
                    }
                }


                if (model.ContractNumber != employmentContract.Number || model.ContractDate.ToShortDateString() != employmentContract.Date.ToShortDateString()) //Если менялся трудовой договор
                {
                    EmploymentContract newEmploymentContract = new EmploymentContract() { Date = model.ContractDate, Number = model.ContractNumber, WorkerId = worker.Id };
                    db.EmploymentContracts.Add(newEmploymentContract);
                    db.SaveChanges();
                }
                    worker.DeliveryAvailible = model.DeliveryAvaliable;
                worker.WorkerTypeId = model.TypeId;
                db.SaveChanges();
                return RedirectToAction("Workers","Home");
            }
            else
            {
                ViewData["error"] = "Работник не найден в БД!";
                return View("~/Views/Shared/_ErrorPage.cshtml");
            }


            
        }

        public ActionResult GenerateStickers()
        {
            return ExcelReportGenerator.GenerateStickers(db.Workers.ToList(), db, _env);
        }

        public ActionResult AddKDE(string KDEType)
        {
            KDEType type = db.KDETypes.FirstOrDefault(k => k.Name == KDEType);
            if (type != null)
            {
                KDE kde = new KDE { KDETypeId = type.Id };
                db.KDEs.Add(kde);
                db.SaveChanges();
                //return PartialView("~/Views/Shared/_KDE.cshtml", kde);
                //return RedirectToAction("OpenKDE", "HOME", new { kde.Id });
                return Redirect("~/Home/OpenKDE/" + kde.Id);

            }
            else
            {
                ViewData["error"] = "Тип КДЕ не найден в БД!";
                return View("~/Views/Shared/_ErrorPage.cshtml");

            }

        }

        public IActionResult KDE()
        {
            return View();
        }

       
        public IActionResult OpenKDE (int id)
        {
            ViewBag.KDE = db.KDEs.Find(id);
            return View("~/Views/Home/KDE.cshtml");
        }

        [HttpPost]
        public IActionResult AddPUToKDE(string serial, int kdeId)
        {
            Device device = db.Devices.FirstOrDefault(d => d.SerialNumber == serial);
            if (device != null)
            {
                KDE kde = db.KDEs.Find(kdeId);
               
                if (kde != null)
                {
                    if(kde.KDEType.Name == "КДЕ-3-1")
                    {
                        if (kde.Devices.Count >= 1)
                        {
                            ViewData["error"] = "В КДЕ максимальное количество ПУ!";
                            return View("~/Views/Shared/_ErrorPage.cshtml");
                        }

                    }

                    if (kde.KDEType.Name == "КДЕ-3-2")
                    {
                        if (kde.Devices.Count >= 2)
                        {
                            ViewData["error"] = "В КДЕ максимальное количество ПУ!";
                            return View("~/Views/Shared/_ErrorPage.cshtml");
                        }

                    }
                    User user = db.Users.FirstOrDefault(u => u.Login == User.Identity.Name);
                    ViewBag.KDE = kde;
                    device.KDEId = kde.Id;
                    DeviceStateType type = db.DeviceStateTypes.FirstOrDefault(t => t.Description == "привязан к КДЕ");
                    db.DeviceStates.Add(new DeviceState { DeviceId = device.Id, UserId = user.Id, DeviceStateTypeId = type.Id, Date = DateTime.Now});
                    db.SaveChanges();
                    return PartialView("~/Views/Shared/_KDE.cshtml", kde);
                }
                else
                {
                    ViewData["error"] = "КДЕ не найден в БД!";
                    return View("~/Views/Shared/_ErrorPage.cshtml");
                }
                
            }
            else
            {
                ViewData["error"] = "ПУ не найден в БД!";
                return View("~/Views/Shared/_ErrorPage.cshtml");
            }
        }

        [HttpPost]
        public IActionResult DeletePUFromKDE (string serial, int kdeId)
        {
            Device device = db.Devices.FirstOrDefault(d => d.SerialNumber == serial);
            if (device != null)
            {
                KDE kde = db.KDEs.Find(kdeId);

                if (kde != null)
                {
                   if(device.KDEId != kdeId)
                    {
                        ViewData["error"] = "ПУ не привязан к этому КДЕ!";
                        return View("~/Views/Shared/_ErrorPage.cshtml");
                    }
                    User user = db.Users.FirstOrDefault(u => u.Login == User.Identity.Name);
                    device.KDEId = null;
                    DeviceStateType type = db.DeviceStateTypes.FirstOrDefault(t => t.Description == "удален из КДЕ");
                    db.DeviceStates.Add(new DeviceState { DeviceId = device.Id, UserId = user.Id, DeviceStateTypeId = type.Id, Date = DateTime.Now });
                    db.SaveChanges();
                    return PartialView("~/Views/Shared/_KDE.cshtml", kde);
                }
                else
                {
                    ViewData["error"] = "КДЕ не найден в БД!";
                    return View("~/Views/Shared/_ErrorPage.cshtml");
                }

            }
            else
            {
                ViewData["error"] = "ПУ не найден в БД!";
                return View("~/Views/Shared/_ErrorPage.cshtml");
            }
        }
    
        private List<WorkerModel> PrepareWorkersModel()
        {
            List<WorkerModel> workersModel = new List<WorkerModel>();
            foreach (var type in db.WorkerTypes)
            {
                //db.Entry(type).Collection("Workers").Load();
                foreach (var worker in type.Workers)
                {
                    workersModel.Add(new WorkerModel() { Id = worker.Id, Name = worker.Name, Surname = worker.Surname, Middlename = worker.MIddlename, Type = type.Description });
                }
            }
            return workersModel;
        }


    }
}
