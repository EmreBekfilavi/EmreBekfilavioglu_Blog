using EmreBekfilavioglu_Blog.DAL;
using EmreBekfilavioglu_Blog.Models;
using EmreBekfilavioglu_Blog.Models.Identity;
using EmreBekfilavioglu_Blog.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EmreBekfilavioglu_Blog.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly SinavDBContext _context;

		public HomeController(ILogger<HomeController> logger, SinavDBContext context)
		{
			_logger = logger;
			_context = context;
		}

		public IActionResult Index(int id = 0)
		{
			List<Makale> makaleler = _context.Makaleler.Include(x=> x.Uye).OrderByDescending(x=>x.YazimTarihi).ToList();

			Sayfala_VM sayfalaVM = new Sayfala_VM();

			sayfalaVM.KayitSayisi = 4;

			if (makaleler.Count % sayfalaVM.KayitSayisi == 0)
			{
				sayfalaVM.SayfaAdedi = makaleler.Count / sayfalaVM.KayitSayisi;
			}
			else
			{
				sayfalaVM.SayfaAdedi = (makaleler.Count / sayfalaVM.KayitSayisi) + 1;
			}


			if (id == 0)
			{
				sayfalaVM.Makaleler = makaleler.Take(sayfalaVM.KayitSayisi).ToList();
			}
			else
			{
				sayfalaVM.Makaleler = makaleler.Skip(id * sayfalaVM.KayitSayisi).Take(sayfalaVM.KayitSayisi).ToList();
			}



			return View(sayfalaVM);
		}

		public IActionResult Hakkimizda()
		{
			return View();
		}

		public IActionResult EnCokOkunanlar()
		{
			List<Makale> makaleler = _context.Makaleler.Take(3).OrderByDescending(x=>x.OkunmaSayisi).ToList();

			return View(makaleler);
		}

		public IActionResult MakaleOku(int id)
		{
			Makale makale = _context.Makaleler.Include(x => x.Uye).FirstOrDefault(x=> x.MakaleID.Equals(id));

			makale.OkunmaSayisi += 1;

			_context.SaveChanges();

			return View(makale);
		}

		public IActionResult YazanUyeGoruntule(int id)
		{

			Uye uye = _context.Users.Include(x => x.YazilanMakaleler).FirstOrDefault(x => x.Id.Equals(id));

			return View(uye);
		}

	

	
	}
}
