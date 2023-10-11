using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class KrediKartiIslemleri
{
    public int KrediKartiIslemleriId { get; set; }

    public string TcKimlikNo { get; set; } = null!;

    public string KartSahibiAdSoyad { get; set; } = null!;

    public string KartSahibiCepTelefon { get; set; } = null!;

    public string IpAdresi { get; set; } = null!;

    public string? CcLast4Num { get; set; }

    public DateTime KayitTarihi { get; set; }

    public int? IslemTuruId { get; set; }

    public virtual ICollection<BuroGecici> BuroGecicis { get; set; } = new List<BuroGecici>();

    public virtual YpIslemTuru? IslemTuru { get; set; }

    public virtual ICollection<KrediKartiIslemleriLog> KrediKartiIslemleriLogs { get; set; } = new List<KrediKartiIslemleriLog>();

    public virtual ICollection<KullaniciGecici> KullaniciGecicis { get; set; } = new List<KullaniciGecici>();
}
