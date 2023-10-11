using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class KullaniciTercihleri
{
    public int TercihId { get; set; }

    public int BuroId { get; set; }

    public int KullaniciId { get; set; }

    public int TercihTuruId { get; set; }

    public string TercihAdi { get; set; } = null!;

    public string? TercihAciklama { get; set; }

    public string Deger { get; set; } = null!;

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Kullanicilar Kullanici { get; set; } = null!;

    public virtual YpKullaniciTercihTuru TercihTuru { get; set; } = null!;
}
