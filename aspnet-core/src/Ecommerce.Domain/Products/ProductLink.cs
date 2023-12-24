using System;
using Volo.Abp.Domain.Entities;

namespace Ecommerce.Products
{
    public class ProductLink : Entity<Guid>
    {
        public Guid ProductId { get; set; }
        public Guid LinkedProductId { get; set; }
    }
}
