using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class KullaniciLog
{
    public int KullaniciLogId { get; set; }

    public int BuroId { get; set; }

    public int FormId { get; set; }

    public int KullaniciId { get; set; }

    public int KullaniciIslemTuruId { get; set; }

    public DateTime IslemTarihi { get; set; }

    public string? ErisilenIp { get; set; }

    public string? Aciklama { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual YpFormlar Form { get; set; } = null!;

    public virtual Kullanicilar Kullanici { get; set; } = null!;

    public virtual KullaniciIslemTuru KullaniciIslemTuru { get; set; } = null!;
}
