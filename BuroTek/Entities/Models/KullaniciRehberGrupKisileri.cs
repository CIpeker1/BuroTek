using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class KullaniciRehberGrupKisileri
{
    public int KullaniciRehberGrupKisileriId { get; set; }

    public int BuroId { get; set; }

    public int KullaniciId { get; set; }

    public int? KullaniciRehberId { get; set; }

    public int KullaniciRehberGrupId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public int? KayitliKullaniciId { get; set; }

    public virtual Kullanicilar? KayitliKullanici { get; set; }

    public virtual KullaniciRehber? KullaniciRehber { get; set; }
}
