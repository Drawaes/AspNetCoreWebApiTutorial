using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Tutorial.Services.Inventory.Core.Models;

namespace Tutorial.Services.Inventory.Core.Controllers
{
    [Route("api/[controller]")]
    public class CarStockController
    {
        private static CarStockModel[] s_stock = new CarStockModel[]
        {
            new CarStockModel()
            {
                CarId = "Nissan-GTR",
                Nearby = 10,
                Onsite = 1
            },
            new CarStockModel()
            {
                CarId = "BMW-M3",
                Nearby = 5,
                Onsite = 4
            },
        };

        [HttpGet]
        public IEnumerable<CarStockModel> Get()
        {
            return s_stock;
        }
    }
}
