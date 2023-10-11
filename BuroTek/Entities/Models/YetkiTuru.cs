using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YetkiTuru
{
    public int YetkiTuruId { get; set; }

    public string YetkiTuruAdi { get; set; } = null!;

    public virtual ICollection<KisiVekaletYetki> KisiVekaletYetkis { get; set; } = new List<KisiVekaletYetki>();
}
