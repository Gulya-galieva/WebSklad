using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebSklad.Models
{
    public class DropDownItem
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }


    public class DeviceRemanings
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }

    public class MaterialRemanings
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Volume { get; set; }
    }

    public class MaterialMoving
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Income { get; set; }
        public double Outcome { get; set; }
    }

    public enum EDeliveryType : int
    {
        Income,
        Outcome,
        Set,
        Defect,
        ToTune,
        ToAssembly,
        FromAssemly,
        FromTune,
        ReturnToStore,
        PPEIncom,
        PPEOutcome
    }

    public class LineChartModel
    {
        public string DimensionOne { get; set; }
        public double Quantity { get; set; }
    }

    public class UpdateInfo
    {
        public string Error { get; set; }
        public int Count { get; set; }
        public int NewItems { get; set; }
        public int UpdatedUnits { get; set; }
        public int UpdatePrice { get; set; }
        public List<UpdateUnits> UpdateUnits { get; set; }
        public List<UpdatePrice> UpdatePrices { get; set; }
        public List<NewMaterials> NewMaterials { get; set; }

        public UpdateInfo()
        {
            UpdateUnits = new List<UpdateUnits>();
            UpdatePrices = new List<UpdatePrice>();
            NewMaterials = new List<NewMaterials>();
        }
    }
    public class UpdateUnits
    {
        public string Name { get; set; }
        public string OldUnit { get; set; }
        public string NewUnit { get; set; }
    }
    public class UpdatePrice
    {
        public string Name { get; set; }
        public double OldPrice { get; set; }
        public double NewPrice { get; set; }
    }
    public class NewMaterials
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Price { get; set; }
    }

    public class StatesList
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }
}