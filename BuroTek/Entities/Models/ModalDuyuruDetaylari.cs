using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class ModalDuyuruDetaylari
{
    public int ModalDuyuruDetayId { get; set; }

    public int? KullaniciTipiId { get; set; }

    public string? Konu { get; set; }

    public string? Detay { get; set; }

    public bool? AktifMi { get; set; }

    public DateTime? BaslangicTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public int? KullaniciId { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public virtual Kullanicilar? Kullanici { get; set; }

    public virtual YpKullaniciTipleri? KullaniciTipi { get; set; }
}
