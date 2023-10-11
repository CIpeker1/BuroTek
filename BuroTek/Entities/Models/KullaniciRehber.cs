using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class KullaniciRehber
{
    public int KullaniciRehberId { get; set; }

    public int BuroId { get; set; }

    public int KullaniciId { get; set; }

    public string AdSoyad { get; set; } = null!;

    public string Telefon { get; set; } = null!;

    public DateTime KayitTarihi { get; set; }

    public int? KayitliKullaniciId { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Kullanicilar? KayitliKullanici { get; set; }

    public virtual Kullanicilar Kullanici { get; set; } = null!;

    public virtual ICollection<KullaniciRehberGrupKisileri> KullaniciRehberGrupKisileris { get; set; } = new List<KullaniciRehberGrupKisileri>();
}
