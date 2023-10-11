using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class IcraDurum
{
    public int IcraDurumId { get; set; }

    public string IcraDurumAdi { get; set; } = null!;

    public virtual ICollection<Icralar> Icralars { get; set; } = new List<Icralar>();
}
