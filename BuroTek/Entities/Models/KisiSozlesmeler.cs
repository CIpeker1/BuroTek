using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class KisiSozlesmeler
{
    public int KisiSozlesmeId { get; set; }

    public int? KisiId { get; set; }

    public int? OdemeTuruId { get; set; }

    public decimal? SozlesmeOrani { get; set; }

    public decimal? SozlesmeUcreti { get; set; }

    public decimal? GiderTutar { get; set; }

    public string? GiderTutarAciklama { get; set; }

    public DateTime SozlesmeBaslangicTarihi { get; set; }

    public DateTime? SozlesmeBitisTarihi { get; set; }

    public string Aciklama { get; set; } = null!;

    public int KullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public virtual ICollection<DanismaKisi> DanismaKisis { get; set; } = new List<DanismaKisi>();

    public virtual ICollection<DavaKisiler> DavaKisilers { get; set; } = new List<DavaKisiler>();

    public virtual ICollection<IcraKisiler> IcraKisilers { get; set; } = new List<IcraKisiler>();

    public virtual Kisiler? Kisi { get; set; }

    public virtual ICollection<KisiSozlesmeDosya> KisiSozlesmeDosyas { get; set; } = new List<KisiSozlesmeDosya>();

    public virtual ICollection<KisiSozlesmeTaksitlendirme> KisiSozlesmeTaksitlendirmes { get; set; } = new List<KisiSozlesmeTaksitlendirme>();

    public virtual Kullanicilar Kullanici { get; set; } = null!;

    public virtual OdemeTuru? OdemeTuru { get; set; }
}
