using Microsoft.AspNetCore.Identity;

namespace EmreBekfilavioglu_Blog.Models.Identity
{
	public class Uye : IdentityUser<int>
	{
        public string UyeAdi { get; set; }
        public string UyeSoyadi { get; set; }
        public string? UyeAciklamasi { get; set; }
        public string? UyeResmi { get; set; }

        public ICollection<KonuUye>? TakipEdilenKonular { get; set; }
        public ICollection<Makale>? YazilanMakaleler { get; set; }
    }
}
