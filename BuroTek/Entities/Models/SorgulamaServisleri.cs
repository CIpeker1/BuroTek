using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class SorgulamaServisleri
{
    public int ServisId { get; set; }

    public string ServisAdi { get; set; } = null!;

    public string ServisAciklama { get; set; } = null!;

    public int OperatorTurId { get; set; }

    public string ServisBilgi { get; set; } = null!;

    public decimal? ServisUcreti { get; set; }

    public virtual OperatorTurleri OperatorTur { get; set; } = null!;

    public virtual ICollection<SorgulamaLoglari> SorgulamaLoglaris { get; set; } = new List<SorgulamaLoglari>();
}
