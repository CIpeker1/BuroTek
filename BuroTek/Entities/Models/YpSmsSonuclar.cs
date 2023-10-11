using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpSmsSonuclar
{
    public int SmsSonucId { get; set; }

    public string SmsSonucAciklama { get; set; } = null!;
}
