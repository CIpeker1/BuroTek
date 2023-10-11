using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpKurumTurleri
{
    public int KurumTuruId { get; set; }

    public string KurumTuruAdi { get; set; } = null!;

    public virtual ICollection<YpKurumTanimlari> YpKurumTanimlaris { get; set; } = new List<YpKurumTanimlari>();
}
