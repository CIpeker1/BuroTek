using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class VekalatUcretleri
{
    public int VekalatUcretleriId { get; set; }

    public decimal? MinumumTutar { get; set; }

    public decimal? MaximumTutar { get; set; }

    public double? Oran { get; set; }

    public decimal? MinumumVekaletUcreti { get; set; }

    public DateTime BaslangicTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }
}
