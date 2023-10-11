using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpKurumTanimlari
{
    public int KurumId { get; set; }

    public int BuroId { get; set; }

    public int? KurumTuruId { get; set; }

    public string KurumAdi { get; set; } = null!;

    public int OlusturanKisiId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual ICollection<Danisma> Danismas { get; set; } = new List<Danisma>();

    public virtual ICollection<Davalar> Davalars { get; set; } = new List<Davalar>();

    public virtual ICollection<Evrak> Evraks { get; set; } = new List<Evrak>();

    public virtual YpKurumTurleri? KurumTuru { get; set; }

    public virtual Kullanicilar OlusturanKisi { get; set; } = null!;
}
