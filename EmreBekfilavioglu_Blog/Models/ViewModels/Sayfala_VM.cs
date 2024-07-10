namespace EmreBekfilavioglu_Blog.Models.ViewModels
{
	public class Sayfala_VM
	{
        public IEnumerable<Makale> Makaleler { get; set; }
        public int KayitSayisi { get; set; }
        public int SayfaAdedi { get; set; }
    }
}
