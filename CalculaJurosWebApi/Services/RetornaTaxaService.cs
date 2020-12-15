using CalculaJurosWebApi.Abstractions;
using Refit;
using System.Threading.Tasks;

namespace CalculaJurosWebApi.Services
{
    public class RetornaTaxaService : IRetornaTaxaService
    {
        public async Task<decimal> Get()
        {
            var api = RestService.For<IRetornaTaxaApi>("http://retornataxawebapi:80");

            return await api.Get();
        }
    }
}
