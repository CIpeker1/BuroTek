using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpTurkposSonucLog
{
    public int YpTurkposSonucLogId { get; set; }

    public string Parametreler { get; set; } = null!;

    public bool Sonuc { get; set; }

    public DateTime Tarih { get; set; }
}
