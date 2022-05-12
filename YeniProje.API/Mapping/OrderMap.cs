using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YeniProje.API.Models;

namespace YeniProje.API.Mapping
{
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => new { x.Order_Id, x.Customer_Id });
            builder.Property(x => x.Order_Id).UseIdentityColumn();
           
        }
    }
}
