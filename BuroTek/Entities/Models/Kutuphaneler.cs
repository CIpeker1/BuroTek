using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class Kutuphaneler
{
    public int KutuphaneId { get; set; }

    public int BuroId { get; set; }

    public int? UstKutuphaneId { get; set; }

    public string KutuphaneAdi { get; set; } = null!;

    public int? KullaniciId { get; set; }

    public string? KutuphaneKodu { get; set; }

    public string? KutuphaneAdres { get; set; }

    public string? KutuphaneTelefon { get; set; }

    public decimal? GunlukCeza { get; set; }

    public int? Opsiyon { get; set; }

    public DateTime KayitTarihi { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual ICollection<Kutuphaneler> InverseUstKutuphane { get; set; } = new List<Kutuphaneler>();

    public virtual Kullanicilar? Kullanici { get; set; }

    public virtual Kutuphaneler? UstKutuphane { get; set; }

    public virtual ICollection<Yayinlar> Yayinlars { get; set; } = new List<Yayinlar>();
}
