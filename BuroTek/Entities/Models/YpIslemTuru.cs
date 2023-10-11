using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpIslemTuru
{
    public int IslemTuruId { get; set; }

    public string IslemTuruAdi { get; set; } = null!;

    public virtual ICollection<FaturaIslemleri> FaturaIslemleris { get; set; } = new List<FaturaIslemleri>();

    public virtual ICollection<KrediKartiIslemleri> KrediKartiIslemleris { get; set; } = new List<KrediKartiIslemleri>();
}
