using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class Evrak
{
    public int EvrakId { get; set; }

    public int BuroId { get; set; }

    public int EvrakTuruId { get; set; }

    public int? GelenGidenKisiId { get; set; }

    public int? GeldigiGittigiKurumId { get; set; }

    public string? BelgeNo { get; set; }

    public DateTime? BelgeTarihi { get; set; }

    public string? Konu { get; set; }

    public string? Aciklama { get; set; }

    public DateTime KayitTarihi { get; set; }

    public int OlusturanKullaniciId { get; set; }

    public int? BelgeTuruId { get; set; }

    public string? KurumBelgeNo { get; set; }

    public DateTime? KurumBelgeTarihi { get; set; }

    public int? ModulId { get; set; }

    public int? DisKayitNo { get; set; }

    public int? SiraNo { get; set; }

    public int? Yil { get; set; }

    public string? BuroDosya { get; set; }

    public virtual BelgeTuru? BelgeTuru { get; set; }

    public virtual ICollection<EvrakBaglanti> EvrakBaglantis { get; set; } = new List<EvrakBaglanti>();

    public virtual ICollection<EvrakDosya> EvrakDosyas { get; set; } = new List<EvrakDosya>();

    public virtual EvrakTuru EvrakTuru { get; set; } = null!;

    public virtual YpKurumTanimlari? GeldigiGittigiKurum { get; set; }

    public virtual Kisiler? GelenGidenKisi { get; set; }
}
