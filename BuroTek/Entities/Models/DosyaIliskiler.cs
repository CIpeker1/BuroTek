using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class DosyaIliskiler
{
    public int DosyaIliskiId { get; set; }

    public int BuroId { get; set; }

    public int KayitId { get; set; }

    public int DisKayitId { get; set; }

    public int ModulId { get; set; }

    public int KullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }
}
