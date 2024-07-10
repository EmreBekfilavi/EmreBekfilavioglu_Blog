using EmreBekfilavioglu_Blog.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmreBekfilavioglu_Blog.DAL.Configurations
{
    public class Rol_CFG : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.HasData(new Rol { Id = 1, Name ="Uye", NormalizedName = "UYE", ConcurrencyStamp = Guid.NewGuid().ToString() });
        }
    }
}
