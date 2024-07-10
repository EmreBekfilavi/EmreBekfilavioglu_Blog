using EmreBekfilavioglu_Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmreBekfilavioglu_Blog.DAL.Configurations
{
    public class KonuMakale_CFG : IEntityTypeConfiguration<KonuMakale>
    {
        public void Configure(EntityTypeBuilder<KonuMakale> builder)
        {
            builder.HasData
                (
                new KonuMakale { KonuMakaleID = 1, MakaleID = 1, KonuID = 3 },
                new KonuMakale { KonuMakaleID = 2, MakaleID = 1, KonuID = 5 },
                new KonuMakale { KonuMakaleID = 3, MakaleID = 2, KonuID = 2},
                new KonuMakale { KonuMakaleID = 4, MakaleID = 3, KonuID = 4},
                new KonuMakale { KonuMakaleID = 5, MakaleID = 4, KonuID = 6},
                new KonuMakale { KonuMakaleID = 6, MakaleID = 5, KonuID = 7}
                );
        }
    }
}
