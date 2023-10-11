using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpYetkiGruplari
{
    public int YetkiGrupId { get; set; }

    public string YetkiGrupAdi { get; set; } = null!;

    public string? YetkiGrupAciklama { get; set; }

    public int KullaniciTipiId { get; set; }

    public virtual YpKullaniciTipleri KullaniciTipi { get; set; } = null!;

    public virtual ICollection<YpKullaniciYetkiGruplari> YpKullaniciYetkiGruplaris { get; set; } = new List<YpKullaniciYetkiGruplari>();

    public virtual ICollection<YpYetkiGrupKontrolNoktalari> YpYetkiGrupKontrolNoktalaris { get; set; } = new List<YpYetkiGrupKontrolNoktalari>();
}
