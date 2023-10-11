using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YayinTurleri
{
    public int YayinTuruId { get; set; }

    public int BuroId { get; set; }

    public int? UstYayinTuruId { get; set; }

    public string YayinTuruAdi { get; set; } = null!;

    public int KullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual ICollection<YayinTurleri> InverseUstYayinTuru { get; set; } = new List<YayinTurleri>();

    public virtual Kullanicilar Kullanici { get; set; } = null!;

    public virtual YayinTurleri? UstYayinTuru { get; set; }

    public virtual ICollection<Yayinlar> YayinlarYayinAltTurus { get; set; } = new List<Yayinlar>();

    public virtual ICollection<Yayinlar> YayinlarYayinTurus { get; set; } = new List<Yayinlar>();
}
