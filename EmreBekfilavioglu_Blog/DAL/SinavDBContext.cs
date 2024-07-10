using EmreBekfilavioglu_Blog.Models;
using EmreBekfilavioglu_Blog.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EmreBekfilavioglu_Blog.DAL
{
	public class SinavDBContext : IdentityDbContext<Uye,Rol,int>
	{

        public SinavDBContext()
        {
            
        }

		public SinavDBContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Konu> Konular { get; set; }
        public DbSet<Makale> Makaleler { get; set; }
        public DbSet<KonuUye> KonuUyeler { get; set; }
        public DbSet<KonuMakale> KonuMakaleler { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


			// Olusturulan ilk uyeye uye rol atamasi yapildi...
            IdentityUserRole<int> identityUserRole = new IdentityUserRole<int>();
            identityUserRole.UserId = 1;
            identityUserRole.RoleId = 1;

            builder.Entity<IdentityUserRole<int>>(x => x.HasData(identityUserRole));
        }

	}
}
