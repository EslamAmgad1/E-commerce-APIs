using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Core.Models
{
    public class ProductType : BaseEntity
    {
        [JsonIgnore]
        public ICollection<Product> Products { get; set; }

    }
}
