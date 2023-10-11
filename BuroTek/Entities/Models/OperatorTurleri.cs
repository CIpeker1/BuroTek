using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class OperatorTurleri
{
    public int OperatorTurId { get; set; }

    public string? OperatorTurAdi { get; set; }

    public virtual ICollection<SorgulamaLoglari> SorgulamaLoglaris { get; set; } = new List<SorgulamaLoglari>();

    public virtual ICollection<SorgulamaServisleri> SorgulamaServisleris { get; set; } = new List<SorgulamaServisleri>();

    public virtual ICollection<SorgulamaUlkeKodlari> SorgulamaUlkeKodlaris { get; set; } = new List<SorgulamaUlkeKodlari>();
}
