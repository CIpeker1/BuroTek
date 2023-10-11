using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class TalepDurum
{
    public int TalepDurumId { get; set; }

    public string TalepDurumAdi { get; set; } = null!;

    public virtual ICollection<Talep> Taleps { get; set; } = new List<Talep>();
}
