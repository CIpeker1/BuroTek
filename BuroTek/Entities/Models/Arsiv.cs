using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class Arsiv
{
    public int ArsivId { get; set; }

    public int DosyaId { get; set; }

    public int ArsivYonetimiId { get; set; }

    public int BuroId { get; set; }

    public int ArsivTuruId { get; set; }

    public string Konu { get; set; } = null!;

    public string? Ilgi { get; set; }

    public string? Aciklama { get; set; }

    public string? BolumNo { get; set; }

    public string? KlasorNo { get; set; }

    public int KullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public int? ModulId { get; set; }

    public int? DisKayitNo { get; set; }

    public virtual ArsivTuru ArsivTuru { get; set; } = null!;

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Dosyalar Dosya { get; set; } = null!;

    public virtual Kullanicilar Kullanici { get; set; } = null!;
}
