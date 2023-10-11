using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class Kullanicilar
{
    public int KullaniciId { get; set; }

    public int BuroId { get; set; }

    public string KullaniciAdi { get; set; } = null!;

    public string KullaniciSifre { get; set; } = null!;

    public string KullaniciEposta { get; set; } = null!;

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public string? TcKimlikNo { get; set; }

    public int KullaniciTipiId { get; set; }

    public bool? AvukatOrtakDurumu { get; set; }

    public int? BaroSicilNo { get; set; }

    public string? Adres { get; set; }

    public int? IlId { get; set; }

    public int? IlceId { get; set; }

    public string? Cinsiyet { get; set; }

    public DateTime? DogumTarihi { get; set; }

    public string? KullaniciTelefon { get; set; }

    public string? KullaniciFaks { get; set; }

    public string? KullaniciCepTelefon { get; set; }

    public int? BankaKodu { get; set; }

    public int? BankaSubeKodu { get; set; }

    public string? IbanNo { get; set; }

    public DateTime? SistemBasvuruTarihi { get; set; }

    public DateTime? AktivasyonTarihi { get; set; }

    public DateTime? KapatilmaTarihi { get; set; }

    public int KullaniciDurumId { get; set; }

    public int? DisKullaniciId { get; set; }

    public string? SmsBaslik { get; set; }

    public int? KullaniciResimId { get; set; }

    public bool OtpBlok { get; set; }

    public bool YetkiliAvukat { get; set; }

    public virtual ICollection<ArsivTuru> ArsivTurus { get; set; } = new List<ArsivTuru>();

    public virtual ICollection<ArsivYonetimi> ArsivYonetimis { get; set; } = new List<ArsivYonetimi>();

    public virtual ICollection<Arsiv> Arsivs { get; set; } = new List<Arsiv>();

    public virtual ICollection<BelgeKayit> BelgeKayits { get; set; } = new List<BelgeKayit>();

    public virtual ICollection<BelgeTuru> BelgeTurus { get; set; } = new List<BelgeTuru>();

    public virtual Burolar Buro { get; set; } = null!;

    public virtual ICollection<CariIslemler> CariIslemlers { get; set; } = new List<CariIslemler>();

    public virtual ICollection<Danisma> DanismaAtananAvukats { get; set; } = new List<Danisma>();

    public virtual ICollection<DanismaDosya> DanismaDosyas { get; set; } = new List<DanismaDosya>();

    public virtual ICollection<Danisma> DanismaKullanicis { get; set; } = new List<Danisma>();

    public virtual ICollection<DavaDosya> DavaDosyas { get; set; } = new List<DavaDosya>();

    public virtual ICollection<DavaKisiler> DavaKisilers { get; set; } = new List<DavaKisiler>();

    public virtual ICollection<DavaTurleri> DavaTurleris { get; set; } = new List<DavaTurleri>();

    public virtual ICollection<Davalar> DavalarIlgilenenAvukats { get; set; } = new List<Davalar>();

    public virtual ICollection<Davalar> DavalarKullanicis { get; set; } = new List<Davalar>();

    public virtual ICollection<Davalar> DavalarOlusturanKullanicis { get; set; } = new List<Davalar>();

    public virtual ICollection<Demirba> Demirbas { get; set; } = new List<Demirba>();

    public virtual ICollection<DemirbasDosya> DemirbasDosyas { get; set; } = new List<DemirbasDosya>();

    public virtual ICollection<DilekceTurleri> DilekceTurleriGuncellemeKullanicis { get; set; } = new List<DilekceTurleri>();

    public virtual ICollection<DilekceTurleri> DilekceTurleriKayitKullanicis { get; set; } = new List<DilekceTurleri>();

    public virtual ICollection<Dosyalar> Dosyalars { get; set; } = new List<Dosyalar>();

    public virtual ICollection<DurusmaDosya> DurusmaDosyas { get; set; } = new List<DurusmaDosya>();

    public virtual ICollection<Durusmalar> Durusmalars { get; set; } = new List<Durusmalar>();

    public virtual ICollection<EmsalKarar> EmsalKarars { get; set; } = new List<EmsalKarar>();

    public virtual ICollection<EvrakBaglanti> EvrakBaglantis { get; set; } = new List<EvrakBaglanti>();

    public virtual ICollection<EvrakDosya> EvrakDosyas { get; set; } = new List<EvrakDosya>();

    public virtual ICollection<FaizOranlari> FaizOranlaris { get; set; } = new List<FaizOranlari>();

    public virtual ICollection<Faizler> Faizlers { get; set; } = new List<Faizler>();

    public virtual ICollection<FaturaBilgileri> FaturaBilgileris { get; set; } = new List<FaturaBilgileri>();

    public virtual ICollection<FaturaIslemleri> FaturaIslemleriIslemYapanKullanicis { get; set; } = new List<FaturaIslemleri>();

    public virtual ICollection<FaturaIslemleri> FaturaIslemleriKullanicis { get; set; } = new List<FaturaIslemleri>();

    public virtual ICollection<IcraDaireleri> IcraDaireleris { get; set; } = new List<IcraDaireleri>();

    public virtual ICollection<IcraDosya> IcraDosyas { get; set; } = new List<IcraDosya>();

    public virtual ICollection<IcraKisiler> IcraKisilers { get; set; } = new List<IcraKisiler>();

    public virtual ICollection<Icralar> IcralarIlgilenAvukats { get; set; } = new List<Icralar>();

    public virtual ICollection<Icralar> IcralarOlusturanKullanicis { get; set; } = new List<Icralar>();

    public virtual YpIlIlce? Il { get; set; }

    public virtual YpIlIlce? Ilce { get; set; }

    public virtual ICollection<IletisimBilgileri> IletisimBilgileris { get; set; } = new List<IletisimBilgileri>();

    public virtual ICollection<Kesifler> Kesiflers { get; set; } = new List<Kesifler>();

    public virtual ICollection<KisiSozlesmeDosya> KisiSozlesmeDosyas { get; set; } = new List<KisiSozlesmeDosya>();

    public virtual ICollection<KisiSozlesmeTaksitlendirme> KisiSozlesmeTaksitlendirmes { get; set; } = new List<KisiSozlesmeTaksitlendirme>();

    public virtual ICollection<KisiSozlesmeler> KisiSozlesmelers { get; set; } = new List<KisiSozlesmeler>();

    public virtual ICollection<KisiVekaletDosya> KisiVekaletDosyas { get; set; } = new List<KisiVekaletDosya>();

    public virtual ICollection<Kisiler> Kisilers { get; set; } = new List<Kisiler>();

    public virtual ICollection<KrediKartiIslemleriLog> KrediKartiIslemleriLogs { get; set; } = new List<KrediKartiIslemleriLog>();

    public virtual ICollection<KrediYuklemeIslemleri> KrediYuklemeIslemleris { get; set; } = new List<KrediYuklemeIslemleri>();

    public virtual YpKullaniciDurumlari KullaniciDurum { get; set; } = null!;

    public virtual ICollection<KullaniciKredi> KullaniciKredis { get; set; } = new List<KullaniciKredi>();

    public virtual ICollection<KullaniciLog> KullaniciLogs { get; set; } = new List<KullaniciLog>();

    public virtual ICollection<KullaniciRehberGrupKisileri> KullaniciRehberGrupKisileris { get; set; } = new List<KullaniciRehberGrupKisileri>();

    public virtual ICollection<KullaniciRehberGruplari> KullaniciRehberGruplaris { get; set; } = new List<KullaniciRehberGruplari>();

    public virtual ICollection<KullaniciRehber> KullaniciRehberKayitliKullanicis { get; set; } = new List<KullaniciRehber>();

    public virtual ICollection<KullaniciRehber> KullaniciRehberKullanicis { get; set; } = new List<KullaniciRehber>();

    public virtual KullaniciResim? KullaniciResim { get; set; }

    public virtual ICollection<KullaniciSmsLog> KullaniciSmsLogIslemYapanKullanicis { get; set; } = new List<KullaniciSmsLog>();

    public virtual ICollection<KullaniciSmsLog> KullaniciSmsLogKullanicis { get; set; } = new List<KullaniciSmsLog>();

    public virtual ICollection<KullaniciSmsSablonKategori> KullaniciSmsSablonKategoris { get; set; } = new List<KullaniciSmsSablonKategori>();

    public virtual ICollection<KullaniciSmsSablon> KullaniciSmsSablons { get; set; } = new List<KullaniciSmsSablon>();

    public virtual ICollection<KullaniciTercihleri> KullaniciTercihleris { get; set; } = new List<KullaniciTercihleri>();

    public virtual YpKullaniciTipleri KullaniciTipi { get; set; } = null!;

    public virtual ICollection<Kutuphaneler> Kutuphanelers { get; set; } = new List<Kutuphaneler>();

    public virtual ICollection<ModalDuyuruDetaylari> ModalDuyuruDetaylaris { get; set; } = new List<ModalDuyuruDetaylari>();

    public virtual ICollection<ModalDuyuru> ModalDuyurus { get; set; } = new List<ModalDuyuru>();

    public virtual ICollection<Notlar> NotlarIslemYapanKullanicis { get; set; } = new List<Notlar>();

    public virtual ICollection<Notlar> NotlarKullanicis { get; set; } = new List<Notlar>();

    public virtual ICollection<OkunanKampanyalar> OkunanKampanyalars { get; set; } = new List<OkunanKampanyalar>();

    public virtual ICollection<OtpLog> OtpLogs { get; set; } = new List<OtpLog>();

    public virtual ICollection<SikcaSorulanSorular> SikcaSorulanSorulars { get; set; } = new List<SikcaSorulanSorular>();

    public virtual ICollection<SorgulamaLoglari> SorgulamaLoglaris { get; set; } = new List<SorgulamaLoglari>();

    public virtual ICollection<TalepDosya> TalepDosyas { get; set; } = new List<TalepDosya>();

    public virtual ICollection<Talep> TalepKapatanKullanicis { get; set; } = new List<Talep>();

    public virtual ICollection<Talep> TalepTalepEdenKullanicis { get; set; } = new List<Talep>();

    public virtual ICollection<Token> Tokens { get; set; } = new List<Token>();

    public virtual ICollection<YayinCikislari> YayinCikislaris { get; set; } = new List<YayinCikislari>();

    public virtual ICollection<YayinTurleri> YayinTurleris { get; set; } = new List<YayinTurleri>();

    public virtual ICollection<YpBildirimler> YpBildirimlerBildirenKullanicis { get; set; } = new List<YpBildirimler>();

    public virtual ICollection<YpBildirimler> YpBildirimlerBildirilenKullanicis { get; set; } = new List<YpBildirimler>();

    public virtual ICollection<YpKullaniciSozlesme> YpKullaniciSozlesmeIslemYapanKullanicis { get; set; } = new List<YpKullaniciSozlesme>();

    public virtual ICollection<YpKullaniciSozlesme> YpKullaniciSozlesmeKullanicis { get; set; } = new List<YpKullaniciSozlesme>();

    public virtual ICollection<YpKullaniciYetkiGruplari> YpKullaniciYetkiGruplaris { get; set; } = new List<YpKullaniciYetkiGruplari>();

    public virtual ICollection<YpKurumTanimlari> YpKurumTanimlaris { get; set; } = new List<YpKurumTanimlari>();

    public virtual ICollection<YpSucTipleri> YpSucTipleris { get; set; } = new List<YpSucTipleri>();
}
