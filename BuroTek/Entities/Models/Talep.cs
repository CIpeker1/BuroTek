using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class Talep
{
    public int TalepId { get; set; }

    public int BuroId { get; set; }

    public DateTime TalepTarihi { get; set; }

    public int TalepEdenKullaniciId { get; set; }

    public string TalepKonu { get; set; } = null!;

    public int TalepDurumId { get; set; }

    public int TalepTurId { get; set; }

    public string? TalepCevap { get; set; }

    public DateTime? TalepCevapTarihi { get; set; }

    public int? KapatanKullaniciId { get; set; }

    public string TalepAciklama { get; set; } = null!;

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Kullanicilar? KapatanKullanici { get; set; }

    public virtual ICollection<TalepDosya> TalepDosyas { get; set; } = new List<TalepDosya>();

    public virtual TalepDurum TalepDurum { get; set; } = null!;

    public virtual Kullanicilar TalepEdenKullanici { get; set; } = null!;

    public virtual TalepTuru TalepTur { get; set; } = null!;
}
