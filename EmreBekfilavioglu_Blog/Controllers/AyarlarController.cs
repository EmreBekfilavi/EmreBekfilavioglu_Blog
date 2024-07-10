using EmreBekfilavioglu_Blog.DAL;
using EmreBekfilavioglu_Blog.Models.Identity;
using EmreBekfilavioglu_Blog.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmreBekfilavioglu_Blog.Areas.UyeAlani.Controllers
{
	[Authorize]
	public class AyarlarController : Controller
	{
		private readonly SinavDBContext _context;
		private readonly UserManager<Uye> _userManager;
		private readonly SignInManager<Uye> _signInManager;

        public AyarlarController(SinavDBContext context, UserManager<Uye> userManager, SignInManager<Uye> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public int GetUserID()
        {
            //ctor injection ile UserManager'ı yükle...
            return int.Parse(_userManager.GetUserId(User));
        }


        public  IActionResult Detay(int id)
		{	
			Uye uye = _context.Users.FirstOrDefault(x => x.Id.Equals(id));

			return View(uye);
		}

		public IActionResult Guncelle(int id)
		{
			UyeGuncelle_VM vm = new UyeGuncelle_VM();

			Uye uye = _context.Users.FirstOrDefault(x => x.Id.Equals(id));

			vm.UyeID = uye.Id;
			vm.UyeAdi = uye.UyeAdi;
			vm.UyeSoyadi = uye.UyeSoyadi;
			vm.UyeAciklamasi = uye.UyeAciklamasi;
			vm.UyeResmi = uye.UyeResmi;
			vm.EMail = uye.Email;
			vm.UserName = uye.UserName;

			return View(vm);
		}

		[HttpPost]
		public async Task<IActionResult> Guncelle(UyeGuncelle_VM vm)
		{
			Uye uye = _context.Users.FirstOrDefault(x => x.Id.Equals(vm.UyeID));

			if (ModelState.IsValid)
			{
				
				uye.Id = vm.UyeID;
				uye.UyeAdi = vm.UyeAdi;
				uye.UyeSoyadi =vm.UyeSoyadi;
				uye.UyeResmi =vm.UyeResmi;
				uye.UyeAciklamasi = vm.UyeAciklamasi;
				uye.Email = vm.EMail;
				uye.UserName = vm.UserName;

				_context.SaveChanges();

				TempData["GuncelleSonuc"] = "Güncelleme İşlemi Başarılı";
				int _id = vm.UyeID;


				return RedirectToAction("Index", "Home");
				
				//return RedirectToAction("Detay","Ayarlar",new {id = _id});
			}
			else
			{
				TempData["GuncelleSonuc"] = "Güncellenirken Hata Oluştu";

				return View(vm);
			}
		}


		public IActionResult Sil(int id)
		{
			Uye uye = _context.Users.FirstOrDefault(x => x.Id.Equals(id));

			return View(uye);
		}

		[HttpPost]
		public  IActionResult Sil()
		{
			int id = GetUserID();

			_context.Users.Remove(_context.Users.FirstOrDefault(x => x.Id.Equals(id)));

			_context.SaveChanges();
            

            return RedirectToAction("Cikis", "Login");
            
		}
	}
}
