using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TravelTripProje.Models.Entities
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public string BlogImage { get; set; }

        public ICollection<Yorumlar> Yorumlars { get; set; }
    }
}