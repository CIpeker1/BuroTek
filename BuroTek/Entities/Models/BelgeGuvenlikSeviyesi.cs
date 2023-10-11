using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class BelgeGuvenlikSeviyesi
{
    public int BelgeGuvenlikSeviyesiId { get; set; }

    public string BelgeGuvenlikSeviyesiAdi { get; set; } = null!;
}
