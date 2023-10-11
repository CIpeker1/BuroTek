using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class ArsivYonetimi
{
    public int ArsivYonetimiId { get; set; }

    public int BuroId { get; set; }

    public int? UstKlasorId { get; set; }

    public string KlasorAdi { get; set; } = null!;

    public int KullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Kullanicilar Kullanici { get; set; } = null!;
}
