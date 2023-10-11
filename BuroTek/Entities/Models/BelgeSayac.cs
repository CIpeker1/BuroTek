using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class BelgeSayac
{
    public int BelgeSayacId { get; set; }

    public string BelgeSayacAdi { get; set; } = null!;

    public int BelgeSayacSiraNo { get; set; }

    public int BelgeTuruId { get; set; }

    public int Yil { get; set; }

    public int BuroId { get; set; }

    public virtual ICollection<BelgeKayit> BelgeKayits { get; set; } = new List<BelgeKayit>();

    public virtual BelgeTuruYeni BelgeTuru { get; set; } = null!;

    public virtual Burolar Buro { get; set; } = null!;
}
