using Microsoft.AspNetCore.Mvc;

namespace RetornaTaxaWebApi.Controllers
{
    [Route("api/RetornaTaxa")]
    [ApiController]
    public class RetornaTaxaController : ControllerBase
    {
        // GET: api/RetornaTaxa
        [HttpGet]
        public decimal Get()
        {
            return 0.01m;
        }
    }
}
