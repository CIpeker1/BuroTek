using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class FaizOranlari
{
    public int FaizOranId { get; set; }

    public int FaizId { get; set; }

    public decimal Oran { get; set; }

    public DateTime BaslangicTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public int KullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public virtual Faizler Faiz { get; set; } = null!;

    public virtual Kullanicilar Kullanici { get; set; } = null!;
}
