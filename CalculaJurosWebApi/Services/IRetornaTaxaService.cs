using System.Threading.Tasks;

namespace CalculaJurosWebApi.Services
{
    public interface IRetornaTaxaService
    {
        public Task<decimal> Get();
    }
}
