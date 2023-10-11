using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YayinCikislari
{
    public int YayinCikisId { get; set; }

    public int BuroId { get; set; }

    public int YayinId { get; set; }

    public bool? TeslimAlindi { get; set; }

    public int? KullaniciId { get; set; }

    public DateTime VerilisTarihi { get; set; }

    public DateTime AlinmasiGerekenTarih { get; set; }

    public DateTime? TeslimTarihi { get; set; }

    public DateTime YayinKayitTarihi { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Kullanicilar? Kullanici { get; set; }

    public virtual Yayinlar Yayin { get; set; } = null!;
}
