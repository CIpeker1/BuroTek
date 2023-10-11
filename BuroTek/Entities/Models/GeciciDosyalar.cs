using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class GeciciDosyalar
{
    public int GeciciDosyaId { get; set; }

    public string DosyaYolu { get; set; } = null!;

    public DateTime KayitTarihi { get; set; }
}
