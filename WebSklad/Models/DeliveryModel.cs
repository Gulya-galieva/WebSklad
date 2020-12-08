using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbManager;


namespace WebSklad.Models
{
    public class DeliveryModel
    {
        public List<DeviceDelivery> DeviceDeliveries { get; set; }
        public List<MaterialDelivery> MaterialDeliveries { get; set; }
        public List<PPEDelivery> PPEDeliveries { get;  set; }
      
        
        public DeliveryModel(int actId, StoreContext db)
        {
            DeliveryAct act = db.DeliveryActs.Find(actId);
            if (act != null)
            {
                DeviceDeliveries = act.DeviceDeliveries.ToList();
                MaterialDeliveries = act.MaterialDeliveries.ToList();
                PPEDeliveries = act.PPEDeliveries.ToList(); //OrderByDescending(x => x.Id).ToList();
            }
            else
            {
                DeviceDeliveries = new List<DeviceDelivery>();
                MaterialDeliveries = new List<MaterialDelivery>();
                PPEDeliveries = new List<PPEDelivery>();
            }
        }
    }

    public class DeliveryToAssemble
    {
        public string DeviceType { get; set; }
        public string Serial { get; set; }
        public string SetName { get; set; }
        public int DeliveryId { get; set; }
        public int SetId { get; set; }
        DeliveryAct act { get; set; }
    }

    public class DeliveryActModel
    {
        public int ActId { get; set; }
        public int MaterialTypeId { get; set; }
        public int MaterialId { get; set; }
        public int DeviceId { get; set; }
        public double Volume { get; set; }
        public string Other { get; set; }
        public string SerialNumber { get; set; }
        public int SetId { get; set; }
        public int WorkerId { get; set; }
        public string Defect { get; set; }
        public string DeviceTypeName { get; set; }
        public int PPEId { get; set; }
    }

    public class PPEReportModel
    {
        public string Name { get; set; }
        public int Volume { get; set; }
    }
    
    public class WorkerMaterials
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Volume { get; set; }
    }
 }
