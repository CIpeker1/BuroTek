using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class Icralar
{
    public int IcraId { get; set; }

    public int BuroId { get; set; }

    public DateTime TakipTarihi { get; set; }

    public int IlgilenAvukatId { get; set; }

    public string? DosyaNo { get; set; }

    public int IcraTakipTuruId { get; set; }

    public int? IcraSiraNo { get; set; }

    public int? FoyNo { get; set; }

    public string? OzelFoyNo { get; set; }

    public int? TakipYoluTuruId { get; set; }

    public int? IcraDaireId { get; set; }

    public string? BorcunSebebi { get; set; }

    public int IcraDurumId { get; set; }

    public DateTime? SonIslemTarihi { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? InfazTarihi { get; set; }

    public DateTime? ItirazTemyizTarihi { get; set; }

    public string? ItirazTemyizAciklama { get; set; }

    public int OlusturanKullaniciId { get; set; }

    public int? DisKayitNo { get; set; }

    public int? DanismaId { get; set; }

    public decimal? TakipTutari { get; set; }

    public bool? ArsiveKaldirildi { get; set; }

    public bool? Kilit { get; set; }

    public decimal? AnlasmaTutari { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Danisma? Danisma { get; set; }

    public virtual ICollection<EmsalKarar> EmsalKarars { get; set; } = new List<EmsalKarar>();

    public virtual IcraDaireleri? IcraDaire { get; set; }

    public virtual ICollection<IcraDosya> IcraDosyas { get; set; } = new List<IcraDosya>();

    public virtual IcraDurum IcraDurum { get; set; } = null!;

    public virtual ICollection<IcraKisiler> IcraKisilers { get; set; } = new List<IcraKisiler>();

    public virtual IcraTakipTuru IcraTakipTuru { get; set; } = null!;

    public virtual Kullanicilar IlgilenAvukat { get; set; } = null!;

    public virtual Kullanicilar OlusturanKullanici { get; set; } = null!;

    public virtual TakipYoluTuru? TakipYoluTuru { get; set; }
}
