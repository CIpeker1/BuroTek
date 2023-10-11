using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class Lokasyonlar
{
    public int LokasyonId { get; set; }

    public int BuroId { get; set; }

    public int? AltLokasyonId { get; set; }

    public int KullaniciId { get; set; }

    public string LokasyonAdi { get; set; } = null!;

    public DateTime KayitTarihi { get; set; }

    public virtual Lokasyonlar? AltLokasyon { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual ICollection<Demirba> Demirbas { get; set; } = new List<Demirba>();

    public virtual ICollection<Lokasyonlar> InverseAltLokasyon { get; set; } = new List<Lokasyonlar>();
}
