using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class EvrakDosya
{
    public int EvrakDosyaId { get; set; }

    public int BuroId { get; set; }

    public int EvrakId { get; set; }

    public int DosyaId { get; set; }

    public int KullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Dosyalar Dosya { get; set; } = null!;

    public virtual Evrak Evrak { get; set; } = null!;

    public virtual Kullanicilar Kullanici { get; set; } = null!;
}
