using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpBildirimDurumlari
{
    public int BildirimDurumId { get; set; }

    public string BildirimDurumAdi { get; set; } = null!;

    public virtual ICollection<YpBildirimler> YpBildirimlers { get; set; } = new List<YpBildirimler>();
}
