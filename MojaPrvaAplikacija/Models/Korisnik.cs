using System.ComponentModel.DataAnnotations;

namespace MojaPrvaAplikacija.Models
{
    public class Korisnik
    {
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string email { get; set; }

    }
}
