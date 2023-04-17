using Microsoft.EntityFrameworkCore;

namespace API.DTO.STI
{
    [Keyless]
    public class StiResponse
    {
        public int SiraNo { get; set; }
        public string IslemTur { get; set; }
        public string EvrakNo { get; set; }
        public string Tarih { get; set; }
        public int GirisMiktar { get; set; }
        public int CikisMiktar { get; set; }
        public int StokMiktar { get; set; }
    }
}
