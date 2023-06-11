using Ecommerce.Orders;
using System;
using Volo.Abp.Domain.Entities;

namespace Ecommerce.Products
{
    public class ProductTag : Entity
    {
        public Guid ProductId { get; set; }
        public Guid TagId { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { ProductId, TagId };
        }
    }
}
