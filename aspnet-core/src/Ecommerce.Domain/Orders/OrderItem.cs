using System;
using Volo.Abp.Domain.Entities;

namespace Ecommerce.Orders
{
    public class OrderItem : Entity
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public string SKU { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public override object[] GetKeys()
        {
            return new object[] { OrderId, ProductId };
        }
    }
}
