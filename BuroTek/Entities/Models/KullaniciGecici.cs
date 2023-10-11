using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class KullaniciGecici
{
    public int KullaniciGeciciId { get; set; }

    public string KullaniciSifre { get; set; } = null!;

    public string KullaniciEposta { get; set; } = null!;

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public string TcKimlikNo { get; set; } = null!;

    public int KullaniciTipiId { get; set; }

    public string Adres { get; set; } = null!;

    public int IlId { get; set; }

    public int IlceId { get; set; }

    public string KullaniciCepTelefon { get; set; } = null!;

    public int IslemId { get; set; }

    public virtual KrediKartiIslemleri Islem { get; set; } = null!;
}
