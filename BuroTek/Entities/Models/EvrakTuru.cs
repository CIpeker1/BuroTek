using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class EvrakTuru
{
    public int EvrakTuruId { get; set; }

    public string EvrakTuruAdi { get; set; } = null!;

    public virtual ICollection<Evrak> Evraks { get; set; } = new List<Evrak>();
}
