using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class DavaDurum
{
    public int DavaDurumId { get; set; }

    public string DavaDurumAdi { get; set; } = null!;

    public virtual ICollection<Davalar> Davalars { get; set; } = new List<Davalar>();
}
