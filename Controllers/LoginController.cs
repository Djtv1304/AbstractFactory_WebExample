using AbstractFactory.Data;
using AbstractFactory.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AbstractFactory.Controllers
{
    public class LoginController : Controller
    {

        private readonly ApplicationDBContext _dbContext;

        public LoginController(ApplicationDBContext dbContext)
        {

            _dbContext = dbContext;

        }

        // GET: LoginController
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Usuario UserToLogin)
        {
            try
            {
                Usuario UserVerified = await _dbContext.Usuarios.FirstOrDefaultAsync( data => data.Mail.Equals(UserToLogin.Mail) && data.Password.Equals(UserToLogin.Password) );

                if (UserVerified != null)
                {

                    // Redirigir a la página de inicio
                    return RedirectToAction("Index", "Home");

                }

                // Aquí asignamos el mensaje de error
                ViewBag.ErrorMessage = "Usuario o contraseña incorrectos.";

                return View();
            }
            catch
            {

                // Aquí también podrías asignar un mensaje de error si lo deseas
                ViewBag.ErrorMessage = "Ocurrió un error al intentar iniciar sesión.";
                return View();

            }
        }

        // GET: LoginController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
