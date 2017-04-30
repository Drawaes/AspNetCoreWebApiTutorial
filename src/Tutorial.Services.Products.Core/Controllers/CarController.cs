using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Tutorial.Services.Products.Core.Models;

namespace Tutorial.Services.Products.Core.Controllers
{
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private static CarModel[] s_cars = new CarModel[]
        {
            new CarModel()
            {
                CarId = "Nissan-GTR",
                Make = "Nissan",
                Model = "GTR"
            },
            new CarModel()
            {
                CarId = "BMW-M3",
                Make = "BMW",
                Model = "M3"
            }
        };

        public IEnumerable<CarModel> Get()
        {
            return s_cars;
        }
    }
}
