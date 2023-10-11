using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class IletisimBilgileri
{
    public int IletisimBilgileriId { get; set; }

    public string Baslik { get; set; } = null!;

    public string IletisimBilgileriMetni { get; set; } = null!;

    public int KullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public virtual Kullanicilar Kullanici { get; set; } = null!;
}
