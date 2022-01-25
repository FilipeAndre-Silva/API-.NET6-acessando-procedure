using System;
using System.Collections.Generic;

namespace EcommerceApi
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public int Amount { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; } = null!;
    }
}
