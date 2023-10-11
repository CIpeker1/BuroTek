using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YardimVideolari
{
    public int YardimVideoId { get; set; }

    public string Url { get; set; } = null!;

    public string Aciklama { get; set; } = null!;
}
