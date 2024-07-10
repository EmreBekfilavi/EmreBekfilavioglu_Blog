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
	public class MakaleController : Controller
	{
		private readonly UserManager<Uye> _userManager;
		private readonly SinavDBContext _context;

		public MakaleController(UserManager<Uye> userManager, SinavDBContext context)
		{
			_userManager = userManager;
			_context = context;
		}

		public IActionResult Yaz()
		{
			MakaleYaz_VM vm = new MakaleYaz_VM();

			List<Konu> tumKonular = _context.Konular.ToList();




			List<KonuMakaleAta_VM> konuAta = new List<KonuMakaleAta_VM>();


			tumKonular.ForEach(konu => konuAta.Add(new KonuMakaleAta_VM() { SeciliMi = false, KonuID = konu.KonuID, KonuAdi = konu.KonuAdi }));

			vm.KonuMakaleAta = konuAta;

			return View(vm);
		}

		[HttpPost]
		public async Task<IActionResult> Yaz(MakaleYaz_VM vm)
		{
			Uye uye = await _userManager.GetUserAsync(User);

			if (ModelState.IsValid)
			{
				Makale makale = new Makale();
				makale.Baslik = vm.Baslik;
				makale.Icerik = vm.Icerik;
				makale.OkumaSuresi = vm.OkumaSuresi;
				makale.UyeID = uye.Id;

				_context.Makaleler.Add(makale);
				_context.SaveChanges();

				foreach (KonuMakaleAta_VM konu in vm.KonuMakaleAta)
				{
					if (konu.SeciliMi)
					{
						KonuMakale makaleKonusu = new KonuMakale();
						makaleKonusu.MakaleID = makale.MakaleID;
						makaleKonusu.KonuID = konu.KonuID;

						_context.KonuMakaleler.Add(makaleKonusu);
					}
				}
			}
			else
			{
				TempData["Sonuc"] = "Bir Hata Oluştu";
				return View(vm);
			}


			_context.SaveChanges();

			TempData["Sonuc"] = "Makale Başarıyla Oluşturulmuştur";

			return RedirectToAction("Index", "Home");
		}

		public IActionResult YazdigimMakaleler(int id)
		{

			Uye uye = _context.Users.Include(x => x.YazilanMakaleler).FirstOrDefault(x => x.Id.Equals(id));

			return View(uye);
		}

		public IActionResult İlgiliMakaleler(int sayfaId=0)
		{
			int id = int.Parse(_userManager.GetUserId(User));
			List<KonuUye> uyeKonulari = _context.KonuUyeler.Where(x => x.UyeID.Equals(id)).ToList();

			List<Makale> ilgiCekebilecek = new List<Makale>();

			// Ara Tablodan Dönerek Kullanıcının Konusuyla Makalenin Konusu Ortaklandı
			foreach(var item in _context.KonuMakaleler.Include(x=>x.Makale).ThenInclude(x=>x.Uye))
			{
				foreach(var konu in uyeKonulari)
				{
					if(item.KonuID == konu.KonuID)
					{
						// Bir Makalenin birden fazla konusu olduğu için aynı makale eklensin istemiyorum...
						if (!ilgiCekebilecek.Contains(item.Makale))
						{
							ilgiCekebilecek.Add(item.Makale);
						}
					}
				}
			}

			Sayfala_VM sayfalaVM = new Sayfala_VM();

            sayfalaVM.KayitSayisi = 4;

            if (ilgiCekebilecek.Count % sayfalaVM.KayitSayisi == 0)
            {
                sayfalaVM.SayfaAdedi = ilgiCekebilecek.Count / sayfalaVM.KayitSayisi;
            }
            else
            {
                sayfalaVM.SayfaAdedi = (ilgiCekebilecek.Count / sayfalaVM.KayitSayisi) + 1;
            }


            if (sayfaId == 0)
            {
                sayfalaVM.Makaleler = ilgiCekebilecek.Take(sayfalaVM.KayitSayisi).OrderByDescending(x => x.YazimTarihi).ToList();
            }
            else
            {
                sayfalaVM.Makaleler = ilgiCekebilecek.Skip(id * sayfalaVM.KayitSayisi).Take(sayfalaVM.KayitSayisi).OrderByDescending(x=>x.YazimTarihi).ToList();
            }



            return View(sayfalaVM);
		}


	}
}



