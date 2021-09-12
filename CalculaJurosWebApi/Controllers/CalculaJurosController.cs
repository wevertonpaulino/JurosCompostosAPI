using CalculaJurosWebApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

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
        public async Task<decimal> GetAsync(decimal valorInicial, int meses)
        {
            var taxaJuros = await _retornaTaxaService.GetAsync();
            var value = valorInicial * (decimal)Math.Pow(1 + (double)taxaJuros, meses);
            var result = TruncateDecimal(value, 2);

            return result;
        }

        private decimal TruncateDecimal(decimal value, int precision)
        {
            decimal step = (decimal)Math.Pow(10, precision);
            decimal temp = Math.Truncate(step * value);

            return temp / step;
        }
    }
}
