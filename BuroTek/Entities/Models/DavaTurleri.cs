using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class DavaTurleri
{
    public int DavaTuruId { get; set; }

    public string DavaTuruAdi { get; set; } = null!;

    public DateTime KayitTarihi { get; set; }

    public int KullaniciId { get; set; }

    public int? DavaTuruTipiId { get; set; }

    public virtual DavaTuruTipleri? DavaTuruTipi { get; set; }

    public virtual ICollection<Davalar> Davalars { get; set; } = new List<Davalar>();

    public virtual Kullanicilar Kullanici { get; set; } = null!;
}
