using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpBankalar
{
    public int BankaId { get; set; }

    public int? BankaKodu { get; set; }

    public int? BankaSubeKodu { get; set; }

    public string? BankaSubeAdi { get; set; }

    public bool BankaMi { get; set; }

    public virtual ICollection<IcraDaireleri> IcraDaireleriBankaSubes { get; set; } = new List<IcraDaireleri>();

    public virtual ICollection<IcraDaireleri> IcraDaireleriBankas { get; set; } = new List<IcraDaireleri>();
}
