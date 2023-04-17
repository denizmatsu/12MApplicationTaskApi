using API.DTO.STI;
using API.Entity;
using API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class STIController : ControllerBase
    {
        private readonly ISTIRepository _stiRepository;

        public STIController(ISTIRepository stiRepository)
        {
            _stiRepository = stiRepository;
        }

        [HttpPost("GetStockStatement")]
        public IActionResult GetStockStatement(StkFilter filter)
        {
            var result = _stiRepository.StockStatementAsync(filter.MalKodu, filter.GirisTarih, filter.CikisTarih);
            return Ok(result);
        }

        [HttpGet("GetStockName")]
        public async Task<IActionResult> GetStockName()
        {
            var result = await _stiRepository.GetStockNameAsync();
            return Ok(result);
        }
    }
}
