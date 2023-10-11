using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpBildirimler
{
    public int BildirimId { get; set; }

    public int BuroId { get; set; }

    public string? Konu { get; set; }

    public int BildirilenKullaniciId { get; set; }

    public int BildirenKullaniciId { get; set; }

    public DateTime BildirimTarihi { get; set; }

    public int BildirimDurumId { get; set; }

    public int BildirimTuruId { get; set; }

    public string BildirimMetni { get; set; } = null!;

    public DateTime? OkunmaTarihi { get; set; }

    public DateTime? SilinmeTarihi { get; set; }

    public virtual Kullanicilar BildirenKullanici { get; set; } = null!;

    public virtual Kullanicilar BildirilenKullanici { get; set; } = null!;

    public virtual YpBildirimDurumlari BildirimDurum { get; set; } = null!;

    public virtual YpBildirimTurleri BildirimTuru { get; set; } = null!;

    public virtual Burolar Buro { get; set; } = null!;
}
