using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpBildirimTurleri
{
    public int BildirimTuruId { get; set; }

    public string BildirimTuruAdi { get; set; } = null!;

    public int BildirimTuruGrupId { get; set; }

    public virtual YpBildirimTuruGruplari BildirimTuruGrup { get; set; } = null!;

    public virtual ICollection<YpBildirimler> YpBildirimlers { get; set; } = new List<YpBildirimler>();
}
