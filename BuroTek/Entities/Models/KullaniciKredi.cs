using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class KullaniciKredi
{
    public int KullaniciKrediId { get; set; }

    public int BuroId { get; set; }

    public int? KullaniciId { get; set; }

    public decimal Kredi { get; set; }

    public DateTime KayitTarihi { get; set; }

    public int KrediSahipTipiId { get; set; }

    public decimal KullanimdakiKredi { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual YpKrediSahipTipleri KrediSahipTipi { get; set; } = null!;

    public virtual Kullanicilar? Kullanici { get; set; }
}
