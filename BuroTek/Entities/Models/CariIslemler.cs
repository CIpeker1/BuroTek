using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class CariIslemler
{
    public int CariIslemId { get; set; }

    public int BuroId { get; set; }

    public int CariHesapKoduId { get; set; }

    public DateTime Tarih { get; set; }

    public int IslemYapanKullaniciId { get; set; }

    public int? CariId { get; set; }

    public decimal Tutar { get; set; }

    public string Aciklama { get; set; } = null!;

    public int? DisKayitNo { get; set; }

    /// <summary>
    /// BU alan modüllerle gelirleri tutmak için yapıldı
    /// </summary>
    public int? ModulId { get; set; }

    public int? KisiId { get; set; }

    public DateTime? CariTarihi { get; set; }

    public bool? Odendi { get; set; }

    public string? EmakbuzGuid { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Cariler? Cari { get; set; }

    public virtual CariHesapKodlari CariHesapKodu { get; set; } = null!;

    public virtual Kullanicilar IslemYapanKullanici { get; set; } = null!;

    public virtual Kisiler? Kisi { get; set; }

    public virtual Moduller? Modul { get; set; }
}
