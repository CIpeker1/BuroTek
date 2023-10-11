using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class MaktuVekaletUcretleri
{
    public int MaktuVekaletUcretId { get; set; }

    public decimal Tutar { get; set; }

    public DateTime BaslangicTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public DateTime KayitTarihi { get; set; }

    public int KullaniciId { get; set; }
}
