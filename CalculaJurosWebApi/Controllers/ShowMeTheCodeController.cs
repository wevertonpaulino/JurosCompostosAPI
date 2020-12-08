using Microsoft.AspNetCore.Mvc;

namespace CalculaJurosWebApi.Controllers
{
    [Route("api/ShowMeTheCode")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            var url = "https://github.com/wevertonpaulino/juros-compostos-csharp";

            return url;
        }
    }
}
