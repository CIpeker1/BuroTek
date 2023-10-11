using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class EmakbuzBilgileri
{
    public int EmakbuzBilgileriId { get; set; }

    public string? ReferansNo { get; set; }

    public string? GelenFaturaNo { get; set; }

    public string? GelenEttn { get; set; }

    public bool Durum { get; set; }

    public int KullaniciId { get; set; }

    public DateTime IslemTarihi { get; set; }

    public int ModulId { get; set; }

    public int KayitId { get; set; }
}
