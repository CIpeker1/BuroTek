using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class BelgeTuruYeni
{
    public int BelgeTuruId { get; set; }

    public string BelgeTuruAdi { get; set; } = null!;

    public virtual ICollection<BelgeKayit> BelgeKayits { get; set; } = new List<BelgeKayit>();

    public virtual ICollection<BelgeSayac> BelgeSayacs { get; set; } = new List<BelgeSayac>();
}
