using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Tutorial.Services.Products.Core.Models;

namespace Tutorial.Services.Products.Core.Controllers
{
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        private static Car[] _cars = new Car[]
        {
            new Car()
            {
                Make = "BMW",
                Model = "M3"
            },
            new Car()
            {
                Make = "Nissan",
                Model = "GTR"
            }
        };

        public IEnumerable<Car> Get()
        {
            return _cars;  
        }
    }
}
