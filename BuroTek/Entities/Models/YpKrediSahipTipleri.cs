using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpKrediSahipTipleri
{
    public int KrediSahipTipiId { get; set; }

    public string KrediSahipTipiAdi { get; set; } = null!;

    public virtual ICollection<KullaniciKredi> KullaniciKredis { get; set; } = new List<KullaniciKredi>();

    public virtual ICollection<KullaniciSmsLog> KullaniciSmsLogs { get; set; } = new List<KullaniciSmsLog>();
}
