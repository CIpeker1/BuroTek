using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class VekaletTuru
{
    public int VekaletTuruId { get; set; }

    public string VekaletTuruAdi { get; set; } = null!;

    public virtual ICollection<KisiVekaletler> KisiVekaletlers { get; set; } = new List<KisiVekaletler>();
}
