using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class Yayinlar
{
    public int YayinId { get; set; }

    public int BuroId { get; set; }

    public int KutuphaneId { get; set; }

    public string YayinAdi { get; set; } = null!;

    public string? YayinEvi { get; set; }

    public int? YayinBasimYili { get; set; }

    public int? Barkod { get; set; }

    public string? YayinKodu { get; set; }

    public string? YazarAdi { get; set; }

    public int? YayinTuruId { get; set; }

    public int? YayinAltTuruId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Kutuphaneler Kutuphane { get; set; } = null!;

    public virtual YayinTurleri? YayinAltTuru { get; set; }

    public virtual ICollection<YayinCikislari> YayinCikislaris { get; set; } = new List<YayinCikislari>();

    public virtual YayinTurleri? YayinTuru { get; set; }
}
