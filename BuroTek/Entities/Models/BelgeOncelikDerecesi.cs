using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class BelgeOncelikDerecesi
{
    public int BelgeOncelikDerecesiId { get; set; }

    public string BelgeOncelikDerecesiAdi { get; set; } = null!;

    public int KullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public int BuroId { get; set; }

    public virtual ICollection<BelgeKayit> BelgeKayits { get; set; } = new List<BelgeKayit>();
}
