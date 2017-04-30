using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial.Services.Inventory.Core.Models
{
    public class CarStockModel
    {
        public string CarId { get; set; }
        public int Onsite { get; set; }
        public int Nearby { get; set; }
    }
}
