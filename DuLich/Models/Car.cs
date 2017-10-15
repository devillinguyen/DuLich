using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DuLich.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public Seat Seat { get; set; }
        [Required]
        public byte SeatId { get; set; }
        [Required]
        [StringLength(50)]
        public string Color { get; set; }
        [Required]
        [StringLength(50)]
        public string Brand { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Inventory { get; set; }
        [Required]
        [StringLength(255)]
        public string Image { get; set; }
        public string Description { get; set; }
    }
}