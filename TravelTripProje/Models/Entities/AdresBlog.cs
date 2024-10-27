using System.ComponentModel.DataAnnotations;

namespace TravelTripProje.Models.Entities
{
    public class AdresBlog
    {
        [Key]
        public int AdresId { get; set; }
        public string Aciklama  { get; set; }
        public string AdresAcik  { get; set; }
        public string Mail  { get; set; }
        public string Telefon  { get; set; }
        public string Konum  { get; set; }
    }
}