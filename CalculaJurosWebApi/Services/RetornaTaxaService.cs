using System;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;

namespace CalculaJurosWebApi.Services
{
    public class RetornaTaxaService : IRetornaTaxaService
    {
        public async Task<decimal> Get()
        {
            var taxaJuros = 0m;

            using (var httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:58257/") })
            {
                using (var response = await httpClient.GetAsync("api/RetornaTaxa"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var responseString = await response.Content.ReadAsStringAsync();
                        taxaJuros = Decimal.Parse(responseString, NumberStyles.Number, new CultureInfo("en-US"));
                    }
                }
            }

            return taxaJuros;
        }
    }
}
