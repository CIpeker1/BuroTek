using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpKullaniciSozlesme
{
    public int KullaniciSozlesmeId { get; set; }

    public int BuroId { get; set; }

    public int KullaniciId { get; set; }

    public DateTime BaslangicTarihi { get; set; }

    public DateTime BitisTarihi { get; set; }

    public int UyelikUcretlendirmeId { get; set; }

    public int IslemYapanKullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public bool UcretsizSekreter { get; set; }

    public decimal? SozlesmeTutari { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Kullanicilar IslemYapanKullanici { get; set; } = null!;

    public virtual Kullanicilar Kullanici { get; set; } = null!;

    public virtual YpUyelikUcretlendirme UyelikUcretlendirme { get; set; } = null!;
}
