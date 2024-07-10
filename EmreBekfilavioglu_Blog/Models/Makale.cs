using EmreBekfilavioglu_Blog.Models.Identity;

namespace EmreBekfilavioglu_Blog.Models
{
	public class Makale
	{
		public int MakaleID { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public DateTime YazimTarihi { get; set; } = DateTime.Now;
        public int OkumaSuresi { get; set; }

        // Site tutarsa double yapılabilir...
        public int OkunmaSayisi { get; set; } = 0;

        
        
        public int UyeID { get; set; }

        public ICollection<KonuMakale>? KonuMakaleler { get; set; }
        public Uye Uye { get; set; }



    }
}
