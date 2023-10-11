using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpOtpAyar
{
    public int YpOtpAyarId { get; set; }

    public bool OtpAktif { get; set; }

    public bool OtpBlokAktif { get; set; }

    public bool GecerliAyar { get; set; }

    public string OtpBlokBilgiMail { get; set; } = null!;
}
