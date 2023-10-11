using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class KisiVekaletler
{
    public int KisiVekaletId { get; set; }

    public int BuroId { get; set; }

    public int KisiId { get; set; }

    public int VekaletTuruId { get; set; }

    public string NoterlikAdi { get; set; } = null!;

    public string YevmiyeNo { get; set; } = null!;

    public DateTime VekaletTarihi { get; set; }

    public DateTime? VekaletBitisTarihi { get; set; }

    public string? VekaletDokumanDosyaYolu { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual ICollection<DavaKisiler> DavaKisilers { get; set; } = new List<DavaKisiler>();

    public virtual ICollection<IcraKisiler> IcraKisilers { get; set; } = new List<IcraKisiler>();

    public virtual Kisiler Kisi { get; set; } = null!;

    public virtual ICollection<KisiVekaletDosya> KisiVekaletDosyas { get; set; } = new List<KisiVekaletDosya>();

    public virtual ICollection<KisiVekaletYetki> KisiVekaletYetkis { get; set; } = new List<KisiVekaletYetki>();

    public virtual VekaletTuru VekaletTuru { get; set; } = null!;
}
