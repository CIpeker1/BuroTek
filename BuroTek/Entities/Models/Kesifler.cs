using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class Kesifler
{
    public int KesifId { get; set; }

    public int BuroId { get; set; }

    public int DavaId { get; set; }

    public DateTime KesifTarihi { get; set; }

    public string KesifYeri { get; set; } = null!;

    public string? Aciklama { get; set; }

    public bool UyariYapilsin { get; set; }

    public int? UyariGunOnce { get; set; }

    public bool? UyariSonlandi { get; set; }

    public int OlusturanKullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public int? NotId { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Davalar Dava { get; set; } = null!;

    public virtual Notlar? Not { get; set; }

    public virtual Kullanicilar OlusturanKullanici { get; set; } = null!;
}
