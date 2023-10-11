using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class HarcTipleri
{
    public int HarcTipiId { get; set; }

    public string HarcTipiAdi { get; set; } = null!;

    public virtual ICollection<HarcUcretleri> HarcUcretleris { get; set; } = new List<HarcUcretleri>();
}
