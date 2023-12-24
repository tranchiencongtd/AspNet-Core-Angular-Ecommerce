using System;
using Volo.Abp.Domain.Entities;

namespace Ecommerce.Promotions
{
    public class PromotionManufacturer : Entity<Guid>
    {
        public Guid ManufactureId { get; set; }
        public Guid PromotionId { get; set; }
    }
}
