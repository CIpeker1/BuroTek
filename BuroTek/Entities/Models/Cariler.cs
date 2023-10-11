using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class Cariler
{
    public int CariId { get; set; }

    public int BuroId { get; set; }

    public string CariAdi { get; set; } = null!;

    public string? KisaAdi { get; set; }

    public string IlgiliKisiAdSoyad { get; set; } = null!;

    public string? VergiDairesi { get; set; }

    public string? VergiNo { get; set; }

    public string? Adres { get; set; }

    public string Telefon { get; set; } = null!;

    public virtual Burolar Buro { get; set; } = null!;

    public virtual ICollection<CariIslemler> CariIslemlers { get; set; } = new List<CariIslemler>();
}
