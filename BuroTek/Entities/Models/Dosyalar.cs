using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class Dosyalar
{
    public int DosyaId { get; set; }

    public int BuroId { get; set; }

    public string DosyaAdi { get; set; } = null!;

    public string Uzanti { get; set; } = null!;

    public string? Aciklama { get; set; }

    public int DosyaBoyutu { get; set; }

    public string DosyaTipi { get; set; } = null!;

    public int KullaniciId { get; set; }

    public DateTime KayitTarihi { get; set; }

    public string? OcrMetin { get; set; }

    public string? DepoDosyaAdi { get; set; }

    public virtual ICollection<Arsiv> Arsivs { get; set; } = new List<Arsiv>();

    public virtual Burolar Buro { get; set; } = null!;

    public virtual ICollection<DanismaDosya> DanismaDosyas { get; set; } = new List<DanismaDosya>();

    public virtual ICollection<DavaDosya> DavaDosyas { get; set; } = new List<DavaDosya>();

    public virtual ICollection<DemirbasDosya> DemirbasDosyas { get; set; } = new List<DemirbasDosya>();

    public virtual ICollection<DurusmaDosya> DurusmaDosyas { get; set; } = new List<DurusmaDosya>();

    public virtual ICollection<EvrakDosya> EvrakDosyas { get; set; } = new List<EvrakDosya>();

    public virtual ICollection<IcraDosya> IcraDosyas { get; set; } = new List<IcraDosya>();

    public virtual ICollection<KisiSozlesmeDosya> KisiSozlesmeDosyas { get; set; } = new List<KisiSozlesmeDosya>();

    public virtual ICollection<KisiVekaletDosya> KisiVekaletDosyas { get; set; } = new List<KisiVekaletDosya>();

    public virtual Kullanicilar Kullanici { get; set; } = null!;

    public virtual ICollection<KullaniciSmsLog> KullaniciSmsLogs { get; set; } = new List<KullaniciSmsLog>();

    public virtual ICollection<TalepDosya> TalepDosyas { get; set; } = new List<TalepDosya>();
}
