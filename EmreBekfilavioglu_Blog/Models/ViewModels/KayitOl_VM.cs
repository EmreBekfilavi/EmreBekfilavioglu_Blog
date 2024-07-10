using System.ComponentModel.DataAnnotations;

namespace EmreBekfilavioglu_Blog.Models.ViewModels
{
	public class KayitOl_VM
	{
		public string Ad { get; set; }
		public string Soyad { get; set; }
		public string EMail { get; set; }
		public string Sifre { get; set; }

		[Compare(nameof(Sifre),ErrorMessage = "Sifre İle Aynı Olmalıdır...")]
		public string SifreTekrar { get; set; }
	}
}
