using System.ComponentModel.DataAnnotations;

namespace HopeageWeb.Models
{
    public class Photo
    {
        [Key]
        public int Id { get; set; }

        public string? Image { get; set; }
    }
}
