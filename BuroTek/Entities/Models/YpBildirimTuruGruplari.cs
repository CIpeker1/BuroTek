using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpBildirimTuruGruplari
{
    public int BildirimTuruGrupId { get; set; }

    public string BildirimTuruGrupAdi { get; set; } = null!;

    public virtual ICollection<YpBildirimTurleri> YpBildirimTurleris { get; set; } = new List<YpBildirimTurleri>();
}
