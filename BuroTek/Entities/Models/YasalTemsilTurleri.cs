using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YasalTemsilTurleri
{
    public int TemsilTuruId { get; set; }

    public string TemsilTuruAdi { get; set; } = null!;

    public virtual ICollection<Kisiler> Kisilers { get; set; } = new List<Kisiler>();
}
