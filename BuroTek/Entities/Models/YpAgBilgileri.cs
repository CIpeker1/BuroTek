using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpAgBilgileri
{
    public int AgBilgileriId { get; set; }

    public string IvrDbIp { get; set; } = null!;

    public string SesIp { get; set; } = null!;

    public string KullaniciAdi { get; set; } = null!;

    public string Sifre { get; set; } = null!;
}
