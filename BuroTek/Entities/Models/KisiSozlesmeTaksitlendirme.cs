using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class KisiSozlesmeTaksitlendirme
{
    public int KisiSozlesmeTaksitId { get; set; }

    public int KisiSozlesmeId { get; set; }

    public DateTime TaksitBaslamaTarihi { get; set; }

    public DateTime TaksitBitisTarihi { get; set; }

    public decimal TaksitTutar { get; set; }

    public bool? Odendi { get; set; }

    public DateTime? OdemeTarihi { get; set; }

    public int KullaniciId { get; set; }

    public DateTime IslemTarihi { get; set; }

    public virtual KisiSozlesmeler KisiSozlesme { get; set; } = null!;

    public virtual Kullanicilar Kullanici { get; set; } = null!;
}
