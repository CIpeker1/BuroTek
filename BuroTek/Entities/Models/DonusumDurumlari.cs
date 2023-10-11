using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class DonusumDurumlari
{
    public int DonusumDurumId { get; set; }

    public string DonusumDurumAdi { get; set; } = null!;

    public virtual ICollection<FaturaIslemleri> FaturaIslemleris { get; set; } = new List<FaturaIslemleri>();
}
