using BuroTek.Core.Entities;

namespace BuroTek.Entities.Models
{
    public class ADRES_TIPLERI : IEntity
    {
        public int ADRES_TIPI_ID { get; set; }
        public string ADRES_TIPI_ADI { get; set; }
    }
    public class ARSIV : IEntity
    {
        public int ARSIV_ID { get; set; }
        public int DOSYA_ID { get; set; }
        public int ARSIV_YONETEMI_ID { get; set; }
        public int BURO_ID { get; set; }
        public int ARSIV_TURU_ID { get; set; }
        public string KONU { get; set; }
        public string ILGI { get; set; }
        public string ACIKLAMA { get; set; }
        public string BOLUM_NO { get; set; }
        public string KLASOR_NO { get; set; }
        public int KULLANICI_ID { get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
        public int MODUL_ID { get; set; }
        public int DIS_KAYIT_NO { get; set; }
    }
    public class ARSIV_TURU : IEntity
    {
        public int ARSIV_TURU_ID { get; set; }
        public string ARSIV_TURU_ADI { get; set; }
        public int BURO_ID { get; set; }
        public int KULLANICI_ID { get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
    }
    public class ARSIV_YONETIMI : IEntity
    {
        public int ARSIV_YONETIMI_ID { get; set; }
        public int BURO_ID { get; set; }
        public int UST_KLASOR_ID { get; set; }
        public string KLASOR_ADI { get; set; }
        public int KULLANICI_ID { get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
    }
    public class BELGE_ERISIM_HAKKI : IEntity
    {
        public int BELGE_ERISIM_HAKKI_ID { get; set; }
        public string BELGE_ERISIM_ADI { get; set; }
    }
    public class BELGE_GUVENLIK_SEVIYESI : IEntity
    {
        public int BELGE_GUVENLIK_SEVIYESI_ID { get; set; }
        public string BELGE_GUVENLIK_SEVIYESI_ADI { get; set; }
    }
    public class BELGE_KAYIT : IEntity
    {
        public int BELGE_ID { get; set; }
        public int BELGE_TURU_ID { get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
        public int KAYIT_NO { get; set; }
        public string KONU { get; set; }
        public string SAYI { get; set; }
        public int GELDIGI_GITTIGI_KISI_ID { get; set; }
        public DateTime URETIM_TARIHI { get; set; }
        public int BELGE_ERISIM_HAKKI_ID { get; set; }
        public int BELGE_GUVENLIK_SEVIYESI_ID { get; set; }
        public bool BILGI_EDINME_KAPSAMINDA { get; set; }
        public bool TELIF_HAKKI_KAPSAMI { get; set; }
        public int BELGE_ONCELIK_DERECESI_ID { get; set; }
        public DateTime MIAD_TARIHI { get; set; }
        public string ACIKLAMA { get; set; }
        public int KULLANICI_ID { get; set; }
        public int BURO_ID { get; set; }
        public int BELGE_SAYAC_ID { get; set; }
        public int SAYAC_SIRA_NO { get; set; }
        public string EK { get; set; }
    }
    public class BELGE_ONCELIK_DERECESI : IEntity
    {
        public int BELGE_ONCELIK_DERECESI_ID { get; set; }
        public string BELGE_ONCELIK_DERECESI_ADI { get; set; }
        public int KULLANICI_ID { get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
        public int BURO_ID { get; set; }
    }
    public class BELGE_SAYAC : IEntity
    {
        public int BELGE_SAYAC_ID { get; set; }
        public string BELGE_SAYAC_ADI { get; set; }
        public int BELGE_SAYAC_SIRA_NO { get; set; }
        public int BELGE_TURU_ID { get; set; }
        public int YIL { get; set; }
        public int BURO_ID { get; set; }
    }
    public class BELGE_TURU : IEntity
    {
        public int BELGE_TURU_ID { get; set; }
        public string BELGE_TURU_ADI { get; set; }
        public int BURO_ID { get; set; }
        public int KULLANICI_ID { get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
    }
    public class BELGE_TURU_YENI : IEntity
    {
        public int BELGE_TURU_ID { get; set; }
        public string BELGE_TURU_ADI { get; set; }
    }
    public class BILGILENDIRILECEKLER : IEntity
    {
        public int BILGILENDIRILECEK_ID { get; set; }
        public string ARANACAK_TEL_NO { get; set; }
        public int BILGILENDIRME_ID { get; set; }
        public int BURO_ID { get; set; }
        public int BILGILENDIRME_KUYRUK_ID { get; set; }
    }
    public class BILGILENDIRME : IEntity
    {
        public int BILGILENDIRME_ID { get; set; }
        public string BILGILENDIRME_MESAJI { get; set; }
        public string BILGILENDIRME_SES_YOLU { get; set; }
        public bool ARANDI { get; set; }
    }
    public class BURO_GECICI : IEntity
    {
        public int BURO_GECICI_ID { get; set; }
        public string BURO_ADI { get; set; }
        public int BURO_IL_ID { get; set; }
        public int BURO_ILCE_ID { get; set; }
        public string BURO_TELEFON { get; set; }
        public string BURO_FAKS { get; set; }
        public string BURO_ADRES { get; set; }
        public bool AKTIF { get; set; }
        public int ISLEM_ID { get; set; }
    }
    public class BUROLAR : IEntity
    {
        public int BURO_ID { get; set; }
        public string BURO_ADI { get; set; }
        public int BURO_IL_ID { get; set; }
        public int BURO_ILCE_ID { get; set; }
        public string BURO_TELEFON { get; set; }
        public string BURO_FAKS { get; set; }
        public string BURO_ADRES { get; set; }
        public string EPOSTA { get; set; }
        public string WEB_SITE { get; set; }
        public string IBAN_NO { get; set; }
        public string SMS_BASLIK { get; set; }
        public bool AKTIF { get; set; }
        public bool CARI_ISLEM_GECMISI_SEKRETER_GORMESIN { get; set; }
    }
    public class CARI_HESAP_KODLARI : IEntity
    {
        public int CARI_HESAP_KODU_ID { get; set; }
        public string CARI_HESAP_KODU { get; set; }
        public string CARI_HESAP_ADI { get; set; }
        public int HESAP_TURU_ID { get; set; }
        public int BURO_ID { get; set; }
    }
    public class CARI_ISLEMLER : IEntity
    {
        public int CARI_ISLEM_ID { get; set; }
        public int BURO_ID { get; set; }
        public int CARI_HESAP_KODU_ID { get; set; }
        public DateTime TARIH { get; set; }
        public int ISLEM_YAPAN_KULLANICI_ID { get; set; }
        public int CARI_ID { get; set; }
        public decimal TUTAR { get; set; }
        public string ACIKLAMA { get; set; }
        public int DIS_KAYIT_NO { get; set; }
        public int MODUL_ID { get; set; }
        public int KISI_ID { get; set; }
        public DateTime CARI_TARRIHI { get; set; }
        public bool ODENDI { get; set; }
        public string EMAKBUZ_GUID { get; set; }
    }
    public class CARILER : IEntity
    {
        public int CARI_ID { get; set; }
        public int BURO_ID { get; set; }
        public string CARI_ADI { get; set; }
        public string KISA_ADI { get; set; }
        public string ILGILI_KISI_AD_SOYAD { get; set; }
        public string VERGI_DAIRESI { get; set; }
        public string VERGI_NO { get; set; }
        public string ADRES { get; set; }
        public string TELEFON { get; set; }
    }
    public class CRM_LOGLARI : IEntity
    {
        public int CRM_LOG_ID { get; set; }
        public string UYGULAMA_ADI { get; set; }
        public int KULLANICI_ID { get; set; }
        public DateTime TARIH { get; set; }
        public DateOnly BASLANGIC_TARIHI { get; set; }
        public DateOnly BITIS_TARIHI { get; set; }
        public string IP { get; set; }
        public bool BASARI_DURUMU { get; set; }
        public string MESAJ { get; set; }
        public int YENI_UYE_SAYISI { get; set; }
        public int UYELIK_UZATMA_SAYISI { get; set; }
        public int KREDI_YUKLEME_KISI_SAYISI { get; set; }
        public decimal YENI_UYELIK_TUTAR { get; set; }
        public decimal UYELIK_UZARMA_TUTAR { get; set; }
        public decimal KREDI_YUKLEME_TUTAR { get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
    }
    public class DANISMA : IEntity
    {
        public int DANISMA_ID { get; set; }
        public int BURO_ID { get; set; }
        public string BURO_DANISMA_NO { get; set; }
        public string DOSYA_NO{ get; set; }
        public DateTime DOSYA_TARIHI { get; set; }
        public string KONU { get; set; }
        public string ACIKLAMA { get; set; }
        public int HIZMET_TIPI_ID { get; set; }
        public int ATANAN_AVUKAT_ID { get; set; }
        public int KULLANICI_ID { get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
        public int SIRA_NO { get; set; }
        public string DELIL { get; set; }
        public string DANISAN_TALEPLERI { get; set; }
        public bool ARSIVE_KALDIRILDI { get; set; }
        public string KARSI_TARAF_ADSOYAD { get; set; }
        public bool KILIT { get; set; }
        public string ILGILI_KURUM { get; set; }
        public string ILGII_KURUM { get; set; }
        public string KURUM_NO { get; set; }
        public decimal ANLASMA_TUTARI { get; set; }
        public string ARABULUCUKLUK_DOSYA_NO { get; set; }
        public int ARABULUCULUK_YP_KURUM_TANIM_ID { get; set; }
    }
    public class DANISMA_DOSYA : IEntity
    {
        public int DANISMA_DOSYA_ID { get; set; }
        public int BURO_ID { get; set; }
        public int DANISMA_ID { get; set; }
        public int DOSYA_ID { get; set; }
        public int KULLANICI_ID { get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
        public string ACIKLAMA { get; set; }
    }
    public class DANISMA_KISI : IEntity
    {
        public int DANISMA_KISI_ID { get; set; }
        public int DANISMA_ID { get; set; }
        public int KISI_ID { get; set; }
        public int KISI_SOZLESME_ID { get; set; }
    }
    public class DAVA_DOSYA : IEntity
    {
        public int DAVA_DOSYA_ID { get; set; }
        public int BURO_ID { get; set; }
        public int DAVA_ID { get; set; }
        public int DOSYA_ID { get; set; }
        public int KULLANICI_ID { get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
    }
    public class DAVA_DURUM : IEntity
    {
        public int DAVA_DURUM_ID { get; set; }
        public string DAVA_DURUM_ADI { get; set; }
    }
    public class DAVA_KISILER : IEntity
    {
        public int DAVA_KISI_ID { get; set; }
        public int BURO_ID { get; set; }
        public int DAVA_ID { get; set; }
        public int KISI_ID { get; set; }
        public int KISI_SOZLESME_ID { get; set; }
        public int KISI_VEKALET_ID { get; set; }
        public int KISI_ROL_ID { get; set; }
        public string KARSI_TARAF_AVUKAT_AD_SOYAD { get; set; }
        public string KARSI_TARAF_AVUKAT_TELEFON { get; set; }
        public string ACIKLAMA { get; set; }
        public int OLUSTURAN_KULLANICI_ID { get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
        public bool MUVEKKIL_DAVACI { get; set; }
        public string DIGER_ACIKLAMA { get; set; }
    }
    public class DAVA_TURLERI : IEntity
    {
        public int DAVA_TURU_ID { get; set; }
        public string DAVA_TURU_ADI { get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
        public int KULLANICI_ID { get; set; }
        public int DAVA_TURU_TIPI_ID { get; set; }
    }
    public class DAVA_TURU_TIPLERI : IEntity
    {
        public int DAVA_TURU_TIPI_ID { get; set; }
        public string DAVA_TURU_TIPI_ADI { get; set; }
    }
    public class DAVALAR : IEntity
    {
        public int DAVA_ID { get; set; }
        public int BURO_ID { get; set; }
        public int ILGINENEN_AVUKAT_ID { get; set; }
        public int DAVA_TURU_ID { get; set; }
        public string DOSYA_NO { get; set; }
        public int DOSYA_SIRA_NO { get; set; }
        public DateTime DAVA_TARIHI { get; set; }
        public int KURUM_ID { get; set; }
        public string DOSYA_ESAS_NO { get; set; }
        public string KARAR_NO { get; set; }
        public string TEMYIZ_ESAS_NO { get; set; }
        public string TEMYIZ_KARAR_NO { get; set; }
        public DateTime KARAR_TARIHI { get; set; }
        public string KARAR_OZETI { get; set; }
        public DateTime ITIRAZ_TEMYIZ_TARIHI { get; set; }
        public string ITIRAZ_TEMYIZ_ACIKLAMA { get; set; }
        public DateTime KESINLESME_TARIHI { get; set; }
        public string KESINLESME_KARAR_OZETI { get; set; }
        public int DAVA_DURUM_ID { get; set; }
        public string ACIKLAMA { get; set; }
        public int OLUSTURAN_KULLANICI_ID { get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
        public int DANISMA_ID { get; set; }
        public string KLASOR_NO { get; set; }
        public int SUC_TIPI_ID { get; set; }
        public bool KILIT { get; set; }
        public int KULLANICI_ID { get; set; }
        public string SORUSTURMA_NO { get; set; }
        public bool ARSIVE_KALDIRILDI { get; set; }
        public string ARSIC_NO { get; set; }
        public decimal ANLASMA_TUTARI { get; set; }
    }
    public class DEMIRBAS : IEntity
    {
        public int DEMIRBAS_ID { get; set; }
        public int BURO_ID { get; set; }
        public int LOKASYON_ID { get; set; }
        public int KULLANICI_ID { get; set; }
        public int DEMIRBAS_DURUM_ID { get; set; }
        public int BARKOD { get; set; }
        public int TASINIR_GRUBU_ID { get; set; }
        public string DEMIRBAS_ADI { get; set; }
        public string DEMIRBAS_KODU { get; set; }
        public DateTime GARANTI_BASLANGIC_TARIHI { get; set; }
        public DateTime GARANTI_BITIS_TARIHI { get; set; }
        public string ACIKLAMA { get; set; }
        public decimal FIYATI { get; set; }
        public string FATURA_NO { get; set; }
        public DateTime FATURA_TARIHI { get; set; }
        public string SERI_NO { get; set; }
        public string ALINAN_FIRMA { get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
    }
    public class DEMIRBAS_DOSYA : IEntity
    {
        public int DEMIRBAS_DOSYA_ID { get; set; }
        public int BURO_ID { get; set; }
        public int DEMIRBAS_ID { get; set; }
        public int DOSYA_ID { get; set; }
        public int KULLANICI_ID { get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
    }
    public class DEMIRBAS_DURUMLARI : IEntity
    {
        public int DEMIRBAS_DURUM_ID { get; set; }
        public string DEMIRBAS_DURUM_ADI { get; set; }
        public bool DEMIRBAS_DURUMU { get; set; }
    }
    public class DILEKCE_MEVZUAT : IEntity
    {
        public int DILEKCE_MEVZUAT_ID { get; set; }
        public int DILEKCE_MEVZUAT_TURU_ID { get; set; }
        public int DILEKCE_TURU { get; set; }
        public bool SISTEM { get; set; }
        public string DILEKCE_MEVZUAT_DOSYA_ADI { get; set; }
        public int DILEKCE_MEVZUAT_DOSYA_ID { get; set; }
        public string UZANTI { get; set; }
        public int DOSYA_BOYUTU { get; set; }
        public int KULLANICI_ID { get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
        public string ACIKLAMA { get; set; }
        public int BURO_ID { get; set; }
        public string DOSYA_TIPI { get; set; }
    }
    public class DILEKCE_MEVZUAT_DOSYA : IEntity
    {
        public int DILEKCE_MEVZUAT_DOSYA_ID { get; set; }
        //public byte[] DILEKCE_MEVZUAT_DOSYA { get; set; }
    }
    public class DILEKCE_MEVZUAT_TURU : IEntity
    {
        public int DILEKCE_MEVZUAT_TURU_ID { get; set; }
        public string DILEKCE_MEVZUAT_TURU_ADI { get; set; }
    }
    public class DILEKCE_TURLERI : IEntity
    {
        public int DILEKCE_TURU_ID { get; set; }
        public string DILEKCE_TURU_ADI { get; set; }
        public int KAYIT_KULLANICI_ID { get; set; }
        public int GUNCELLEME_KULLANICI_ID { get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
        public DateTime GUNCELLEME_TARIHI { get; set; }
    }
    public class DONUSUM_DURUMLARI : IEntity
    {
        public int DONUSUM_DURUM_ID { get; set; }
        public string DONUSUM_DURUM_ADI { get; set; }
    }
    public class DOSYA_ILISKILER : IEntity
    {
        public int DOSYA_ILISKI_ID { get; set; }
        public int BURO_ID { get; set; }
        public int KAYIT_ID { get; set; }
        public int DIS_KAYIT_ID { get; set; }
        public int MODUL_ID { get; set; }
        public int KULLANICI_ID { get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
    }
    public class DOSYALAR : IEntity
    {
        public int DOSYA_ID { get; set; }
        public int BUTO_ID { get; set; }
        public string DOSYA_ADI { get; set; }
        public string UZANTI { get; set; }
        public string ACIKLAMA { get; set; }
        public int DOSYA_BOYUTU { get; set; }
        public string DOSYA_TIPI { get; set; }
        public int KULLANICI_ID { get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
        public string OCR_METIN { get; set; }
        public string DEPO_DOSYA_ADI { get; set; }
    }
    public class DURUSMA_DOSYA : IEntity
    {
        public int DURUSMA_DOSYA_ID { get; set; }
        public int BURO_ID { get; set; }
        public int DURUSMA_ID { get; set; }
        public int DOSYA_ID { get; set; }
        public int KULLANICI_ID { get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
    }
    public class DURUSMALAR : IEntity
    {
        public int DURUSMA_ID { get; set; }
        public int BURO_ID { get; set; }
        public int DAVA_ID { get; set; }
        public DateTime DURUSMA_TARIHI { get; set; }
        public string DURUSMA_YERI { get; set; }
        public string ACIKLAMA { get; set; }
        public bool UYARI_YAPILSIN { get; set; }
        public bool UYARI_GUN_ONCE { get; set; }
        public bool UYARI_SONLANDI { get; set; }
        public string DURUSMA_KARAR { get; set; }
        public int OLUSTURAN_KULLANICI_ID { get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
        public int NOT_ID { get; set; }
    }

}
