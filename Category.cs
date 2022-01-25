using System;
using System.Collections.Generic;

namespace EcommerceApi
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
