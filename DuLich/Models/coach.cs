using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DuLich.Models
{
    public class Coach
    {
        // Properties
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public byte SeatId { get; set; }
        public Seat Seat { get; set; }
    }
}