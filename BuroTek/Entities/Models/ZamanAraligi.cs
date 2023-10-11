using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class ZamanAraligi
{
    public int ZamanAraligiId { get; set; }

    public int Dakika { get; set; }

    public string Aciklama { get; set; } = null!;

    public virtual ICollection<Notlar> Notlars { get; set; } = new List<Notlar>();
}
