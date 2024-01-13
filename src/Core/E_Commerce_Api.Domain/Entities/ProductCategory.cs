using E_Commerce_Api.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Api.Domain.Entities
{
    public class ProductCategory : EntityBase, IEntityBase
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
