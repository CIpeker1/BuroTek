using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class Notlar
{
    public int NotId { get; set; }

    public int BuroId { get; set; }

    public int KullaniciId { get; set; }

    public string KisaAciklama { get; set; } = null!;

    public string Aciklama { get; set; } = null!;

    public DateTime? Tarih { get; set; }

    public int? ModulId { get; set; }

    public int? DisKayitNo { get; set; }

    public bool Hatirlatma { get; set; }

    public DateTime? HatirlatmaTarihi { get; set; }

    public int? ZamanAraligiId { get; set; }

    public int IslemYapanKullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public string? DosyaAdi { get; set; }

    public bool? BildirimGonderildi { get; set; }

    public bool? Tamamlandi { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual ICollection<Durusmalar> Durusmalars { get; set; } = new List<Durusmalar>();

    public virtual Kullanicilar IslemYapanKullanici { get; set; } = null!;

    public virtual ICollection<Kesifler> Kesiflers { get; set; } = new List<Kesifler>();

    public virtual Kullanicilar Kullanici { get; set; } = null!;

    public virtual Moduller? Modul { get; set; }

    public virtual ZamanAraligi? ZamanAraligi { get; set; }
}
