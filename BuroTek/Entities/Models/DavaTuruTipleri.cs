using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class DavaTuruTipleri
{
    public int DavaTuruTipiId { get; set; }

    public string DavaTuruTipiAdi { get; set; } = null!;

    public virtual ICollection<DavaTurleri> DavaTurleris { get; set; } = new List<DavaTurleri>();
}
