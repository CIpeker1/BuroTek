using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class KrediKartiIslemleriLog
{
    public int KrediKartiIslemLogId { get; set; }

    public int? BuroId { get; set; }

    public int? KullaniciId { get; set; }

    public string KrediKartiSon4Hane { get; set; } = null!;

    public bool BasariDurumu { get; set; }

    public string SonucAciklama { get; set; } = null!;

    public string Guid { get; set; } = null!;

    public DateTime IslemTarihi { get; set; }

    public string DekontId { get; set; } = null!;

    public decimal TahsilatTutari { get; set; }

    public decimal OdemeTutari { get; set; }

    public string SiparisId { get; set; } = null!;

    public int? IslemId { get; set; }

    public int KartTipi { get; set; }

    public virtual Burolar? Buro { get; set; }

    public virtual KrediKartiIslemleri? Islem { get; set; }

    public virtual Kullanicilar? Kullanici { get; set; }
}
