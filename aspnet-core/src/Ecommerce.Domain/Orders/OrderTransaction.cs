using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Ecommerce.Orders
{
    public class OrderTransaction : CreationAuditedEntity<Guid>
    {
        public string Code { get; set; }
        public Guid OrderId { get; set; }
        public Guid UserId { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
    }
}
