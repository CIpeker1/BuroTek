using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpUyelikUcretlendirme
{
    public int UyelikUcretlendirmeId { get; set; }

    public string Aciklama { get; set; } = null!;

    public decimal Ucret { get; set; }

    public virtual ICollection<YpKullaniciSozlesme> YpKullaniciSozlesmes { get; set; } = new List<YpKullaniciSozlesme>();
}
