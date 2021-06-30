using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Brand
    {
        public int id { get; set; }
        [Required]
        public string BrandName { get; set; }
        [Required]
        public string Logo { get; set; }

        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}