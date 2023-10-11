using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpSmsDurum
{
    public int DurumId { get; set; }

    public string DurumAdi { get; set; } = null!;

    public virtual ICollection<KullaniciSmsLog> KullaniciSmsLogs { get; set; } = new List<KullaniciSmsLog>();
}
