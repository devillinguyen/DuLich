using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DuLich.ViewModels
{
    public class TourViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal ServicePackage { get; set; }
        [Required]
        public string Image1 { get; set; }
        [Required]
        public string Image2 { get; set; }
        [Required]
        public string Image3 { get; set; }
        [Required]
        public string Description1 { get; set; }
        [Required]
        public string Description2 { get; set; }
    }
}