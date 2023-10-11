using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class EntegrasyonLoglari
{
    public int EntegrasyonLoglariId { get; set; }

    public int EntegrasyonId { get; set; }

    public string KullaniciJson { get; set; } = null!;

    public string KullaniciResponseJson { get; set; } = null!;

    public string LoginUrl { get; set; } = null!;

    public string? FaturaUrl { get; set; }

    public string? Token { get; set; }

    public bool BasariDurumu { get; set; }

    public DateTime DuzenlemeTarihi { get; set; }

    public int DuzenleyenKullaniciId { get; set; }

    public string Mesaj { get; set; } = null!;
}
