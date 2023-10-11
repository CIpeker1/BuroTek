using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class OtpLog
{
    public int OtpLogId { get; set; }

    public int KullaniciId { get; set; }

    public string TelefonNo { get; set; } = null!;

    public string IpAdresi { get; set; } = null!;

    public int? MenuId { get; set; }

    public string OtpKod { get; set; } = null!;

    public string? GirilenOtpKod { get; set; }

    public int DenemeSayisi { get; set; }

    public bool Basarili { get; set; }

    public DateTime OtpGonderimZamani { get; set; }

    public DateTime? DogrulamaDenemeZamani { get; set; }

    public bool LogKaydiIleDogrulandi { get; set; }

    public virtual Kullanicilar Kullanici { get; set; } = null!;

    public virtual YpMenuler? Menu { get; set; }
}
