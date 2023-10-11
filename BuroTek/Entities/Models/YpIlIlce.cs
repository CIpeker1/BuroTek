using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpIlIlce
{
    public int IlIlceId { get; set; }

    public int? IlIlceTuruId { get; set; }

    public string? PlakaKodu { get; set; }

    public int? IlId { get; set; }

    public string? IlIlceAdi { get; set; }

    public virtual ICollection<Burolar> Burolars { get; set; } = new List<Burolar>();

    public virtual ICollection<KisiAdresler> KisiAdreslerIlces { get; set; } = new List<KisiAdresler>();

    public virtual ICollection<KisiAdresler> KisiAdreslerIls { get; set; } = new List<KisiAdresler>();

    public virtual ICollection<Kullanicilar> KullanicilarIlces { get; set; } = new List<Kullanicilar>();

    public virtual ICollection<Kullanicilar> KullanicilarIls { get; set; } = new List<Kullanicilar>();
}
