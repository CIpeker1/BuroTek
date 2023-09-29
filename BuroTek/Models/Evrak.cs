namespace BuroTek.Model
{
    public class Evrak
    {
        public int EvrakID { get; set; }
        public string? GeldigiGittigiKisi { get; set; }
        public string? GeldigiGittigiKurum { get; set; }
        public string? BelgeTuru { get; set; }
        public string? Konu { get; set; }
        public string? BaglantiliBuroDosyaNo { get; set; }
        public string? Aciklama { get; set; }
        public DateTime BelgeKayitTarihi { get; set; }
        public int BelgeNo { get; set; }
        public DateTime KurumKayitTarihi { get; set; }
        public string? KurumBelgeNo { get; set; }

    }
}
