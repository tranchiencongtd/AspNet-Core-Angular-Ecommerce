using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Ecommerce.Products
{
    public class Product : AuditedAggregateRoot<Guid>
    {
        public Guid ManufactureId { get; set; }
        public string Name { get; set; }
        public ProductType ProductType { get; set; }
        public string SKU { get; set; }
        public int SortOrder { get; set; }
        public bool Visibility { get; set; }
        public Guid CategoryId { get; set; }
        public string SeoMetaDescription { get; set; }
        public string Description { get; set; }
        public string ThumbnailPicture { get; set; }
    }
}
