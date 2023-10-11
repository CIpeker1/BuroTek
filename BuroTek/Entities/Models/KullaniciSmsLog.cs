using System;
using System.Collections.Generic;

namespace BuroTek.Entities.Models;

public partial class KullaniciSmsLog
{
    public int KullaniciSmsLogId { get; set; }

    public int SmsTuruId { get; set; }

    public int BuroId { get; set; }

    public int? KullaniciId { get; set; }

    public string? CepTelefon { get; set; }

    /// <summary>
    /// kurum dışında gönderimler yapıldığında cep telefon üzerinden gönderim yapılacak
    /// </summary>
    public int? DosyaId { get; set; }

    public int? KisiId { get; set; }

    public string SmsMetni { get; set; } = null!;

    public int SmsAdet { get; set; }

    public int? SmsSonucId { get; set; }

    public bool BasariDurumu { get; set; }

    public DateTime KayitTarihi { get; set; }

    public int IslemYapanKullaniciId { get; set; }

    public int? KrediSahipTipiId { get; set; }

    public int SmsDurumId { get; set; }

    public int? ModulId { get; set; }

    public int? DisKayitNo { get; set; }

    public virtual Burolar Buro { get; set; } = null!;

    public virtual Dosyalar? Dosya { get; set; }

    public virtual Kullanicilar IslemYapanKullanici { get; set; } = null!;

    public virtual Kisiler? Kisi { get; set; }

    public virtual YpKrediSahipTipleri? KrediSahipTipi { get; set; }

    public virtual Kullanicilar? Kullanici { get; set; }

    public virtual YpSmsDurum SmsDurum { get; set; } = null!;

    public virtual YpSmsTuru SmsTuru { get; set; } = null!;
}
