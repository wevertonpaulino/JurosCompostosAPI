using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetornaTaxaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RetornaTaxaController : ControllerBase
    {
        [HttpGet]
        public decimal Get()
        {
            return 0.01m;
        }
    }
}
