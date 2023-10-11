using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpKrediKartiAyar
{
    public int KrediKartiAyarId { get; set; }

    public string KullaniciAdi { get; set; } = null!;

    public string Sifre { get; set; } = null!;

    public string ClientId { get; set; } = null!;

    public string SanalPosUrl { get; set; } = null!;
}
