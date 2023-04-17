using API.DTO.STI;
using API.Entity;

namespace API.Repository
{
    public interface ISTIRepository 
    {
        Task<List<StiResponse>> StockStatementAsync(string MalKodu, DateTime GirisTarih, DateTime CikisTarih);
        Task<List<Stk>> GetStockNameAsync();

    }
}
