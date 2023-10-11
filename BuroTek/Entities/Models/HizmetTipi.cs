using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class HizmetTipi
{
    public int HizmetTipiId { get; set; }

    public string HizmetTipiAdi { get; set; } = null!;

    public virtual ICollection<Danisma> Danismas { get; set; } = new List<Danisma>();
}
