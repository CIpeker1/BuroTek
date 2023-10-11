using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class KisiAdresler
{
    public int KisiAdresId { get; set; }

    public int BuroId { get; set; }

    public int KisiId { get; set; }

    public int AdresTipiId { get; set; }

    public string? Adres { get; set; }

    public int? IlId { get; set; }

    public int? IlceId { get; set; }

    public bool? Birincil { get; set; }

    public virtual AdresTipleri AdresTipi { get; set; } = null!;

    public virtual Burolar Buro { get; set; } = null!;

    public virtual YpIlIlce? Il { get; set; }

    public virtual YpIlIlce? Ilce { get; set; }

    public virtual Kisiler Kisi { get; set; } = null!;
}
