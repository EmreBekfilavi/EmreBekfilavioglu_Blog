using EmreBekfilavioglu_Blog.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmreBekfilavioglu_Blog.DAL.Configurations
{
    public class Uye_CFG : IEntityTypeConfiguration<Uye>
    {
        public void Configure(EntityTypeBuilder<Uye> builder)
        {
            Uye uye = new Uye
            {
                Id = 1,
                UyeAdi = "Emre",
                UyeSoyadi = "Bekfilavi",
                UyeAciklamasi = "KD-20 BilgeAdam Boost Ogrencisi",
                Email = "emre@gmail.com",
                NormalizedEmail = "EMRE@GMAIL.COM",
                UserName = "emre@gmail.com",
                NormalizedUserName = "EMRE@GMAIL.COM",
                EmailConfirmed = false,
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString()

            };

            PasswordHasher<Uye> passwordHasher = new PasswordHasher<Uye>();
            uye.PasswordHash = passwordHasher.HashPassword(uye, "emRe_123");

            builder.HasData(uye);

        }
    }
}
