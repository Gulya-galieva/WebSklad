using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSklad.Models
{
    public class WorkerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Middlename { get; set; }
        public string Type { get; set; }
        public int TypeId { get; set; }
        public bool DeliveryAvaliable { get; set; }
        public string ContractNumber { get; set; }
        public DateTime ContractDate { get; set; }
       
    }

    public class MounterReportModel
    {
        public string Serial { get; set; }
        public string DeviceType { get; set; }
        public DateTime Date { get; set; }
        public string RowColorCode { get; set; }
        public int ContractId { get; set; }
    }
}
