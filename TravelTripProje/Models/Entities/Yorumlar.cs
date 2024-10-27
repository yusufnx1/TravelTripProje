using System.ComponentModel.DataAnnotations;

namespace TravelTripProje.Models.Entities
{
    public class Yorumlar
    {
        [Key]
        public int YorumlarId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public int BlogId { get; set; }

        public virtual Blog Blog { get; set; }
    }
}