using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class HesapTuru
{
    public int HesapTuruId { get; set; }

    public string HesapTuruAdi { get; set; } = null!;

    public virtual ICollection<CariHesapKodlari> CariHesapKodlaris { get; set; } = new List<CariHesapKodlari>();
}
