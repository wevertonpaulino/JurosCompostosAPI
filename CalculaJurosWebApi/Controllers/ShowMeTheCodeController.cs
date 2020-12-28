using Microsoft.AspNetCore.Mvc;

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
            return "https://github.com/wevertonpaulino/juros-compostos-api";
        }
    }
}
