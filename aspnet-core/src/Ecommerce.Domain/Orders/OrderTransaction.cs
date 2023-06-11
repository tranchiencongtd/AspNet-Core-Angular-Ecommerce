using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Ecommerce.Orders
{
    public class OrderTransaction : Entity<Guid>
    {
        public string Code { get; set; }
        public Guid OrderId { get; set; }
        public Guid UserId { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
    }
}
