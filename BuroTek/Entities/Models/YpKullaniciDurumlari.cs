using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpKullaniciDurumlari
{
    public int KullaniciDurumId { get; set; }

    public string KullaniciDurumAdi { get; set; } = null!;

    public virtual ICollection<Kullanicilar> Kullanicilars { get; set; } = new List<Kullanicilar>();
}
