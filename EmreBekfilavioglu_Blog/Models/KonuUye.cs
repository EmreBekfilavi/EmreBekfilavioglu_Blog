using EmreBekfilavioglu_Blog.Models.Identity;

namespace EmreBekfilavioglu_Blog.Models
{
	public class KonuUye
	{
        public int KonuUyeID { get; set; }

        public int KonuID { get; set; }
        public int UyeID { get; set; }

        public Konu Konu { get; set; }
        public Uye Uye { get; set; }
    }
}
