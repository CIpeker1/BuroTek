using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class IcraTakipTuru
{
    public int IcraTakipTuruId { get; set; }

    public string IcraTakipTuruAdi { get; set; } = null!;

    public bool Ilamli { get; set; }

    public virtual ICollection<Icralar> Icralars { get; set; } = new List<Icralar>();
}
