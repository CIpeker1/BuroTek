using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class FaturaIslemleri
{
    public int FaturaIslemId { get; set; }

    public int BuroId { get; set; }

    public int? KullaniciId { get; set; }

    public string? FaturaNo { get; set; }

    public bool Durum { get; set; }

    public string CcLast4Num { get; set; } = null!;

    public decimal Tutar { get; set; }

    public DateTime IslemTarihi { get; set; }

    public DateTime KayitTarihi { get; set; }

    public int IslemYapanKullaniciId { get; set; }

    public string IpAdresi { get; set; } = null!;

    public int IslemTuruId { get; set; }

    public string? Ettn { get; set; }

    public int KartTipi { get; set; }

    public int? DonusumDurumId { get; set; }

    public string? HataMesaji { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual DonusumDurumlari? DonusumDurum { get; set; }

    public virtual YpIslemTuru IslemTuru { get; set; } = null!;

    public virtual Kullanicilar IslemYapanKullanici { get; set; } = null!;

    public virtual Kullanicilar? Kullanici { get; set; }
}
