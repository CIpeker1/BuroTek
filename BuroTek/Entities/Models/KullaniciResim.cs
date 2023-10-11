using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class KullaniciResim
{
    public int KullaniciResimId { get; set; }

    public byte[] ResimKucuk { get; set; } = null!;

    public byte[] ResimBuyuk { get; set; } = null!;

    public virtual ICollection<Kullanicilar> Kullanicilars { get; set; } = new List<Kullanicilar>();
}
