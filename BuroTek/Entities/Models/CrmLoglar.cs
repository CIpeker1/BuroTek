using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class CrmLoglar
{
    public int CrmLogId { get; set; }

    public string UygulamaAdi { get; set; } = null!;

    public int KullaniciId { get; set; }

    public DateTime Tarih { get; set; }

    public DateTime BaslangicTarihi { get; set; }

    public DateTime BitisTarihi { get; set; }

    public string Ip { get; set; } = null!;

    public bool? BasariDurumu { get; set; }

    public string? Mesaj { get; set; }

    public int? YeniUyeSayisi { get; set; }

    public int? UyelikUzatmaSayisi { get; set; }

    public int? KrediYuklemeKisiSayisi { get; set; }

    public decimal? YeniUyelikTutar { get; set; }

    public decimal? UyelikUzatmaTutar { get; set; }

    public decimal? KrediYuklemeTutar { get; set; }

    public DateTime KayitTarihi { get; set; }
}
