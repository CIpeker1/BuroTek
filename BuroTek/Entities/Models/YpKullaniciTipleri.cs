using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpKullaniciTipleri
{
    public int KullaniciTipiId { get; set; }

    public string KullaniciTipiAdi { get; set; } = null!;

    public virtual ICollection<Kullanicilar> Kullanicilars { get; set; } = new List<Kullanicilar>();

    public virtual ICollection<ModalDuyuruDetaylari> ModalDuyuruDetaylaris { get; set; } = new List<ModalDuyuruDetaylari>();

    public virtual ICollection<YpYetkiGruplari> YpYetkiGruplaris { get; set; } = new List<YpYetkiGruplari>();
}
