using System;
using Microsoft.AspNetCore.Mvc;

namespace TeaService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeaController : ControllerBase
    {
        private static readonly string[] Teas = new[]{
            "Grean","Peppermint","Earl Grey","English Breakfast","Camomile"
        };
        [HttpGet]
        public string Get()
        {
            var rnd = new Random();
            return Teas[rnd.Next(Teas.Length)];
        }
    }
}