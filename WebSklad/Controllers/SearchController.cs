using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebSklad.Models;
using DbManager;

namespace WebSklad.Controllers
{
    public class SearchController : Controller
    {

        StoreContext db;

        public SearchController (StoreContext context)
        {
            db = context;
        }

        public ActionResult SearchResults(string query)
        {
            Int32.TryParse(query, out int actId);
            DeliveryAct act = db.DeliveryActs.FirstOrDefault(a => a.Id == actId);
            if(act != null)
            {
                return Redirect("/Delivery/DeliveryAct/" + act.Id);
            }
            else
            {
                Device pu = db.Devices.FirstOrDefault(d => d.SerialNumber == query);
                if (pu != null)
                {
                    return RedirectToAction("Device", "Device", new { deviceId = pu.Id });
                }
            }
            return View();
        }
    }
}