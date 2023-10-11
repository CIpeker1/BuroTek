﻿using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class DavaKisiler
{
    public int DavaKisiId { get; set; }

    public int BuroId { get; set; }

    public int DavaId { get; set; }

    public int KisiId { get; set; }

    public int? KisiSozlesmeId { get; set; }

    public int? KisiVekaletId { get; set; }

    public int KisiRolId { get; set; }

    public string? KarsiTarafAvukatAdSoyad { get; set; }

    public string? KarsiTarafAvukatTelefon { get; set; }

    public string? Aciklama { get; set; }

    public int OlusturanKullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public bool? MuvekkilDavaci { get; set; }

    public string? DigerAciklama { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Davalar Dava { get; set; } = null!;

    public virtual Kisiler Kisi { get; set; } = null!;

    public virtual KisiRoller KisiRol { get; set; } = null!;

    public virtual KisiSozlesmeler? KisiSozlesme { get; set; }

    public virtual KisiVekaletler? KisiVekalet { get; set; }

    public virtual Kullanicilar OlusturanKullanici { get; set; } = null!;
}
