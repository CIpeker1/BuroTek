using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class KullaniciIslemTuru
{
    public int KullaniciIslemTuruId { get; set; }

    public string KullaniciIslemTuruAdi { get; set; } = null!;

    public virtual ICollection<KullaniciLog> KullaniciLogs { get; set; } = new List<KullaniciLog>();

    public virtual ICollection<SiteyeGirisLog> SiteyeGirisLogs { get; set; } = new List<SiteyeGirisLog>();
}
