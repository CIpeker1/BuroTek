using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class KisiVekaletDosya
{
    public int KisiVekaletDosyaId { get; set; }

    public int BuroId { get; set; }

    public int KisiVekaletId { get; set; }

    public int DosyaId { get; set; }

    public int KullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Dosyalar Dosya { get; set; } = null!;

    public virtual KisiVekaletler KisiVekalet { get; set; } = null!;

    public virtual Kullanicilar Kullanici { get; set; } = null!;
}
