using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class DilekceMevzuat
{
    public int DilekceMevzuatId { get; set; }

    public int DilekceMevzuatTuruId { get; set; }

    public int? DilekceTuruId { get; set; }

    public bool Sistem { get; set; }

    public string DilekceMevzuatDosyaAdi { get; set; } = null!;

    public int DilekceMevzuatDosyaId { get; set; }

    public string Uzanti { get; set; } = null!;

    public int DosyaBoyutu { get; set; }

    public int KullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public string Aciklama { get; set; } = null!;

    public int BuroId { get; set; }

    public string? DosyaTipi { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual DilekceMevzuatTuru DilekceMevzuatTuru { get; set; } = null!;

    public virtual DilekceTurleri? DilekceTuru { get; set; }
}
