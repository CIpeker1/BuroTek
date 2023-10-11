using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpKontrolNoktalari
{
    public int KontrolNoktasiId { get; set; }

    public string KontrolNoktasiAdi { get; set; } = null!;

    public string KontrolNoktasiAciklama { get; set; } = null!;

    public virtual ICollection<YpYetkiGrupKontrolNoktalari> YpYetkiGrupKontrolNoktalaris { get; set; } = new List<YpYetkiGrupKontrolNoktalari>();
}
