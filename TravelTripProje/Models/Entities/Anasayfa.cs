using System.ComponentModel.DataAnnotations;

namespace TravelTripProje.Models.Entities
{
    public class Anasayfa
    {
        [Key]
        public int AnasayfaId { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
    }
}