using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class DilekceMevzuatTuru
{
    public int DilekceMevzuatTuruId { get; set; }

    public string DilekceMevzuatTuruAdi { get; set; } = null!;

    public virtual ICollection<DilekceMevzuat> DilekceMevzuats { get; set; } = new List<DilekceMevzuat>();
}
