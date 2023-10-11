using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class SorgulamaUlkeKodlari
{
    public int SorgulamaUlkeKodId { get; set; }

    public int UlkeKodu { get; set; }

    public string UlkeAdi { get; set; } = null!;

    public int OperatorTurId { get; set; }

    public virtual OperatorTurleri OperatorTur { get; set; } = null!;
}
