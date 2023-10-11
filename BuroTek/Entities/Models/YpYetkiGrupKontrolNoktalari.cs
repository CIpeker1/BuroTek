using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpYetkiGrupKontrolNoktalari
{
    public int YetkiGrupKontrolNoktasiId { get; set; }

    public int YetkiGrupId { get; set; }

    public int KontrolNoktasiId { get; set; }

    public int Suid { get; set; }

    public virtual YpKontrolNoktalari KontrolNoktasi { get; set; } = null!;

    public virtual YpYetkiGruplari YetkiGrup { get; set; } = null!;
}
