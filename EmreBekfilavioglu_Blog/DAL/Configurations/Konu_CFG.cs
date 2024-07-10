using EmreBekfilavioglu_Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmreBekfilavioglu_Blog.DAL.Configurations
{
	public class Konu_CFG : IEntityTypeConfiguration<Konu>
	{
		public void Configure(EntityTypeBuilder<Konu> builder)
		{
			builder.HasData
				(
				new Konu { KonuID = 1, KonuAdi = "Bilim" },
				new Konu { KonuID = 2, KonuAdi = "Spor" },
				new Konu { KonuID = 3, KonuAdi = "Yazılım" },
				new Konu { KonuID = 4, KonuAdi = "Edebiyat" },
				new Konu { KonuID = 5, KonuAdi = "Teknoloji" },
				new Konu { KonuID = 6, KonuAdi = "Kişisel Gelişim" },
				new Konu { KonuID = 7, KonuAdi = "Oyun" }

				);
		}
	}
}
