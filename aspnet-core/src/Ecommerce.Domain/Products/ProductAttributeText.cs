using System;
using Volo.Abp.Domain.Entities;

namespace Ecommerce.Products
{
    public class ProductAttributeText : Entity<Guid>
    {
        public Guid AttributeId { get; set; }
        public Guid ProductId { get; set; }
        public string Value { get; set; }
    }
}
