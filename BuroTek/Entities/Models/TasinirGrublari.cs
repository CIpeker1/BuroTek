using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class TasinirGrublari
{
    public int TasinirGrubuId { get; set; }

    public int? TasinirGrubuAltId { get; set; }

    public string TasinirGrubuAdi { get; set; } = null!;

    public string? TasinirGurubuKodu { get; set; }

    public virtual ICollection<Demirba> Demirbas { get; set; } = new List<Demirba>();
}
