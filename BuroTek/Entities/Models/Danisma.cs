using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class Danisma
{
    public int DanismaId { get; set; }

    public int BuroId { get; set; }

    public string? BuroDanismaNo { get; set; }

    public string? DosyaNo { get; set; }

    public DateTime? DosyaTarihi { get; set; }

    public string Konu { get; set; } = null!;

    public string? Aciklama { get; set; }

    public int? HizmetTipiId { get; set; }

    public int? AtananAvukatId { get; set; }

    public int KullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public int? SiraNo { get; set; }

    public string? Delil { get; set; }

    public string? DanisanTalepleri { get; set; }

    public bool? ArsiveKaldirildi { get; set; }

    public string? KarsiTarafAdsoyad { get; set; }

    public bool? Kilit { get; set; }

    public string? IlgiliKurum { get; set; }

    public string? KurumNo { get; set; }

    public decimal? AnlasmaTutari { get; set; }

    public string? ArabuluculukDosyaNo { get; set; }

    public int? ArabuluculukYpKurumTanimId { get; set; }

    public virtual YpKurumTanimlari? ArabuluculukYpKurumTanim { get; set; }

    public virtual Kullanicilar? AtananAvukat { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual ICollection<DanismaDosya> DanismaDosyas { get; set; } = new List<DanismaDosya>();

    public virtual ICollection<DanismaKisi> DanismaKisis { get; set; } = new List<DanismaKisi>();

    public virtual ICollection<Davalar> Davalars { get; set; } = new List<Davalar>();

    public virtual HizmetTipi? HizmetTipi { get; set; }

    public virtual ICollection<Icralar> Icralars { get; set; } = new List<Icralar>();

    public virtual Kullanicilar Kullanici { get; set; } = null!;
}
