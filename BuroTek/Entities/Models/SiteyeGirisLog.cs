using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class SiteyeGirisLog
{
    public int SiteyeGirisLogId { get; set; }

    public string ErisimIp { get; set; } = null!;

    public int KullaniciIslemTuruId { get; set; }

    public string Aciklama { get; set; } = null!;

    public DateTime KayitTarihi { get; set; }

    public virtual KullaniciIslemTuru KullaniciIslemTuru { get; set; } = null!;
}
