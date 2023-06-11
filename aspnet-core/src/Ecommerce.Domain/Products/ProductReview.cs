// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Ecommerce.Products
{
    public class ProductReview : CreationAuditedEntity<Guid>
    {
        public Guid ProductId { get; set; }
        public Guid? ParentId { get; set; }
        public string Tiltle { get; set; }
        public double Rating { get; set; }
        public DateTime? PushishedDate { get; set; }
        public string Content { get; set; }
        public Guid OrderId { get; set; }
    }
}
