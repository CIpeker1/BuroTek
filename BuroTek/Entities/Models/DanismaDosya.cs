using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class DanismaDosya
{
    public int DanismaDosyaId { get; set; }

    public int BuroId { get; set; }

    public int DanismaId { get; set; }

    public int DosyaId { get; set; }

    public int KullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public string? Aciklama { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Danisma Danisma { get; set; } = null!;

    public virtual Dosyalar Dosya { get; set; } = null!;

    public virtual Kullanicilar Kullanici { get; set; } = null!;
}
