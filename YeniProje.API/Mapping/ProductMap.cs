using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YeniProje.API.Models;

namespace YeniProje.API.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => new { x.Product_Id});
            builder.Property(x => x.Product_Id).UseIdentityColumn();
        }
    }
}
