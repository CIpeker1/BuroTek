using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class EvrakBaglanti
{
    public int EvrakBaglantiId { get; set; }

    public int BuroId { get; set; }

    public int EvrakId { get; set; }

    public int ModulId { get; set; }

    public int DisKayitNo { get; set; }

    public string EvrakAdi { get; set; } = null!;

    public string DosyaAdi { get; set; } = null!;

    public string? Aciklama { get; set; }

    public DateTime KayitTarihi { get; set; }

    public int KullaniciId { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Evrak Evrak { get; set; } = null!;

    public virtual Kullanicilar Kullanici { get; set; } = null!;

    public virtual Moduller Modul { get; set; } = null!;
}
