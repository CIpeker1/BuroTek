namespace BuroTek.Entities.Dtos
{
    public class NotlarResponseModel
    {
        public int Id { get; set; }
        public string? AdSoyad { get; set; }
        public string KayitTuru { get; set; }
        public string Baslik { get; set; }
        public DateTime KayitTarihi { get; set; }
        public string Not { get; set; }

    }
}
