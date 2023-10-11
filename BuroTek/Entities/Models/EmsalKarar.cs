using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class EmsalKarar
{
    public int EmsalKararId { get; set; }

    public int BuroId { get; set; }

    public int EmsalKararTuruId { get; set; }

    public int? DavaId { get; set; }

    public int? IcraId { get; set; }

    public int KararId { get; set; }

    public int KullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public string? EsasNo { get; set; }

    public string? KararNo { get; set; }

    public DateTime? KararTarihi { get; set; }

    public string? Mahkeme { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Davalar? Dava { get; set; }

    public virtual YpEmsalKararTuru EmsalKararTuru { get; set; } = null!;

    public virtual Icralar? Icra { get; set; }

    public virtual Kullanicilar Kullanici { get; set; } = null!;
}
