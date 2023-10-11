using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class Kisiler
{
    public int KisiId { get; set; }

    public int BuroId { get; set; }

    public int KisiTipiId { get; set; }

    public int? KisiSiraNo { get; set; }

    public string? Ad { get; set; }

    public string? Soyad { get; set; }

    public string? TuzelKisiAdi { get; set; }

    public string? TcKimlikNo { get; set; }

    public string? VergiNo { get; set; }

    public string? VergiDairesi { get; set; }

    public string? MersisNo { get; set; }

    public string? Telefon { get; set; }

    public string? Faks { get; set; }

    public string? CepTelefon { get; set; }

    public string? EPosta { get; set; }

    public int KullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public bool? Muvekkil { get; set; }

    public bool? KarsiTaraf { get; set; }

    public int? TemsilTuruId { get; set; }

    public string? YasalTemsilciAd { get; set; }

    public string? YasalTemsilciSoyad { get; set; }

    public bool? YabanciUyrukluMu { get; set; }

    public string? PasaportNo { get; set; }

    public bool? Diger { get; set; }

    public string? DigerAciklama { get; set; }

    public virtual ICollection<BelgeKayit> BelgeKayits { get; set; } = new List<BelgeKayit>();

    public virtual Burolar Buro { get; set; } = null!;

    public virtual ICollection<CariIslemler> CariIslemlers { get; set; } = new List<CariIslemler>();

    public virtual ICollection<DanismaKisi> DanismaKisis { get; set; } = new List<DanismaKisi>();

    public virtual ICollection<DavaKisiler> DavaKisilers { get; set; } = new List<DavaKisiler>();

    public virtual ICollection<Evrak> Evraks { get; set; } = new List<Evrak>();

    public virtual ICollection<IcraKisiler> IcraKisilers { get; set; } = new List<IcraKisiler>();

    public virtual ICollection<KisiAdresler> KisiAdreslers { get; set; } = new List<KisiAdresler>();

    public virtual ICollection<KisiSozlesmeler> KisiSozlesmelers { get; set; } = new List<KisiSozlesmeler>();

    public virtual KisiTipi KisiTipi { get; set; } = null!;

    public virtual ICollection<KisiVekaletler> KisiVekaletlers { get; set; } = new List<KisiVekaletler>();

    public virtual Kullanicilar Kullanici { get; set; } = null!;

    public virtual ICollection<KullaniciSmsLog> KullaniciSmsLogs { get; set; } = new List<KullaniciSmsLog>();

    public virtual YasalTemsilTurleri? TemsilTuru { get; set; }
}
