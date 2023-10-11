using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class SikcaSorulanSorular
{
    public int SikcaSorulanSoruId { get; set; }

    public string Soru { get; set; } = null!;

    public string Cevap { get; set; } = null!;

    public DateTime KayitTarihi { get; set; }

    public int KullaniciId { get; set; }

    public int? KullaniciTipiId { get; set; }

    public virtual Kullanicilar Kullanici { get; set; } = null!;
}
