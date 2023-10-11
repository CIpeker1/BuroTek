using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class DanismaKisi
{
    public int DanismaKisiId { get; set; }

    public int DanismaId { get; set; }

    public int KisiId { get; set; }

    public int? KisiSozlesmeId { get; set; }

    public virtual Danisma Danisma { get; set; } = null!;

    public virtual Kisiler Kisi { get; set; } = null!;

    public virtual KisiSozlesmeler? KisiSozlesme { get; set; }
}
