﻿using System;
using Volo.Abp.Domain.Entities;

namespace Ecommerce.Products
{
    public class Tag : Entity<Guid>
    {
        public string Label { get; set; }
        public string Slug { get; set; }
    }
}
