using CalculaJurosWebApi.Abstractions;
using Refit;
using System.Threading.Tasks;

namespace CalculaJurosWebApi.Services
{
    public class RetornaTaxaService : IRetornaTaxaService
    {
        public async Task<decimal> GetAsync()
        {
            var api = RestService.For<IRetornaTaxaApi>("http://localhost:58257/");

            return await api.Get();
        }
    }
}
