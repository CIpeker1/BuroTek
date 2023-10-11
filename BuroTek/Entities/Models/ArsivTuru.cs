using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class ArsivTuru
{
    public int ArsivTuruId { get; set; }

    public string ArsivTuruAdi { get; set; } = null!;

    public int BuroId { get; set; }

    public int KullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public virtual ICollection<Arsiv> Arsivs { get; set; } = new List<Arsiv>();

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Kullanicilar Kullanici { get; set; } = null!;
}
