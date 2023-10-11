using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpTurkposAyar
{
    public int TurkposAyarId { get; set; }

    public string ClientCode { get; set; } = null!;

    public string ClientUsername { get; set; } = null!;

    public string ClientPassword { get; set; } = null!;

    public string Guid { get; set; } = null!;
}
