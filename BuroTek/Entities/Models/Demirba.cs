using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class Demirba
{
    public int DemirbasId { get; set; }

    public int BuroId { get; set; }

    public int LokasyonId { get; set; }

    public int KullaniciId { get; set; }

    public int DemirbasDurumId { get; set; }

    public int? Barkod { get; set; }

    public int TasinirGrubuId { get; set; }

    public string DemirbasAdi { get; set; } = null!;

    public string DemirbasKodu { get; set; } = null!;

    public DateTime? GarantiBaslangicTarihi { get; set; }

    public DateTime? GarantiBitisTarihi { get; set; }

    public string? Aciklama { get; set; }

    public decimal? Fiyati { get; set; }

    public string? FaturaNo { get; set; }

    public DateTime? FaturaTarihi { get; set; }

    public string? SeriNo { get; set; }

    public string? AlinanFirma { get; set; }

    public DateTime KayitTarihi { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual ICollection<DemirbasDosya> DemirbasDosyas { get; set; } = new List<DemirbasDosya>();

    public virtual DemirbasDurumlari DemirbasDurum { get; set; } = null!;

    public virtual Kullanicilar Kullanici { get; set; } = null!;

    public virtual Lokasyonlar Lokasyon { get; set; } = null!;

    public virtual TasinirGrublari TasinirGrubu { get; set; } = null!;
}
