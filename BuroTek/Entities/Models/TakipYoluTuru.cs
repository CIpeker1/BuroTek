using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class TakipYoluTuru
{
    public int TakipYoluTuruId { get; set; }

    public string TakipYoluTuruAdi { get; set; } = null!;

    public virtual ICollection<Icralar> Icralars { get; set; } = new List<Icralar>();
}
