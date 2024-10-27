using System.ComponentModel.DataAnnotations;

namespace TravelTripProje.Models.Entities
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        public string Kullanici { get; set; }
        public string Sifre { get; set; }
    }
}