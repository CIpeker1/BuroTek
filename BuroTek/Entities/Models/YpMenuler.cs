using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpMenuler
{
    public int MenuId { get; set; }

    public string MenuAdi { get; set; } = null!;

    public string? Durum { get; set; }

    public string? Url { get; set; }

    public int UstMenuId { get; set; }

    public string? KontrolNoktasiAdi { get; set; }

    public int MenuSirasi { get; set; }

    public string? Aciklama { get; set; }

    public string? Ikon { get; set; }

    public bool OtpGerekli { get; set; }

    public virtual ICollection<OtpLog> OtpLogs { get; set; } = new List<OtpLog>();
}
