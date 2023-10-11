using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class YpKullaniciYetkiGruplari
{
    public int KullaniciYetkiGrubuId { get; set; }

    public int KullaniciId { get; set; }

    public int YetkiGrupId { get; set; }

    public virtual Kullanicilar Kullanici { get; set; } = null!;

    public virtual YpYetkiGruplari YetkiGrup { get; set; } = null!;
}
