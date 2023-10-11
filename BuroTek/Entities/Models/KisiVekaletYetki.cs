using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class KisiVekaletYetki
{
    public int KisiVekaletYetkiId { get; set; }

    public int KisiVekaletId { get; set; }

    public int YetkiTuruId { get; set; }

    public virtual KisiVekaletler KisiVekalet { get; set; } = null!;

    public virtual YetkiTuru YetkiTuru { get; set; } = null!;
}
