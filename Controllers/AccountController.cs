using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using MovieRank.Models;
using MovieRank.Services;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace MovieRank.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserService _userService;

        public AccountController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [AllowAnonymous] // Permite el acceso sin autenticación
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous] // Permite el acceso sin autenticación
        public IActionResult Login(User model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Implementa la lógica para validar las credenciales del usuario
            // Por ejemplo: var user = _userService.GetUserByEmailAndPassword(model.UserEmail, model.Password);

            // Simula un inicio de sesión exitoso
            var claims = new[] { new Claim(ClaimTypes.Name, model.UserEmail) };
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            return RedirectToAction("Index", "Home");
        }

        // Implementa acciones similares para Registro y Cierre de Sesión (Logout)
    }
}