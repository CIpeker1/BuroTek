using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpSucTipleri
{
    public int SucTipiId { get; set; }

    public string SucTipiAdi { get; set; } = null!;

    public int? UstSucTipiId { get; set; }

    public int KullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public virtual ICollection<Davalar> Davalars { get; set; } = new List<Davalar>();

    public virtual ICollection<YpSucTipleri> InverseUstSucTipi { get; set; } = new List<YpSucTipleri>();

    public virtual Kullanicilar Kullanici { get; set; } = null!;

    public virtual YpSucTipleri? UstSucTipi { get; set; }
}
