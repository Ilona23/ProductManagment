using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProductManagment.Entities
{
    public class PackageProductConfiguration : IEntityTypeConfiguration<PackageProduct>
    {
        public void Configure(EntityTypeBuilder<PackageProduct> builder)
        {
            builder.HasOne(p => p.Package)
                .WithMany(b => b.PackageProducts)
                .HasForeignKey(p => p.PackageId);
        }
    }
}
