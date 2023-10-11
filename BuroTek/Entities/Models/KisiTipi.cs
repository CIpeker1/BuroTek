using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class KisiTipi
{
    public int KisiTipiId { get; set; }

    public string KisiTipiAdi { get; set; } = null!;

    public virtual ICollection<Kisiler> Kisilers { get; set; } = new List<Kisiler>();
}
