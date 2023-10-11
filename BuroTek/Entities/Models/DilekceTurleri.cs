using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class DilekceTurleri
{
    public int DilekceTuruId { get; set; }

    public string DilekceTuruAdi { get; set; } = null!;

    public int KayitKullaniciId { get; set; }

    public int GuncellemeKullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public DateTime GuncellemeTarihi { get; set; }

    public virtual ICollection<DilekceMevzuat> DilekceMevzuats { get; set; } = new List<DilekceMevzuat>();

    public virtual Kullanicilar GuncellemeKullanici { get; set; } = null!;

    public virtual Kullanicilar KayitKullanici { get; set; } = null!;
}
