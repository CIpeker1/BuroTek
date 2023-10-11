using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class DavaDosya
{
    public int DavaDosyaId { get; set; }

    public int BuroId { get; set; }

    public int DavaId { get; set; }

    public int DosyaId { get; set; }

    public int KullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Davalar Dava { get; set; } = null!;

    public virtual Dosyalar Dosya { get; set; } = null!;

    public virtual Kullanicilar Kullanici { get; set; } = null!;
}
