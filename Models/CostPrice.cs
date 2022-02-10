using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUSA.Models
{
    public class CostPrice
    {
        public string Name { get; set; }
        public string Processor { get; set; }
        public byte RAM { get; set; }
        public int HDD { get; set; }
        public bool Battery { get; set; }
        public bool AC { get; set; }
        public string Comment { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string LotNumber { get; set; }
        public string TrackNumber { get; set; }
        public double BodyPrice { get; set; }
        public double ACPrice { get; set; }
        public double RAMPrice { get; set; }
        public double HDDPrice { get; set; }
        public double BatteryPrice { get; set; }
        public double CaddyPrice { get; set; }
        public double CustomPrice { get; set; }
        public double ShippingPrice { get; set; }
        public double UnlockPrice { get; set; }
        public double BuyPrice { get; set; }
        public double SellPrice { get; set; }
        public double CoursePrice { get; set; }
    }
}
