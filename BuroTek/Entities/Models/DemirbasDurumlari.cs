using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class DemirbasDurumlari
{
    public int DemirbasDurumId { get; set; }

    public string DemirbasDurumAdi { get; set; } = null!;

    public bool DemirbasDurumu { get; set; }

    public virtual ICollection<Demirba> Demirbas { get; set; } = new List<Demirba>();
}
