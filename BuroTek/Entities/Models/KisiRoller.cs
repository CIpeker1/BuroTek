using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class KisiRoller
{
    public int KisiRolId { get; set; }

    public string KisiRolAdi { get; set; } = null!;

    public virtual ICollection<DavaKisiler> DavaKisilers { get; set; } = new List<DavaKisiler>();

    public virtual ICollection<IcraKisiler> IcraKisilers { get; set; } = new List<IcraKisiler>();
}
