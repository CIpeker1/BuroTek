using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class BelgeErisimHakki
{
    public int BelgeErisimHakkiId { get; set; }

    public string BelgeErisimHakkiAdi { get; set; } = null!;

    public virtual ICollection<BelgeKayit> BelgeKayits { get; set; } = new List<BelgeKayit>();
}
