namespace EmreBekfilavioglu_Blog.Models
{
	public class KonuMakale
	{
        public int KonuMakaleID { get; set; }


        public int KonuID { get; set; }
        public int MakaleID { get; set; }

        public Konu Konu { get; set; }
        public Makale Makale { get; set; }
    }
}
