
namespace BuroTek.Entities.Entities.Dtos
{
    public class UserResponseModel
    {
        public int UserId { get; set; }
        public string KullaniciAdi { get; set; }
        public string AdSoyad { get; set; }
        public string TcNo { get; set; }
        public string TelNo { get; set; }
        public string Mail { get; set; }
        public int KullaniciTipi { get; set; }
        public string Durum { get; set; }
        public int BaroSicilNo { get; set; }
        public int BuroSıraNo { get; set; }
        public string KisiTipi { get; set; }
        public string TuzelKisiAdi { get; set; }
        public string YasalTemsilci { get; set; }
        public DateTime KayitTarihi { get; set; }
        public string Not { get; set; }
        public string Baslik { get; set; }
    }
}
