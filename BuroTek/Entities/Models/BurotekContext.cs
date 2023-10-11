using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BuroTek.Entities.Models;

public partial class BurotekContext : DbContext
{
    public BurotekContext()
    {
    }

    public BurotekContext(DbContextOptions<BurotekContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdresTipleri> AdresTipleris { get; set; }

    public virtual DbSet<Arsiv> Arsivs { get; set; }

    public virtual DbSet<ArsivTuru> ArsivTurus { get; set; }

    public virtual DbSet<ArsivYonetimi> ArsivYonetimis { get; set; }

    public virtual DbSet<BelgeErisimHakki> BelgeErisimHakkis { get; set; }

    public virtual DbSet<BelgeGuvenlikSeviyesi> BelgeGuvenlikSeviyesis { get; set; }

    public virtual DbSet<BelgeKayit> BelgeKayits { get; set; }

    public virtual DbSet<BelgeOncelikDerecesi> BelgeOncelikDerecesis { get; set; }

    public virtual DbSet<BelgeSayac> BelgeSayacs { get; set; }

    public virtual DbSet<BelgeTuru> BelgeTurus { get; set; }

    public virtual DbSet<BelgeTuruYeni> BelgeTuruYenis { get; set; }

    public virtual DbSet<Bilgilendirilecekler> Bilgilendirileceklers { get; set; }

    public virtual DbSet<Bilgilendirme> Bilgilendirmes { get; set; }

    public virtual DbSet<BuroGecici> BuroGecicis { get; set; }

    public virtual DbSet<Burolar> Burolars { get; set; }

    public virtual DbSet<CariHesapKodlari> CariHesapKodlaris { get; set; }

    public virtual DbSet<CariIslemler> CariIslemlers { get; set; }

    public virtual DbSet<Cariler> Carilers { get; set; }

    public virtual DbSet<CrmLoglar> CrmLoglars { get; set; }

    public virtual DbSet<Danisma> Danismas { get; set; }

    public virtual DbSet<DanismaDosya> DanismaDosyas { get; set; }

    public virtual DbSet<DanismaKisi> DanismaKisis { get; set; }

    public virtual DbSet<DavaDosya> DavaDosyas { get; set; }

    public virtual DbSet<DavaDurum> DavaDurums { get; set; }

    public virtual DbSet<DavaKisiler> DavaKisilers { get; set; }

    public virtual DbSet<DavaTurleri> DavaTurleris { get; set; }

    public virtual DbSet<DavaTuruTipleri> DavaTuruTipleris { get; set; }

    public virtual DbSet<Davalar> Davalars { get; set; }

    public virtual DbSet<Demirba> Demirbas { get; set; }

    public virtual DbSet<DemirbasDosya> DemirbasDosyas { get; set; }

    public virtual DbSet<DemirbasDurumlari> DemirbasDurumlaris { get; set; }

    public virtual DbSet<DilekceMevzuat> DilekceMevzuats { get; set; }

    public virtual DbSet<DilekceMevzuatDosya> DilekceMevzuatDosyas { get; set; }

    public virtual DbSet<DilekceMevzuatTuru> DilekceMevzuatTurus { get; set; }

    public virtual DbSet<DilekceTurleri> DilekceTurleris { get; set; }

    public virtual DbSet<DonusumDurumlari> DonusumDurumlaris { get; set; }

    public virtual DbSet<DosyaIliskiler> DosyaIliskilers { get; set; }

    public virtual DbSet<Dosyalar> Dosyalars { get; set; }

    public virtual DbSet<DurusmaDosya> DurusmaDosyas { get; set; }

    public virtual DbSet<Durusmalar> Durusmalars { get; set; }

    public virtual DbSet<EmakbuzBilgileri> EmakbuzBilgileris { get; set; }

    public virtual DbSet<EmsalKarar> EmsalKarars { get; set; }

    public virtual DbSet<EntegrasyonLoglari> EntegrasyonLoglaris { get; set; }

    public virtual DbSet<EntegrasyonLoglariDetay> EntegrasyonLoglariDetays { get; set; }

    public virtual DbSet<Entegrasyonlar> Entegrasyonlars { get; set; }

    public virtual DbSet<Evrak> Evraks { get; set; }

    public virtual DbSet<EvrakBaglanti> EvrakBaglantis { get; set; }

    public virtual DbSet<EvrakDosya> EvrakDosyas { get; set; }

    public virtual DbSet<EvrakTuru> EvrakTurus { get; set; }

    public virtual DbSet<FaizOranlari> FaizOranlaris { get; set; }

    public virtual DbSet<FaizTurleri> FaizTurleris { get; set; }

    public virtual DbSet<Faizler> Faizlers { get; set; }

    public virtual DbSet<FaturaBilgileri> FaturaBilgileris { get; set; }

    public virtual DbSet<FaturaIslemleri> FaturaIslemleris { get; set; }

    public virtual DbSet<GeciciDosyalar> GeciciDosyalars { get; set; }

    public virtual DbSet<HarcTipleri> HarcTipleris { get; set; }

    public virtual DbSet<HarcUcretleri> HarcUcretleris { get; set; }

    public virtual DbSet<HesapTuru> HesapTurus { get; set; }

    public virtual DbSet<HizmetTipi> HizmetTipis { get; set; }

    public virtual DbSet<IcraDaireleri> IcraDaireleris { get; set; }

    public virtual DbSet<IcraDosya> IcraDosyas { get; set; }

    public virtual DbSet<IcraDurum> IcraDurums { get; set; }

    public virtual DbSet<IcraKisiler> IcraKisilers { get; set; }

    public virtual DbSet<IcraTakipTuru> IcraTakipTurus { get; set; }

    public virtual DbSet<Icralar> Icralars { get; set; }

    public virtual DbSet<IletisimBilgileri> IletisimBilgileris { get; set; }

    public virtual DbSet<Kesifler> Kesiflers { get; set; }

    public virtual DbSet<KisiAdresler> KisiAdreslers { get; set; }

    public virtual DbSet<KisiRoller> KisiRollers { get; set; }

    public virtual DbSet<KisiSozlesmeDosya> KisiSozlesmeDosyas { get; set; }

    public virtual DbSet<KisiSozlesmeTaksitlendirme> KisiSozlesmeTaksitlendirmes { get; set; }

    public virtual DbSet<KisiSozlesmeler> KisiSozlesmelers { get; set; }

    public virtual DbSet<KisiTipi> KisiTipis { get; set; }

    public virtual DbSet<KisiVekaletDosya> KisiVekaletDosyas { get; set; }

    public virtual DbSet<KisiVekaletYetki> KisiVekaletYetkis { get; set; }

    public virtual DbSet<KisiVekaletler> KisiVekaletlers { get; set; }

    public virtual DbSet<Kisiler> Kisilers { get; set; }

    public virtual DbSet<KrediKartiIslemleri> KrediKartiIslemleris { get; set; }

    public virtual DbSet<KrediKartiIslemleriLog> KrediKartiIslemleriLogs { get; set; }

    public virtual DbSet<KrediYuklemeIslemleri> KrediYuklemeIslemleris { get; set; }

    public virtual DbSet<KullaniciGecici> KullaniciGecicis { get; set; }

    public virtual DbSet<KullaniciIslemTuru> KullaniciIslemTurus { get; set; }

    public virtual DbSet<KullaniciKredi> KullaniciKredis { get; set; }

    public virtual DbSet<KullaniciLog> KullaniciLogs { get; set; }

    public virtual DbSet<KullaniciRehber> KullaniciRehbers { get; set; }

    public virtual DbSet<KullaniciRehberGrupKisileri> KullaniciRehberGrupKisileris { get; set; }

    public virtual DbSet<KullaniciRehberGruplari> KullaniciRehberGruplaris { get; set; }

    public virtual DbSet<KullaniciResim> KullaniciResims { get; set; }

    public virtual DbSet<KullaniciSmsLog> KullaniciSmsLogs { get; set; }

    public virtual DbSet<KullaniciSmsSablon> KullaniciSmsSablons { get; set; }

    public virtual DbSet<KullaniciSmsSablonKategori> KullaniciSmsSablonKategoris { get; set; }

    public virtual DbSet<KullaniciTercihleri> KullaniciTercihleris { get; set; }

    public virtual DbSet<Kullanicilar> Kullanicilars { get; set; }

    public virtual DbSet<Kutuphaneler> Kutuphanelers { get; set; }

    public virtual DbSet<Lokasyonlar> Lokasyonlars { get; set; }

    public virtual DbSet<MaktuVekaletUcretleri> MaktuVekaletUcretleris { get; set; }

    public virtual DbSet<ModalDuyuru> ModalDuyurus { get; set; }

    public virtual DbSet<ModalDuyuruDetaylari> ModalDuyuruDetaylaris { get; set; }

    public virtual DbSet<Moduller> Modullers { get; set; }

    public virtual DbSet<Notlar> Notlars { get; set; }

    public virtual DbSet<OdemeTuru> OdemeTurus { get; set; }

    public virtual DbSet<OkunanKampanyalar> OkunanKampanyalars { get; set; }

    public virtual DbSet<OperatorTurleri> OperatorTurleris { get; set; }

    public virtual DbSet<OtpLog> OtpLogs { get; set; }

    public virtual DbSet<SikcaSorulanSorular> SikcaSorulanSorulars { get; set; }

    public virtual DbSet<SiteyeGirisLog> SiteyeGirisLogs { get; set; }

    public virtual DbSet<SorgulamaLoglari> SorgulamaLoglaris { get; set; }

    public virtual DbSet<SorgulamaServisleri> SorgulamaServisleris { get; set; }

    public virtual DbSet<SorgulamaUlkeKodlari> SorgulamaUlkeKodlaris { get; set; }

    public virtual DbSet<TakipYoluTuru> TakipYoluTurus { get; set; }

    public virtual DbSet<Talep> Taleps { get; set; }

    public virtual DbSet<TalepDosya> TalepDosyas { get; set; }

    public virtual DbSet<TalepDurum> TalepDurums { get; set; }

    public virtual DbSet<TalepTuru> TalepTurus { get; set; }

    public virtual DbSet<TasinirGrublari> TasinirGrublaris { get; set; }

    public virtual DbSet<Token> Tokens { get; set; }

    public virtual DbSet<VekalatUcretleri> VekalatUcretleris { get; set; }

    public virtual DbSet<VekaletTuru> VekaletTurus { get; set; }

    public virtual DbSet<YardimVideolari> YardimVideolaris { get; set; }

    public virtual DbSet<YasalTemsilTurleri> YasalTemsilTurleris { get; set; }

    public virtual DbSet<YayinCikislari> YayinCikislaris { get; set; }

    public virtual DbSet<YayinTurleri> YayinTurleris { get; set; }

    public virtual DbSet<Yayinlar> Yayinlars { get; set; }

    public virtual DbSet<YetkiTuru> YetkiTurus { get; set; }

    public virtual DbSet<YpAgBilgileri> YpAgBilgileris { get; set; }

    public virtual DbSet<YpBankalar> YpBankalars { get; set; }

    public virtual DbSet<YpBildirimDurumlari> YpBildirimDurumlaris { get; set; }

    public virtual DbSet<YpBildirimTurleri> YpBildirimTurleris { get; set; }

    public virtual DbSet<YpBildirimTuruGruplari> YpBildirimTuruGruplaris { get; set; }

    public virtual DbSet<YpBildirimler> YpBildirimlers { get; set; }

    public virtual DbSet<YpEmsalKararTuru> YpEmsalKararTurus { get; set; }

    public virtual DbSet<YpFormlar> YpFormlars { get; set; }

    public virtual DbSet<YpIlIlce> YpIlIlces { get; set; }

    public virtual DbSet<YpIslemTuru> YpIslemTurus { get; set; }

    public virtual DbSet<YpKontrolNoktalari> YpKontrolNoktalaris { get; set; }

    public virtual DbSet<YpKrediKartiAyar> YpKrediKartiAyars { get; set; }

    public virtual DbSet<YpKrediSahipTipleri> YpKrediSahipTipleris { get; set; }

    public virtual DbSet<YpKullaniciDurumlari> YpKullaniciDurumlaris { get; set; }

    public virtual DbSet<YpKullaniciSozlesme> YpKullaniciSozlesmes { get; set; }

    public virtual DbSet<YpKullaniciTercihTuru> YpKullaniciTercihTurus { get; set; }

    public virtual DbSet<YpKullaniciTipleri> YpKullaniciTipleris { get; set; }

    public virtual DbSet<YpKullaniciYetkiGruplari> YpKullaniciYetkiGruplaris { get; set; }

    public virtual DbSet<YpKurumTanimlari> YpKurumTanimlaris { get; set; }

    public virtual DbSet<YpKurumTurleri> YpKurumTurleris { get; set; }

    public virtual DbSet<YpMenuler> YpMenulers { get; set; }

    public virtual DbSet<YpOtpAyar> YpOtpAyars { get; set; }

    public virtual DbSet<YpSmsAyar> YpSmsAyars { get; set; }

    public virtual DbSet<YpSmsDurum> YpSmsDurums { get; set; }

    public virtual DbSet<YpSmsSonuclar> YpSmsSonuclars { get; set; }

    public virtual DbSet<YpSmsTuru> YpSmsTurus { get; set; }

    public virtual DbSet<YpSucTipleri> YpSucTipleris { get; set; }

    public virtual DbSet<YpTurkposAyar> YpTurkposAyars { get; set; }

    public virtual DbSet<YpTurkposSonucLog> YpTurkposSonucLogs { get; set; }

    public virtual DbSet<YpUyelikUcretlendirme> YpUyelikUcretlendirmes { get; set; }

    public virtual DbSet<YpUyruklar> YpUyruklars { get; set; }

    public virtual DbSet<YpYetkiGrupKontrolNoktalari> YpYetkiGrupKontrolNoktalaris { get; set; }

    public virtual DbSet<YpYetkiGruplari> YpYetkiGruplaris { get; set; }

    public virtual DbSet<ZamanAraligi> ZamanAraligis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=burotek;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdresTipleri>(entity =>
        {
            entity.HasKey(e => e.AdresTipiId);

            entity.ToTable("ADRES_TIPLERI");

            entity.Property(e => e.AdresTipiId).HasColumnName("ADRES_TIPI_ID");
            entity.Property(e => e.AdresTipiAdi)
                .HasMaxLength(300)
                .HasColumnName("ADRES_TIPI_ADI");
        });

        modelBuilder.Entity<Arsiv>(entity =>
        {
            entity.ToTable("ARSIV");

            entity.Property(e => e.ArsivId).HasColumnName("ARSIV_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.ArsivTuruId).HasColumnName("ARSIV_TURU_ID");
            entity.Property(e => e.ArsivYonetimiId).HasColumnName("ARSIV_YONETIMI_ID");
            entity.Property(e => e.BolumNo)
                .HasMaxLength(50)
                .HasColumnName("BOLUM_NO");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.DisKayitNo).HasColumnName("DIS_KAYIT_NO");
            entity.Property(e => e.DosyaId).HasColumnName("DOSYA_ID");
            entity.Property(e => e.Ilgi)
                .HasMaxLength(300)
                .HasColumnName("ILGI");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KlasorNo)
                .HasMaxLength(50)
                .HasColumnName("KLASOR_NO");
            entity.Property(e => e.Konu)
                .HasMaxLength(300)
                .HasColumnName("KONU");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.ModulId).HasColumnName("MODUL_ID");

            entity.HasOne(d => d.ArsivTuru).WithMany(p => p.Arsivs)
                .HasForeignKey(d => d.ArsivTuruId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSIV_ARSIV_TURU");

            entity.HasOne(d => d.Buro).WithMany(p => p.Arsivs)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSIV_BUROLAR");

            entity.HasOne(d => d.Dosya).WithMany(p => p.Arsivs)
                .HasForeignKey(d => d.DosyaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSIV_DOSYALAR");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.Arsivs)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSIV_KULLANICILAR");
        });

        modelBuilder.Entity<ArsivTuru>(entity =>
        {
            entity.ToTable("ARSIV_TURU");

            entity.Property(e => e.ArsivTuruId).HasColumnName("ARSIV_TURU_ID");
            entity.Property(e => e.ArsivTuruAdi)
                .HasMaxLength(300)
                .HasColumnName("ARSIV_TURU_ADI");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.ArsivTurus)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSIV_TURU_BUROLAR");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.ArsivTurus)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSIV_TURU_KULLANICILAR");
        });

        modelBuilder.Entity<ArsivYonetimi>(entity =>
        {
            entity.ToTable("ARSIV_YONETIMI");

            entity.Property(e => e.ArsivYonetimiId).HasColumnName("ARSIV_YONETIMI_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KlasorAdi)
                .HasMaxLength(300)
                .HasColumnName("KLASOR_ADI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.UstKlasorId).HasColumnName("UST_KLASOR_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.ArsivYonetimis)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSIV_YONETIMI_BUROLAR");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.ArsivYonetimis)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSIV_YONETIMI_KULLANICILAR");
        });

        modelBuilder.Entity<BelgeErisimHakki>(entity =>
        {
            entity.ToTable("BELGE_ERISIM_HAKKI");

            entity.Property(e => e.BelgeErisimHakkiId)
                .ValueGeneratedNever()
                .HasColumnName("BELGE_ERISIM_HAKKI_ID");
            entity.Property(e => e.BelgeErisimHakkiAdi)
                .HasMaxLength(50)
                .HasColumnName("BELGE_ERISIM_HAKKI_ADI");
        });

        modelBuilder.Entity<BelgeGuvenlikSeviyesi>(entity =>
        {
            entity.ToTable("BELGE_GUVENLIK_SEVIYESI");

            entity.Property(e => e.BelgeGuvenlikSeviyesiId)
                .ValueGeneratedNever()
                .HasColumnName("BELGE_GUVENLIK_SEVIYESI_ID");
            entity.Property(e => e.BelgeGuvenlikSeviyesiAdi)
                .HasMaxLength(50)
                .HasColumnName("BELGE_GUVENLIK_SEVIYESI_ADI");
        });

        modelBuilder.Entity<BelgeKayit>(entity =>
        {
            entity.HasKey(e => e.BelgeId);

            entity.ToTable("BELGE_KAYIT");

            entity.Property(e => e.BelgeId).HasColumnName("BELGE_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(300)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.BelgeErisimHakkiId).HasColumnName("BELGE_ERISIM_HAKKI_ID");
            entity.Property(e => e.BelgeGuvenlikSeviyesiId).HasColumnName("BELGE_GUVENLIK_SEVIYESI_ID");
            entity.Property(e => e.BelgeOncelikDerecesiId).HasColumnName("BELGE_ONCELIK_DERECESI_ID");
            entity.Property(e => e.BelgeSayacId).HasColumnName("BELGE_SAYAC_ID");
            entity.Property(e => e.BelgeTuruId).HasColumnName("BELGE_TURU_ID");
            entity.Property(e => e.BilgiEdinmeKapsaminda).HasColumnName("BILGI_EDINME_KAPSAMINDA");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.Ek)
                .HasMaxLength(300)
                .HasColumnName("EK");
            entity.Property(e => e.GeldigiGittigiKisiId).HasColumnName("GELDIGI_GITTIGI_KISI_ID");
            entity.Property(e => e.KayitNo).HasColumnName("KAYIT_NO");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.Konu)
                .HasMaxLength(300)
                .HasColumnName("KONU");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.MiadTarihi)
                .HasColumnType("datetime")
                .HasColumnName("MIAD_TARIHI");
            entity.Property(e => e.SayacSiraNo).HasColumnName("SAYAC_SIRA_NO");
            entity.Property(e => e.Sayi)
                .HasMaxLength(300)
                .HasColumnName("SAYI");
            entity.Property(e => e.TelifHakkiKapsami).HasColumnName("TELIF_HAKKI_KAPSAMI");
            entity.Property(e => e.UretimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("URETIM_TARIHI");

            entity.HasOne(d => d.BelgeErisimHakki).WithMany(p => p.BelgeKayits)
                .HasForeignKey(d => d.BelgeErisimHakkiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BELGE_KAYIT_BELGE_ERISIM_HAKKI");

            entity.HasOne(d => d.BelgeOncelikDerecesi).WithMany(p => p.BelgeKayits)
                .HasForeignKey(d => d.BelgeOncelikDerecesiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BELGE_KAYIT_BELGE_ONCELIK_DERECESI");

            entity.HasOne(d => d.BelgeSayac).WithMany(p => p.BelgeKayits)
                .HasForeignKey(d => d.BelgeSayacId)
                .HasConstraintName("FK_BELGE_KAYIT_BELGE_SAYAC");

            entity.HasOne(d => d.BelgeTuru).WithMany(p => p.BelgeKayits)
                .HasForeignKey(d => d.BelgeTuruId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BELGE_KAYIT_BELGE_TURU");

            entity.HasOne(d => d.Buro).WithMany(p => p.BelgeKayits)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BELGE_KAYIT_BUROLAR");

            entity.HasOne(d => d.GeldigiGittigiKisi).WithMany(p => p.BelgeKayits)
                .HasForeignKey(d => d.GeldigiGittigiKisiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BELGE_KAYIT_KISILER");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.BelgeKayits)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BELGE_KAYIT_KULLANICILAR");
        });

        modelBuilder.Entity<BelgeOncelikDerecesi>(entity =>
        {
            entity.ToTable("BELGE_ONCELIK_DERECESI");

            entity.Property(e => e.BelgeOncelikDerecesiId).HasColumnName("BELGE_ONCELIK_DERECESI_ID");
            entity.Property(e => e.BelgeOncelikDerecesiAdi)
                .HasMaxLength(150)
                .HasColumnName("BELGE_ONCELIK_DERECESI_ADI");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
        });

        modelBuilder.Entity<BelgeSayac>(entity =>
        {
            entity.ToTable("BELGE_SAYAC");

            entity.Property(e => e.BelgeSayacId).HasColumnName("BELGE_SAYAC_ID");
            entity.Property(e => e.BelgeSayacAdi)
                .HasMaxLength(150)
                .HasColumnName("BELGE_SAYAC_ADI");
            entity.Property(e => e.BelgeSayacSiraNo).HasColumnName("BELGE_SAYAC_SIRA_NO");
            entity.Property(e => e.BelgeTuruId).HasColumnName("BELGE_TURU_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.Yil).HasColumnName("YIL");

            entity.HasOne(d => d.BelgeTuru).WithMany(p => p.BelgeSayacs)
                .HasForeignKey(d => d.BelgeTuruId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BELGE_SAYAC_BELGE_TURU");

            entity.HasOne(d => d.Buro).WithMany(p => p.BelgeSayacs)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BELGE_SAYAC_BUROLAR");
        });

        modelBuilder.Entity<BelgeTuru>(entity =>
        {
            entity.ToTable("BELGE_TURU");

            entity.Property(e => e.BelgeTuruId).HasColumnName("BELGE_TURU_ID");
            entity.Property(e => e.BelgeTuruAdi)
                .HasMaxLength(250)
                .HasColumnName("BELGE_TURU_ADI");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.BelgeTurus)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BELGE_TURU_BUROLAR");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.BelgeTurus)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BELGE_TURU_KULLANICILAR");
        });

        modelBuilder.Entity<BelgeTuruYeni>(entity =>
        {
            entity.HasKey(e => e.BelgeTuruId).HasName("PK_BELGE_TURU_1");

            entity.ToTable("BELGE_TURU_YENI");

            entity.Property(e => e.BelgeTuruId)
                .ValueGeneratedNever()
                .HasColumnName("BELGE_TURU_ID");
            entity.Property(e => e.BelgeTuruAdi)
                .HasMaxLength(50)
                .HasColumnName("BELGE_TURU_ADI");
        });

        modelBuilder.Entity<Bilgilendirilecekler>(entity =>
        {
            entity.HasKey(e => e.BilgilendirilecekId);

            entity.ToTable("BILGILENDIRILECEKLER");

            entity.Property(e => e.BilgilendirilecekId).HasColumnName("BILGILENDIRILECEK_ID");
            entity.Property(e => e.AranacakTelNo)
                .HasMaxLength(20)
                .HasColumnName("ARANACAK_TEL_NO");
            entity.Property(e => e.BilgilendirmeId).HasColumnName("BILGILENDIRME_ID");
            entity.Property(e => e.BilgilendirmeKuyrukId).HasColumnName("BILGILENDIRME_KUYRUK_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");

            entity.HasOne(d => d.Bilgilendirme).WithMany(p => p.Bilgilendirileceklers)
                .HasForeignKey(d => d.BilgilendirmeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILGILENDIRILECEKLER_BILGILENDIRME");

            entity.HasOne(d => d.Buro).WithMany(p => p.Bilgilendirileceklers)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILGILENDIRILECEKLER_BUROLAR");
        });

        modelBuilder.Entity<Bilgilendirme>(entity =>
        {
            entity.ToTable("BILGILENDIRME");

            entity.Property(e => e.BilgilendirmeId).HasColumnName("BILGILENDIRME_ID");
            entity.Property(e => e.Arandi).HasColumnName("ARANDI");
            entity.Property(e => e.BilgilendirmeMesaji).HasColumnName("BILGILENDIRME_MESAJI");
            entity.Property(e => e.BilgilendirmeSesYolu)
                .HasMaxLength(250)
                .HasColumnName("BILGILENDIRME_SES_YOLU");
        });

        modelBuilder.Entity<BuroGecici>(entity =>
        {
            entity.ToTable("BURO_GECICI");

            entity.Property(e => e.BuroGeciciId).HasColumnName("BURO_GECICI_ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.BuroAdi)
                .HasMaxLength(250)
                .HasColumnName("BURO_ADI");
            entity.Property(e => e.BuroAdres)
                .HasMaxLength(300)
                .HasColumnName("BURO_ADRES");
            entity.Property(e => e.BuroFaks)
                .HasMaxLength(50)
                .HasColumnName("BURO_FAKS");
            entity.Property(e => e.BuroIlId).HasColumnName("BURO_IL_ID");
            entity.Property(e => e.BuroIlceId).HasColumnName("BURO_ILCE_ID");
            entity.Property(e => e.BuroTelefon)
                .HasMaxLength(50)
                .HasColumnName("BURO_TELEFON");
            entity.Property(e => e.IslemId).HasColumnName("ISLEM_ID");

            entity.HasOne(d => d.Islem).WithMany(p => p.BuroGecicis)
                .HasForeignKey(d => d.IslemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BURO_GECICI_KREDI_KARTI_ISLEMLERI");
        });

        modelBuilder.Entity<Burolar>(entity =>
        {
            entity.HasKey(e => e.BuroId);

            entity.ToTable("BUROLAR");

            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.BuroAdi)
                .HasMaxLength(250)
                .HasColumnName("BURO_ADI");
            entity.Property(e => e.BuroAdres)
                .HasMaxLength(300)
                .HasColumnName("BURO_ADRES");
            entity.Property(e => e.BuroFaks)
                .HasMaxLength(50)
                .HasColumnName("BURO_FAKS");
            entity.Property(e => e.BuroIlId).HasColumnName("BURO_IL_ID");
            entity.Property(e => e.BuroIlceId).HasColumnName("BURO_ILCE_ID");
            entity.Property(e => e.BuroTelefon)
                .HasMaxLength(50)
                .HasColumnName("BURO_TELEFON");
            entity.Property(e => e.CariIslemGecmisiSekreterGormesin)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CARI_ISLEM_GECMISI_SEKRETER_GORMESIN");
            entity.Property(e => e.Eposta)
                .HasMaxLength(150)
                .HasColumnName("EPOSTA");
            entity.Property(e => e.IbanNo)
                .HasMaxLength(50)
                .HasColumnName("IBAN_NO");
            entity.Property(e => e.SmsBaslik)
                .HasMaxLength(11)
                .HasColumnName("SMS_BASLIK");
            entity.Property(e => e.WebSite)
                .HasMaxLength(150)
                .HasColumnName("WEB_SITE");

            entity.HasOne(d => d.BuroIlce).WithMany(p => p.Burolars)
                .HasForeignKey(d => d.BuroIlceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BUROLAR_YP_IL_ILCE");
        });

        modelBuilder.Entity<CariHesapKodlari>(entity =>
        {
            entity.HasKey(e => e.CariHesapKoduId);

            entity.ToTable("CARI_HESAP_KODLARI");

            entity.Property(e => e.CariHesapKoduId).HasColumnName("CARI_HESAP_KODU_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.CariHesapAdi)
                .HasMaxLength(300)
                .HasColumnName("CARI_HESAP_ADI");
            entity.Property(e => e.CariHesapKodu)
                .HasMaxLength(50)
                .HasColumnName("CARI_HESAP_KODU");
            entity.Property(e => e.HesapTuruId).HasColumnName("HESAP_TURU_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.CariHesapKodlaris)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CARI_HESAP_KODLARI_BUROLAR");

            entity.HasOne(d => d.HesapTuru).WithMany(p => p.CariHesapKodlaris)
                .HasForeignKey(d => d.HesapTuruId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CARI_HESAP_KODLARI_HESAP_TURU");
        });

        modelBuilder.Entity<CariIslemler>(entity =>
        {
            entity.HasKey(e => e.CariIslemId);

            entity.ToTable("CARI_ISLEMLER");

            entity.Property(e => e.CariIslemId).HasColumnName("CARI_ISLEM_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(300)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.CariHesapKoduId).HasColumnName("CARI_HESAP_KODU_ID");
            entity.Property(e => e.CariId).HasColumnName("CARI_ID");
            entity.Property(e => e.CariTarihi)
                .HasColumnType("datetime")
                .HasColumnName("CARI_TARIHI");
            entity.Property(e => e.DisKayitNo).HasColumnName("DIS_KAYIT_NO");
            entity.Property(e => e.EmakbuzGuid).HasColumnName("EMAKBUZ_GUID");
            entity.Property(e => e.IslemYapanKullaniciId).HasColumnName("ISLEM_YAPAN_KULLANICI_ID");
            entity.Property(e => e.KisiId).HasColumnName("KISI_ID");
            entity.Property(e => e.ModulId)
                .HasComment("BU alan modüllerle gelirleri tutmak için yapıldı")
                .HasColumnName("MODUL_ID");
            entity.Property(e => e.Odendi).HasColumnName("ODENDI");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tutar)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("TUTAR");

            entity.HasOne(d => d.Buro).WithMany(p => p.CariIslemlers)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CARI_ISLEMLER_BUROLAR");

            entity.HasOne(d => d.CariHesapKodu).WithMany(p => p.CariIslemlers)
                .HasForeignKey(d => d.CariHesapKoduId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CARI_ISLEMLER_CARI_HESAP_KODLARI");

            entity.HasOne(d => d.Cari).WithMany(p => p.CariIslemlers)
                .HasForeignKey(d => d.CariId)
                .HasConstraintName("FK_CARI_ISLEMLER_CARILER");

            entity.HasOne(d => d.IslemYapanKullanici).WithMany(p => p.CariIslemlers)
                .HasForeignKey(d => d.IslemYapanKullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CARI_ISLEMLER_KULLANICILAR");

            entity.HasOne(d => d.Kisi).WithMany(p => p.CariIslemlers)
                .HasForeignKey(d => d.KisiId)
                .HasConstraintName("FK_CARI_ISLEMLER_KISILER");

            entity.HasOne(d => d.Modul).WithMany(p => p.CariIslemlers)
                .HasForeignKey(d => d.ModulId)
                .HasConstraintName("FK_CARI_ISLEMLER_MODULLER");
        });

        modelBuilder.Entity<Cariler>(entity =>
        {
            entity.HasKey(e => e.CariId);

            entity.ToTable("CARILER");

            entity.Property(e => e.CariId).HasColumnName("CARI_ID");
            entity.Property(e => e.Adres)
                .HasMaxLength(300)
                .HasColumnName("ADRES");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.CariAdi)
                .HasMaxLength(300)
                .HasColumnName("CARI_ADI");
            entity.Property(e => e.IlgiliKisiAdSoyad)
                .HasMaxLength(150)
                .HasColumnName("ILGILI_KISI_AD_SOYAD");
            entity.Property(e => e.KisaAdi)
                .HasMaxLength(150)
                .HasColumnName("KISA_ADI");
            entity.Property(e => e.Telefon)
                .HasMaxLength(50)
                .HasColumnName("TELEFON");
            entity.Property(e => e.VergiDairesi)
                .HasMaxLength(300)
                .HasColumnName("VERGI_DAIRESI");
            entity.Property(e => e.VergiNo)
                .HasMaxLength(50)
                .HasColumnName("VERGI_NO");

            entity.HasOne(d => d.Buro).WithMany(p => p.Carilers)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CARILER_BUROLAR");
        });

        modelBuilder.Entity<CrmLoglar>(entity =>
        {
            entity.HasKey(e => e.CrmLogId);

            entity.ToTable("CRM_LOGLAR");

            entity.Property(e => e.CrmLogId).HasColumnName("CRM_LOG_ID");
            entity.Property(e => e.BasariDurumu).HasColumnName("BASARI_DURUMU");
            entity.Property(e => e.BaslangicTarihi)
                .HasColumnType("date")
                .HasColumnName("BASLANGIC_TARIHI");
            entity.Property(e => e.BitisTarihi)
                .HasColumnType("date")
                .HasColumnName("BITIS_TARIHI");
            entity.Property(e => e.Ip)
                .HasMaxLength(50)
                .HasColumnName("IP");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KrediYuklemeKisiSayisi).HasColumnName("KREDI_YUKLEME_KISI_SAYISI");
            entity.Property(e => e.KrediYuklemeTutar)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KREDI_YUKLEME_TUTAR");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.Mesaj)
                .HasMaxLength(250)
                .HasColumnName("MESAJ");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.UyelikUzatmaSayisi).HasColumnName("UYELIK_UZATMA_SAYISI");
            entity.Property(e => e.UyelikUzatmaTutar)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("UYELIK_UZATMA_TUTAR");
            entity.Property(e => e.UygulamaAdi)
                .HasMaxLength(50)
                .HasColumnName("UYGULAMA_ADI");
            entity.Property(e => e.YeniUyeSayisi).HasColumnName("YENI_UYE_SAYISI");
            entity.Property(e => e.YeniUyelikTutar)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("YENI_UYELIK_TUTAR");
        });

        modelBuilder.Entity<Danisma>(entity =>
        {
            entity.ToTable("DANISMA");

            entity.Property(e => e.DanismaId).HasColumnName("DANISMA_ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.AnlasmaTutari)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("ANLASMA_TUTARI");
            entity.Property(e => e.ArabuluculukDosyaNo)
                .HasMaxLength(100)
                .HasColumnName("ARABULUCULUK_DOSYA_NO");
            entity.Property(e => e.ArabuluculukYpKurumTanimId).HasColumnName("ARABULUCULUK_YP_KURUM_TANIM_ID");
            entity.Property(e => e.ArsiveKaldirildi).HasColumnName("ARSIVE_KALDIRILDI");
            entity.Property(e => e.AtananAvukatId).HasColumnName("ATANAN_AVUKAT_ID");
            entity.Property(e => e.BuroDanismaNo)
                .HasMaxLength(50)
                .HasColumnName("BURO_DANISMA_NO");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.DanisanTalepleri).HasColumnName("DANISAN_TALEPLERI");
            entity.Property(e => e.Delil).HasColumnName("DELIL");
            entity.Property(e => e.DosyaNo)
                .HasMaxLength(50)
                .HasColumnName("DOSYA_NO");
            entity.Property(e => e.DosyaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DOSYA_TARIHI");
            entity.Property(e => e.HizmetTipiId).HasColumnName("HIZMET_TIPI_ID");
            entity.Property(e => e.IlgiliKurum)
                .HasMaxLength(100)
                .HasColumnName("ILGILI_KURUM");
            entity.Property(e => e.KarsiTarafAdsoyad)
                .HasMaxLength(50)
                .HasColumnName("KARSI_TARAF_ADSOYAD");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.Kilit).HasColumnName("KILIT");
            entity.Property(e => e.Konu).HasColumnName("KONU");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.KurumNo)
                .HasMaxLength(50)
                .HasColumnName("KURUM_NO");
            entity.Property(e => e.SiraNo).HasColumnName("SIRA_NO");

            entity.HasOne(d => d.ArabuluculukYpKurumTanim).WithMany(p => p.Danismas)
                .HasForeignKey(d => d.ArabuluculukYpKurumTanimId)
                .HasConstraintName("FK_DANISMA_YP_KURUM_TANIMLARI");

            entity.HasOne(d => d.AtananAvukat).WithMany(p => p.DanismaAtananAvukats)
                .HasForeignKey(d => d.AtananAvukatId)
                .HasConstraintName("FK_DANISMA_KULLANICILAR");

            entity.HasOne(d => d.Buro).WithMany(p => p.Danismas)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DANISMA_BUROLAR");

            entity.HasOne(d => d.HizmetTipi).WithMany(p => p.Danismas)
                .HasForeignKey(d => d.HizmetTipiId)
                .HasConstraintName("FK_DANISMA_HIZMET_TIPI");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.DanismaKullanicis)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DANISMA_KULLANICILAR1");
        });

        modelBuilder.Entity<DanismaDosya>(entity =>
        {
            entity.ToTable("DANISMA_DOSYA");

            entity.Property(e => e.DanismaDosyaId).HasColumnName("DANISMA_DOSYA_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(300)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.DanismaId).HasColumnName("DANISMA_ID");
            entity.Property(e => e.DosyaId).HasColumnName("DOSYA_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.DanismaDosyas)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DANISMA_DOSYA_BUROLAR");

            entity.HasOne(d => d.Danisma).WithMany(p => p.DanismaDosyas)
                .HasForeignKey(d => d.DanismaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DANISMA_DOSYA_DANISMA");

            entity.HasOne(d => d.Dosya).WithMany(p => p.DanismaDosyas)
                .HasForeignKey(d => d.DosyaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DANISMA_DOSYA_DOSYALAR");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.DanismaDosyas)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DANISMA_DOSYA_KULLANICILAR");
        });

        modelBuilder.Entity<DanismaKisi>(entity =>
        {
            entity.ToTable("DANISMA_KISI");

            entity.Property(e => e.DanismaKisiId).HasColumnName("DANISMA_KISI_ID");
            entity.Property(e => e.DanismaId).HasColumnName("DANISMA_ID");
            entity.Property(e => e.KisiId).HasColumnName("KISI_ID");
            entity.Property(e => e.KisiSozlesmeId).HasColumnName("KISI_SOZLESME_ID");

            entity.HasOne(d => d.Danisma).WithMany(p => p.DanismaKisis)
                .HasForeignKey(d => d.DanismaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DANISMA_KISI_DANISMA_KISI");

            entity.HasOne(d => d.Kisi).WithMany(p => p.DanismaKisis)
                .HasForeignKey(d => d.KisiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DANISMA_KISI_KISILER");

            entity.HasOne(d => d.KisiSozlesme).WithMany(p => p.DanismaKisis)
                .HasForeignKey(d => d.KisiSozlesmeId)
                .HasConstraintName("FK_DANISMA_KISI_KISI_SOZLESMELER");
        });

        modelBuilder.Entity<DavaDosya>(entity =>
        {
            entity.ToTable("DAVA_DOSYA");

            entity.Property(e => e.DavaDosyaId).HasColumnName("DAVA_DOSYA_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.DavaId).HasColumnName("DAVA_ID");
            entity.Property(e => e.DosyaId).HasColumnName("DOSYA_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.DavaDosyas)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DAVA_DOSYA_BUROLAR");

            entity.HasOne(d => d.Dava).WithMany(p => p.DavaDosyas)
                .HasForeignKey(d => d.DavaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DAVA_DOSYA_DAVALAR");

            entity.HasOne(d => d.Dosya).WithMany(p => p.DavaDosyas)
                .HasForeignKey(d => d.DosyaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DAVA_DOSYA_DOSYALAR");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.DavaDosyas)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DAVA_DOSYA_KULLANICILAR");
        });

        modelBuilder.Entity<DavaDurum>(entity =>
        {
            entity.ToTable("DAVA_DURUM");

            entity.Property(e => e.DavaDurumId).HasColumnName("DAVA_DURUM_ID");
            entity.Property(e => e.DavaDurumAdi)
                .HasMaxLength(50)
                .HasColumnName("DAVA_DURUM_ADI");
        });

        modelBuilder.Entity<DavaKisiler>(entity =>
        {
            entity.HasKey(e => e.DavaKisiId);

            entity.ToTable("DAVA_KISILER");

            entity.HasIndex(e => e.DavaId, "IDX_DAVA_KISILER_DAVA_ID");

            entity.Property(e => e.DavaKisiId).HasColumnName("DAVA_KISI_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(300)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.DavaId).HasColumnName("DAVA_ID");
            entity.Property(e => e.DigerAciklama)
                .HasMaxLength(50)
                .HasColumnName("DIGER_ACIKLAMA");
            entity.Property(e => e.KarsiTarafAvukatAdSoyad)
                .HasMaxLength(150)
                .HasColumnName("KARSI_TARAF_AVUKAT_AD_SOYAD");
            entity.Property(e => e.KarsiTarafAvukatTelefon)
                .HasMaxLength(50)
                .HasColumnName("KARSI_TARAF_AVUKAT_TELEFON");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KisiId).HasColumnName("KISI_ID");
            entity.Property(e => e.KisiRolId).HasColumnName("KISI_ROL_ID");
            entity.Property(e => e.KisiSozlesmeId).HasColumnName("KISI_SOZLESME_ID");
            entity.Property(e => e.KisiVekaletId).HasColumnName("KISI_VEKALET_ID");
            entity.Property(e => e.MuvekkilDavaci).HasColumnName("MUVEKKIL_DAVACI");
            entity.Property(e => e.OlusturanKullaniciId).HasColumnName("OLUSTURAN_KULLANICI_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.DavaKisilers)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DAVA_KISILER_BUROLAR");

            entity.HasOne(d => d.Dava).WithMany(p => p.DavaKisilers)
                .HasForeignKey(d => d.DavaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DAVA_KISILER_DAVALAR");

            entity.HasOne(d => d.Kisi).WithMany(p => p.DavaKisilers)
                .HasForeignKey(d => d.KisiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DAVA_KISILER_KISILER");

            entity.HasOne(d => d.KisiRol).WithMany(p => p.DavaKisilers)
                .HasForeignKey(d => d.KisiRolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DAVA_KISILER_KISI_ROLLER");

            entity.HasOne(d => d.KisiSozlesme).WithMany(p => p.DavaKisilers)
                .HasForeignKey(d => d.KisiSozlesmeId)
                .HasConstraintName("FK_DAVA_KISILER_KISI_SOZLESMELER");

            entity.HasOne(d => d.KisiVekalet).WithMany(p => p.DavaKisilers)
                .HasForeignKey(d => d.KisiVekaletId)
                .HasConstraintName("FK_DAVA_KISILER_KISI_VEKALETLER");

            entity.HasOne(d => d.OlusturanKullanici).WithMany(p => p.DavaKisilers)
                .HasForeignKey(d => d.OlusturanKullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DAVA_KISILER_KULLANICILAR");
        });

        modelBuilder.Entity<DavaTurleri>(entity =>
        {
            entity.HasKey(e => e.DavaTuruId);

            entity.ToTable("DAVA_TURLERI");

            entity.Property(e => e.DavaTuruId).HasColumnName("DAVA_TURU_ID");
            entity.Property(e => e.DavaTuruAdi)
                .HasMaxLength(250)
                .HasColumnName("DAVA_TURU_ADI");
            entity.Property(e => e.DavaTuruTipiId).HasColumnName("DAVA_TURU_TIPI_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            entity.HasOne(d => d.DavaTuruTipi).WithMany(p => p.DavaTurleris)
                .HasForeignKey(d => d.DavaTuruTipiId)
                .HasConstraintName("FK_DAVA_TURLERI_DAVA_TURU_TIPLERI");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.DavaTurleris)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DAVA_TURLERI_KULLANICILAR");
        });

        modelBuilder.Entity<DavaTuruTipleri>(entity =>
        {
            entity.HasKey(e => e.DavaTuruTipiId);

            entity.ToTable("DAVA_TURU_TIPLERI");

            entity.Property(e => e.DavaTuruTipiId).HasColumnName("DAVA_TURU_TIPI_ID");
            entity.Property(e => e.DavaTuruTipiAdi)
                .HasMaxLength(50)
                .HasColumnName("DAVA_TURU_TIPI_ADI");
        });

        modelBuilder.Entity<Davalar>(entity =>
        {
            entity.HasKey(e => e.DavaId);

            entity.ToTable("DAVALAR");

            entity.HasIndex(e => new { e.BuroId, e.Kilit, e.ArsiveKaldirildi }, "IDX_DAVALAR_BURO_ID_KILIT_KALDIRILDI");

            entity.Property(e => e.DavaId).HasColumnName("DAVA_ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.AnlasmaTutari)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("ANLASMA_TUTARI");
            entity.Property(e => e.ArsivNo)
                .HasMaxLength(25)
                .HasColumnName("ARSIV_NO");
            entity.Property(e => e.ArsiveKaldirildi).HasColumnName("ARSIVE_KALDIRILDI");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.DanismaId).HasColumnName("DANISMA_ID");
            entity.Property(e => e.DavaDurumId).HasColumnName("DAVA_DURUM_ID");
            entity.Property(e => e.DavaSiraNo).HasColumnName("DAVA_SIRA_NO");
            entity.Property(e => e.DavaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DAVA_TARIHI");
            entity.Property(e => e.DavaTuruId).HasColumnName("DAVA_TURU_ID");
            entity.Property(e => e.DosyaEsasNo)
                .HasMaxLength(250)
                .HasColumnName("DOSYA_ESAS_NO");
            entity.Property(e => e.DosyaNo)
                .HasMaxLength(50)
                .HasColumnName("DOSYA_NO");
            entity.Property(e => e.IlgilenenAvukatId).HasColumnName("ILGILENEN_AVUKAT_ID");
            entity.Property(e => e.ItirazTemyizAciklama)
                .HasMaxLength(300)
                .HasColumnName("ITIRAZ_TEMYIZ_ACIKLAMA");
            entity.Property(e => e.ItirazTemyizTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ITIRAZ_TEMYIZ_TARIHI");
            entity.Property(e => e.KararNo)
                .HasMaxLength(250)
                .HasColumnName("KARAR_NO");
            entity.Property(e => e.KararOzeti)
                .HasMaxLength(300)
                .HasColumnName("KARAR_OZETI");
            entity.Property(e => e.KararTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KARAR_TARIHI");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KesinlesmeKararOzeti)
                .HasMaxLength(300)
                .HasColumnName("KESINLESME_KARAR_OZETI");
            entity.Property(e => e.KesinlesmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KESINLESME_TARIHI");
            entity.Property(e => e.Kilit).HasColumnName("KILIT");
            entity.Property(e => e.KlasorNo)
                .HasMaxLength(50)
                .HasColumnName("KLASOR_NO");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.KurumId).HasColumnName("KURUM_ID");
            entity.Property(e => e.OlusturanKullaniciId).HasColumnName("OLUSTURAN_KULLANICI_ID");
            entity.Property(e => e.SorusturmaNo)
                .HasMaxLength(50)
                .HasColumnName("SORUSTURMA_NO");
            entity.Property(e => e.SucTipiId).HasColumnName("SUC_TIPI_ID");
            entity.Property(e => e.TemyizEsasNo)
                .HasMaxLength(250)
                .HasColumnName("TEMYIZ_ESAS_NO");
            entity.Property(e => e.TemyizKararNo)
                .HasMaxLength(250)
                .HasColumnName("TEMYIZ_KARAR_NO");

            entity.HasOne(d => d.Danisma).WithMany(p => p.Davalars)
                .HasForeignKey(d => d.DanismaId)
                .HasConstraintName("FK_DAVALAR_DANISMA");

            entity.HasOne(d => d.DavaDurum).WithMany(p => p.Davalars)
                .HasForeignKey(d => d.DavaDurumId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DAVALAR_DAVA_DURUM");

            entity.HasOne(d => d.DavaTuru).WithMany(p => p.Davalars)
                .HasForeignKey(d => d.DavaTuruId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DAVALAR_DAVA_TURLERI");

            entity.HasOne(d => d.IlgilenenAvukat).WithMany(p => p.DavalarIlgilenenAvukats)
                .HasForeignKey(d => d.IlgilenenAvukatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DAVALAR_KULLANICILAR1");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.DavalarKullanicis)
                .HasForeignKey(d => d.KullaniciId)
                .HasConstraintName("FK_DAVALAR_KULLANICILAR2");

            entity.HasOne(d => d.Kurum).WithMany(p => p.Davalars)
                .HasForeignKey(d => d.KurumId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DAVALAR_YP_KURUM_TANIMLARI");

            entity.HasOne(d => d.OlusturanKullanici).WithMany(p => p.DavalarOlusturanKullanicis)
                .HasForeignKey(d => d.OlusturanKullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DAVALAR_KULLANICILAR");

            entity.HasOne(d => d.SucTipi).WithMany(p => p.Davalars)
                .HasForeignKey(d => d.SucTipiId)
                .HasConstraintName("FK_DAVALAR_YP_SUC_TIPLERI");
        });

        modelBuilder.Entity<Demirba>(entity =>
        {
            entity.HasKey(e => e.DemirbasId);

            entity.ToTable("DEMIRBAS");

            entity.Property(e => e.DemirbasId).HasColumnName("DEMIRBAS_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.AlinanFirma)
                .HasMaxLength(250)
                .HasColumnName("ALINAN_FIRMA");
            entity.Property(e => e.Barkod).HasColumnName("BARKOD");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.DemirbasAdi)
                .HasMaxLength(250)
                .HasColumnName("DEMIRBAS_ADI");
            entity.Property(e => e.DemirbasDurumId).HasColumnName("DEMIRBAS_DURUM_ID");
            entity.Property(e => e.DemirbasKodu)
                .HasMaxLength(250)
                .HasColumnName("DEMIRBAS_KODU");
            entity.Property(e => e.FaturaNo)
                .HasMaxLength(250)
                .HasColumnName("FATURA_NO");
            entity.Property(e => e.FaturaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("FATURA_TARIHI");
            entity.Property(e => e.Fiyati)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FIYATI");
            entity.Property(e => e.GarantiBaslangicTarihi)
                .HasColumnType("datetime")
                .HasColumnName("GARANTI_BASLANGIC_TARIHI");
            entity.Property(e => e.GarantiBitisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("GARANTI_BITIS_TARIHI");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.LokasyonId).HasColumnName("LOKASYON_ID");
            entity.Property(e => e.SeriNo)
                .HasMaxLength(250)
                .HasColumnName("SERI_NO");
            entity.Property(e => e.TasinirGrubuId).HasColumnName("TASINIR_GRUBU_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.Demirbas)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DEMIRBAS_BUROLAR");

            entity.HasOne(d => d.DemirbasDurum).WithMany(p => p.Demirbas)
                .HasForeignKey(d => d.DemirbasDurumId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DEMIRBAS_DEMIRBAS_DURUMLARI");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.Demirbas)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DEMIRBAS_KULLANICILAR");

            entity.HasOne(d => d.Lokasyon).WithMany(p => p.Demirbas)
                .HasForeignKey(d => d.LokasyonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DEMIRBAS_LOKASYONLAR");

            entity.HasOne(d => d.TasinirGrubu).WithMany(p => p.Demirbas)
                .HasForeignKey(d => d.TasinirGrubuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DEMIRBAS_TASINIR_GRUBLARI");
        });

        modelBuilder.Entity<DemirbasDosya>(entity =>
        {
            entity.ToTable("DEMIRBAS_DOSYA");

            entity.Property(e => e.DemirbasDosyaId).HasColumnName("DEMIRBAS_DOSYA_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.DemirbasId).HasColumnName("DEMIRBAS_ID");
            entity.Property(e => e.DosyaId).HasColumnName("DOSYA_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.DemirbasDosyas)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DEMIRBAS_DOSYA_BUROLAR");

            entity.HasOne(d => d.Demirbas).WithMany(p => p.DemirbasDosyas)
                .HasForeignKey(d => d.DemirbasId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DEMIRBAS_DOSYA_DEMIRBAS");

            entity.HasOne(d => d.Dosya).WithMany(p => p.DemirbasDosyas)
                .HasForeignKey(d => d.DosyaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DEMIRBAS_DOSYA_DOSYALAR");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.DemirbasDosyas)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DEMIRBAS_DOSYA_KULLANICILAR");
        });

        modelBuilder.Entity<DemirbasDurumlari>(entity =>
        {
            entity.HasKey(e => e.DemirbasDurumId);

            entity.ToTable("DEMIRBAS_DURUMLARI");

            entity.Property(e => e.DemirbasDurumId).HasColumnName("DEMIRBAS_DURUM_ID");
            entity.Property(e => e.DemirbasDurumAdi)
                .HasMaxLength(300)
                .HasColumnName("DEMIRBAS_DURUM_ADI");
            entity.Property(e => e.DemirbasDurumu).HasColumnName("DEMIRBAS_DURUMU");
        });

        modelBuilder.Entity<DilekceMevzuat>(entity =>
        {
            entity.ToTable("DILEKCE_MEVZUAT");

            entity.Property(e => e.DilekceMevzuatId).HasColumnName("DILEKCE_MEVZUAT_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.DilekceMevzuatDosyaAdi)
                .HasMaxLength(255)
                .HasColumnName("DILEKCE_MEVZUAT_DOSYA_ADI");
            entity.Property(e => e.DilekceMevzuatDosyaId).HasColumnName("DILEKCE_MEVZUAT_DOSYA_ID");
            entity.Property(e => e.DilekceMevzuatTuruId).HasColumnName("DILEKCE_MEVZUAT_TURU_ID");
            entity.Property(e => e.DilekceTuruId).HasColumnName("DILEKCE_TURU_ID");
            entity.Property(e => e.DosyaBoyutu).HasColumnName("DOSYA_BOYUTU");
            entity.Property(e => e.DosyaTipi)
                .HasMaxLength(300)
                .HasColumnName("DOSYA_TIPI");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.Sistem).HasColumnName("SISTEM");
            entity.Property(e => e.Uzanti)
                .HasMaxLength(150)
                .HasColumnName("UZANTI");

            entity.HasOne(d => d.Buro).WithMany(p => p.DilekceMevzuats)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DILEKCE_MEVZUAT_BUROLAR");

            entity.HasOne(d => d.DilekceMevzuatTuru).WithMany(p => p.DilekceMevzuats)
                .HasForeignKey(d => d.DilekceMevzuatTuruId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DILEKCE_MEVZUAT_DILEKCE_MEVZUAT_TURU");

            entity.HasOne(d => d.DilekceTuru).WithMany(p => p.DilekceMevzuats)
                .HasForeignKey(d => d.DilekceTuruId)
                .HasConstraintName("FK_DILEKCE_MEVZUAT_DILEKCE_TURU");
        });

        modelBuilder.Entity<DilekceMevzuatDosya>(entity =>
        {
            entity.HasKey(e => e.DilekceMevzuatDosyaId).HasName("PK_DILEKCE_DOSYA");

            entity.ToTable("DILEKCE_MEVZUAT_DOSYA");

            entity.Property(e => e.DilekceMevzuatDosyaId).HasColumnName("DILEKCE_MEVZUAT_DOSYA_ID");
            entity.Property(e => e.DilekceMevzuatDosya1).HasColumnName("DILEKCE_MEVZUAT_DOSYA");
        });

        modelBuilder.Entity<DilekceMevzuatTuru>(entity =>
        {
            entity.ToTable("DILEKCE_MEVZUAT_TURU");

            entity.Property(e => e.DilekceMevzuatTuruId).HasColumnName("DILEKCE_MEVZUAT_TURU_ID");
            entity.Property(e => e.DilekceMevzuatTuruAdi)
                .HasMaxLength(255)
                .HasColumnName("DILEKCE_MEVZUAT_TURU_ADI");
        });

        modelBuilder.Entity<DilekceTurleri>(entity =>
        {
            entity.HasKey(e => e.DilekceTuruId);

            entity.ToTable("DILEKCE_TURLERI");

            entity.Property(e => e.DilekceTuruId).HasColumnName("DILEKCE_TURU_ID");
            entity.Property(e => e.DilekceTuruAdi)
                .HasMaxLength(255)
                .HasColumnName("DILEKCE_TURU_ADI");
            entity.Property(e => e.GuncellemeKullaniciId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("GUNCELLEME_KULLANICI_ID");
            entity.Property(e => e.GuncellemeTarihi)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("GUNCELLEME_TARIHI");
            entity.Property(e => e.KayitKullaniciId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("KAYIT_KULLANICI_ID");
            entity.Property(e => e.KayitTarihi)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");

            entity.HasOne(d => d.GuncellemeKullanici).WithMany(p => p.DilekceTurleriGuncellemeKullanicis)
                .HasForeignKey(d => d.GuncellemeKullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DILEKCE_TURLERI_KULLANICILAR1");

            entity.HasOne(d => d.KayitKullanici).WithMany(p => p.DilekceTurleriKayitKullanicis)
                .HasForeignKey(d => d.KayitKullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DILEKCE_TURLERI_KULLANICILAR");
        });

        modelBuilder.Entity<DonusumDurumlari>(entity =>
        {
            entity.HasKey(e => e.DonusumDurumId);

            entity.ToTable("DONUSUM_DURUMLARI");

            entity.Property(e => e.DonusumDurumId)
                .ValueGeneratedNever()
                .HasColumnName("DONUSUM_DURUM_ID");
            entity.Property(e => e.DonusumDurumAdi)
                .HasMaxLength(50)
                .HasColumnName("DONUSUM_DURUM_ADI");
        });

        modelBuilder.Entity<DosyaIliskiler>(entity =>
        {
            entity.HasKey(e => e.DosyaIliskiId);

            entity.ToTable("DOSYA_ILISKILER");

            entity.Property(e => e.DosyaIliskiId).HasColumnName("DOSYA_ILISKI_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.DisKayitId).HasColumnName("DIS_KAYIT_ID");
            entity.Property(e => e.KayitId).HasColumnName("KAYIT_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.ModulId).HasColumnName("MODUL_ID");
        });

        modelBuilder.Entity<Dosyalar>(entity =>
        {
            entity.HasKey(e => e.DosyaId);

            entity.ToTable("DOSYALAR");

            entity.Property(e => e.DosyaId).HasColumnName("DOSYA_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(300)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.DepoDosyaAdi)
                .HasMaxLength(100)
                .HasColumnName("DEPO_DOSYA_ADI");
            entity.Property(e => e.DosyaAdi)
                .HasMaxLength(300)
                .HasColumnName("DOSYA_ADI");
            entity.Property(e => e.DosyaBoyutu).HasColumnName("DOSYA_BOYUTU");
            entity.Property(e => e.DosyaTipi)
                .HasMaxLength(300)
                .HasColumnName("DOSYA_TIPI");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.OcrMetin).HasColumnName("OCR_METIN");
            entity.Property(e => e.Uzanti)
                .HasMaxLength(20)
                .HasColumnName("UZANTI");

            entity.HasOne(d => d.Buro).WithMany(p => p.Dosyalars)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DOSYALAR_BUROLAR");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.Dosyalars)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DOSYALAR_KULLANICILAR");
        });

        modelBuilder.Entity<DurusmaDosya>(entity =>
        {
            entity.ToTable("DURUSMA_DOSYA");

            entity.Property(e => e.DurusmaDosyaId).HasColumnName("DURUSMA_DOSYA_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.DosyaId).HasColumnName("DOSYA_ID");
            entity.Property(e => e.DurusmaId).HasColumnName("DURUSMA_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.DurusmaDosyas)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DURUSMA_DOSYA_BUROLAR");

            entity.HasOne(d => d.Dosya).WithMany(p => p.DurusmaDosyas)
                .HasForeignKey(d => d.DosyaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DURUSMA_DOSYA_DOSYALAR");

            entity.HasOne(d => d.Durusma).WithMany(p => p.DurusmaDosyas)
                .HasForeignKey(d => d.DurusmaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DURUSMA_DOSYA_DURUSMALAR");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.DurusmaDosyas)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DURUSMA_DOSYA_KULLANICILAR");
        });

        modelBuilder.Entity<Durusmalar>(entity =>
        {
            entity.HasKey(e => e.DurusmaId);

            entity.ToTable("DURUSMALAR");

            entity.Property(e => e.DurusmaId).HasColumnName("DURUSMA_ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.DavaId).HasColumnName("DAVA_ID");
            entity.Property(e => e.DurusmaKarar).HasColumnName("DURUSMA_KARAR");
            entity.Property(e => e.DurusmaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DURUSMA_TARIHI");
            entity.Property(e => e.DurusmaYeri)
                .HasMaxLength(300)
                .HasColumnName("DURUSMA_YERI");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.NotId).HasColumnName("NOT_ID");
            entity.Property(e => e.OlusturanKullaniciId).HasColumnName("OLUSTURAN_KULLANICI_ID");
            entity.Property(e => e.UyariGunOnce).HasColumnName("UYARI_GUN_ONCE");
            entity.Property(e => e.UyariSonlandi).HasColumnName("UYARI_SONLANDI");
            entity.Property(e => e.UyariYapilsin).HasColumnName("UYARI_YAPILSIN");

            entity.HasOne(d => d.Buro).WithMany(p => p.Durusmalars)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DURUSMALAR_BUROLAR");

            entity.HasOne(d => d.Dava).WithMany(p => p.Durusmalars)
                .HasForeignKey(d => d.DavaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DURUSMALAR_DAVALAR");

            entity.HasOne(d => d.Not).WithMany(p => p.Durusmalars)
                .HasForeignKey(d => d.NotId)
                .HasConstraintName("FK_DURUSMALAR_NOTLAR");

            entity.HasOne(d => d.OlusturanKullanici).WithMany(p => p.Durusmalars)
                .HasForeignKey(d => d.OlusturanKullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DURUSMALAR_KULLANICILAR");
        });

        modelBuilder.Entity<EmakbuzBilgileri>(entity =>
        {
            entity.ToTable("EMAKBUZ_BILGILERI");

            entity.Property(e => e.EmakbuzBilgileriId).HasColumnName("EMAKBUZ_BILGILERI_ID");
            entity.Property(e => e.Durum).HasColumnName("DURUM");
            entity.Property(e => e.GelenEttn)
                .HasMaxLength(500)
                .HasColumnName("GELEN_ETTN");
            entity.Property(e => e.GelenFaturaNo)
                .HasMaxLength(500)
                .HasColumnName("GELEN_FATURA_NO");
            entity.Property(e => e.IslemTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ISLEM_TARIHI");
            entity.Property(e => e.KayitId).HasColumnName("KAYIT_ID");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.ModulId).HasColumnName("MODUL_ID");
            entity.Property(e => e.ReferansNo)
                .HasMaxLength(500)
                .HasColumnName("REFERANS_NO");
        });

        modelBuilder.Entity<EmsalKarar>(entity =>
        {
            entity.ToTable("EMSAL_KARAR");

            entity.Property(e => e.EmsalKararId).HasColumnName("EMSAL_KARAR_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.DavaId).HasColumnName("DAVA_ID");
            entity.Property(e => e.EmsalKararTuruId).HasColumnName("EMSAL_KARAR_TURU_ID");
            entity.Property(e => e.EsasNo)
                .HasMaxLength(150)
                .HasColumnName("ESAS_NO");
            entity.Property(e => e.IcraId).HasColumnName("ICRA_ID");
            entity.Property(e => e.KararId).HasColumnName("KARAR_ID");
            entity.Property(e => e.KararNo)
                .HasMaxLength(150)
                .HasColumnName("KARAR_NO");
            entity.Property(e => e.KararTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KARAR_TARIHI");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.Mahkeme)
                .HasMaxLength(150)
                .HasColumnName("MAHKEME");

            entity.HasOne(d => d.Buro).WithMany(p => p.EmsalKarars)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EMSAL_KARAR_BUROLAR");

            entity.HasOne(d => d.Dava).WithMany(p => p.EmsalKarars)
                .HasForeignKey(d => d.DavaId)
                .HasConstraintName("FK_EMSAL_KARAR_DAVALAR");

            entity.HasOne(d => d.EmsalKararTuru).WithMany(p => p.EmsalKarars)
                .HasForeignKey(d => d.EmsalKararTuruId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EMSAL_KARAR_YP_EMSAL_KARAR_TURU");

            entity.HasOne(d => d.Icra).WithMany(p => p.EmsalKarars)
                .HasForeignKey(d => d.IcraId)
                .HasConstraintName("FK_EMSAL_KARAR_ICRALAR");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.EmsalKarars)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EMSAL_KARAR_KULLANICILAR");
        });

        modelBuilder.Entity<EntegrasyonLoglari>(entity =>
        {
            entity.ToTable("ENTEGRASYON_LOGLARI");

            entity.Property(e => e.EntegrasyonLoglariId).HasColumnName("ENTEGRASYON_LOGLARI_ID");
            entity.Property(e => e.BasariDurumu).HasColumnName("BASARI_DURUMU");
            entity.Property(e => e.DuzenlemeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DUZENLEME_TARIHI");
            entity.Property(e => e.DuzenleyenKullaniciId).HasColumnName("DUZENLEYEN_KULLANICI_ID");
            entity.Property(e => e.EntegrasyonId).HasColumnName("ENTEGRASYON_ID");
            entity.Property(e => e.FaturaUrl)
                .HasMaxLength(500)
                .HasColumnName("FATURA_URL");
            entity.Property(e => e.KullaniciJson).HasColumnName("KULLANICI_JSON");
            entity.Property(e => e.KullaniciResponseJson).HasColumnName("KULLANICI_RESPONSE_JSON");
            entity.Property(e => e.LoginUrl)
                .HasMaxLength(500)
                .HasColumnName("LOGIN_URL");
            entity.Property(e => e.Mesaj)
                .HasMaxLength(500)
                .HasColumnName("MESAJ");
            entity.Property(e => e.Token)
                .HasMaxLength(1000)
                .HasColumnName("TOKEN");
        });

        modelBuilder.Entity<EntegrasyonLoglariDetay>(entity =>
        {
            entity.ToTable("ENTEGRASYON_LOGLARI_DETAY");

            entity.Property(e => e.EntegrasyonLoglariDetayId).HasColumnName("ENTEGRASYON_LOGLARI_DETAY_ID");
            entity.Property(e => e.AciklamaSebeb)
                .HasMaxLength(50)
                .HasColumnName("ACIKLAMA_SEBEB");
            entity.Property(e => e.Adi)
                .HasMaxLength(250)
                .HasColumnName("ADI");
            entity.Property(e => e.BirimFiyat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BIRIM_FIYAT");
            entity.Property(e => e.BirimTipi).HasColumnName("BIRIM_TIPI");
            entity.Property(e => e.DuzenlemeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DUZENLEME_TARIHI");
            entity.Property(e => e.DuzenleyenKullaniciId).HasColumnName("DUZENLEYEN_KULLANICI_ID");
            entity.Property(e => e.EPosta)
                .HasMaxLength(150)
                .HasColumnName("E_POSTA");
            entity.Property(e => e.EntegrasyonLoglariId).HasColumnName("ENTEGRASYON_LOGLARI_ID");
            entity.Property(e => e.FaturaIslemId).HasColumnName("FATURA_ISLEM_ID");
            entity.Property(e => e.FaturaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("FATURA_TARIHI");
            entity.Property(e => e.FaturaTipi).HasColumnName("FATURA_TIPI");
            entity.Property(e => e.FaturaTuru).HasColumnName("FATURA_TURU");
            entity.Property(e => e.GelenAciklama)
                .HasMaxLength(1500)
                .HasColumnName("GELEN_ACIKLAMA");
            entity.Property(e => e.GelenBasariDurumu).HasColumnName("GELEN_BASARI_DURUMU");
            entity.Property(e => e.GelenEttn)
                .HasMaxLength(500)
                .HasColumnName("GELEN_ETTN");
            entity.Property(e => e.GelenFaturaNo)
                .HasMaxLength(500)
                .HasColumnName("GELEN_FATURA_NO");
            entity.Property(e => e.GelenReferans)
                .HasMaxLength(500)
                .HasColumnName("GELEN_REFERANS");
            entity.Property(e => e.GonderimSekli).HasColumnName("GONDERIM_SEKLI");
            entity.Property(e => e.HizmetUrunAdi)
                .HasMaxLength(50)
                .HasColumnName("HIZMET_URUN_ADI");
            entity.Property(e => e.InternetSatisAraciFirmaVkn)
                .HasMaxLength(50)
                .HasColumnName("INTERNET_SATIS_ARACI_FIRMA_VKN");
            entity.Property(e => e.InternetSatisOdemeAciklamasi)
                .HasMaxLength(250)
                .HasColumnName("INTERNET_SATIS_ODEME_ACIKLAMASI");
            entity.Property(e => e.InternetSatisOdemeAraciFirmaAdi)
                .HasMaxLength(250)
                .HasColumnName("INTERNET_SATIS_ODEME_ARACI_FIRMA_ADI");
            entity.Property(e => e.InternetSatisOdemeSekli).HasColumnName("INTERNET_SATIS_ODEME_SEKLI");
            entity.Property(e => e.InternetSatisOdemeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("INTERNET_SATIS_ODEME_TARIHI");
            entity.Property(e => e.InternetSatisTuru).HasColumnName("INTERNET_SATIS_TURU");
            entity.Property(e => e.InternetSatisUlkeAdi)
                .HasMaxLength(50)
                .HasColumnName("INTERNET_SATIS_ULKE_ADI");
            entity.Property(e => e.InternetSatisWebAdresi)
                .HasMaxLength(50)
                .HasColumnName("INTERNET_SATIS_WEB_ADRESI");
            entity.Property(e => e.InternetUzerindenSatisMi).HasColumnName("INTERNET_UZERINDEN_SATIS_MI");
            entity.Property(e => e.IskontoOrani)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ISKONTO_ORANI");
            entity.Property(e => e.IskontoTutari)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ISKONTO_TUTARI");
            entity.Property(e => e.IstisnaKodu)
                .HasMaxLength(50)
                .HasColumnName("ISTISNA_KODU");
            entity.Property(e => e.KdvOrani)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KDV_ORANI");
            entity.Property(e => e.KdvTutari)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KDV_TUTARI");
            entity.Property(e => e.Kur)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KUR");
            entity.Property(e => e.MalHizmetTutari)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MAL_HIZMET_TUTARI");
            entity.Property(e => e.Miktar)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.ParaBirimi).HasColumnName("PARA_BIRIMI");
            entity.Property(e => e.ReferansNo)
                .HasMaxLength(50)
                .HasColumnName("REFERANS_NO");
            entity.Property(e => e.Soyadi)
                .HasMaxLength(250)
                .HasColumnName("SOYADI");
            entity.Property(e => e.TasiyiciFisNo)
                .HasMaxLength(50)
                .HasColumnName("TASIYICI_FIS_NO");
            entity.Property(e => e.TasiyiciGonderimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("TASIYICI_GONDERIM_TARIHI");
            entity.Property(e => e.TasiyiciKargoFirmaUnvani)
                .HasMaxLength(50)
                .HasColumnName("TASIYICI_KARGO_FIRMA_UNVANI");
            entity.Property(e => e.TasiyiciKargoFirmaVkn)
                .HasMaxLength(50)
                .HasColumnName("TASIYICI_KARGO_FIRMA_VKN");
            entity.Property(e => e.TasiyiciKargoTakipNo)
                .HasMaxLength(50)
                .HasColumnName("TASIYICI_KARGO_TAKIP_NO");
            entity.Property(e => e.TasiyiciUlkeAdi)
                .HasMaxLength(50)
                .HasColumnName("TASIYICI_ULKE_ADI");
            entity.Property(e => e.TelefonNo)
                .HasMaxLength(50)
                .HasColumnName("TELEFON_NO");
            entity.Property(e => e.Unvani)
                .HasMaxLength(50)
                .HasColumnName("UNVANI");
            entity.Property(e => e.VergiDairesi)
                .HasMaxLength(250)
                .HasColumnName("VERGI_DAIRESI");
            entity.Property(e => e.VknTckn)
                .HasMaxLength(50)
                .HasColumnName("VKN_TCKN");
        });

        modelBuilder.Entity<Entegrasyonlar>(entity =>
        {
            entity.HasKey(e => e.EntegrasyonId);

            entity.ToTable("ENTEGRASYONLAR");

            entity.Property(e => e.EntegrasyonId).HasColumnName("ENTEGRASYON_ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.BaseAdres)
                .HasMaxLength(150)
                .HasColumnName("BASE_ADRES");
            entity.Property(e => e.EntegrasyonAdi)
                .HasMaxLength(150)
                .HasColumnName("ENTEGRASYON_ADI");
            entity.Property(e => e.EntegrasyonUrl)
                .HasMaxLength(500)
                .HasColumnName("ENTEGRASYON_URL");
            entity.Property(e => e.KullaniciAdi)
                .HasMaxLength(50)
                .HasColumnName("KULLANICI_ADI");
            entity.Property(e => e.LoginUrl)
                .HasMaxLength(500)
                .HasColumnName("LOGIN_URL");
            entity.Property(e => e.Sifre)
                .HasMaxLength(50)
                .HasColumnName("SIFRE");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<Evrak>(entity =>
        {
            entity.ToTable("EVRAK");

            entity.Property(e => e.EvrakId).HasColumnName("EVRAK_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.BelgeNo)
                .HasMaxLength(250)
                .HasColumnName("BELGE_NO");
            entity.Property(e => e.BelgeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BELGE_TARIHI");
            entity.Property(e => e.BelgeTuruId).HasColumnName("BELGE_TURU_ID");
            entity.Property(e => e.BuroDosya)
                .HasMaxLength(50)
                .HasColumnName("BURO_DOSYA");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.DisKayitNo).HasColumnName("DIS_KAYIT_NO");
            entity.Property(e => e.EvrakTuruId).HasColumnName("EVRAK_TURU_ID");
            entity.Property(e => e.GeldigiGittigiKurumId).HasColumnName("GELDIGI_GITTIGI_KURUM_ID");
            entity.Property(e => e.GelenGidenKisiId).HasColumnName("GELEN_GIDEN_KISI_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.Konu)
                .HasMaxLength(250)
                .HasColumnName("KONU");
            entity.Property(e => e.KurumBelgeNo)
                .HasMaxLength(250)
                .HasColumnName("KURUM_BELGE_NO");
            entity.Property(e => e.KurumBelgeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KURUM_BELGE_TARIHI");
            entity.Property(e => e.ModulId).HasColumnName("MODUL_ID");
            entity.Property(e => e.OlusturanKullaniciId).HasColumnName("OLUSTURAN_KULLANICI_ID");
            entity.Property(e => e.SiraNo).HasColumnName("SIRA_NO");
            entity.Property(e => e.Yil).HasColumnName("YIL");

            entity.HasOne(d => d.BelgeTuru).WithMany(p => p.Evraks)
                .HasForeignKey(d => d.BelgeTuruId)
                .HasConstraintName("FK_EVRAK_BELGE_TURU");

            entity.HasOne(d => d.EvrakTuru).WithMany(p => p.Evraks)
                .HasForeignKey(d => d.EvrakTuruId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EVRAK_EVRAK_TURU");

            entity.HasOne(d => d.GeldigiGittigiKurum).WithMany(p => p.Evraks)
                .HasForeignKey(d => d.GeldigiGittigiKurumId)
                .HasConstraintName("FK_EVRAK_YP_KURUM_TANIMLARI");

            entity.HasOne(d => d.GelenGidenKisi).WithMany(p => p.Evraks)
                .HasForeignKey(d => d.GelenGidenKisiId)
                .HasConstraintName("FK_EVRAK_KISILER");
        });

        modelBuilder.Entity<EvrakBaglanti>(entity =>
        {
            entity.ToTable("EVRAK_BAGLANTI");

            entity.Property(e => e.EvrakBaglantiId).HasColumnName("EVRAK_BAGLANTI_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(300)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.DisKayitNo).HasColumnName("DIS_KAYIT_NO");
            entity.Property(e => e.DosyaAdi)
                .HasMaxLength(250)
                .HasColumnName("DOSYA_ADI");
            entity.Property(e => e.EvrakAdi)
                .HasMaxLength(250)
                .HasColumnName("EVRAK_ADI");
            entity.Property(e => e.EvrakId).HasColumnName("EVRAK_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.ModulId).HasColumnName("MODUL_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.EvrakBaglantis)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EVRAK_BAGLANTI_BUROLAR");

            entity.HasOne(d => d.Evrak).WithMany(p => p.EvrakBaglantis)
                .HasForeignKey(d => d.EvrakId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EVRAK_BAGLANTI_EVRAK");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.EvrakBaglantis)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EVRAK_BAGLANTI_KULLANICILAR");

            entity.HasOne(d => d.Modul).WithMany(p => p.EvrakBaglantis)
                .HasForeignKey(d => d.ModulId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EVRAK_BAGLANTI_MODULLER");
        });

        modelBuilder.Entity<EvrakDosya>(entity =>
        {
            entity.ToTable("EVRAK_DOSYA");

            entity.Property(e => e.EvrakDosyaId).HasColumnName("EVRAK_DOSYA_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.DosyaId).HasColumnName("DOSYA_ID");
            entity.Property(e => e.EvrakId).HasColumnName("EVRAK_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.EvrakDosyas)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EVRAK_DOSYA_BUROLAR");

            entity.HasOne(d => d.Dosya).WithMany(p => p.EvrakDosyas)
                .HasForeignKey(d => d.DosyaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EVRAK_DOSYA_DOSYALAR");

            entity.HasOne(d => d.Evrak).WithMany(p => p.EvrakDosyas)
                .HasForeignKey(d => d.EvrakId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EVRAK_DOSYA_EVRAK");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.EvrakDosyas)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EVRAK_DOSYA_KULLANICILAR");
        });

        modelBuilder.Entity<EvrakTuru>(entity =>
        {
            entity.ToTable("EVRAK_TURU");

            entity.Property(e => e.EvrakTuruId)
                .ValueGeneratedNever()
                .HasColumnName("EVRAK_TURU_ID");
            entity.Property(e => e.EvrakTuruAdi)
                .HasMaxLength(50)
                .HasColumnName("EVRAK_TURU_ADI");
        });

        modelBuilder.Entity<FaizOranlari>(entity =>
        {
            entity.HasKey(e => e.FaizOranId);

            entity.ToTable("FAIZ_ORANLARI");

            entity.Property(e => e.FaizOranId).HasColumnName("FAIZ_ORAN_ID");
            entity.Property(e => e.BaslangicTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BASLANGIC_TARIHI");
            entity.Property(e => e.BitisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BITIS_TARIHI");
            entity.Property(e => e.FaizId).HasColumnName("FAIZ_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.Oran)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ORAN");

            entity.HasOne(d => d.Faiz).WithMany(p => p.FaizOranlaris)
                .HasForeignKey(d => d.FaizId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAIZ_ORANLARI_FAIZLER");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.FaizOranlaris)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAIZ_ORANLARI_KULLANICILAR");
        });

        modelBuilder.Entity<FaizTurleri>(entity =>
        {
            entity.HasKey(e => e.FaizTuruId);

            entity.ToTable("FAIZ_TURLERI");

            entity.Property(e => e.FaizTuruId).HasColumnName("FAIZ_TURU_ID");
            entity.Property(e => e.FaizTuruAdi)
                .HasMaxLength(50)
                .HasColumnName("FAIZ_TURU_ADI");
        });

        modelBuilder.Entity<Faizler>(entity =>
        {
            entity.HasKey(e => e.FaizId);

            entity.ToTable("FAIZLER");

            entity.Property(e => e.FaizId).HasColumnName("FAIZ_ID");
            entity.Property(e => e.FaizAdi)
                .HasMaxLength(150)
                .HasColumnName("FAIZ_ADI");
            entity.Property(e => e.FaizTuruId).HasColumnName("FAIZ_TURU_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.OzelFaiz).HasColumnName("OZEL_FAIZ");

            entity.HasOne(d => d.FaizTuru).WithMany(p => p.Faizlers)
                .HasForeignKey(d => d.FaizTuruId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAIZLER_FAIZ_TURLERI");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.Faizlers)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAIZLER_KULLANICILAR");
        });

        modelBuilder.Entity<FaturaBilgileri>(entity =>
        {
            entity.HasKey(e => e.FaturaBilgiId);

            entity.ToTable("FATURA_BILGILERI");

            entity.Property(e => e.FaturaBilgiId).HasColumnName("FATURA_BILGI_ID");
            entity.Property(e => e.Adres)
                .HasMaxLength(400)
                .HasColumnName("ADRES");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.FaturaGonderilsin).HasColumnName("FATURA_GONDERILSIN");
            entity.Property(e => e.KulaniciId).HasColumnName("KULANICI_ID");
            entity.Property(e => e.Kurum).HasColumnName("KURUM");
            entity.Property(e => e.KurumAdi)
                .HasMaxLength(250)
                .HasColumnName("KURUM_ADI");
            entity.Property(e => e.VergiDairesi)
                .HasMaxLength(100)
                .HasColumnName("VERGI_DAIRESI");
            entity.Property(e => e.VergiNo)
                .HasMaxLength(100)
                .HasColumnName("VERGI_NO");

            entity.HasOne(d => d.Buro).WithMany(p => p.FaturaBilgileris)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FATURA_BILGILERI_BUROLAR");

            entity.HasOne(d => d.Kulanici).WithMany(p => p.FaturaBilgileris)
                .HasForeignKey(d => d.KulaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FATURA_BILGILERI_KULLANICILAR");
        });

        modelBuilder.Entity<FaturaIslemleri>(entity =>
        {
            entity.HasKey(e => e.FaturaIslemId);

            entity.ToTable("FATURA_ISLEMLERI");

            entity.Property(e => e.FaturaIslemId).HasColumnName("FATURA_ISLEM_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.CcLast4Num)
                .HasMaxLength(4)
                .HasColumnName("CC_LAST_4_NUM");
            entity.Property(e => e.DonusumDurumId).HasColumnName("DONUSUM_DURUM_ID");
            entity.Property(e => e.Durum).HasColumnName("DURUM");
            entity.Property(e => e.Ettn)
                .HasMaxLength(150)
                .HasColumnName("ETTN");
            entity.Property(e => e.FaturaNo)
                .HasMaxLength(50)
                .HasColumnName("FATURA_NO");
            entity.Property(e => e.HataMesaji)
                .HasMaxLength(250)
                .HasColumnName("HATA_MESAJI");
            entity.Property(e => e.IpAdresi)
                .HasMaxLength(50)
                .HasColumnName("IP_ADRESI");
            entity.Property(e => e.IslemTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ISLEM_TARIHI");
            entity.Property(e => e.IslemTuruId).HasColumnName("ISLEM_TURU_ID");
            entity.Property(e => e.IslemYapanKullaniciId).HasColumnName("ISLEM_YAPAN_KULLANICI_ID");
            entity.Property(e => e.KartTipi).HasColumnName("KART_TIPI");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.Tutar)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUTAR");

            entity.HasOne(d => d.Buro).WithMany(p => p.FaturaIslemleris)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FATURA_ISLEMLERI_BUROLAR");

            entity.HasOne(d => d.DonusumDurum).WithMany(p => p.FaturaIslemleris)
                .HasForeignKey(d => d.DonusumDurumId)
                .HasConstraintName("FK_FATURA_ISLEMLERI_DONUSUM_DURUMLARI");

            entity.HasOne(d => d.IslemTuru).WithMany(p => p.FaturaIslemleris)
                .HasForeignKey(d => d.IslemTuruId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FATURA_ISLEMLERI_YP_ISLEM_TURU");

            entity.HasOne(d => d.IslemYapanKullanici).WithMany(p => p.FaturaIslemleriIslemYapanKullanicis)
                .HasForeignKey(d => d.IslemYapanKullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FATURA_ISLEMLERI_KULLANICILAR1");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.FaturaIslemleriKullanicis)
                .HasForeignKey(d => d.KullaniciId)
                .HasConstraintName("FK_FATURA_ISLEMLERI_KULLANICILAR");
        });

        modelBuilder.Entity<GeciciDosyalar>(entity =>
        {
            entity.HasKey(e => e.GeciciDosyaId);

            entity.ToTable("GECICI_DOSYALAR");

            entity.Property(e => e.GeciciDosyaId).HasColumnName("GECICI_DOSYA_ID");
            entity.Property(e => e.DosyaYolu)
                .HasMaxLength(300)
                .HasColumnName("DOSYA_YOLU");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
        });

        modelBuilder.Entity<HarcTipleri>(entity =>
        {
            entity.HasKey(e => e.HarcTipiId);

            entity.ToTable("HARC_TIPLERI");

            entity.Property(e => e.HarcTipiId).HasColumnName("HARC_TIPI_ID");
            entity.Property(e => e.HarcTipiAdi)
                .HasMaxLength(100)
                .HasColumnName("HARC_TIPI_ADI");
        });

        modelBuilder.Entity<HarcUcretleri>(entity =>
        {
            entity.HasKey(e => e.HarcUcretId);

            entity.ToTable("HARC_UCRETLERI");

            entity.Property(e => e.HarcUcretId).HasColumnName("HARC_UCRET_ID");
            entity.Property(e => e.BaslangicTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BASLANGIC_TARIHI");
            entity.Property(e => e.BitisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BITIS_TARIHI");
            entity.Property(e => e.HarcTipiId).HasColumnName("HARC_TIPI_ID");
            entity.Property(e => e.HarcUcreti)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HARC_UCRETI");
            entity.Property(e => e.Oran)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ORAN");

            entity.HasOne(d => d.HarcTipi).WithMany(p => p.HarcUcretleris)
                .HasForeignKey(d => d.HarcTipiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HARC_UCRETLERI_HARC_TIPLERI");
        });

        modelBuilder.Entity<HesapTuru>(entity =>
        {
            entity.ToTable("HESAP_TURU");

            entity.Property(e => e.HesapTuruId)
                .ValueGeneratedNever()
                .HasColumnName("HESAP_TURU_ID");
            entity.Property(e => e.HesapTuruAdi)
                .HasMaxLength(50)
                .HasColumnName("HESAP_TURU_ADI");
        });

        modelBuilder.Entity<HizmetTipi>(entity =>
        {
            entity.ToTable("HIZMET_TIPI");

            entity.Property(e => e.HizmetTipiId).HasColumnName("HIZMET_TIPI_ID");
            entity.Property(e => e.HizmetTipiAdi)
                .HasMaxLength(150)
                .HasColumnName("HIZMET_TIPI_ADI");
        });

        modelBuilder.Entity<IcraDaireleri>(entity =>
        {
            entity.HasKey(e => e.IcraDaireId);

            entity.ToTable("ICRA_DAIRELERI");

            entity.Property(e => e.IcraDaireId).HasColumnName("ICRA_DAIRE_ID");
            entity.Property(e => e.BankaId).HasColumnName("BANKA_ID");
            entity.Property(e => e.BankaSubeId).HasColumnName("BANKA_SUBE_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.IbanNo)
                .HasMaxLength(50)
                .HasColumnName("IBAN_NO");
            entity.Property(e => e.IcraDaireAdi)
                .HasMaxLength(250)
                .HasColumnName("ICRA_DAIRE_ADI");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            entity.HasOne(d => d.Banka).WithMany(p => p.IcraDaireleriBankas)
                .HasForeignKey(d => d.BankaId)
                .HasConstraintName("FK_ICRA_DAIRELERI_YP_BANKALAR");

            entity.HasOne(d => d.BankaSube).WithMany(p => p.IcraDaireleriBankaSubes)
                .HasForeignKey(d => d.BankaSubeId)
                .HasConstraintName("FK_ICRA_DAIRELERI_YP_BANKALAR1");

            entity.HasOne(d => d.Buro).WithMany(p => p.IcraDaireleris)
                .HasForeignKey(d => d.BuroId)
                .HasConstraintName("FK_ICRA_DAIRELERI_BUROLAR");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.IcraDaireleris)
                .HasForeignKey(d => d.KullaniciId)
                .HasConstraintName("FK_ICRA_DAIRELERI_KULLANICILAR");
        });

        modelBuilder.Entity<IcraDosya>(entity =>
        {
            entity.ToTable("ICRA_DOSYA");

            entity.Property(e => e.IcraDosyaId).HasColumnName("ICRA_DOSYA_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.DosyaId).HasColumnName("DOSYA_ID");
            entity.Property(e => e.IcraId).HasColumnName("ICRA_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.IcraDosyas)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICRA_DOSYA_BUROLAR");

            entity.HasOne(d => d.Dosya).WithMany(p => p.IcraDosyas)
                .HasForeignKey(d => d.DosyaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICRA_DOSYA_DOSYALAR");

            entity.HasOne(d => d.Icra).WithMany(p => p.IcraDosyas)
                .HasForeignKey(d => d.IcraId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICRA_DOSYA_ICRALAR");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.IcraDosyas)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICRA_DOSYA_KULLANICILAR");
        });

        modelBuilder.Entity<IcraDurum>(entity =>
        {
            entity.ToTable("ICRA_DURUM");

            entity.Property(e => e.IcraDurumId)
                .ValueGeneratedNever()
                .HasColumnName("ICRA_DURUM_ID");
            entity.Property(e => e.IcraDurumAdi)
                .HasMaxLength(50)
                .HasColumnName("ICRA_DURUM_ADI");
        });

        modelBuilder.Entity<IcraKisiler>(entity =>
        {
            entity.HasKey(e => e.IcraKisiId);

            entity.ToTable("ICRA_KISILER");

            entity.Property(e => e.IcraKisiId).HasColumnName("ICRA_KISI_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(300)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Borclu).HasColumnName("BORCLU");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.DigerAciklama)
                .HasMaxLength(50)
                .HasColumnName("DIGER_ACIKLAMA");
            entity.Property(e => e.IcraId).HasColumnName("ICRA_ID");
            entity.Property(e => e.KarsiTarafAvukatAdSoyad)
                .HasMaxLength(150)
                .HasColumnName("KARSI_TARAF_AVUKAT_AD_SOYAD");
            entity.Property(e => e.KarsiTarafAvukatTelefon)
                .HasMaxLength(50)
                .HasColumnName("KARSI_TARAF_AVUKAT_TELEFON");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KisiId).HasColumnName("KISI_ID");
            entity.Property(e => e.KisiRolId).HasColumnName("KISI_ROL_ID");
            entity.Property(e => e.KisiSozlesmeId).HasColumnName("KISI_SOZLESME_ID");
            entity.Property(e => e.KisiVekaletId).HasColumnName("KISI_VEKALET_ID");
            entity.Property(e => e.OlusturanKullaniciId).HasColumnName("OLUSTURAN_KULLANICI_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.IcraKisilers)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICRA_KISILER_BUROLAR");

            entity.HasOne(d => d.Icra).WithMany(p => p.IcraKisilers)
                .HasForeignKey(d => d.IcraId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICRA_KISILER_ICRALAR");

            entity.HasOne(d => d.Kisi).WithMany(p => p.IcraKisilers)
                .HasForeignKey(d => d.KisiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICRA_KISILER_KISILER");

            entity.HasOne(d => d.KisiRol).WithMany(p => p.IcraKisilers)
                .HasForeignKey(d => d.KisiRolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICRA_KISILER_KISI_ROLLER");

            entity.HasOne(d => d.KisiSozlesme).WithMany(p => p.IcraKisilers)
                .HasForeignKey(d => d.KisiSozlesmeId)
                .HasConstraintName("FK_ICRA_KISILER_KISI_SOZLESMELER");

            entity.HasOne(d => d.KisiVekalet).WithMany(p => p.IcraKisilers)
                .HasForeignKey(d => d.KisiVekaletId)
                .HasConstraintName("FK_ICRA_KISILER_KISI_VEKALETLER");

            entity.HasOne(d => d.OlusturanKullanici).WithMany(p => p.IcraKisilers)
                .HasForeignKey(d => d.OlusturanKullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICRA_KISILER_KULLANICILAR");
        });

        modelBuilder.Entity<IcraTakipTuru>(entity =>
        {
            entity.ToTable("ICRA_TAKIP_TURU");

            entity.Property(e => e.IcraTakipTuruId)
                .ValueGeneratedNever()
                .HasColumnName("ICRA_TAKIP_TURU_ID");
            entity.Property(e => e.IcraTakipTuruAdi)
                .HasMaxLength(300)
                .HasColumnName("ICRA_TAKIP_TURU_ADI");
            entity.Property(e => e.Ilamli).HasColumnName("ILAMLI");
        });

        modelBuilder.Entity<Icralar>(entity =>
        {
            entity.HasKey(e => e.IcraId);

            entity.ToTable("ICRALAR");

            entity.Property(e => e.IcraId).HasColumnName("ICRA_ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.AnlasmaTutari)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("ANLASMA_TUTARI");
            entity.Property(e => e.ArsiveKaldirildi).HasColumnName("ARSIVE_KALDIRILDI");
            entity.Property(e => e.BorcunSebebi).HasColumnName("BORCUN_SEBEBI");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.DanismaId).HasColumnName("DANISMA_ID");
            entity.Property(e => e.DisKayitNo).HasColumnName("DIS_KAYIT_NO");
            entity.Property(e => e.DosyaNo)
                .HasMaxLength(50)
                .HasColumnName("DOSYA_NO");
            entity.Property(e => e.FoyNo).HasColumnName("FOY_NO");
            entity.Property(e => e.IcraDaireId).HasColumnName("ICRA_DAIRE_ID");
            entity.Property(e => e.IcraDurumId).HasColumnName("ICRA_DURUM_ID");
            entity.Property(e => e.IcraSiraNo).HasColumnName("ICRA_SIRA_NO");
            entity.Property(e => e.IcraTakipTuruId).HasColumnName("ICRA_TAKIP_TURU_ID");
            entity.Property(e => e.IlgilenAvukatId).HasColumnName("ILGILEN_AVUKAT_ID");
            entity.Property(e => e.InfazTarihi)
                .HasColumnType("datetime")
                .HasColumnName("INFAZ_TARIHI");
            entity.Property(e => e.ItirazTemyizAciklama).HasColumnName("ITIRAZ_TEMYIZ_ACIKLAMA");
            entity.Property(e => e.ItirazTemyizTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ITIRAZ_TEMYIZ_TARIHI");
            entity.Property(e => e.Kilit).HasColumnName("KILIT");
            entity.Property(e => e.OlusturanKullaniciId).HasColumnName("OLUSTURAN_KULLANICI_ID");
            entity.Property(e => e.OzelFoyNo)
                .HasMaxLength(50)
                .HasColumnName("OZEL_FOY_NO");
            entity.Property(e => e.SonIslemTarihi)
                .HasColumnType("datetime")
                .HasColumnName("SON_ISLEM_TARIHI");
            entity.Property(e => e.TakipTarihi)
                .HasColumnType("datetime")
                .HasColumnName("TAKIP_TARIHI");
            entity.Property(e => e.TakipTutari)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TAKIP_TUTARI");
            entity.Property(e => e.TakipYoluTuruId).HasColumnName("TAKIP_YOLU_TURU_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.Icralars)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICRALAR_BUROLAR");

            entity.HasOne(d => d.Danisma).WithMany(p => p.Icralars)
                .HasForeignKey(d => d.DanismaId)
                .HasConstraintName("FK_ICRALAR_DANISMA");

            entity.HasOne(d => d.IcraDaire).WithMany(p => p.Icralars)
                .HasForeignKey(d => d.IcraDaireId)
                .HasConstraintName("FK_ICRALAR_ICRA_DAIRELERI");

            entity.HasOne(d => d.IcraDurum).WithMany(p => p.Icralars)
                .HasForeignKey(d => d.IcraDurumId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICRALAR_ICRA_DURUM");

            entity.HasOne(d => d.IcraTakipTuru).WithMany(p => p.Icralars)
                .HasForeignKey(d => d.IcraTakipTuruId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICRALAR_ICRA_TAKIP_TURU");

            entity.HasOne(d => d.IlgilenAvukat).WithMany(p => p.IcralarIlgilenAvukats)
                .HasForeignKey(d => d.IlgilenAvukatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICRALAR_KULLANICILAR");

            entity.HasOne(d => d.OlusturanKullanici).WithMany(p => p.IcralarOlusturanKullanicis)
                .HasForeignKey(d => d.OlusturanKullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICRALAR_KULLANICILAR1");

            entity.HasOne(d => d.TakipYoluTuru).WithMany(p => p.Icralars)
                .HasForeignKey(d => d.TakipYoluTuruId)
                .HasConstraintName("FK_ICRALAR_TAKIP_YOLU_TURU");
        });

        modelBuilder.Entity<IletisimBilgileri>(entity =>
        {
            entity.ToTable("ILETISIM_BILGILERI");

            entity.Property(e => e.IletisimBilgileriId).HasColumnName("ILETISIM_BILGILERI_ID");
            entity.Property(e => e.Baslik)
                .HasMaxLength(250)
                .HasColumnName("BASLIK");
            entity.Property(e => e.IletisimBilgileriMetni).HasColumnName("ILETISIM_BILGILERI_METNI");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.IletisimBilgileris)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ILETISIM_BILGILERI_KULLANICILAR");
        });

        modelBuilder.Entity<Kesifler>(entity =>
        {
            entity.HasKey(e => e.KesifId);

            entity.ToTable("KESIFLER");

            entity.Property(e => e.KesifId).HasColumnName("KESIF_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(300)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.DavaId).HasColumnName("DAVA_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KesifTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KESIF_TARIHI");
            entity.Property(e => e.KesifYeri)
                .HasMaxLength(300)
                .HasColumnName("KESIF_YERI");
            entity.Property(e => e.NotId).HasColumnName("NOT_ID");
            entity.Property(e => e.OlusturanKullaniciId).HasColumnName("OLUSTURAN_KULLANICI_ID");
            entity.Property(e => e.UyariGunOnce).HasColumnName("UYARI_GUN_ONCE");
            entity.Property(e => e.UyariSonlandi).HasColumnName("UYARI_SONLANDI");
            entity.Property(e => e.UyariYapilsin).HasColumnName("UYARI_YAPILSIN");

            entity.HasOne(d => d.Buro).WithMany(p => p.Kesiflers)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KESIFLER_BUROLAR");

            entity.HasOne(d => d.Dava).WithMany(p => p.Kesiflers)
                .HasForeignKey(d => d.DavaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KESIFLER_DAVALAR");

            entity.HasOne(d => d.Not).WithMany(p => p.Kesiflers)
                .HasForeignKey(d => d.NotId)
                .HasConstraintName("FK_KESIFLER_NOTLAR");

            entity.HasOne(d => d.OlusturanKullanici).WithMany(p => p.Kesiflers)
                .HasForeignKey(d => d.OlusturanKullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KESIFLER_KULLANICILAR");
        });

        modelBuilder.Entity<KisiAdresler>(entity =>
        {
            entity.HasKey(e => e.KisiAdresId).HasName("PK_KISI_ADRELER");

            entity.ToTable("KISI_ADRESLER");

            entity.Property(e => e.KisiAdresId).HasColumnName("KISI_ADRES_ID");
            entity.Property(e => e.Adres)
                .HasMaxLength(300)
                .HasColumnName("ADRES");
            entity.Property(e => e.AdresTipiId).HasColumnName("ADRES_TIPI_ID");
            entity.Property(e => e.Birincil).HasColumnName("BIRINCIL");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.IlId).HasColumnName("IL_ID");
            entity.Property(e => e.IlceId).HasColumnName("ILCE_ID");
            entity.Property(e => e.KisiId).HasColumnName("KISI_ID");

            entity.HasOne(d => d.AdresTipi).WithMany(p => p.KisiAdreslers)
                .HasForeignKey(d => d.AdresTipiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KISI_ADRESLER_ADRES_TIPLERI");

            entity.HasOne(d => d.Buro).WithMany(p => p.KisiAdreslers)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KISI_ADRESLER_BUROLAR");

            entity.HasOne(d => d.Il).WithMany(p => p.KisiAdreslerIls)
                .HasForeignKey(d => d.IlId)
                .HasConstraintName("FK_KISI_ADRESLER_YP_IL_ILCE");

            entity.HasOne(d => d.Ilce).WithMany(p => p.KisiAdreslerIlces)
                .HasForeignKey(d => d.IlceId)
                .HasConstraintName("FK_KISI_ADRESLER_YP_IL_ILCE1");

            entity.HasOne(d => d.Kisi).WithMany(p => p.KisiAdreslers)
                .HasForeignKey(d => d.KisiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KISI_ADRESLER_KISILER");
        });

        modelBuilder.Entity<KisiRoller>(entity =>
        {
            entity.HasKey(e => e.KisiRolId);

            entity.ToTable("KISI_ROLLER");

            entity.Property(e => e.KisiRolId)
                .ValueGeneratedNever()
                .HasColumnName("KISI_ROL_ID");
            entity.Property(e => e.KisiRolAdi)
                .HasMaxLength(50)
                .HasColumnName("KISI_ROL_ADI");
        });

        modelBuilder.Entity<KisiSozlesmeDosya>(entity =>
        {
            entity.ToTable("KISI_SOZLESME_DOSYA");

            entity.Property(e => e.KisiSozlesmeDosyaId).HasColumnName("KISI_SOZLESME_DOSYA_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.DosyaId).HasColumnName("DOSYA_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KisiSozlesmeId).HasColumnName("KISI_SOZLESME_ID");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.KisiSozlesmeDosyas)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KISI_SOZLESME_DOSYA_BUROLAR");

            entity.HasOne(d => d.Dosya).WithMany(p => p.KisiSozlesmeDosyas)
                .HasForeignKey(d => d.DosyaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KISI_SOZLESME_DOSYA_DOSYALAR");

            entity.HasOne(d => d.KisiSozlesme).WithMany(p => p.KisiSozlesmeDosyas)
                .HasForeignKey(d => d.KisiSozlesmeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KISI_SOZLESME_DOSYA_KISI_SOZLESMELER");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.KisiSozlesmeDosyas)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KISI_SOZLESME_DOSYA_KULLANICILAR");
        });

        modelBuilder.Entity<KisiSozlesmeTaksitlendirme>(entity =>
        {
            entity.HasKey(e => e.KisiSozlesmeTaksitId);

            entity.ToTable("KISI_SOZLESME_TAKSITLENDIRME");

            entity.Property(e => e.KisiSozlesmeTaksitId).HasColumnName("KISI_SOZLESME_TAKSIT_ID");
            entity.Property(e => e.IslemTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ISLEM_TARIHI");
            entity.Property(e => e.KisiSozlesmeId).HasColumnName("KISI_SOZLESME_ID");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.OdemeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ODEME_TARIHI");
            entity.Property(e => e.Odendi).HasColumnName("ODENDI");
            entity.Property(e => e.TaksitBaslamaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("TAKSIT_BASLAMA_TARIHI");
            entity.Property(e => e.TaksitBitisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("TAKSIT_BITIS_TARIHI");
            entity.Property(e => e.TaksitTutar)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TAKSIT_TUTAR");

            entity.HasOne(d => d.KisiSozlesme).WithMany(p => p.KisiSozlesmeTaksitlendirmes)
                .HasForeignKey(d => d.KisiSozlesmeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KISI_SOZLESME_TAKSITLENDIRME_KISI_SOZLESMELER");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.KisiSozlesmeTaksitlendirmes)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KISI_SOZLESME_TAKSITLENDIRME_KULLANICILAR");
        });

        modelBuilder.Entity<KisiSozlesmeler>(entity =>
        {
            entity.HasKey(e => e.KisiSozlesmeId);

            entity.ToTable("KISI_SOZLESMELER");

            entity.Property(e => e.KisiSozlesmeId).HasColumnName("KISI_SOZLESME_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(300)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.GiderTutar)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GIDER_TUTAR");
            entity.Property(e => e.GiderTutarAciklama)
                .HasMaxLength(500)
                .HasColumnName("GIDER_TUTAR_ACIKLAMA");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KisiId).HasColumnName("KISI_ID");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.OdemeTuruId).HasColumnName("ODEME_TURU_ID");
            entity.Property(e => e.SozlesmeBaslangicTarihi)
                .HasColumnType("date")
                .HasColumnName("SOZLESME_BASLANGIC_TARIHI");
            entity.Property(e => e.SozlesmeBitisTarihi)
                .HasColumnType("date")
                .HasColumnName("SOZLESME_BITIS_TARIHI");
            entity.Property(e => e.SozlesmeOrani)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SOZLESME_ORANI");
            entity.Property(e => e.SozlesmeUcreti)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SOZLESME_UCRETI");

            entity.HasOne(d => d.Kisi).WithMany(p => p.KisiSozlesmelers)
                .HasForeignKey(d => d.KisiId)
                .HasConstraintName("FK_KISI_SOZLESMELER_KISILER");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.KisiSozlesmelers)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KISI_SOZLESMELER_KULLANICILAR");

            entity.HasOne(d => d.OdemeTuru).WithMany(p => p.KisiSozlesmelers)
                .HasForeignKey(d => d.OdemeTuruId)
                .HasConstraintName("FK_KISI_SOZLESMELER_ODEME_TURU");
        });

        modelBuilder.Entity<KisiTipi>(entity =>
        {
            entity.ToTable("KISI_TIPI");

            entity.Property(e => e.KisiTipiId)
                .ValueGeneratedNever()
                .HasColumnName("KISI_TIPI_ID");
            entity.Property(e => e.KisiTipiAdi)
                .HasMaxLength(50)
                .HasColumnName("KISI_TIPI_ADI");
        });

        modelBuilder.Entity<KisiVekaletDosya>(entity =>
        {
            entity.ToTable("KISI_VEKALET_DOSYA");

            entity.Property(e => e.KisiVekaletDosyaId).HasColumnName("KISI_VEKALET_DOSYA_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.DosyaId).HasColumnName("DOSYA_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KisiVekaletId).HasColumnName("KISI_VEKALET_ID");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.KisiVekaletDosyas)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KISI_VEKALET_DOSYA_BUROLAR");

            entity.HasOne(d => d.Dosya).WithMany(p => p.KisiVekaletDosyas)
                .HasForeignKey(d => d.DosyaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KISI_VEKALET_DOSYA_DOSYALAR");

            entity.HasOne(d => d.KisiVekalet).WithMany(p => p.KisiVekaletDosyas)
                .HasForeignKey(d => d.KisiVekaletId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KISI_VEKALET_DOSYA_KISI_VEKALETLER");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.KisiVekaletDosyas)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KISI_VEKALET_DOSYA_KULLANICILAR");
        });

        modelBuilder.Entity<KisiVekaletYetki>(entity =>
        {
            entity.ToTable("KISI_VEKALET_YETKI");

            entity.Property(e => e.KisiVekaletYetkiId).HasColumnName("KISI_VEKALET_YETKI_ID");
            entity.Property(e => e.KisiVekaletId).HasColumnName("KISI_VEKALET_ID");
            entity.Property(e => e.YetkiTuruId).HasColumnName("YETKI_TURU_ID");

            entity.HasOne(d => d.KisiVekalet).WithMany(p => p.KisiVekaletYetkis)
                .HasForeignKey(d => d.KisiVekaletId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KISI_VEKALET_YETKI_KISI_VEKALETLER");

            entity.HasOne(d => d.YetkiTuru).WithMany(p => p.KisiVekaletYetkis)
                .HasForeignKey(d => d.YetkiTuruId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KISI_VEKALET_YETKI_YETKI_TURU");
        });

        modelBuilder.Entity<KisiVekaletler>(entity =>
        {
            entity.HasKey(e => e.KisiVekaletId);

            entity.ToTable("KISI_VEKALETLER");

            entity.Property(e => e.KisiVekaletId).HasColumnName("KISI_VEKALET_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.KisiId).HasColumnName("KISI_ID");
            entity.Property(e => e.NoterlikAdi)
                .HasMaxLength(250)
                .HasColumnName("NOTERLIK_ADI");
            entity.Property(e => e.VekaletBitisTarihi)
                .HasColumnType("date")
                .HasColumnName("VEKALET_BITIS_TARIHI");
            entity.Property(e => e.VekaletDokumanDosyaYolu)
                .HasMaxLength(300)
                .HasColumnName("VEKALET_DOKUMAN_DOSYA_YOLU");
            entity.Property(e => e.VekaletTarihi)
                .HasColumnType("date")
                .HasColumnName("VEKALET_TARIHI");
            entity.Property(e => e.VekaletTuruId).HasColumnName("VEKALET_TURU_ID");
            entity.Property(e => e.YevmiyeNo)
                .HasMaxLength(50)
                .HasColumnName("YEVMIYE_NO");

            entity.HasOne(d => d.Buro).WithMany(p => p.KisiVekaletlers)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KISI_VEKALETLER_BUROLAR");

            entity.HasOne(d => d.Kisi).WithMany(p => p.KisiVekaletlers)
                .HasForeignKey(d => d.KisiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KISI_VEKALETLER_KISILER");

            entity.HasOne(d => d.VekaletTuru).WithMany(p => p.KisiVekaletlers)
                .HasForeignKey(d => d.VekaletTuruId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KISI_VEKALETLER_VEKALET_TURU");
        });

        modelBuilder.Entity<Kisiler>(entity =>
        {
            entity.HasKey(e => e.KisiId);

            entity.ToTable("KISILER");

            entity.Property(e => e.KisiId).HasColumnName("KISI_ID");
            entity.Property(e => e.Ad)
                .HasMaxLength(150)
                .HasColumnName("AD");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.CepTelefon)
                .HasMaxLength(50)
                .HasColumnName("CEP_TELEFON");
            entity.Property(e => e.Diger).HasColumnName("DIGER");
            entity.Property(e => e.DigerAciklama)
                .HasMaxLength(50)
                .HasColumnName("DIGER_ACIKLAMA");
            entity.Property(e => e.EPosta)
                .HasMaxLength(150)
                .HasColumnName("E_POSTA");
            entity.Property(e => e.Faks)
                .HasMaxLength(50)
                .HasColumnName("FAKS");
            entity.Property(e => e.KarsiTaraf).HasColumnName("KARSI_TARAF");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KisiSiraNo).HasColumnName("KISI_SIRA_NO");
            entity.Property(e => e.KisiTipiId).HasColumnName("KISI_TIPI_ID");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.MersisNo)
                .HasMaxLength(16)
                .HasColumnName("MERSIS_NO");
            entity.Property(e => e.Muvekkil).HasColumnName("MUVEKKIL");
            entity.Property(e => e.PasaportNo)
                .HasMaxLength(50)
                .HasColumnName("PASAPORT_NO");
            entity.Property(e => e.Soyad)
                .HasMaxLength(150)
                .HasColumnName("SOYAD");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(11)
                .HasColumnName("TC_KIMLIK_NO");
            entity.Property(e => e.Telefon)
                .HasMaxLength(50)
                .HasColumnName("TELEFON");
            entity.Property(e => e.TemsilTuruId).HasColumnName("TEMSIL_TURU_ID");
            entity.Property(e => e.TuzelKisiAdi)
                .HasMaxLength(300)
                .HasColumnName("TUZEL_KISI_ADI");
            entity.Property(e => e.VergiDairesi)
                .HasMaxLength(250)
                .HasColumnName("VERGI_DAIRESI");
            entity.Property(e => e.VergiNo)
                .HasMaxLength(50)
                .HasColumnName("VERGI_NO");
            entity.Property(e => e.YabanciUyrukluMu).HasColumnName("YABANCI_UYRUKLU_MU");
            entity.Property(e => e.YasalTemsilciAd)
                .HasMaxLength(150)
                .HasColumnName("YASAL_TEMSILCI_AD");
            entity.Property(e => e.YasalTemsilciSoyad)
                .HasMaxLength(150)
                .HasColumnName("YASAL_TEMSILCI_SOYAD");

            entity.HasOne(d => d.Buro).WithMany(p => p.Kisilers)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KISILER_BUROLAR");

            entity.HasOne(d => d.KisiTipi).WithMany(p => p.Kisilers)
                .HasForeignKey(d => d.KisiTipiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KISILER_KISI_TIPI");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.Kisilers)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KISILER_KULLANICILAR");

            entity.HasOne(d => d.TemsilTuru).WithMany(p => p.Kisilers)
                .HasForeignKey(d => d.TemsilTuruId)
                .HasConstraintName("FK_KISILER_YASAL_TEMSIL_TURLERI");
        });

        modelBuilder.Entity<KrediKartiIslemleri>(entity =>
        {
            entity.ToTable("KREDI_KARTI_ISLEMLERI");

            entity.Property(e => e.KrediKartiIslemleriId).HasColumnName("KREDI_KARTI_ISLEMLERI_ID");
            entity.Property(e => e.CcLast4Num)
                .HasMaxLength(50)
                .HasColumnName("CC_LAST_4_NUM");
            entity.Property(e => e.IpAdresi)
                .HasMaxLength(50)
                .HasColumnName("IP_ADRESI");
            entity.Property(e => e.IslemTuruId).HasColumnName("ISLEM_TURU_ID");
            entity.Property(e => e.KartSahibiAdSoyad)
                .HasMaxLength(150)
                .HasColumnName("KART_SAHIBI_AD_SOYAD");
            entity.Property(e => e.KartSahibiCepTelefon)
                .HasMaxLength(50)
                .HasColumnName("KART_SAHIBI_CEP_TELEFON");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(11)
                .HasColumnName("TC_KIMLIK_NO");

            entity.HasOne(d => d.IslemTuru).WithMany(p => p.KrediKartiIslemleris)
                .HasForeignKey(d => d.IslemTuruId)
                .HasConstraintName("FK_KREDI_KARTI_ISLEMLERI_YP_ISLEM_TURU");
        });

        modelBuilder.Entity<KrediKartiIslemleriLog>(entity =>
        {
            entity.HasKey(e => e.KrediKartiIslemLogId);

            entity.ToTable("KREDI_KARTI_ISLEMLERI_LOG");

            entity.Property(e => e.KrediKartiIslemLogId).HasColumnName("KREDI_KARTI_ISLEM_LOG_ID");
            entity.Property(e => e.BasariDurumu).HasColumnName("BASARI_DURUMU");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.DekontId)
                .HasMaxLength(50)
                .HasColumnName("DEKONT_ID");
            entity.Property(e => e.Guid)
                .HasMaxLength(150)
                .HasColumnName("GUID");
            entity.Property(e => e.IslemId).HasColumnName("ISLEM_ID");
            entity.Property(e => e.IslemTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ISLEM_TARIHI");
            entity.Property(e => e.KartTipi).HasColumnName("KART_TIPI");
            entity.Property(e => e.KrediKartiSon4Hane)
                .HasMaxLength(4)
                .HasColumnName("KREDI_KARTI_SON4_HANE");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.OdemeTutari)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ODEME_TUTARI");
            entity.Property(e => e.SiparisId)
                .HasMaxLength(50)
                .HasColumnName("SIPARIS_ID");
            entity.Property(e => e.SonucAciklama)
                .HasMaxLength(500)
                .HasColumnName("SONUC_ACIKLAMA");
            entity.Property(e => e.TahsilatTutari)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TAHSILAT_TUTARI");

            entity.HasOne(d => d.Buro).WithMany(p => p.KrediKartiIslemleriLogs)
                .HasForeignKey(d => d.BuroId)
                .HasConstraintName("FK_KREDI_KARTI_ISLEMLERI_LOG_BUROLAR");

            entity.HasOne(d => d.Islem).WithMany(p => p.KrediKartiIslemleriLogs)
                .HasForeignKey(d => d.IslemId)
                .HasConstraintName("FK_KREDI_KARTI_ISLEMLERI_LOG_KREDI_KARTI_ISLEMLERI");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.KrediKartiIslemleriLogs)
                .HasForeignKey(d => d.KullaniciId)
                .HasConstraintName("FK_KREDI_KARTI_ISLEMLERI_LOG_KULLANICILAR");
        });

        modelBuilder.Entity<KrediYuklemeIslemleri>(entity =>
        {
            entity.ToTable("KREDI_YUKLEME_ISLEMLERI");

            entity.Property(e => e.KrediYuklemeIslemleriId).HasColumnName("KREDI_YUKLEME_ISLEMLERI_ID");
            entity.Property(e => e.AuthCode)
                .HasMaxLength(50)
                .HasColumnName("AUTH_CODE");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.CcLast4Num)
                .HasMaxLength(50)
                .HasColumnName("CC_LAST_4_NUM");
            entity.Property(e => e.ErrMsg).HasColumnName("ERR_MSG");
            entity.Property(e => e.HostRefNum)
                .HasMaxLength(50)
                .HasColumnName("HOST_REF_NUM");
            entity.Property(e => e.IpAdresi)
                .HasMaxLength(50)
                .HasColumnName("IP_ADRESI");
            entity.Property(e => e.IslemDurumu).HasColumnName("ISLEM_DURUMU");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.OrderId)
                .HasMaxLength(50)
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.ProcReturnCode)
                .HasMaxLength(50)
                .HasColumnName("PROC_RETURN_CODE");
            entity.Property(e => e.Response)
                .HasMaxLength(50)
                .HasColumnName("RESPONSE");
            entity.Property(e => e.TransId)
                .HasMaxLength(50)
                .HasColumnName("TRANS_ID");
            entity.Property(e => e.YuklemeTutari)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("YUKLEME_TUTARI");

            entity.HasOne(d => d.Buro).WithMany(p => p.KrediYuklemeIslemleris)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KREDI_YUKLEME_ISLEMLERI_KREDI_YUKLEME_ISLEMLERI");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.KrediYuklemeIslemleris)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KREDI_YUKLEME_ISLEMLERI_KULLANICILAR");
        });

        modelBuilder.Entity<KullaniciGecici>(entity =>
        {
            entity.ToTable("KULLANICI_GECICI");

            entity.Property(e => e.KullaniciGeciciId).HasColumnName("KULLANICI_GECICI_ID");
            entity.Property(e => e.Ad)
                .HasMaxLength(70)
                .HasColumnName("AD");
            entity.Property(e => e.Adres)
                .HasMaxLength(300)
                .HasColumnName("ADRES");
            entity.Property(e => e.IlId).HasColumnName("IL_ID");
            entity.Property(e => e.IlceId).HasColumnName("ILCE_ID");
            entity.Property(e => e.IslemId).HasColumnName("ISLEM_ID");
            entity.Property(e => e.KullaniciCepTelefon)
                .HasMaxLength(50)
                .HasColumnName("KULLANICI_CEP_TELEFON");
            entity.Property(e => e.KullaniciEposta)
                .HasMaxLength(70)
                .HasColumnName("KULLANICI_EPOSTA");
            entity.Property(e => e.KullaniciSifre)
                .HasMaxLength(250)
                .HasColumnName("KULLANICI_SIFRE");
            entity.Property(e => e.KullaniciTipiId).HasColumnName("KULLANICI_TIPI_ID");
            entity.Property(e => e.Soyad)
                .HasMaxLength(70)
                .HasColumnName("SOYAD");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(11)
                .HasColumnName("TC_KIMLIK_NO");

            entity.HasOne(d => d.Islem).WithMany(p => p.KullaniciGecicis)
                .HasForeignKey(d => d.IslemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KULLANICI_GECICI_KREDI_KARTI_ISLEMLERI");
        });

        modelBuilder.Entity<KullaniciIslemTuru>(entity =>
        {
            entity.ToTable("KULLANICI_ISLEM_TURU");

            entity.Property(e => e.KullaniciIslemTuruId)
                .ValueGeneratedNever()
                .HasColumnName("KULLANICI_ISLEM_TURU_ID");
            entity.Property(e => e.KullaniciIslemTuruAdi)
                .HasMaxLength(50)
                .HasColumnName("KULLANICI_ISLEM_TURU_ADI");
        });

        modelBuilder.Entity<KullaniciKredi>(entity =>
        {
            entity.ToTable("KULLANICI_KREDI");

            entity.Property(e => e.KullaniciKrediId).HasColumnName("KULLANICI_KREDI_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.Kredi)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("KREDI");
            entity.Property(e => e.KrediSahipTipiId).HasColumnName("KREDI_SAHIP_TIPI_ID");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.KullanimdakiKredi)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("KULLANIMDAKI_KREDI");

            entity.HasOne(d => d.Buro).WithMany(p => p.KullaniciKredis)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KULLANICI_KREDI_BUROLAR");

            entity.HasOne(d => d.KrediSahipTipi).WithMany(p => p.KullaniciKredis)
                .HasForeignKey(d => d.KrediSahipTipiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KULLANICI_KREDI_YP_KREDI_SAHIP_TIPLERI");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.KullaniciKredis)
                .HasForeignKey(d => d.KullaniciId)
                .HasConstraintName("FK_KULLANICI_KREDI_KULLANICI_KREDI");
        });

        modelBuilder.Entity<KullaniciLog>(entity =>
        {
            entity.ToTable("KULLANICI_LOG");

            entity.Property(e => e.KullaniciLogId).HasColumnName("KULLANICI_LOG_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(300)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.ErisilenIp)
                .HasMaxLength(150)
                .HasColumnName("ERISILEN_IP");
            entity.Property(e => e.FormId).HasColumnName("FORM_ID");
            entity.Property(e => e.IslemTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ISLEM_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.KullaniciIslemTuruId).HasColumnName("KULLANICI_ISLEM_TURU_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.KullaniciLogs)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KULLANICI_LOG_BUROLAR");

            entity.HasOne(d => d.Form).WithMany(p => p.KullaniciLogs)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KULLANICI_LOG_FORMLAR");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.KullaniciLogs)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KULLANICI_LOG_KULLANICILAR");

            entity.HasOne(d => d.KullaniciIslemTuru).WithMany(p => p.KullaniciLogs)
                .HasForeignKey(d => d.KullaniciIslemTuruId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KULLANICI_LOG_KULLANICI_ISLEM_TURU");
        });

        modelBuilder.Entity<KullaniciRehber>(entity =>
        {
            entity.ToTable("KULLANICI_REHBER");

            entity.Property(e => e.KullaniciRehberId).HasColumnName("KULLANICI_REHBER_ID");
            entity.Property(e => e.AdSoyad)
                .HasMaxLength(150)
                .HasColumnName("AD_SOYAD");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KayitliKullaniciId).HasColumnName("KAYITLI_KULLANICI_ID");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.Telefon)
                .HasMaxLength(50)
                .HasColumnName("TELEFON");

            entity.HasOne(d => d.Buro).WithMany(p => p.KullaniciRehbers)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KULLANICI_REHBER_BUROLAR");

            entity.HasOne(d => d.KayitliKullanici).WithMany(p => p.KullaniciRehberKayitliKullanicis)
                .HasForeignKey(d => d.KayitliKullaniciId)
                .HasConstraintName("FK_KULLANICI_REHBER_KULLANICILAR1");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.KullaniciRehberKullanicis)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KULLANICI_REHBER_KULLANICILAR");
        });

        modelBuilder.Entity<KullaniciRehberGrupKisileri>(entity =>
        {
            entity.ToTable("KULLANICI_REHBER_GRUP_KISILERI");

            entity.Property(e => e.KullaniciRehberGrupKisileriId).HasColumnName("KULLANICI_REHBER_GRUP_KISILERI_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KayitliKullaniciId).HasColumnName("KAYITLI_KULLANICI_ID");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.KullaniciRehberGrupId).HasColumnName("KULLANICI_REHBER_GRUP_ID");
            entity.Property(e => e.KullaniciRehberId).HasColumnName("KULLANICI_REHBER_ID");

            entity.HasOne(d => d.KayitliKullanici).WithMany(p => p.KullaniciRehberGrupKisileris)
                .HasForeignKey(d => d.KayitliKullaniciId)
                .HasConstraintName("FK_KULLANICI_REHBER_GRUP_KISILERI_KULLANICILAR");

            entity.HasOne(d => d.KullaniciRehber).WithMany(p => p.KullaniciRehberGrupKisileris)
                .HasForeignKey(d => d.KullaniciRehberId)
                .HasConstraintName("FK_KULLANICI_REHBER_GRUP_KISILERI_KULLANICI_REHBER");
        });

        modelBuilder.Entity<KullaniciRehberGruplari>(entity =>
        {
            entity.HasKey(e => e.KullaniciRehberGrupId);

            entity.ToTable("KULLANICI_REHBER_GRUPLARI");

            entity.Property(e => e.KullaniciRehberGrupId).HasColumnName("KULLANICI_REHBER_GRUP_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.GrupAdi)
                .HasMaxLength(300)
                .HasColumnName("GRUP_ADI");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KisiSayisi).HasColumnName("KISI_SAYISI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.KullaniciRehberGruplaris)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KULLANICI_REHBER_GRUPLARI_BUROLAR");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.KullaniciRehberGruplaris)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KULLANICI_REHBER_GRUPLARI_KULLANICILAR");
        });

        modelBuilder.Entity<KullaniciResim>(entity =>
        {
            entity.ToTable("KULLANICI_RESIM");

            entity.Property(e => e.KullaniciResimId).HasColumnName("KULLANICI_RESIM_ID");
            entity.Property(e => e.ResimBuyuk).HasColumnName("RESIM_BUYUK");
            entity.Property(e => e.ResimKucuk).HasColumnName("RESIM_KUCUK");
        });

        modelBuilder.Entity<KullaniciSmsLog>(entity =>
        {
            entity.ToTable("KULLANICI_SMS_LOG");

            entity.Property(e => e.KullaniciSmsLogId).HasColumnName("KULLANICI_SMS_LOG_ID");
            entity.Property(e => e.BasariDurumu).HasColumnName("BASARI_DURUMU");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.CepTelefon).HasColumnName("CEP_TELEFON");
            entity.Property(e => e.DisKayitNo).HasColumnName("DIS_KAYIT_NO");
            entity.Property(e => e.DosyaId)
                .HasComment("kurum dışında gönderimler yapıldığında cep telefon üzerinden gönderim yapılacak")
                .HasColumnName("DOSYA_ID");
            entity.Property(e => e.IslemYapanKullaniciId).HasColumnName("ISLEM_YAPAN_KULLANICI_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KisiId).HasColumnName("KISI_ID");
            entity.Property(e => e.KrediSahipTipiId).HasColumnName("KREDI_SAHIP_TIPI_ID");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.ModulId).HasColumnName("MODUL_ID");
            entity.Property(e => e.SmsAdet).HasColumnName("SMS_ADET");
            entity.Property(e => e.SmsDurumId).HasColumnName("SMS_DURUM_ID");
            entity.Property(e => e.SmsMetni)
                .HasMaxLength(500)
                .HasColumnName("SMS_METNI");
            entity.Property(e => e.SmsSonucId).HasColumnName("SMS_SONUC_ID");
            entity.Property(e => e.SmsTuruId).HasColumnName("SMS_TURU_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.KullaniciSmsLogs)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KULLANICI_SMS_LOG_BUROLAR");

            entity.HasOne(d => d.Dosya).WithMany(p => p.KullaniciSmsLogs)
                .HasForeignKey(d => d.DosyaId)
                .HasConstraintName("FK_KULLANICI_SMS_LOG_DOSYALAR");

            entity.HasOne(d => d.IslemYapanKullanici).WithMany(p => p.KullaniciSmsLogIslemYapanKullanicis)
                .HasForeignKey(d => d.IslemYapanKullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KULLANICI_SMS_LOG_KULLANICILAR1");

            entity.HasOne(d => d.Kisi).WithMany(p => p.KullaniciSmsLogs)
                .HasForeignKey(d => d.KisiId)
                .HasConstraintName("FK_KULLANICI_SMS_LOG_KISILER");

            entity.HasOne(d => d.KrediSahipTipi).WithMany(p => p.KullaniciSmsLogs)
                .HasForeignKey(d => d.KrediSahipTipiId)
                .HasConstraintName("FK_KULLANICI_SMS_LOG_YP_KREDI_SAHIP_TIPLERI");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.KullaniciSmsLogKullanicis)
                .HasForeignKey(d => d.KullaniciId)
                .HasConstraintName("FK_KULLANICI_SMS_LOG_KULLANICILAR");

            entity.HasOne(d => d.SmsDurum).WithMany(p => p.KullaniciSmsLogs)
                .HasForeignKey(d => d.SmsDurumId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KULLANICI_SMS_LOG_YP_SMS_DURUM");

            entity.HasOne(d => d.SmsTuru).WithMany(p => p.KullaniciSmsLogs)
                .HasForeignKey(d => d.SmsTuruId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KULLANICI_SMS_LOG_YP_SMS_TURU");
        });

        modelBuilder.Entity<KullaniciSmsSablon>(entity =>
        {
            entity.ToTable("KULLANICI_SMS_SABLON");

            entity.Property(e => e.KullaniciSmsSablonId).HasColumnName("KULLANICI_SMS_SABLON_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.Mesaj)
                .HasMaxLength(500)
                .HasColumnName("MESAJ");
            entity.Property(e => e.SmsSablonKategoriId).HasColumnName("SMS_SABLON_KATEGORI_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.KullaniciSmsSablons)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KULLANICI_SMS_SABLON_BUROLAR");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.KullaniciSmsSablons)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KULLANICI_SMS_SABLON_KULLANICILAR");

            entity.HasOne(d => d.SmsSablonKategori).WithMany(p => p.KullaniciSmsSablons)
                .HasForeignKey(d => d.SmsSablonKategoriId)
                .HasConstraintName("FK_KULLANICI_SMS_SABLON_KULLANICI_SMS_SABLON_KATEGORI");
        });

        modelBuilder.Entity<KullaniciSmsSablonKategori>(entity =>
        {
            entity.ToTable("KULLANICI_SMS_SABLON_KATEGORI");

            entity.Property(e => e.KullaniciSmsSablonKategoriId).HasColumnName("KULLANICI_SMS_SABLON_KATEGORI_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.KategoriAdi)
                .HasMaxLength(300)
                .HasColumnName("KATEGORI_ADI");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.KullaniciSmsSablonKategoris)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KULLANICI_SMS_SABLON_KATEGORI_BUROLAR");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.KullaniciSmsSablonKategoris)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KULLANICI_SMS_SABLON_KATEGORI_KULLANICILAR");
        });

        modelBuilder.Entity<KullaniciTercihleri>(entity =>
        {
            entity.HasKey(e => e.TercihId);

            entity.ToTable("KULLANICI_TERCIHLERI");

            entity.Property(e => e.TercihId).HasColumnName("TERCIH_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.Deger)
                .HasMaxLength(50)
                .HasColumnName("DEGER");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.TercihAciklama)
                .HasMaxLength(400)
                .HasColumnName("TERCIH_ACIKLAMA");
            entity.Property(e => e.TercihAdi)
                .HasMaxLength(50)
                .HasColumnName("TERCIH_ADI");
            entity.Property(e => e.TercihTuruId).HasColumnName("TERCIH_TURU_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.KullaniciTercihleris)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KULLANICI_TERCIHLERI_BUROLAR");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.KullaniciTercihleris)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KULLANICI_TERCIHLERI_KULLANICILAR");

            entity.HasOne(d => d.TercihTuru).WithMany(p => p.KullaniciTercihleris)
                .HasForeignKey(d => d.TercihTuruId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KULLANICI_TERCIHLERI_YP_KULLANICI_TERCIH_TURU");
        });

        modelBuilder.Entity<Kullanicilar>(entity =>
        {
            entity.HasKey(e => e.KullaniciId);

            entity.ToTable("KULLANICILAR");

            entity.HasIndex(e => new { e.KullaniciAdi, e.KullaniciSifre }, "IX_KULLANICILAR");

            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.Ad)
                .HasMaxLength(70)
                .HasColumnName("AD");
            entity.Property(e => e.Adres)
                .HasMaxLength(300)
                .HasColumnName("ADRES");
            entity.Property(e => e.AktivasyonTarihi)
                .HasColumnType("datetime")
                .HasColumnName("AKTIVASYON_TARIHI");
            entity.Property(e => e.AvukatOrtakDurumu).HasColumnName("AVUKAT_ORTAK_DURUMU");
            entity.Property(e => e.BankaKodu).HasColumnName("BANKA_KODU");
            entity.Property(e => e.BankaSubeKodu).HasColumnName("BANKA_SUBE_KODU");
            entity.Property(e => e.BaroSicilNo).HasColumnName("BARO_SICIL_NO");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.Cinsiyet)
                .HasMaxLength(1)
                .HasColumnName("CINSIYET");
            entity.Property(e => e.DisKullaniciId).HasColumnName("DIS_KULLANICI_ID");
            entity.Property(e => e.DogumTarihi)
                .HasColumnType("date")
                .HasColumnName("DOGUM_TARIHI");
            entity.Property(e => e.IbanNo)
                .HasMaxLength(50)
                .HasColumnName("IBAN_NO");
            entity.Property(e => e.IlId).HasColumnName("IL_ID");
            entity.Property(e => e.IlceId).HasColumnName("ILCE_ID");
            entity.Property(e => e.KapatilmaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAPATILMA_TARIHI");
            entity.Property(e => e.KullaniciAdi)
                .HasMaxLength(50)
                .HasColumnName("KULLANICI_ADI");
            entity.Property(e => e.KullaniciCepTelefon)
                .HasMaxLength(50)
                .HasColumnName("KULLANICI_CEP_TELEFON");
            entity.Property(e => e.KullaniciDurumId).HasColumnName("KULLANICI_DURUM_ID");
            entity.Property(e => e.KullaniciEposta)
                .HasMaxLength(70)
                .HasColumnName("KULLANICI_EPOSTA");
            entity.Property(e => e.KullaniciFaks)
                .HasMaxLength(50)
                .HasColumnName("KULLANICI_FAKS");
            entity.Property(e => e.KullaniciResimId).HasColumnName("KULLANICI_RESIM_ID");
            entity.Property(e => e.KullaniciSifre)
                .HasMaxLength(250)
                .HasColumnName("KULLANICI_SIFRE");
            entity.Property(e => e.KullaniciTelefon)
                .HasMaxLength(50)
                .HasColumnName("KULLANICI_TELEFON");
            entity.Property(e => e.KullaniciTipiId).HasColumnName("KULLANICI_TIPI_ID");
            entity.Property(e => e.OtpBlok).HasColumnName("OTP_BLOK");
            entity.Property(e => e.SistemBasvuruTarihi)
                .HasColumnType("date")
                .HasColumnName("SISTEM_BASVURU_TARIHI");
            entity.Property(e => e.SmsBaslik)
                .HasMaxLength(15)
                .HasColumnName("SMS_BASLIK");
            entity.Property(e => e.Soyad)
                .HasMaxLength(70)
                .HasColumnName("SOYAD");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(11)
                .HasColumnName("TC_KIMLIK_NO");
            entity.Property(e => e.YetkiliAvukat).HasColumnName("YETKILI_AVUKAT");

            entity.HasOne(d => d.Buro).WithMany(p => p.Kullanicilars)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KULLANICILAR_BUROLAR");

            entity.HasOne(d => d.Il).WithMany(p => p.KullanicilarIls)
                .HasForeignKey(d => d.IlId)
                .HasConstraintName("FK_KULLANICILAR_YP_IL_ILCE");

            entity.HasOne(d => d.Ilce).WithMany(p => p.KullanicilarIlces)
                .HasForeignKey(d => d.IlceId)
                .HasConstraintName("FK_KULLANICILAR_YP_IL_ILCE1");

            entity.HasOne(d => d.KullaniciDurum).WithMany(p => p.Kullanicilars)
                .HasForeignKey(d => d.KullaniciDurumId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KULLANICILAR_YP_KULLANICI_DURUMLARI");

            entity.HasOne(d => d.KullaniciResim).WithMany(p => p.Kullanicilars)
                .HasForeignKey(d => d.KullaniciResimId)
                .HasConstraintName("FK_KULLANICILAR_KULLANICI_RESIM");

            entity.HasOne(d => d.KullaniciTipi).WithMany(p => p.Kullanicilars)
                .HasForeignKey(d => d.KullaniciTipiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KULLANICILAR_YP_KULLANICI_TIPLERI");
        });

        modelBuilder.Entity<Kutuphaneler>(entity =>
        {
            entity.HasKey(e => e.KutuphaneId);

            entity.ToTable("KUTUPHANELER");

            entity.Property(e => e.KutuphaneId).HasColumnName("KUTUPHANE_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.GunlukCeza)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GUNLUK_CEZA");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.KutuphaneAdi)
                .HasMaxLength(300)
                .HasColumnName("KUTUPHANE_ADI");
            entity.Property(e => e.KutuphaneAdres).HasColumnName("KUTUPHANE_ADRES");
            entity.Property(e => e.KutuphaneKodu)
                .HasMaxLength(300)
                .HasColumnName("KUTUPHANE_KODU");
            entity.Property(e => e.KutuphaneTelefon)
                .HasMaxLength(50)
                .HasColumnName("KUTUPHANE_TELEFON");
            entity.Property(e => e.Opsiyon).HasColumnName("OPSIYON");
            entity.Property(e => e.UstKutuphaneId).HasColumnName("UST_KUTUPHANE_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.Kutuphanelers)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KUTUPHANELER_BUROLAR");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.Kutuphanelers)
                .HasForeignKey(d => d.KullaniciId)
                .HasConstraintName("FK_KUTUPHANELER_KULLANICILAR");

            entity.HasOne(d => d.UstKutuphane).WithMany(p => p.InverseUstKutuphane)
                .HasForeignKey(d => d.UstKutuphaneId)
                .HasConstraintName("FK_KUTUPHANELER_KUTUPHANELER");
        });

        modelBuilder.Entity<Lokasyonlar>(entity =>
        {
            entity.HasKey(e => e.LokasyonId);

            entity.ToTable("LOKASYONLAR");

            entity.Property(e => e.LokasyonId).HasColumnName("LOKASYON_ID");
            entity.Property(e => e.AltLokasyonId).HasColumnName("ALT_LOKASYON_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.LokasyonAdi).HasColumnName("LOKASYON_ADI");

            entity.HasOne(d => d.AltLokasyon).WithMany(p => p.InverseAltLokasyon)
                .HasForeignKey(d => d.AltLokasyonId)
                .HasConstraintName("FK_LOKASYONLAR_LOKASYONLAR");

            entity.HasOne(d => d.Buro).WithMany(p => p.Lokasyonlars)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOKASYONLAR_BUROLAR");
        });

        modelBuilder.Entity<MaktuVekaletUcretleri>(entity =>
        {
            entity.HasKey(e => e.MaktuVekaletUcretId);

            entity.ToTable("MAKTU_VEKALET_UCRETLERI");

            entity.Property(e => e.MaktuVekaletUcretId).HasColumnName("MAKTU_VEKALET_UCRET_ID");
            entity.Property(e => e.BaslangicTarihi)
                .HasColumnType("date")
                .HasColumnName("BASLANGIC_TARIHI");
            entity.Property(e => e.BitisTarihi)
                .HasColumnType("date")
                .HasColumnName("BITIS_TARIHI");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.Tutar)
                .HasColumnType("money")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<ModalDuyuru>(entity =>
        {
            entity.ToTable("MODAL_DUYURU");

            entity.Property(e => e.ModalDuyuruId).HasColumnName("MODAL_DUYURU_ID");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.ModalDuyuruDetayId).HasColumnName("MODAL_DUYURU_DETAY_ID");
            entity.Property(e => e.OkumaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("OKUMA_TARIHI");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.ModalDuyurus)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MODAL_DUYURU_KULLANICILAR");
        });

        modelBuilder.Entity<ModalDuyuruDetaylari>(entity =>
        {
            entity.HasKey(e => e.ModalDuyuruDetayId).HasName("PK__MODAL_DU__BC10910D11AFCA96");

            entity.ToTable("MODAL_DUYURU_DETAYLARI");

            entity.Property(e => e.ModalDuyuruDetayId).HasColumnName("MODAL_DUYURU_DETAY_ID");
            entity.Property(e => e.AktifMi).HasColumnName("AKTIF_MI");
            entity.Property(e => e.BaslangicTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BASLANGIC_TARIHI");
            entity.Property(e => e.BitisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BITIS_TARIHI");
            entity.Property(e => e.Detay).HasColumnName("DETAY");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.Konu).HasColumnName("KONU");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.KullaniciTipiId).HasColumnName("KULLANICI_TIPI_ID");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.ModalDuyuruDetaylaris)
                .HasForeignKey(d => d.KullaniciId)
                .HasConstraintName("FK__MODAL_DUY__KULLA__5C2D8B0C");

            entity.HasOne(d => d.KullaniciTipi).WithMany(p => p.ModalDuyuruDetaylaris)
                .HasForeignKey(d => d.KullaniciTipiId)
                .HasConstraintName("FK__MODAL_DUY__KULLA__5B3966D3");
        });

        modelBuilder.Entity<Moduller>(entity =>
        {
            entity.HasKey(e => e.ModulId);

            entity.ToTable("MODULLER");

            entity.Property(e => e.ModulId)
                .ValueGeneratedNever()
                .HasColumnName("MODUL_ID");
            entity.Property(e => e.ModulAdi)
                .HasMaxLength(50)
                .HasColumnName("MODUL_ADI");
        });

        modelBuilder.Entity<Notlar>(entity =>
        {
            entity.HasKey(e => e.NotId);

            entity.ToTable("NOTLAR");

            entity.Property(e => e.NotId).HasColumnName("NOT_ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.BildirimGonderildi).HasColumnName("BILDIRIM_GONDERILDI");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.DisKayitNo).HasColumnName("DIS_KAYIT_NO");
            entity.Property(e => e.DosyaAdi)
                .HasMaxLength(250)
                .HasColumnName("DOSYA_ADI");
            entity.Property(e => e.Hatirlatma).HasColumnName("HATIRLATMA");
            entity.Property(e => e.HatirlatmaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("HATIRLATMA_TARIHI");
            entity.Property(e => e.IslemYapanKullaniciId).HasColumnName("ISLEM_YAPAN_KULLANICI_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KisaAciklama)
                .HasMaxLength(100)
                .HasColumnName("KISA_ACIKLAMA");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.ModulId).HasColumnName("MODUL_ID");
            entity.Property(e => e.Tamamlandi).HasColumnName("TAMAMLANDI");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.ZamanAraligiId).HasColumnName("ZAMAN_ARALIGI_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.Notlars)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NOTLAR_BUROLAR");

            entity.HasOne(d => d.IslemYapanKullanici).WithMany(p => p.NotlarIslemYapanKullanicis)
                .HasForeignKey(d => d.IslemYapanKullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NOTLAR_KULLANICILAR1");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.NotlarKullanicis)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NOTLAR_KULLANICILAR");

            entity.HasOne(d => d.Modul).WithMany(p => p.Notlars)
                .HasForeignKey(d => d.ModulId)
                .HasConstraintName("FK_NOTLAR_MODULLER");

            entity.HasOne(d => d.ZamanAraligi).WithMany(p => p.Notlars)
                .HasForeignKey(d => d.ZamanAraligiId)
                .HasConstraintName("FK_NOTLAR_ZAMAN_ARALIGI");
        });

        modelBuilder.Entity<OdemeTuru>(entity =>
        {
            entity.HasKey(e => e.OdemeTuruId).HasName("PK_YP_ODEME_TURU");

            entity.ToTable("ODEME_TURU");

            entity.Property(e => e.OdemeTuruId).HasColumnName("ODEME_TURU_ID");
            entity.Property(e => e.OdemeTuruAdi)
                .HasMaxLength(50)
                .HasColumnName("ODEME_TURU_ADI");
        });

        modelBuilder.Entity<OkunanKampanyalar>(entity =>
        {
            entity.HasKey(e => e.OkunanKampanyaId);

            entity.ToTable("OKUNAN_KAMPANYALAR");

            entity.Property(e => e.OkunanKampanyaId).HasColumnName("OKUNAN_KAMPANYA_ID");
            entity.Property(e => e.AktifMi).HasColumnName("AKTIF_MI");
            entity.Property(e => e.KampanyaId).HasColumnName("KAMPANYA_ID");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.OkumaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("OKUMA_TARIHI");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.OkunanKampanyalars)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OKUNAN_KAMPANYALAR_KULLANICILAR");
        });

        modelBuilder.Entity<OperatorTurleri>(entity =>
        {
            entity.HasKey(e => e.OperatorTurId);

            entity.ToTable("OPERATOR_TURLERI");

            entity.Property(e => e.OperatorTurId)
                .ValueGeneratedNever()
                .HasColumnName("OPERATOR_TUR_ID");
            entity.Property(e => e.OperatorTurAdi)
                .HasMaxLength(50)
                .HasColumnName("OPERATOR_TUR_ADI");
        });

        modelBuilder.Entity<OtpLog>(entity =>
        {
            entity.HasKey(e => e.OtpLogId).HasName("PK_OTP_LOG_ID");

            entity.ToTable("OTP_LOGS");

            entity.Property(e => e.OtpLogId).HasColumnName("OTP_LOG_ID");
            entity.Property(e => e.Basarili).HasColumnName("BASARILI");
            entity.Property(e => e.DenemeSayisi).HasColumnName("DENEME_SAYISI");
            entity.Property(e => e.DogrulamaDenemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("DOGRULAMA_DENEME_ZAMANI");
            entity.Property(e => e.GirilenOtpKod)
                .HasMaxLength(10)
                .HasColumnName("GIRILEN_OTP_KOD");
            entity.Property(e => e.IpAdresi)
                .HasMaxLength(50)
                .HasColumnName("IP_ADRESI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.LogKaydiIleDogrulandi).HasColumnName("LOG_KAYDI_ILE_DOGRULANDI");
            entity.Property(e => e.MenuId).HasColumnName("MENU_ID");
            entity.Property(e => e.OtpGonderimZamani)
                .HasColumnType("datetime")
                .HasColumnName("OTP_GONDERIM_ZAMANI");
            entity.Property(e => e.OtpKod)
                .HasMaxLength(10)
                .HasColumnName("OTP_KOD");
            entity.Property(e => e.TelefonNo)
                .HasMaxLength(11)
                .HasColumnName("TELEFON_NO");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.OtpLogs)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OTP_LOGS_KULLANICILAR");

            entity.HasOne(d => d.Menu).WithMany(p => p.OtpLogs)
                .HasForeignKey(d => d.MenuId)
                .HasConstraintName("FK_OTP_LOGS_YP_MENU");
        });

        modelBuilder.Entity<SikcaSorulanSorular>(entity =>
        {
            entity.HasKey(e => e.SikcaSorulanSoruId);

            entity.ToTable("SIKCA_SORULAN_SORULAR");

            entity.Property(e => e.SikcaSorulanSoruId).HasColumnName("SIKCA_SORULAN_SORU_ID");
            entity.Property(e => e.Cevap).HasColumnName("CEVAP");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.KullaniciTipiId).HasColumnName("KULLANICI_TIPI_ID");
            entity.Property(e => e.Soru)
                .HasMaxLength(500)
                .HasColumnName("SORU");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.SikcaSorulanSorulars)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SIKCA_SORULAN_SORULAR_SIKCA_SORULAN_SORULAR");
        });

        modelBuilder.Entity<SiteyeGirisLog>(entity =>
        {
            entity.ToTable("SITEYE_GIRIS_LOG");

            entity.Property(e => e.SiteyeGirisLogId).HasColumnName("SITEYE_GIRIS_LOG_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.ErisimIp)
                .HasMaxLength(150)
                .HasColumnName("ERISIM_IP");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciIslemTuruId).HasColumnName("KULLANICI_ISLEM_TURU_ID");

            entity.HasOne(d => d.KullaniciIslemTuru).WithMany(p => p.SiteyeGirisLogs)
                .HasForeignKey(d => d.KullaniciIslemTuruId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SITEYE_GIRIS_LOG_KULLANICI_ISLEM_TURU");
        });

        modelBuilder.Entity<SorgulamaLoglari>(entity =>
        {
            entity.HasKey(e => e.SorgulamaLogId);

            entity.ToTable("SORGULAMA_LOGLARI");

            entity.Property(e => e.SorgulamaLogId).HasColumnName("SORGULAMA_LOG_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.OperatorTurId).HasColumnName("OPERATOR_TUR_ID");
            entity.Property(e => e.ServisId).HasColumnName("SERVIS_ID");
            entity.Property(e => e.SorguBasariDurumu).HasColumnName("SORGU_BASARI_DURUMU");
            entity.Property(e => e.SorgulamaSonucu).HasColumnName("SORGULAMA_SONUCU");
            entity.Property(e => e.SorgulananImeiNo)
                .HasMaxLength(50)
                .HasColumnName("SORGULANAN_IMEI_NO");
            entity.Property(e => e.SorgulananTcKimlikNo)
                .HasMaxLength(11)
                .HasColumnName("SORGULANAN_TC_KIMLIK_NO");
            entity.Property(e => e.SorgulananTelefonNo)
                .HasMaxLength(50)
                .HasColumnName("SORGULANAN_TELEFON_NO");

            entity.HasOne(d => d.Buro).WithMany(p => p.SorgulamaLoglaris)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SORGULAMA_LOGLARI_BUROLAR");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.SorgulamaLoglaris)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SORGULAMA_LOGLARI_KULLANICILAR");

            entity.HasOne(d => d.OperatorTur).WithMany(p => p.SorgulamaLoglaris)
                .HasForeignKey(d => d.OperatorTurId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SORGULAMA_LOGLARI_OPERATOR_TURLERI");

            entity.HasOne(d => d.Servis).WithMany(p => p.SorgulamaLoglaris)
                .HasForeignKey(d => d.ServisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SORGULAMA_LOGLARI_SORGULAMA_SERVISLERI");
        });

        modelBuilder.Entity<SorgulamaServisleri>(entity =>
        {
            entity.HasKey(e => e.ServisId);

            entity.ToTable("SORGULAMA_SERVISLERI");

            entity.Property(e => e.ServisId)
                .ValueGeneratedNever()
                .HasColumnName("SERVIS_ID");
            entity.Property(e => e.OperatorTurId).HasColumnName("OPERATOR_TUR_ID");
            entity.Property(e => e.ServisAciklama)
                .HasMaxLength(500)
                .HasColumnName("SERVIS_ACIKLAMA");
            entity.Property(e => e.ServisAdi)
                .HasMaxLength(100)
                .HasColumnName("SERVIS_ADI");
            entity.Property(e => e.ServisBilgi).HasColumnName("SERVIS_BILGI");
            entity.Property(e => e.ServisUcreti)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SERVIS_UCRETI");

            entity.HasOne(d => d.OperatorTur).WithMany(p => p.SorgulamaServisleris)
                .HasForeignKey(d => d.OperatorTurId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SORGULAMA_SERVISLERI_OPERATOR_TURLERI");
        });

        modelBuilder.Entity<SorgulamaUlkeKodlari>(entity =>
        {
            entity.HasKey(e => e.SorgulamaUlkeKodId);

            entity.ToTable("SORGULAMA_ULKE_KODLARI");

            entity.Property(e => e.SorgulamaUlkeKodId).HasColumnName("SORGULAMA_ULKE_KOD_ID");
            entity.Property(e => e.OperatorTurId).HasColumnName("OPERATOR_TUR_ID");
            entity.Property(e => e.UlkeAdi)
                .HasMaxLength(100)
                .HasColumnName("ULKE_ADI");
            entity.Property(e => e.UlkeKodu).HasColumnName("ULKE_KODU");

            entity.HasOne(d => d.OperatorTur).WithMany(p => p.SorgulamaUlkeKodlaris)
                .HasForeignKey(d => d.OperatorTurId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SORGULAMA_ULKE_KODLARI_OPERATOR_TURLERI");
        });

        modelBuilder.Entity<TakipYoluTuru>(entity =>
        {
            entity.ToTable("TAKIP_YOLU_TURU");

            entity.Property(e => e.TakipYoluTuruId)
                .ValueGeneratedNever()
                .HasColumnName("TAKIP_YOLU_TURU_ID");
            entity.Property(e => e.TakipYoluTuruAdi)
                .HasMaxLength(50)
                .HasColumnName("TAKIP_YOLU_TURU_ADI");
        });

        modelBuilder.Entity<Talep>(entity =>
        {
            entity.HasKey(e => e.TalepId).HasName("PK_YP_TALEP");

            entity.ToTable("TALEP");

            entity.Property(e => e.TalepId).HasColumnName("TALEP_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.KapatanKullaniciId).HasColumnName("KAPATAN_KULLANICI_ID");
            entity.Property(e => e.TalepAciklama).HasColumnName("TALEP_ACIKLAMA");
            entity.Property(e => e.TalepCevap).HasColumnName("TALEP_CEVAP");
            entity.Property(e => e.TalepCevapTarihi)
                .HasColumnType("datetime")
                .HasColumnName("TALEP_CEVAP_TARIHI");
            entity.Property(e => e.TalepDurumId).HasColumnName("TALEP_DURUM_ID");
            entity.Property(e => e.TalepEdenKullaniciId).HasColumnName("TALEP_EDEN_KULLANICI_ID");
            entity.Property(e => e.TalepKonu)
                .HasMaxLength(100)
                .HasColumnName("TALEP_KONU");
            entity.Property(e => e.TalepTarihi)
                .HasColumnType("datetime")
                .HasColumnName("TALEP_TARIHI");
            entity.Property(e => e.TalepTurId).HasColumnName("TALEP_TUR_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.Taleps)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TALEP_BUROLAR");

            entity.HasOne(d => d.KapatanKullanici).WithMany(p => p.TalepKapatanKullanicis)
                .HasForeignKey(d => d.KapatanKullaniciId)
                .HasConstraintName("FK_TALEP_KULLANICILAR1");

            entity.HasOne(d => d.TalepDurum).WithMany(p => p.Taleps)
                .HasForeignKey(d => d.TalepDurumId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TALEP_YP_TALEP_DURUM");

            entity.HasOne(d => d.TalepEdenKullanici).WithMany(p => p.TalepTalepEdenKullanicis)
                .HasForeignKey(d => d.TalepEdenKullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TALEP_KULLANICILAR");

            entity.HasOne(d => d.TalepTur).WithMany(p => p.Taleps)
                .HasForeignKey(d => d.TalepTurId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TALEP_TALEP_TURU");
        });

        modelBuilder.Entity<TalepDosya>(entity =>
        {
            entity.ToTable("TALEP_DOSYA");

            entity.Property(e => e.TalepDosyaId).HasColumnName("TALEP_DOSYA_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.DosyaId).HasColumnName("DOSYA_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.TalepId).HasColumnName("TALEP_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.TalepDosyas)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TALEP_DOSYA_BUROLAR");

            entity.HasOne(d => d.Dosya).WithMany(p => p.TalepDosyas)
                .HasForeignKey(d => d.DosyaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TALEP_DOSYA_DOSYALAR");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.TalepDosyas)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TALEP_DOSYA_KULLANICILAR");

            entity.HasOne(d => d.Talep).WithMany(p => p.TalepDosyas)
                .HasForeignKey(d => d.TalepId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TALEP_DOSYA_TALEP");
        });

        modelBuilder.Entity<TalepDurum>(entity =>
        {
            entity.HasKey(e => e.TalepDurumId).HasName("PK_YP_TALEP_DURUM");

            entity.ToTable("TALEP_DURUM");

            entity.Property(e => e.TalepDurumId)
                .ValueGeneratedNever()
                .HasColumnName("TALEP_DURUM_ID");
            entity.Property(e => e.TalepDurumAdi)
                .HasMaxLength(50)
                .HasColumnName("TALEP_DURUM_ADI");
        });

        modelBuilder.Entity<TalepTuru>(entity =>
        {
            entity.HasKey(e => e.TalepTurId).HasName("PK_YP_TALEP_TURU");

            entity.ToTable("TALEP_TURU");

            entity.Property(e => e.TalepTurId).HasColumnName("TALEP_TUR_ID");
            entity.Property(e => e.TalepTurAdi)
                .HasMaxLength(50)
                .HasColumnName("TALEP_TUR_ADI");
        });

        modelBuilder.Entity<TasinirGrublari>(entity =>
        {
            entity.HasKey(e => e.TasinirGrubuId);

            entity.ToTable("TASINIR_GRUBLARI");

            entity.Property(e => e.TasinirGrubuId).HasColumnName("TASINIR_GRUBU_ID");
            entity.Property(e => e.TasinirGrubuAdi).HasColumnName("TASINIR_GRUBU_ADI");
            entity.Property(e => e.TasinirGrubuAltId).HasColumnName("TASINIR_GRUBU_ALT_ID");
            entity.Property(e => e.TasinirGurubuKodu)
                .HasMaxLength(300)
                .HasColumnName("TASINIR_GURUBU_KODU");
        });

        modelBuilder.Entity<Token>(entity =>
        {
            entity.ToTable("TOKEN");

            entity.Property(e => e.TokenId).HasColumnName("TOKEN_ID");
            entity.Property(e => e.GuncellemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("GUNCELLEME_ZAMANI");
            entity.Property(e => e.IpAdresi)
                .HasMaxLength(50)
                .HasColumnName("IP_ADRESI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.SistemAdi)
                .HasMaxLength(30)
                .HasColumnName("SISTEM_ADI");
            entity.Property(e => e.TokenHash)
                .HasMaxLength(35)
                .HasColumnName("TOKEN_HASH");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.Tokens)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TOKEN_KULLANICILAR");
        });

        modelBuilder.Entity<VekalatUcretleri>(entity =>
        {
            entity.ToTable("VEKALAT_UCRETLERI");

            entity.Property(e => e.VekalatUcretleriId).HasColumnName("VEKALAT_UCRETLERI_ID");
            entity.Property(e => e.BaslangicTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BASLANGIC_TARIHI");
            entity.Property(e => e.BitisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BITIS_TARIHI");
            entity.Property(e => e.MaximumTutar)
                .HasColumnType("money")
                .HasColumnName("MAXIMUM_TUTAR");
            entity.Property(e => e.MinumumTutar)
                .HasColumnType("money")
                .HasColumnName("MINUMUM_TUTAR");
            entity.Property(e => e.MinumumVekaletUcreti)
                .HasColumnType("money")
                .HasColumnName("MINUMUM_VEKALET_UCRETI");
            entity.Property(e => e.Oran).HasColumnName("ORAN");
        });

        modelBuilder.Entity<VekaletTuru>(entity =>
        {
            entity.ToTable("VEKALET_TURU");

            entity.Property(e => e.VekaletTuruId)
                .ValueGeneratedNever()
                .HasColumnName("VEKALET_TURU_ID");
            entity.Property(e => e.VekaletTuruAdi)
                .HasMaxLength(50)
                .HasColumnName("VEKALET_TURU_ADI");
        });

        modelBuilder.Entity<YardimVideolari>(entity =>
        {
            entity.HasKey(e => e.YardimVideoId);

            entity.ToTable("YARDIM_VIDEOLARI");

            entity.Property(e => e.YardimVideoId)
                .ValueGeneratedNever()
                .HasColumnName("YARDIM_VIDEO_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Url)
                .HasMaxLength(250)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<YasalTemsilTurleri>(entity =>
        {
            entity.HasKey(e => e.TemsilTuruId);

            entity.ToTable("YASAL_TEMSIL_TURLERI");

            entity.Property(e => e.TemsilTuruId).HasColumnName("TEMSIL_TURU_ID");
            entity.Property(e => e.TemsilTuruAdi)
                .HasMaxLength(50)
                .HasColumnName("TEMSIL_TURU_ADI");
        });

        modelBuilder.Entity<YayinCikislari>(entity =>
        {
            entity.HasKey(e => e.YayinCikisId);

            entity.ToTable("YAYIN_CIKISLARI");

            entity.Property(e => e.YayinCikisId).HasColumnName("YAYIN_CIKIS_ID");
            entity.Property(e => e.AlinmasiGerekenTarih)
                .HasColumnType("datetime")
                .HasColumnName("ALINMASI_GEREKEN_TARIH");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.TeslimAlindi).HasColumnName("TESLIM_ALINDI");
            entity.Property(e => e.TeslimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("TESLIM_TARIHI");
            entity.Property(e => e.VerilisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("VERILIS_TARIHI");
            entity.Property(e => e.YayinId).HasColumnName("YAYIN_ID");
            entity.Property(e => e.YayinKayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("YAYIN_KAYIT_TARIHI");

            entity.HasOne(d => d.Buro).WithMany(p => p.YayinCikislaris)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_YAYIN_CIKISLARI_BUROLAR");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.YayinCikislaris)
                .HasForeignKey(d => d.KullaniciId)
                .HasConstraintName("FK_YAYIN_CIKISLARI_KULLANICILAR");

            entity.HasOne(d => d.Yayin).WithMany(p => p.YayinCikislaris)
                .HasForeignKey(d => d.YayinId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_YAYIN_CIKISLARI_YAYINLAR");
        });

        modelBuilder.Entity<YayinTurleri>(entity =>
        {
            entity.HasKey(e => e.YayinTuruId);

            entity.ToTable("YAYIN_TURLERI");

            entity.Property(e => e.YayinTuruId).HasColumnName("YAYIN_TURU_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.UstYayinTuruId).HasColumnName("UST_YAYIN_TURU_ID");
            entity.Property(e => e.YayinTuruAdi)
                .HasMaxLength(300)
                .HasColumnName("YAYIN_TURU_ADI");

            entity.HasOne(d => d.Buro).WithMany(p => p.YayinTurleris)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_YAYIN_TURLERI_BUROLAR");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.YayinTurleris)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_YAYIN_TURLERI_KULLANICILAR");

            entity.HasOne(d => d.UstYayinTuru).WithMany(p => p.InverseUstYayinTuru)
                .HasForeignKey(d => d.UstYayinTuruId)
                .HasConstraintName("FK_YAYIN_TURLERI_YAYIN_TURLERI");
        });

        modelBuilder.Entity<Yayinlar>(entity =>
        {
            entity.HasKey(e => e.YayinId);

            entity.ToTable("YAYINLAR");

            entity.Property(e => e.YayinId).HasColumnName("YAYIN_ID");
            entity.Property(e => e.Barkod).HasColumnName("BARKOD");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KutuphaneId).HasColumnName("KUTUPHANE_ID");
            entity.Property(e => e.YayinAdi)
                .HasMaxLength(300)
                .HasColumnName("YAYIN_ADI");
            entity.Property(e => e.YayinAltTuruId).HasColumnName("YAYIN_ALT_TURU_ID");
            entity.Property(e => e.YayinBasimYili).HasColumnName("YAYIN_BASIM_YILI");
            entity.Property(e => e.YayinEvi)
                .HasMaxLength(300)
                .HasColumnName("YAYIN_EVI");
            entity.Property(e => e.YayinKodu)
                .HasMaxLength(300)
                .HasColumnName("YAYIN_KODU");
            entity.Property(e => e.YayinTuruId).HasColumnName("YAYIN_TURU_ID");
            entity.Property(e => e.YazarAdi)
                .HasMaxLength(300)
                .HasColumnName("YAZAR_ADI");

            entity.HasOne(d => d.Buro).WithMany(p => p.Yayinlars)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_YAYINLAR_BUROLAR");

            entity.HasOne(d => d.Kutuphane).WithMany(p => p.Yayinlars)
                .HasForeignKey(d => d.KutuphaneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_YAYINLAR_KUTUPHANELER");

            entity.HasOne(d => d.YayinAltTuru).WithMany(p => p.YayinlarYayinAltTurus)
                .HasForeignKey(d => d.YayinAltTuruId)
                .HasConstraintName("FK_YAYINLAR_YAYIN_TURLERI1");

            entity.HasOne(d => d.YayinTuru).WithMany(p => p.YayinlarYayinTurus)
                .HasForeignKey(d => d.YayinTuruId)
                .HasConstraintName("FK_YAYINLAR_YAYIN_TURLERI");
        });

        modelBuilder.Entity<YetkiTuru>(entity =>
        {
            entity.ToTable("YETKI_TURU");

            entity.Property(e => e.YetkiTuruId)
                .ValueGeneratedNever()
                .HasColumnName("YETKI_TURU_ID");
            entity.Property(e => e.YetkiTuruAdi)
                .HasMaxLength(50)
                .HasColumnName("YETKI_TURU_ADI");
        });

        modelBuilder.Entity<YpAgBilgileri>(entity =>
        {
            entity.HasKey(e => e.AgBilgileriId);

            entity.ToTable("YP_AG_BILGILERI");

            entity.Property(e => e.AgBilgileriId).HasColumnName("AG_BILGILERI_ID");
            entity.Property(e => e.IvrDbIp)
                .HasMaxLength(50)
                .HasColumnName("IVR_DB_IP");
            entity.Property(e => e.KullaniciAdi)
                .HasMaxLength(50)
                .HasColumnName("KULLANICI_ADI");
            entity.Property(e => e.SesIp)
                .HasMaxLength(50)
                .HasColumnName("SES_IP");
            entity.Property(e => e.Sifre)
                .HasMaxLength(50)
                .HasColumnName("SIFRE");
        });

        modelBuilder.Entity<YpBankalar>(entity =>
        {
            entity.HasKey(e => e.BankaId).HasName("PK_BANKALAR_1");

            entity.ToTable("YP_BANKALAR");

            entity.Property(e => e.BankaId).HasColumnName("BANKA_ID");
            entity.Property(e => e.BankaKodu).HasColumnName("BANKA_KODU");
            entity.Property(e => e.BankaMi).HasColumnName("BANKA_MI");
            entity.Property(e => e.BankaSubeAdi)
                .HasMaxLength(50)
                .HasColumnName("BANKA_SUBE_ADI");
            entity.Property(e => e.BankaSubeKodu).HasColumnName("BANKA_SUBE_KODU");
        });

        modelBuilder.Entity<YpBildirimDurumlari>(entity =>
        {
            entity.HasKey(e => e.BildirimDurumId);

            entity.ToTable("YP_BILDIRIM_DURUMLARI");

            entity.Property(e => e.BildirimDurumId).HasColumnName("BILDIRIM_DURUM_ID");
            entity.Property(e => e.BildirimDurumAdi)
                .HasMaxLength(100)
                .HasColumnName("BILDIRIM_DURUM_ADI");
        });

        modelBuilder.Entity<YpBildirimTurleri>(entity =>
        {
            entity.HasKey(e => e.BildirimTuruId);

            entity.ToTable("YP_BILDIRIM_TURLERI");

            entity.Property(e => e.BildirimTuruId)
                .ValueGeneratedNever()
                .HasColumnName("BILDIRIM_TURU_ID");
            entity.Property(e => e.BildirimTuruAdi)
                .HasMaxLength(100)
                .HasColumnName("BILDIRIM_TURU_ADI");
            entity.Property(e => e.BildirimTuruGrupId).HasColumnName("BILDIRIM_TURU_GRUP_ID");

            entity.HasOne(d => d.BildirimTuruGrup).WithMany(p => p.YpBildirimTurleris)
                .HasForeignKey(d => d.BildirimTuruGrupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_YP_BILDIRIM_TURLERI_YP_BILDIRIM_TURU_GRUPLARI");
        });

        modelBuilder.Entity<YpBildirimTuruGruplari>(entity =>
        {
            entity.HasKey(e => e.BildirimTuruGrupId);

            entity.ToTable("YP_BILDIRIM_TURU_GRUPLARI");

            entity.Property(e => e.BildirimTuruGrupId)
                .ValueGeneratedNever()
                .HasColumnName("BILDIRIM_TURU_GRUP_ID");
            entity.Property(e => e.BildirimTuruGrupAdi)
                .HasMaxLength(50)
                .HasColumnName("BILDIRIM_TURU_GRUP_ADI");
        });

        modelBuilder.Entity<YpBildirimler>(entity =>
        {
            entity.HasKey(e => e.BildirimId);

            entity.ToTable("YP_BILDIRIMLER");

            entity.Property(e => e.BildirimId).HasColumnName("BILDIRIM_ID");
            entity.Property(e => e.BildirenKullaniciId).HasColumnName("BILDIREN_KULLANICI_ID");
            entity.Property(e => e.BildirilenKullaniciId).HasColumnName("BILDIRILEN_KULLANICI_ID");
            entity.Property(e => e.BildirimDurumId).HasColumnName("BILDIRIM_DURUM_ID");
            entity.Property(e => e.BildirimMetni).HasColumnName("BILDIRIM_METNI");
            entity.Property(e => e.BildirimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BILDIRIM_TARIHI");
            entity.Property(e => e.BildirimTuruId).HasColumnName("BILDIRIM_TURU_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.Konu)
                .HasMaxLength(250)
                .HasColumnName("KONU");
            entity.Property(e => e.OkunmaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("OKUNMA_TARIHI");
            entity.Property(e => e.SilinmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("SILINME_TARIHI");

            entity.HasOne(d => d.BildirenKullanici).WithMany(p => p.YpBildirimlerBildirenKullanicis)
                .HasForeignKey(d => d.BildirenKullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_YP_BILDIRIMLER_KULLANICILAR");

            entity.HasOne(d => d.BildirilenKullanici).WithMany(p => p.YpBildirimlerBildirilenKullanicis)
                .HasForeignKey(d => d.BildirilenKullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_YP_BILDIRIMLER_KULLANICILAR1");

            entity.HasOne(d => d.BildirimDurum).WithMany(p => p.YpBildirimlers)
                .HasForeignKey(d => d.BildirimDurumId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_YP_BILDIRIMLER_YP_BILDIRIM_DURUMLARI");

            entity.HasOne(d => d.BildirimTuru).WithMany(p => p.YpBildirimlers)
                .HasForeignKey(d => d.BildirimTuruId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_YP_BILDIRIMLER_YP_BILDIRIM_TURLERI");

            entity.HasOne(d => d.Buro).WithMany(p => p.YpBildirimlers)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_YP_BILDIRIMLER_BUROLAR");
        });

        modelBuilder.Entity<YpEmsalKararTuru>(entity =>
        {
            entity.HasKey(e => e.EmsalKararTuruId);

            entity.ToTable("YP_EMSAL_KARAR_TURU");

            entity.Property(e => e.EmsalKararTuruId)
                .ValueGeneratedNever()
                .HasColumnName("EMSAL_KARAR_TURU_ID");
            entity.Property(e => e.EmsalKararTuruAdi)
                .HasMaxLength(100)
                .HasColumnName("EMSAL_KARAR_TURU_ADI");
        });

        modelBuilder.Entity<YpFormlar>(entity =>
        {
            entity.HasKey(e => e.FormId).HasName("PK_FORMLAR");

            entity.ToTable("YP_FORMLAR");

            entity.Property(e => e.FormId).HasColumnName("FORM_ID");
            entity.Property(e => e.FormAdi)
                .HasMaxLength(250)
                .HasColumnName("FORM_ADI");
        });

        modelBuilder.Entity<YpIlIlce>(entity =>
        {
            entity.HasKey(e => e.IlIlceId);

            entity.ToTable("YP_IL_ILCE");

            entity.Property(e => e.IlIlceId).HasColumnName("IL_ILCE_ID");
            entity.Property(e => e.IlId).HasColumnName("IL_ID");
            entity.Property(e => e.IlIlceAdi)
                .HasMaxLength(500)
                .HasColumnName("IL_ILCE_ADI");
            entity.Property(e => e.IlIlceTuruId).HasColumnName("IL_ILCE_TURU_ID");
            entity.Property(e => e.PlakaKodu)
                .HasMaxLength(3)
                .HasColumnName("PLAKA_KODU");
        });

        modelBuilder.Entity<YpIslemTuru>(entity =>
        {
            entity.HasKey(e => e.IslemTuruId);

            entity.ToTable("YP_ISLEM_TURU");

            entity.Property(e => e.IslemTuruId).HasColumnName("ISLEM_TURU_ID");
            entity.Property(e => e.IslemTuruAdi)
                .HasMaxLength(100)
                .HasColumnName("ISLEM_TURU_ADI");
        });

        modelBuilder.Entity<YpKontrolNoktalari>(entity =>
        {
            entity.HasKey(e => e.KontrolNoktasiId);

            entity.ToTable("YP_KONTROL_NOKTALARI");

            entity.Property(e => e.KontrolNoktasiId).HasColumnName("KONTROL_NOKTASI_ID");
            entity.Property(e => e.KontrolNoktasiAciklama)
                .HasMaxLength(300)
                .HasColumnName("KONTROL_NOKTASI_ACIKLAMA");
            entity.Property(e => e.KontrolNoktasiAdi)
                .HasMaxLength(150)
                .HasColumnName("KONTROL_NOKTASI_ADI");
        });

        modelBuilder.Entity<YpKrediKartiAyar>(entity =>
        {
            entity.HasKey(e => e.KrediKartiAyarId);

            entity.ToTable("YP_KREDI_KARTI_AYAR");

            entity.Property(e => e.KrediKartiAyarId).HasColumnName("KREDI_KARTI_AYAR_ID");
            entity.Property(e => e.ClientId)
                .HasMaxLength(50)
                .HasColumnName("CLIENT_ID");
            entity.Property(e => e.KullaniciAdi)
                .HasMaxLength(50)
                .HasColumnName("KULLANICI_ADI");
            entity.Property(e => e.SanalPosUrl)
                .HasMaxLength(250)
                .HasColumnName("SANAL_POS_URL");
            entity.Property(e => e.Sifre)
                .HasMaxLength(50)
                .HasColumnName("SIFRE");
        });

        modelBuilder.Entity<YpKrediSahipTipleri>(entity =>
        {
            entity.HasKey(e => e.KrediSahipTipiId);

            entity.ToTable("YP_KREDI_SAHIP_TIPLERI");

            entity.Property(e => e.KrediSahipTipiId)
                .ValueGeneratedNever()
                .HasColumnName("KREDI_SAHIP_TIPI_ID");
            entity.Property(e => e.KrediSahipTipiAdi)
                .HasMaxLength(50)
                .HasColumnName("KREDI_SAHIP_TIPI_ADI");
        });

        modelBuilder.Entity<YpKullaniciDurumlari>(entity =>
        {
            entity.HasKey(e => e.KullaniciDurumId).HasName("PK_KULLANICI_DURUMLARI");

            entity.ToTable("YP_KULLANICI_DURUMLARI");

            entity.Property(e => e.KullaniciDurumId)
                .ValueGeneratedNever()
                .HasColumnName("KULLANICI_DURUM_ID");
            entity.Property(e => e.KullaniciDurumAdi)
                .HasMaxLength(50)
                .HasColumnName("KULLANICI_DURUM_ADI");
        });

        modelBuilder.Entity<YpKullaniciSozlesme>(entity =>
        {
            entity.HasKey(e => e.KullaniciSozlesmeId);

            entity.ToTable("YP_KULLANICI_SOZLESME");

            entity.Property(e => e.KullaniciSozlesmeId).HasColumnName("KULLANICI_SOZLESME_ID");
            entity.Property(e => e.BaslangicTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BASLANGIC_TARIHI");
            entity.Property(e => e.BitisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BITIS_TARIHI");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.IslemYapanKullaniciId).HasColumnName("ISLEM_YAPAN_KULLANICI_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.SozlesmeTutari)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SOZLESME_TUTARI");
            entity.Property(e => e.UcretsizSekreter).HasColumnName("UCRETSIZ_SEKRETER");
            entity.Property(e => e.UyelikUcretlendirmeId).HasColumnName("UYELIK_UCRETLENDIRME_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.YpKullaniciSozlesmes)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_YP_KULLANICI_SOZLESME_BUROLAR");

            entity.HasOne(d => d.IslemYapanKullanici).WithMany(p => p.YpKullaniciSozlesmeIslemYapanKullanicis)
                .HasForeignKey(d => d.IslemYapanKullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_YP_KULLANICI_SOZLESME_KULLANICILAR1");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.YpKullaniciSozlesmeKullanicis)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_YP_KULLANICI_SOZLESME_KULLANICILAR");

            entity.HasOne(d => d.UyelikUcretlendirme).WithMany(p => p.YpKullaniciSozlesmes)
                .HasForeignKey(d => d.UyelikUcretlendirmeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_YP_KULLANICI_SOZLESME_YP_UYELIK_UCRETLENDIRME");
        });

        modelBuilder.Entity<YpKullaniciTercihTuru>(entity =>
        {
            entity.HasKey(e => e.TercihTuruId);

            entity.ToTable("YP_KULLANICI_TERCIH_TURU");

            entity.Property(e => e.TercihTuruId).HasColumnName("TERCIH_TURU_ID");
            entity.Property(e => e.DegerTipi).HasColumnName("DEGER_TIPI");
            entity.Property(e => e.TercihAciklama)
                .HasMaxLength(400)
                .HasColumnName("TERCIH_ACIKLAMA");
            entity.Property(e => e.TercihTuruAdi)
                .HasMaxLength(50)
                .HasColumnName("TERCIH_TURU_ADI");
            entity.Property(e => e.VarsayilanDeger)
                .HasMaxLength(100)
                .HasColumnName("VARSAYILAN_DEGER");
        });

        modelBuilder.Entity<YpKullaniciTipleri>(entity =>
        {
            entity.HasKey(e => e.KullaniciTipiId).HasName("PK_KULLANICI_TIPLERI");

            entity.ToTable("YP_KULLANICI_TIPLERI");

            entity.Property(e => e.KullaniciTipiId)
                .ValueGeneratedNever()
                .HasColumnName("KULLANICI_TIPI_ID");
            entity.Property(e => e.KullaniciTipiAdi)
                .HasMaxLength(50)
                .HasColumnName("KULLANICI_TIPI_ADI");
        });

        modelBuilder.Entity<YpKullaniciYetkiGruplari>(entity =>
        {
            entity.HasKey(e => e.KullaniciYetkiGrubuId);

            entity.ToTable("YP_KULLANICI_YETKI_GRUPLARI");

            entity.Property(e => e.KullaniciYetkiGrubuId).HasColumnName("KULLANICI_YETKI_GRUBU_ID");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.YetkiGrupId).HasColumnName("YETKI_GRUP_ID");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.YpKullaniciYetkiGruplaris)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_YP_KULLANICI_YETKI_GRUPLARI_KULLANICILAR");

            entity.HasOne(d => d.YetkiGrup).WithMany(p => p.YpKullaniciYetkiGruplaris)
                .HasForeignKey(d => d.YetkiGrupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_YP_KULLANICI_YETKI_GRUPLARI_YP_YETKI_GRUPLARI");
        });

        modelBuilder.Entity<YpKurumTanimlari>(entity =>
        {
            entity.HasKey(e => e.KurumId).HasName("PK_KURUM_TANIMLARI");

            entity.ToTable("YP_KURUM_TANIMLARI");

            entity.Property(e => e.KurumId).HasColumnName("KURUM_ID");
            entity.Property(e => e.BuroId).HasColumnName("BURO_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KurumAdi)
                .HasMaxLength(250)
                .HasColumnName("KURUM_ADI");
            entity.Property(e => e.KurumTuruId).HasColumnName("KURUM_TURU_ID");
            entity.Property(e => e.OlusturanKisiId).HasColumnName("OLUSTURAN_KISI_ID");

            entity.HasOne(d => d.Buro).WithMany(p => p.YpKurumTanimlaris)
                .HasForeignKey(d => d.BuroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_YP_KURUM_TANIMLARI_BUROLAR");

            entity.HasOne(d => d.KurumTuru).WithMany(p => p.YpKurumTanimlaris)
                .HasForeignKey(d => d.KurumTuruId)
                .HasConstraintName("FK_YP_KURUM_TANIMLARI_YP_KURUM_TURLERI");

            entity.HasOne(d => d.OlusturanKisi).WithMany(p => p.YpKurumTanimlaris)
                .HasForeignKey(d => d.OlusturanKisiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_YP_KURUM_TANIMLARI_KULLANICILAR");
        });

        modelBuilder.Entity<YpKurumTurleri>(entity =>
        {
            entity.HasKey(e => e.KurumTuruId).HasName("PK_KURUM_TURLERI");

            entity.ToTable("YP_KURUM_TURLERI");

            entity.Property(e => e.KurumTuruId).HasColumnName("KURUM_TURU_ID");
            entity.Property(e => e.KurumTuruAdi)
                .HasMaxLength(50)
                .HasColumnName("KURUM_TURU_ADI");
        });

        modelBuilder.Entity<YpMenuler>(entity =>
        {
            entity.HasKey(e => e.MenuId);

            entity.ToTable("YP_MENULER");

            entity.Property(e => e.MenuId)
                .ValueGeneratedNever()
                .HasColumnName("MENU_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Durum)
                .HasMaxLength(50)
                .HasColumnName("DURUM");
            entity.Property(e => e.Ikon)
                .HasMaxLength(25)
                .HasColumnName("IKON");
            entity.Property(e => e.KontrolNoktasiAdi)
                .HasMaxLength(150)
                .HasColumnName("KONTROL_NOKTASI_ADI");
            entity.Property(e => e.MenuAdi)
                .HasMaxLength(150)
                .HasColumnName("MENU_ADI");
            entity.Property(e => e.MenuSirasi).HasColumnName("MENU_SIRASI");
            entity.Property(e => e.OtpGerekli).HasColumnName("OTP_GEREKLI");
            entity.Property(e => e.Url)
                .HasMaxLength(300)
                .HasColumnName("URL");
            entity.Property(e => e.UstMenuId).HasColumnName("UST_MENU_ID");
        });

        modelBuilder.Entity<YpOtpAyar>(entity =>
        {
            entity.HasKey(e => e.YpOtpAyarId).HasName("PK_OTP_AYAR_ID");

            entity.ToTable("YP_OTP_AYAR");

            entity.Property(e => e.YpOtpAyarId).HasColumnName("YP_OTP_AYAR_ID");
            entity.Property(e => e.GecerliAyar).HasColumnName("GECERLI_AYAR");
            entity.Property(e => e.OtpAktif).HasColumnName("OTP_AKTIF");
            entity.Property(e => e.OtpBlokAktif).HasColumnName("OTP_BLOK_AKTIF");
            entity.Property(e => e.OtpBlokBilgiMail)
                .HasMaxLength(200)
                .HasColumnName("OTP_BLOK_BILGI_MAIL");
        });

        modelBuilder.Entity<YpSmsAyar>(entity =>
        {
            entity.HasKey(e => e.AyarId);

            entity.ToTable("YP_SMS_AYAR");

            entity.Property(e => e.AyarId)
                .ValueGeneratedNever()
                .HasColumnName("AYAR_ID");
            entity.Property(e => e.AramaUcret)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("ARAMA_UCRET");
            entity.Property(e => e.Kanal).HasColumnName("KANAL");
            entity.Property(e => e.KullaniciAdi)
                .HasMaxLength(50)
                .HasColumnName("KULLANICI_ADI");
            entity.Property(e => e.ServisUrl)
                .HasMaxLength(250)
                .HasColumnName("SERVIS_URL");
            entity.Property(e => e.Sifre)
                .HasMaxLength(50)
                .HasColumnName("SIFRE");
            entity.Property(e => e.SmsUcret)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SMS_UCRET");
        });

        modelBuilder.Entity<YpSmsDurum>(entity =>
        {
            entity.HasKey(e => e.DurumId);

            entity.ToTable("YP_SMS_DURUM");

            entity.Property(e => e.DurumId).HasColumnName("DURUM_ID");
            entity.Property(e => e.DurumAdi)
                .HasMaxLength(100)
                .HasColumnName("DURUM_ADI");
        });

        modelBuilder.Entity<YpSmsSonuclar>(entity =>
        {
            entity.HasKey(e => e.SmsSonucId);

            entity.ToTable("YP_SMS_SONUCLAR");

            entity.Property(e => e.SmsSonucId)
                .ValueGeneratedNever()
                .HasColumnName("SMS_SONUC_ID");
            entity.Property(e => e.SmsSonucAciklama)
                .HasMaxLength(300)
                .HasColumnName("SMS_SONUC_ACIKLAMA");
        });

        modelBuilder.Entity<YpSmsTuru>(entity =>
        {
            entity.HasKey(e => e.SmsTuruId).HasName("PK_YP_SMS_GONDERME_TURU");

            entity.ToTable("YP_SMS_TURU");

            entity.Property(e => e.SmsTuruId)
                .ValueGeneratedNever()
                .HasColumnName("SMS_TURU_ID");
            entity.Property(e => e.SmsTuruAciklama)
                .HasMaxLength(250)
                .HasColumnName("SMS_TURU_ACIKLAMA");
            entity.Property(e => e.SmsTuruAdi)
                .HasMaxLength(50)
                .HasColumnName("SMS_TURU_ADI");
            entity.Property(e => e.SmsTuruSablon)
                .HasMaxLength(500)
                .HasColumnName("SMS_TURU_SABLON");
        });

        modelBuilder.Entity<YpSucTipleri>(entity =>
        {
            entity.HasKey(e => e.SucTipiId).HasName("PK_SUC_TIPLERI");

            entity.ToTable("YP_SUC_TIPLERI");

            entity.Property(e => e.SucTipiId).HasColumnName("SUC_TIPI_ID");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.SucTipiAdi)
                .HasMaxLength(300)
                .HasColumnName("SUC_TIPI_ADI");
            entity.Property(e => e.UstSucTipiId).HasColumnName("UST_SUC_TIPI_ID");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.YpSucTipleris)
                .HasForeignKey(d => d.KullaniciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUC_TIPLERI_KULLANICILAR");

            entity.HasOne(d => d.UstSucTipi).WithMany(p => p.InverseUstSucTipi)
                .HasForeignKey(d => d.UstSucTipiId)
                .HasConstraintName("FK_SUC_TIPLERI_SUC_TIPLERI");
        });

        modelBuilder.Entity<YpTurkposAyar>(entity =>
        {
            entity.HasKey(e => e.TurkposAyarId);

            entity.ToTable("YP_TURKPOS_AYAR");

            entity.Property(e => e.TurkposAyarId).HasColumnName("TURKPOS_AYAR_ID");
            entity.Property(e => e.ClientCode)
                .HasMaxLength(50)
                .HasColumnName("CLIENT_CODE");
            entity.Property(e => e.ClientPassword)
                .HasMaxLength(50)
                .HasColumnName("CLIENT_PASSWORD");
            entity.Property(e => e.ClientUsername)
                .HasMaxLength(50)
                .HasColumnName("CLIENT_USERNAME");
            entity.Property(e => e.Guid)
                .HasMaxLength(50)
                .HasColumnName("GUID");
        });

        modelBuilder.Entity<YpTurkposSonucLog>(entity =>
        {
            entity.ToTable("YP_TURKPOS_SONUC_LOG");

            entity.Property(e => e.YpTurkposSonucLogId).HasColumnName("YP_TURKPOS_SONUC_LOG_ID");
            entity.Property(e => e.Parametreler).HasColumnName("PARAMETRELER");
            entity.Property(e => e.Sonuc).HasColumnName("SONUC");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<YpUyelikUcretlendirme>(entity =>
        {
            entity.HasKey(e => e.UyelikUcretlendirmeId).HasName("PK_UYELIK_UCRETLENDIRME");

            entity.ToTable("YP_UYELIK_UCRETLENDIRME");

            entity.Property(e => e.UyelikUcretlendirmeId)
                .ValueGeneratedNever()
                .HasColumnName("UYELIK_UCRETLENDIRME_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(200)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Ucret)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("UCRET");
        });

        modelBuilder.Entity<YpUyruklar>(entity =>
        {
            entity.HasKey(e => e.UyrukKodu);

            entity.ToTable("YP_UYRUKLAR");

            entity.Property(e => e.UyrukKodu)
                .HasMaxLength(2)
                .HasColumnName("UYRUK_KODU");
            entity.Property(e => e.UyrukAdi)
                .HasMaxLength(70)
                .HasColumnName("UYRUK_ADI");
            entity.Property(e => e.UyrukId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UYRUK_ID");
        });

        modelBuilder.Entity<YpYetkiGrupKontrolNoktalari>(entity =>
        {
            entity.HasKey(e => e.YetkiGrupKontrolNoktasiId);

            entity.ToTable("YP_YETKI_GRUP_KONTROL_NOKTALARI");

            entity.Property(e => e.YetkiGrupKontrolNoktasiId).HasColumnName("YETKI_GRUP_KONTROL_NOKTASI_ID");
            entity.Property(e => e.KontrolNoktasiId).HasColumnName("KONTROL_NOKTASI_ID");
            entity.Property(e => e.Suid).HasColumnName("SUID");
            entity.Property(e => e.YetkiGrupId).HasColumnName("YETKI_GRUP_ID");

            entity.HasOne(d => d.KontrolNoktasi).WithMany(p => p.YpYetkiGrupKontrolNoktalaris)
                .HasForeignKey(d => d.KontrolNoktasiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_YP_YETKI_GRUP_KONTROL_NOKTALARI_YP_KONTROL_NOKTALARI");

            entity.HasOne(d => d.YetkiGrup).WithMany(p => p.YpYetkiGrupKontrolNoktalaris)
                .HasForeignKey(d => d.YetkiGrupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_YP_YETKI_GRUP_KONTROL_NOKTALARI_YP_YETKI_GRUPLARI");
        });

        modelBuilder.Entity<YpYetkiGruplari>(entity =>
        {
            entity.HasKey(e => e.YetkiGrupId);

            entity.ToTable("YP_YETKI_GRUPLARI");

            entity.Property(e => e.YetkiGrupId).HasColumnName("YETKI_GRUP_ID");
            entity.Property(e => e.KullaniciTipiId).HasColumnName("KULLANICI_TIPI_ID");
            entity.Property(e => e.YetkiGrupAciklama)
                .HasMaxLength(300)
                .HasColumnName("YETKI_GRUP_ACIKLAMA");
            entity.Property(e => e.YetkiGrupAdi)
                .HasMaxLength(150)
                .HasColumnName("YETKI_GRUP_ADI");

            entity.HasOne(d => d.KullaniciTipi).WithMany(p => p.YpYetkiGruplaris)
                .HasForeignKey(d => d.KullaniciTipiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_YP_YETKI_GRUPLARI_YP_KULLANICI_TIPLERI");
        });

        modelBuilder.Entity<ZamanAraligi>(entity =>
        {
            entity.ToTable("ZAMAN_ARALIGI");

            entity.Property(e => e.ZamanAraligiId).HasColumnName("ZAMAN_ARALIGI_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(50)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Dakika).HasColumnName("DAKIKA");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
