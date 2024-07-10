namespace EmreBekfilavioglu_Blog.Models.ViewModels
{
	public class MakaleYaz_VM
	{
        public string Baslik { get; set; }
        public string Icerik  { get; set; }
        public int OkumaSuresi { get; set; }
        public List<KonuMakaleAta_VM> KonuMakaleAta { get; set; }

    }
}
