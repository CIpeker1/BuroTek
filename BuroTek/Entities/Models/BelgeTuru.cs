using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class BelgeTuru
{
    public int BelgeTuruId { get; set; }

    public string BelgeTuruAdi { get; set; } = null!;

    public int BuroId { get; set; }

    public int KullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual ICollection<Evrak> Evraks { get; set; } = new List<Evrak>();

    public virtual Kullanicilar Kullanici { get; set; } = null!;
}
