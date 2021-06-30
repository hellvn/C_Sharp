﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }
        public int BrandId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Brand Brand { get; set; }

    }
}