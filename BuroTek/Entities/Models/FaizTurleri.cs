using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class FaizTurleri
{
    public int FaizTuruId { get; set; }

    public string FaizTuruAdi { get; set; } = null!;

    public virtual ICollection<Faizler> Faizlers { get; set; } = new List<Faizler>();
}
