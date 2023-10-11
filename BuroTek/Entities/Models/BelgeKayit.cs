using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class BelgeKayit
{
    public int BelgeId { get; set; }

    public int BelgeTuruId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public int KayitNo { get; set; }

    public string Konu { get; set; } = null!;

    public string? Sayi { get; set; }

    public int GeldigiGittigiKisiId { get; set; }

    public DateTime UretimTarihi { get; set; }

    public int BelgeErisimHakkiId { get; set; }

    public int BelgeGuvenlikSeviyesiId { get; set; }

    public bool BilgiEdinmeKapsaminda { get; set; }

    public bool TelifHakkiKapsami { get; set; }

    public int BelgeOncelikDerecesiId { get; set; }

    public DateTime? MiadTarihi { get; set; }

    public string? Aciklama { get; set; }

    public int KullaniciId { get; set; }

    public int BuroId { get; set; }

    public int? BelgeSayacId { get; set; }

    public int? SayacSiraNo { get; set; }

    public string? Ek { get; set; }

    public virtual BelgeErisimHakki BelgeErisimHakki { get; set; } = null!;

    public virtual BelgeOncelikDerecesi BelgeOncelikDerecesi { get; set; } = null!;

    public virtual BelgeSayac? BelgeSayac { get; set; }

    public virtual BelgeTuruYeni BelgeTuru { get; set; } = null!;

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Kisiler GeldigiGittigiKisi { get; set; } = null!;

    public virtual Kullanicilar Kullanici { get; set; } = null!;
}
