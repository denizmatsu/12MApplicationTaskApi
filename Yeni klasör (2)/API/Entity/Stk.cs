using System;
using System.Collections.Generic;

namespace API.Entity
{
    public partial class Stk
    {
        public int ID { get; set; }
        public string MalKodu { get; set; } = null!;
        public string MalAdi { get; set; } = null!;
    }
}
