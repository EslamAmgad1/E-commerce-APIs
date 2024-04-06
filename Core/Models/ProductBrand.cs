﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Core.Models
{
    public class ProductBrand : BaseEntity
    {
        public string Name { get; set; }

        [JsonIgnore]
        public ICollection<Product> Products { get; set; }

    }
}
