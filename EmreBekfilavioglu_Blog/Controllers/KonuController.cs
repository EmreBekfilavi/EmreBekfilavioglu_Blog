using EmreBekfilavioglu_Blog.DAL;
using EmreBekfilavioglu_Blog.Models;
using EmreBekfilavioglu_Blog.Models.Identity;
using EmreBekfilavioglu_Blog.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmreBekfilavioglu_Blog.Areas.UyeAlani.Controllers
{
	[Authorize(Roles = "Uye")]
	public class KonuController : Controller
	{
		private readonly UserManager<Uye> userManager;
		private readonly SinavDBContext _context;

		public KonuController(UserManager<Uye> userManager, SinavDBContext context)
		{
			this.userManager = userManager;
			_context = context;
		}

		public IActionResult Index(int id)
		{

			Uye uye = _context.Users.Include(x => x.TakipEdilenKonular).FirstOrDefault(x => x.Id.Equals(id));

			List<Konu> tumKonular = _context.Konular.ToList();

			List<KonuUye> uyeKonulari = _context.KonuUyeler.Include(x=>x.Konu).Where(x=>x.UyeID.Equals(id)).ToList();

			List<string> uyeKonuİsimleri = new List<string>();

            foreach (var item in uyeKonulari)
            {
				uyeKonuİsimleri.Add(item.Konu.KonuAdi);
            }

            List<KonuAtama_VM> konuAta = new List<KonuAtama_VM>();


			tumKonular.ForEach(konu => konuAta.Add(new KonuAtama_VM() { SeciliMi = uyeKonuİsimleri.Contains(konu.KonuAdi), KonuID = konu.KonuID, KonuAdi = konu.KonuAdi }));

			return View(konuAta);
		}

		[HttpPost]
		public IActionResult Index(int id, List<KonuAtama_VM> konuListesi)
		{
			Uye uye = _context.Users.FirstOrDefault(x => x.Id.Equals(id));

			foreach (var item in _context.KonuUyeler)
			{
				if (item.UyeID == id)
				{
					_context.KonuUyeler.Remove(item);

				}
			}

			foreach (KonuAtama_VM konu in konuListesi)
            {
				if (konu.SeciliMi)
				{
					KonuUye uyeKonusu = new KonuUye();
					uyeKonusu.UyeID = uye.Id;
					uyeKonusu.KonuID = konu.KonuID;
					
					_context.KonuUyeler.Add(uyeKonusu);
				}
            }

			_context.SaveChanges();

			return RedirectToAction("Index", "Home");
        }
	}
}
