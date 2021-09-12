using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CalculaJurosWebApi.Controllers
{
    [Route("api/ShowMeTheCode")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        // GET: api/ShowMeTheCode
        [HttpGet]
        public string Get()
        {
            return "https://github.com/wevertonpaulino/JurosCompostosAPI";
        }
    }
}
