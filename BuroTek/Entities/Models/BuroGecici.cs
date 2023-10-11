using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class BuroGecici
{
    public int BuroGeciciId { get; set; }

    public string BuroAdi { get; set; } = null!;

    public int BuroIlId { get; set; }

    public int BuroIlceId { get; set; }

    public string BuroTelefon { get; set; } = null!;

    public string BuroFaks { get; set; } = null!;

    public string? BuroAdres { get; set; }

    public bool Aktif { get; set; }

    public int IslemId { get; set; }

    public virtual KrediKartiIslemleri Islem { get; set; } = null!;
}
