﻿using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Ecommerce.ProductAttributes
{
    public class ProductAttribute : CreationAuditedAggregateRoot<Guid>
    {
        public string Code { get; set; }
        public AttributeType DataType { get; set; }
        public string Label { get; set; }
        public int SortOrder { get; set; }
        public bool Visibility { get; set; }
        public bool IsActive { get; set; }
        public bool IsRequired { get; set; }
        public bool IsUnique { get; set; }
        public string Note { get; set; }
    }
}
