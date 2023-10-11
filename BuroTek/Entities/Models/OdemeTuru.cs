using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class OdemeTuru
{
    public int OdemeTuruId { get; set; }

    public string OdemeTuruAdi { get; set; } = null!;

    public virtual ICollection<KisiSozlesmeler> KisiSozlesmelers { get; set; } = new List<KisiSozlesmeler>();
}
