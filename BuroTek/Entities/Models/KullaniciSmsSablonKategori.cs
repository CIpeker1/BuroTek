using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class KullaniciSmsSablonKategori
{
    public int KullaniciSmsSablonKategoriId { get; set; }

    public string KategoriAdi { get; set; } = null!;

    public int BuroId { get; set; }

    public int KullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Kullanicilar Kullanici { get; set; } = null!;

    public virtual ICollection<KullaniciSmsSablon> KullaniciSmsSablons { get; set; } = new List<KullaniciSmsSablon>();
}
