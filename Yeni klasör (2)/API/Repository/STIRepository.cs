using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Entity;
using Microsoft.Data.SqlClient;
using System.Xml;
using System.Data;
using API.DTO.STI;

namespace API.Repository
{
    public class STIRepository : ISTIRepository
    {
        private readonly stokContext _dbContext;
        public STIRepository(stokContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<StiResponse>> StockStatementAsync(string MalKodu, DateTime GirisTarih, DateTime CikisTarih)
        {
            var query = _dbContext
                .StiResponses
                .FromSqlRaw<StiResponse>("EXECUTE dbo.GetSTIRecords @MalKodu=@malKodu, @BaslangicTarihi=@girisTarih, @BitisTarihi=@cikisTarih",
                    new SqlParameter("@malKodu", MalKodu),
                    new SqlParameter("@girisTarih", SqlDbType.DateTime2) { Value = GirisTarih },
                    new SqlParameter("@cikisTarih", SqlDbType.DateTime2) { Value = CikisTarih }
                );
            var result = query
                .ToList();

            return result;
        }

        public async Task<List<Stk>> GetStockNameAsync()
        {
            var result = await _dbContext.Stks.ToListAsync();

            return result;
        }




    }
}
