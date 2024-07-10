namespace EmreBekfilavioglu_Blog.Models
{
	public class Konu
	{
        public int KonuID { get; set; }
        public string KonuAdi { get; set; }


        public ICollection<KonuMakale>? KonuMakeleler { get; set; }
        public ICollection<KonuUye> KonuUyeler { get; set; }
    }
}
