using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial.Services.Products.Core.Controllers
{
    [Route("api/[controller]")]
    public class HealthController : Controller
    {
        public ActionResult Get()
        {
            return Ok();
        }
    }
}
