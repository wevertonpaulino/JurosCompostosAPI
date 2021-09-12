using System.Threading.Tasks;

namespace CalculaJurosWebApi.Services
{
    public interface IRetornaTaxaService
    {
        Task<decimal> GetAsync();
    }
}
