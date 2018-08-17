using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    public class ConverterController : Controller
    {
        // GET api/milhas/1
        [HttpGet("milhas/{kilometro}")]
        public string GetMilha(double kilometro)
        {
            double resultado = kilometro * 0.62137;
            return resultado.ToString();
        }

        // GET api/kilometro/1
        [HttpGet("kilometro/{milha}")]
        public string GetKilometro(double milha)
        {
            //Teste
            double resultado = milha/0.62137;
            return resultado.ToString();
        }
    }
}
