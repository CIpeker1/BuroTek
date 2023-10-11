using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpSmsTuru
{
    public int SmsTuruId { get; set; }

    public string SmsTuruAdi { get; set; } = null!;

    public string SmsTuruSablon { get; set; } = null!;

    public string? SmsTuruAciklama { get; set; }

    public virtual ICollection<KullaniciSmsLog> KullaniciSmsLogs { get; set; } = new List<KullaniciSmsLog>();
}
