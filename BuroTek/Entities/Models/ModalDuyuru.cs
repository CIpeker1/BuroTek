using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class ModalDuyuru
{
    public int ModalDuyuruId { get; set; }

    public int KullaniciId { get; set; }

    public DateTime OkumaTarihi { get; set; }

    public int? ModalDuyuruDetayId { get; set; }

    public virtual Kullanicilar Kullanici { get; set; } = null!;
}
