using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class IcraDaireleri
{
    public int IcraDaireId { get; set; }

    public int? BuroId { get; set; }

    public string? IcraDaireAdi { get; set; }

    public string? IbanNo { get; set; }

    public int? BankaId { get; set; }

    public int? BankaSubeId { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public int? KullaniciId { get; set; }

    public virtual YpBankalar? Banka { get; set; }

    public virtual YpBankalar? BankaSube { get; set; }

    public virtual Burolar? Buro { get; set; }

    public virtual ICollection<Icralar> Icralars { get; set; } = new List<Icralar>();

    public virtual Kullanicilar? Kullanici { get; set; }
}
