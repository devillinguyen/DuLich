using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DuLich.Models;

namespace DuLich.ViewModels
{
    public class CarViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public byte Seat { get; set; }
        public IEnumerable<Seat> Seats { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [InventoryMin(1)]
        public string Inventory { get; set; }
        [Required]
        public string Image { get; set; }
        public string Description { get; set; }
    }
}