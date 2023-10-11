using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpFormlar
{
    public int FormId { get; set; }

    public string FormAdi { get; set; } = null!;

    public virtual ICollection<KullaniciLog> KullaniciLogs { get; set; } = new List<KullaniciLog>();
}
