using System.ComponentModel.DataAnnotations;

namespace TravelTripProje.Models.Entities
{
    public class İletisim
    {
        [Key]
        public int İletisimID { get; set; }
        public string AdSoyad { get; set; }
        public string Mail { get; set; }
        public string Konu { get; set; }
        public string Mesaj { get; set; }
    }
}