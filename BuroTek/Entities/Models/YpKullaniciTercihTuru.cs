using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpKullaniciTercihTuru
{
    public int TercihTuruId { get; set; }

    public string TercihTuruAdi { get; set; } = null!;

    public string? TercihAciklama { get; set; }

    public int DegerTipi { get; set; }

    public string VarsayilanDeger { get; set; } = null!;

    public virtual ICollection<KullaniciTercihleri> KullaniciTercihleris { get; set; } = new List<KullaniciTercihleri>();
}
