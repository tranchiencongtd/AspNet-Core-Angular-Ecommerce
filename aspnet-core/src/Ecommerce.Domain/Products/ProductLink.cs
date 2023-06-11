using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Ecommerce.Products
{
    public class ProductLink : Entity<Guid>
    {
        public Guid ProductId { get; set; }
        string LinkedProductId { get; set; }
    }
}
