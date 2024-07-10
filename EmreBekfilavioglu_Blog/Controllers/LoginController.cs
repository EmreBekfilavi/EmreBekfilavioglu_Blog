
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using EmreBekfilavioglu_Blog.Models.Identity;
using EmreBekfilavioglu_Blog.Models.ViewModels;

namespace HamburgerMVC.Controllers
{
    public class LoginController : Controller
    {


        private readonly SignInManager<Uye> _signInManager;
        private readonly UserManager<Uye> _userManager;

        public LoginController(SignInManager<Uye> signInManager, UserManager<Uye> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Giris()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Giris(GirisYap_VM vm)
        {
            var uye = _userManager.FindByEmailAsync(vm.EMail).Result;

            if (uye == null)
            {
                //eposta kontrolu...
                ViewData["Result"] = "Mail Adresiniz Hatalıdır!";
                return View();
            }

            if (!_userManager.CheckPasswordAsync(uye, vm.Sifre).Result)
            {
                //sifre kontrolu...
                ViewData["Result"] = "Şifre Hatalıdır!";
                return View();
            }

            await _signInManager.SignInAsync(uye, false);

            return RedirectToAction("Index", "Home");
        }

        
        public async Task<IActionResult> Cikis()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
            
        }

        public IActionResult KayitOl()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> KayitOl(KayitOl_VM vm)
        {
            
            Uye uye = new Uye();
            uye.UserName = vm.EMail;
            uye.Email = vm.EMail;
            uye.UyeAdi = vm.Ad;
            uye.UyeSoyadi = vm.Soyad;

            uye.PasswordHash = _userManager.PasswordHasher.HashPassword(uye, vm.Sifre);
            var result = await _userManager.CreateAsync(uye);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(uye, "Uye");

                TempData["Result"] = "Kaydınız Başarıyla Oluşturulmuştur ";

                return RedirectToAction("Index", "Home");
            }

            return View();


        }

    }

}
