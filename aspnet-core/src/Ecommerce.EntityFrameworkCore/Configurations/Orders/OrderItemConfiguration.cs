using Ecommerce.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Configurations.Orders
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable(EcommerceConsts.DbTablePrefix + "OrderItems");
            builder.HasKey(x => new {x.OrderId, x.ProductId});

            builder.Property(x => x.SKU)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsRequired();


        }
    }
}
