using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class CariHesapKodlari
{
    public int CariHesapKoduId { get; set; }

    public string CariHesapKodu { get; set; } = null!;

    public string CariHesapAdi { get; set; } = null!;

    public int HesapTuruId { get; set; }

    public int BuroId { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual ICollection<CariIslemler> CariIslemlers { get; set; } = new List<CariIslemler>();

    public virtual HesapTuru HesapTuru { get; set; } = null!;
}
