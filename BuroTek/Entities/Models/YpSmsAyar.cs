using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpSmsAyar
{
    public int AyarId { get; set; }

    public string KullaniciAdi { get; set; } = null!;

    public string Sifre { get; set; } = null!;

    public int Kanal { get; set; }

    public string ServisUrl { get; set; } = null!;

    public decimal SmsUcret { get; set; }

    public decimal? AramaUcret { get; set; }
}
