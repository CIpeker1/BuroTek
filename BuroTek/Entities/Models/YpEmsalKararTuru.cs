using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpEmsalKararTuru
{
    public int EmsalKararTuruId { get; set; }

    public string EmsalKararTuruAdi { get; set; } = null!;

    public virtual ICollection<EmsalKarar> EmsalKarars { get; set; } = new List<EmsalKarar>();
}
