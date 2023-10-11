using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class OkunanKampanyalar
{
    public int OkunanKampanyaId { get; set; }

    public int KullaniciId { get; set; }

    public int KampanyaId { get; set; }

    public bool AktifMi { get; set; }

    public DateTime OkumaTarihi { get; set; }

    public virtual Kullanicilar Kullanici { get; set; } = null!;
}
