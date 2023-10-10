using BuroTek.Core.Entities;

namespace BuroTek.Entities.Models
{
    public class Buro:IEntity
    {
        public int BuroId { get; set; }
        public string BuroAdi { get; set; }
        public string BuroIl { get; set; }
        public string BuroIlce { get; set; }
        public int BuroSıraNo { get; set; }
    }
}
