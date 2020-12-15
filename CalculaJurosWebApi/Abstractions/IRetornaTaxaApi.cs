using Refit;
using System.Threading.Tasks;

namespace CalculaJurosWebApi.Abstractions
{
    public interface IRetornaTaxaApi
    {
        [Get("/api/RetornaTaxa")]
        Task<decimal> Get();
    }
}
