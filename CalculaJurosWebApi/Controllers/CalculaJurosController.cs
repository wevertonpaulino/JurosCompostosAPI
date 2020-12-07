using CalculaJurosWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CalculaJurosWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly IRetornaTaxaService _retornaTaxaService;

        public CalculaJurosController(IRetornaTaxaService retornaTaxaService)
        {
            _retornaTaxaService = retornaTaxaService;
        }

        [HttpGet]
        public decimal Get(decimal valorInicial, int meses)
        {
            var taxaJuros = _retornaTaxaService.Get();
            var value = valorInicial * (decimal)Math.Pow(1 + (double)taxaJuros, meses);
            var result = Math.Truncate(100 * value) / 100;

            return result;
        }
    }
}
