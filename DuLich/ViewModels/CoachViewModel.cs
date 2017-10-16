using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DuLich.Models;

namespace DuLich.ViewModels
{
    public class CoachViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public byte Seat { get; set; }
        public IEnumerable<Seat> Seats { get; set; }
    }
}