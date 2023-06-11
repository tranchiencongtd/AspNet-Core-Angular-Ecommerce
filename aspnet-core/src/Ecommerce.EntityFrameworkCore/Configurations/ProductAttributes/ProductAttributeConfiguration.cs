using Ecommerce.ProductAttributes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.ProductAttributes
{
    public class ProductAttributeConfiguration : IEntityTypeConfiguration<ProductAttribute>
    {
        public void Configure(EntityTypeBuilder<ProductAttribute> builder)
        {
            builder.ToTable(EcommerceConsts.DbTablePrefix + "ProductAttributes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(x => x.Label)
               .HasMaxLength(50)
               .IsRequired();

        }
    }
}
