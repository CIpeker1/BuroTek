using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class Burolar
{
    public int BuroId { get; set; }

    public string BuroAdi { get; set; } = null!;

    public int BuroIlId { get; set; }

    public int BuroIlceId { get; set; }

    public string BuroTelefon { get; set; } = null!;

    public string BuroFaks { get; set; } = null!;

    public string? BuroAdres { get; set; }

    public string? Eposta { get; set; }

    public string? WebSite { get; set; }

    public string? IbanNo { get; set; }

    public string? SmsBaslik { get; set; }

    public bool Aktif { get; set; }

    public bool? CariIslemGecmisiSekreterGormesin { get; set; }

    public virtual ICollection<ArsivTuru> ArsivTurus { get; set; } = new List<ArsivTuru>();

    public virtual ICollection<ArsivYonetimi> ArsivYonetimis { get; set; } = new List<ArsivYonetimi>();

    public virtual ICollection<Arsiv> Arsivs { get; set; } = new List<Arsiv>();

    public virtual ICollection<BelgeKayit> BelgeKayits { get; set; } = new List<BelgeKayit>();

    public virtual ICollection<BelgeSayac> BelgeSayacs { get; set; } = new List<BelgeSayac>();

    public virtual ICollection<BelgeTuru> BelgeTurus { get; set; } = new List<BelgeTuru>();

    public virtual ICollection<Bilgilendirilecekler> Bilgilendirileceklers { get; set; } = new List<Bilgilendirilecekler>();

    public virtual YpIlIlce BuroIlce { get; set; } = null!;

    public virtual ICollection<CariHesapKodlari> CariHesapKodlaris { get; set; } = new List<CariHesapKodlari>();

    public virtual ICollection<CariIslemler> CariIslemlers { get; set; } = new List<CariIslemler>();

    public virtual ICollection<Cariler> Carilers { get; set; } = new List<Cariler>();

    public virtual ICollection<DanismaDosya> DanismaDosyas { get; set; } = new List<DanismaDosya>();

    public virtual ICollection<Danisma> Danismas { get; set; } = new List<Danisma>();

    public virtual ICollection<DavaDosya> DavaDosyas { get; set; } = new List<DavaDosya>();

    public virtual ICollection<DavaKisiler> DavaKisilers { get; set; } = new List<DavaKisiler>();

    public virtual ICollection<Demirba> Demirbas { get; set; } = new List<Demirba>();

    public virtual ICollection<DemirbasDosya> DemirbasDosyas { get; set; } = new List<DemirbasDosya>();

    public virtual ICollection<DilekceMevzuat> DilekceMevzuats { get; set; } = new List<DilekceMevzuat>();

    public virtual ICollection<Dosyalar> Dosyalars { get; set; } = new List<Dosyalar>();

    public virtual ICollection<DurusmaDosya> DurusmaDosyas { get; set; } = new List<DurusmaDosya>();

    public virtual ICollection<Durusmalar> Durusmalars { get; set; } = new List<Durusmalar>();

    public virtual ICollection<EmsalKarar> EmsalKarars { get; set; } = new List<EmsalKarar>();

    public virtual ICollection<EvrakBaglanti> EvrakBaglantis { get; set; } = new List<EvrakBaglanti>();

    public virtual ICollection<EvrakDosya> EvrakDosyas { get; set; } = new List<EvrakDosya>();

    public virtual ICollection<FaturaBilgileri> FaturaBilgileris { get; set; } = new List<FaturaBilgileri>();

    public virtual ICollection<FaturaIslemleri> FaturaIslemleris { get; set; } = new List<FaturaIslemleri>();

    public virtual ICollection<IcraDaireleri> IcraDaireleris { get; set; } = new List<IcraDaireleri>();

    public virtual ICollection<IcraDosya> IcraDosyas { get; set; } = new List<IcraDosya>();

    public virtual ICollection<IcraKisiler> IcraKisilers { get; set; } = new List<IcraKisiler>();

    public virtual ICollection<Icralar> Icralars { get; set; } = new List<Icralar>();

    public virtual ICollection<Kesifler> Kesiflers { get; set; } = new List<Kesifler>();

    public virtual ICollection<KisiAdresler> KisiAdreslers { get; set; } = new List<KisiAdresler>();

    public virtual ICollection<KisiSozlesmeDosya> KisiSozlesmeDosyas { get; set; } = new List<KisiSozlesmeDosya>();

    public virtual ICollection<KisiVekaletDosya> KisiVekaletDosyas { get; set; } = new List<KisiVekaletDosya>();

    public virtual ICollection<KisiVekaletler> KisiVekaletlers { get; set; } = new List<KisiVekaletler>();

    public virtual ICollection<Kisiler> Kisilers { get; set; } = new List<Kisiler>();

    public virtual ICollection<KrediKartiIslemleriLog> KrediKartiIslemleriLogs { get; set; } = new List<KrediKartiIslemleriLog>();

    public virtual ICollection<KrediYuklemeIslemleri> KrediYuklemeIslemleris { get; set; } = new List<KrediYuklemeIslemleri>();

    public virtual ICollection<KullaniciKredi> KullaniciKredis { get; set; } = new List<KullaniciKredi>();

    public virtual ICollection<KullaniciLog> KullaniciLogs { get; set; } = new List<KullaniciLog>();

    public virtual ICollection<KullaniciRehberGruplari> KullaniciRehberGruplaris { get; set; } = new List<KullaniciRehberGruplari>();

    public virtual ICollection<KullaniciRehber> KullaniciRehbers { get; set; } = new List<KullaniciRehber>();

    public virtual ICollection<KullaniciSmsLog> KullaniciSmsLogs { get; set; } = new List<KullaniciSmsLog>();

    public virtual ICollection<KullaniciSmsSablonKategori> KullaniciSmsSablonKategoris { get; set; } = new List<KullaniciSmsSablonKategori>();

    public virtual ICollection<KullaniciSmsSablon> KullaniciSmsSablons { get; set; } = new List<KullaniciSmsSablon>();

    public virtual ICollection<KullaniciTercihleri> KullaniciTercihleris { get; set; } = new List<KullaniciTercihleri>();

    public virtual ICollection<Kullanicilar> Kullanicilars { get; set; } = new List<Kullanicilar>();

    public virtual ICollection<Kutuphaneler> Kutuphanelers { get; set; } = new List<Kutuphaneler>();

    public virtual ICollection<Lokasyonlar> Lokasyonlars { get; set; } = new List<Lokasyonlar>();

    public virtual ICollection<Notlar> Notlars { get; set; } = new List<Notlar>();

    public virtual ICollection<SorgulamaLoglari> SorgulamaLoglaris { get; set; } = new List<SorgulamaLoglari>();

    public virtual ICollection<TalepDosya> TalepDosyas { get; set; } = new List<TalepDosya>();

    public virtual ICollection<Talep> Taleps { get; set; } = new List<Talep>();

    public virtual ICollection<YayinCikislari> YayinCikislaris { get; set; } = new List<YayinCikislari>();

    public virtual ICollection<YayinTurleri> YayinTurleris { get; set; } = new List<YayinTurleri>();

    public virtual ICollection<Yayinlar> Yayinlars { get; set; } = new List<Yayinlar>();

    public virtual ICollection<YpBildirimler> YpBildirimlers { get; set; } = new List<YpBildirimler>();

    public virtual ICollection<YpKullaniciSozlesme> YpKullaniciSozlesmes { get; set; } = new List<YpKullaniciSozlesme>();

    public virtual ICollection<YpKurumTanimlari> YpKurumTanimlaris { get; set; } = new List<YpKurumTanimlari>();
}
