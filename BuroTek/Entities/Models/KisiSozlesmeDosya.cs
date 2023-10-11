using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class KisiSozlesmeDosya
{
    public int KisiSozlesmeDosyaId { get; set; }

    public int BuroId { get; set; }

    public int KisiSozlesmeId { get; set; }

    public int DosyaId { get; set; }

    public int KullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Dosyalar Dosya { get; set; } = null!;

    public virtual KisiSozlesmeler KisiSozlesme { get; set; } = null!;

    public virtual Kullanicilar Kullanici { get; set; } = null!;
}
