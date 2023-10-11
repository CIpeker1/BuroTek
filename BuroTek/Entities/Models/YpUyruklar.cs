using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpUyruklar
{
    public int UyrukId { get; set; }

    public string UyrukKodu { get; set; } = null!;

    public string UyrukAdi { get; set; } = null!;
}
