using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class Token
{
    public int TokenId { get; set; }

    public string TokenHash { get; set; } = null!;

    public int KullaniciId { get; set; }

    public DateTime GuncellemeZamani { get; set; }

    public string? IpAdresi { get; set; }

    public string? SistemAdi { get; set; }

    public virtual Kullanicilar Kullanici { get; set; } = null!;
}
