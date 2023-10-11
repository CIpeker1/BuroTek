using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class SorgulamaLoglari
{
    public int SorgulamaLogId { get; set; }

    public bool SorguBasariDurumu { get; set; }

    public string SorgulamaSonucu { get; set; } = null!;

    public DateTime KayitTarihi { get; set; }

    public int KullaniciId { get; set; }

    public int BuroId { get; set; }

    public int ServisId { get; set; }

    public int OperatorTurId { get; set; }

    public string? SorgulananTcKimlikNo { get; set; }

    public string? SorgulananTelefonNo { get; set; }

    public string? SorgulananImeiNo { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Kullanicilar Kullanici { get; set; } = null!;

    public virtual OperatorTurleri OperatorTur { get; set; } = null!;

    public virtual SorgulamaServisleri Servis { get; set; } = null!;
}
