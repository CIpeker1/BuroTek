using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class Davalar
{
    public int DavaId { get; set; }

    public int BuroId { get; set; }

    public int IlgilenenAvukatId { get; set; }

    public int DavaTuruId { get; set; }

    public string? DosyaNo { get; set; }

    public int DavaSiraNo { get; set; }

    public DateTime? DavaTarihi { get; set; }

    public int KurumId { get; set; }

    public string? DosyaEsasNo { get; set; }

    public string? KararNo { get; set; }

    public string? TemyizEsasNo { get; set; }

    public string? TemyizKararNo { get; set; }

    public DateTime? KararTarihi { get; set; }

    public string? KararOzeti { get; set; }

    public DateTime? ItirazTemyizTarihi { get; set; }

    public string? ItirazTemyizAciklama { get; set; }

    public DateTime? KesinlesmeTarihi { get; set; }

    public string? KesinlesmeKararOzeti { get; set; }

    public int DavaDurumId { get; set; }

    public string? Aciklama { get; set; }

    public int OlusturanKullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public int? DanismaId { get; set; }

    public string? KlasorNo { get; set; }

    public int? SucTipiId { get; set; }

    public bool? Kilit { get; set; }

    public int? KullaniciId { get; set; }

    public string? SorusturmaNo { get; set; }

    public bool? ArsiveKaldirildi { get; set; }

    public string? ArsivNo { get; set; }

    public decimal? AnlasmaTutari { get; set; }

    public virtual Danisma? Danisma { get; set; }

    public virtual ICollection<DavaDosya> DavaDosyas { get; set; } = new List<DavaDosya>();

    public virtual DavaDurum DavaDurum { get; set; } = null!;

    public virtual ICollection<DavaKisiler> DavaKisilers { get; set; } = new List<DavaKisiler>();

    public virtual DavaTurleri DavaTuru { get; set; } = null!;

    public virtual ICollection<Durusmalar> Durusmalars { get; set; } = new List<Durusmalar>();

    public virtual ICollection<EmsalKarar> EmsalKarars { get; set; } = new List<EmsalKarar>();

    public virtual Kullanicilar IlgilenenAvukat { get; set; } = null!;

    public virtual ICollection<Kesifler> Kesiflers { get; set; } = new List<Kesifler>();

    public virtual Kullanicilar? Kullanici { get; set; }

    public virtual YpKurumTanimlari Kurum { get; set; } = null!;

    public virtual Kullanicilar OlusturanKullanici { get; set; } = null!;

    public virtual YpSucTipleri? SucTipi { get; set; }
}
