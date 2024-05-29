using System.ComponentModel.DataAnnotations;

namespace HopeageWeb.Models
{
    public class Photo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Image { get; set; }
    }
}
