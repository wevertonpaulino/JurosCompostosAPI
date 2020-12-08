using CalculaJurosWebApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CalculaJurosWebApi.Controllers
{
    [Route("api/CalculaJuros")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly IRetornaTaxaService _retornaTaxaService;

        public CalculaJurosController(IRetornaTaxaService retornaTaxaService)
        {
            _retornaTaxaService = retornaTaxaService;
        }

        // GET: api/CalculaJuros?valorInicial=100&meses=5
        [HttpGet]
        public decimal Get(decimal valorInicial, int meses)
        {
            var taxaJuros = _retornaTaxaService.Get().Result;
            var value = valorInicial * (decimal)Math.Pow(1 + (double)taxaJuros, meses);
            var result = TruncateDecimal(value, 2);

            return result;
        }

        [NonAction]
        public decimal TruncateDecimal(decimal value, int precision)
        {
            decimal step = (decimal)Math.Pow(10, precision);
            decimal temp = Math.Truncate(step * value);

            return temp / step;
        }
    }
}
