using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YeniProje.API.Models;

namespace YeniProje.API.Mapping
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => new { x.Customer_Id });
            builder.Property(x => x.Customer_Id).UseIdentityColumn();


        }
    }
}
