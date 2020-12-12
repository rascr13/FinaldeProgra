using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProgaApli.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaulClarosController : ControllerBase
    {
        [HttpGet]
        public string Numero(int numero)
        {
            if (numero > 0)
                {
                return Content(href = 'https://image.freepik.com/vector-gratis/numeros-cartel-imagen_1639-6453.jpg');

            }
            else if (numero == 0)
            {
                return "Realizado por Raul Claros";
            }
            else return "ERROR";
        }
    }
}
