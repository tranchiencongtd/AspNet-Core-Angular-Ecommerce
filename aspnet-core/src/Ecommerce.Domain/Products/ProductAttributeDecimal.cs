using System;
using Volo.Abp.Domain.Entities;

namespace Ecommerce.Products
{
    public class ProductAttributeDecimal : Entity<Guid>
    {
        public Guid AttributeId { get; set; }
        public Guid ProductId { get; set; }
        public decimal Value { get; set; }
    }
}
