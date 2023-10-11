using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class HarcUcretleri
{
    public int HarcUcretId { get; set; }

    public int HarcTipiId { get; set; }

    public decimal? Oran { get; set; }

    public decimal? HarcUcreti { get; set; }

    public DateTime? BaslangicTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public virtual HarcTipleri HarcTipi { get; set; } = null!;
}
