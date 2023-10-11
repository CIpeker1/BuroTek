using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class TalepTuru
{
    public int TalepTurId { get; set; }

    public string TalepTurAdi { get; set; } = null!;

    public virtual ICollection<Talep> Taleps { get; set; } = new List<Talep>();
}
