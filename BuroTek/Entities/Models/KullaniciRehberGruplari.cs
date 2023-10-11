using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class KullaniciRehberGruplari
{
    public int KullaniciRehberGrupId { get; set; }

    public string GrupAdi { get; set; } = null!;

    public int BuroId { get; set; }

    public int KullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public int KisiSayisi { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Kullanicilar Kullanici { get; set; } = null!;
}
