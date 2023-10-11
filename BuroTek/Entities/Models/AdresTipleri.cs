using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class AdresTipleri
{
    public int AdresTipiId { get; set; }

    public string AdresTipiAdi { get; set; } = null!;

    public virtual ICollection<KisiAdresler> KisiAdreslers { get; set; } = new List<KisiAdresler>();
}
