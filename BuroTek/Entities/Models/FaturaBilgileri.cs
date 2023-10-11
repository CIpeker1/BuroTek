using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class FaturaBilgileri
{
    public int FaturaBilgiId { get; set; }

    public int BuroId { get; set; }

    public int KulaniciId { get; set; }

    public bool Kurum { get; set; }

    public bool FaturaGonderilsin { get; set; }

    public string? KurumAdi { get; set; }

    public string? VergiDairesi { get; set; }

    public string? VergiNo { get; set; }

    public string Adres { get; set; } = null!;

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Kullanicilar Kulanici { get; set; } = null!;
}
