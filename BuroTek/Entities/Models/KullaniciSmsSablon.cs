using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class KullaniciSmsSablon
{
    public int KullaniciSmsSablonId { get; set; }

    public string Mesaj { get; set; } = null!;

    public int? SmsSablonKategoriId { get; set; }

    public int BuroId { get; set; }

    public int KullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Kullanicilar Kullanici { get; set; } = null!;

    public virtual KullaniciSmsSablonKategori? SmsSablonKategori { get; set; }
}
