using System.ComponentModel.DataAnnotations;

namespace TravelTripProje.Models.Entities
{
    public class Hakkimizda
    {
        [Key]
        public int HakkimizdaId { get; set; }
        public string FotoUrl { get; set; }
        public string Aciklama{ get; set; }
    }
}