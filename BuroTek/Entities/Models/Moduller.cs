using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class Moduller
{
    public int ModulId { get; set; }

    public string ModulAdi { get; set; } = null!;

    public virtual ICollection<CariIslemler> CariIslemlers { get; set; } = new List<CariIslemler>();

    public virtual ICollection<EvrakBaglanti> EvrakBaglantis { get; set; } = new List<EvrakBaglanti>();

    public virtual ICollection<Notlar> Notlars { get; set; } = new List<Notlar>();
}
