using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class Bilgilendirme
{
    public int BilgilendirmeId { get; set; }

    public string BilgilendirmeMesaji { get; set; } = null!;

    public string BilgilendirmeSesYolu { get; set; } = null!;

    public bool? Arandi { get; set; }

    public virtual ICollection<Bilgilendirilecekler> Bilgilendirileceklers { get; set; } = new List<Bilgilendirilecekler>();
}
