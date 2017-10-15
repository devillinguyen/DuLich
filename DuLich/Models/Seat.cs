using System.ComponentModel.DataAnnotations;

namespace DuLich.Models
{
    public class Seat
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}