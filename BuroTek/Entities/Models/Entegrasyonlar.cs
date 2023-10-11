using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class Entegrasyonlar
{
    public int EntegrasyonId { get; set; }

    public bool Aktif { get; set; }

    public string EntegrasyonAdi { get; set; } = null!;

    public string BaseAdres { get; set; } = null!;

    public string? LoginUrl { get; set; }

    public string EntegrasyonUrl { get; set; } = null!;

    public string? KullaniciAdi { get; set; }

    public string? Sifre { get; set; }

    public DateTime Tarih { get; set; }
}
