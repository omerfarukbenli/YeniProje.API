using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YeniProje.API.Models;

namespace YeniProje.API.Mapping
{
    public class OrderDetailMap : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(x => new {x.Order_Id, x.Product_Id });
            builder.Property(x => x.Order_Id).UseIdentityColumn();
            


        }
    }
}
