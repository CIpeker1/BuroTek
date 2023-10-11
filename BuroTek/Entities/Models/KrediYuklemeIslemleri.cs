using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class KrediYuklemeIslemleri
{
    public int KrediYuklemeIslemleriId { get; set; }

    public int KullaniciId { get; set; }

    public int BuroId { get; set; }

    public string IpAdresi { get; set; } = null!;

    public bool IslemDurumu { get; set; }

    public string? CcLast4Num { get; set; }

    public string? OrderId { get; set; }

    public string? Response { get; set; }

    public string? AuthCode { get; set; }

    public string? HostRefNum { get; set; }

    public string? ProcReturnCode { get; set; }

    public string? TransId { get; set; }

    public string? ErrMsg { get; set; }

    public decimal YuklemeTutari { get; set; }

    public DateTime KayitTarihi { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Kullanicilar Kullanici { get; set; } = null!;
}
