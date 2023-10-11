using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class EntegrasyonLoglariDetay
{
    public int EntegrasyonLoglariDetayId { get; set; }

    public int EntegrasyonLoglariId { get; set; }

    public int FaturaIslemId { get; set; }

    public string ReferansNo { get; set; } = null!;

    public int? FaturaTipi { get; set; }

    public int? FaturaTuru { get; set; }

    public int? GonderimSekli { get; set; }

    public int? ParaBirimi { get; set; }

    public decimal? Kur { get; set; }

    public DateTime? FaturaTarihi { get; set; }

    public bool? InternetUzerindenSatisMi { get; set; }

    public int? InternetSatisOdemeSekli { get; set; }

    public int? InternetSatisTuru { get; set; }

    public DateTime? InternetSatisOdemeTarihi { get; set; }

    public string? InternetSatisAraciFirmaVkn { get; set; }

    public string? InternetSatisOdemeAraciFirmaAdi { get; set; }

    public string? InternetSatisWebAdresi { get; set; }

    public string? InternetSatisOdemeAciklamasi { get; set; }

    public string? InternetSatisUlkeAdi { get; set; }

    public DateTime? TasiyiciGonderimTarihi { get; set; }

    public string? TasiyiciKargoFirmaVkn { get; set; }

    public string? TasiyiciKargoFirmaUnvani { get; set; }

    public string? TasiyiciKargoTakipNo { get; set; }

    public string? TasiyiciFisNo { get; set; }

    public string? TasiyiciUlkeAdi { get; set; }

    public string? AciklamaSebeb { get; set; }

    public string? HizmetUrunAdi { get; set; }

    public decimal? Miktar { get; set; }

    public int? BirimTipi { get; set; }

    public decimal? BirimFiyat { get; set; }

    public decimal? IskontoOrani { get; set; }

    public decimal? IskontoTutari { get; set; }

    public decimal? KdvOrani { get; set; }

    public decimal? KdvTutari { get; set; }

    public decimal? MalHizmetTutari { get; set; }

    public string? IstisnaKodu { get; set; }

    public string? VknTckn { get; set; }

    public string? Adi { get; set; }

    public string? Soyadi { get; set; }

    public string? Unvani { get; set; }

    public string? TelefonNo { get; set; }

    public string? EPosta { get; set; }

    public string? VergiDairesi { get; set; }

    public bool? GelenBasariDurumu { get; set; }

    public string? GelenFaturaNo { get; set; }

    public string? GelenEttn { get; set; }

    public string? GelenReferans { get; set; }

    public string? GelenAciklama { get; set; }

    public DateTime DuzenlemeTarihi { get; set; }

    public int DuzenleyenKullaniciId { get; set; }
}
