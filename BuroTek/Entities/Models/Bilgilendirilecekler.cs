using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class Bilgilendirilecekler
{
    public int BilgilendirilecekId { get; set; }

    public string AranacakTelNo { get; set; } = null!;

    public int BilgilendirmeId { get; set; }

    public int BuroId { get; set; }

    public int? BilgilendirmeKuyrukId { get; set; }

    public virtual Bilgilendirme Bilgilendirme { get; set; } = null!;

    public virtual Burolar Buro { get; set; } = null!;
}
