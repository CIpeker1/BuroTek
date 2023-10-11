using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class DurusmaDosya
{
    public int DurusmaDosyaId { get; set; }

    public int BuroId { get; set; }

    public int DurusmaId { get; set; }

    public int DosyaId { get; set; }

    public int KullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Dosyalar Dosya { get; set; } = null!;

    public virtual Durusmalar Durusma { get; set; } = null!;

    public virtual Kullanicilar Kullanici { get; set; } = null!;
}
