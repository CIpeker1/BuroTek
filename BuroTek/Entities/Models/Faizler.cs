using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class Faizler
{
    public int FaizId { get; set; }

    public string FaizAdi { get; set; } = null!;

    public int FaizTuruId { get; set; }

    public int KullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public bool OzelFaiz { get; set; }

    public virtual ICollection<FaizOranlari> FaizOranlaris { get; set; } = new List<FaizOranlari>();

    public virtual FaizTurleri FaizTuru { get; set; } = null!;

    public virtual Kullanicilar Kullanici { get; set; } = null!;
}
