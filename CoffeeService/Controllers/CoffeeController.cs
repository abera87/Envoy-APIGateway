using System;
using Microsoft.AspNetCore.Mvc;

namespace TeaService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        private static readonly string[] Teas = new[]{
            "Flat White","Long Black","Latte","Americano","Cappuccino"
        };
        [HttpGet]
        public string Get()
        {
            var rnd = new Random();
            return Teas[rnd.Next(Teas.Length)];
        }
    }
}