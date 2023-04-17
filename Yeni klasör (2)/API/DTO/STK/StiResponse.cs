using Microsoft.EntityFrameworkCore;

namespace API.DTO.STI
{
    public class StkResponse
    {
        public int ID { get; set; }
        public string MalKodu { get; set; }
        public string MalAdi { get; set; }

    }
}
