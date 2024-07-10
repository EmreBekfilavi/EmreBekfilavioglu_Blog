using EmreBekfilavioglu_Blog.DAL;
using EmreBekfilavioglu_Blog.Models;
using EmreBekfilavioglu_Blog.Models.Identity;
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

		public IActionResult Index()
		{
			List<Makale> makaleler = _context.Makaleler.Include(x=> x.Uye).OrderByDescending(x=>x.YazimTarihi).ToList();

			return View(makaleler);
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
