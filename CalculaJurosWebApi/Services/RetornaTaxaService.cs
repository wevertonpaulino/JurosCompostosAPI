using System;

namespace CalculaJurosWebApi.Services
{
    public class RetornaTaxaService : IRetornaTaxaService
    {
        public decimal Get()
        {
            return 0.01m;
        }
    }
}
