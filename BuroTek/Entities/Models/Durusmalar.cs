using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class Durusmalar
{
    public int DurusmaId { get; set; }

    public int BuroId { get; set; }

    public int DavaId { get; set; }

    public DateTime DurusmaTarihi { get; set; }

    public string? DurusmaYeri { get; set; }

    public string? Aciklama { get; set; }

    public bool UyariYapilsin { get; set; }

    public int? UyariGunOnce { get; set; }

    public bool? UyariSonlandi { get; set; }

    public string? DurusmaKarar { get; set; }

    public int OlusturanKullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public int? NotId { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Davalar Dava { get; set; } = null!;

    public virtual ICollection<DurusmaDosya> DurusmaDosyas { get; set; } = new List<DurusmaDosya>();

    public virtual Notlar? Not { get; set; }

    public virtual Kullanicilar OlusturanKullanici { get; set; } = null!;
}
