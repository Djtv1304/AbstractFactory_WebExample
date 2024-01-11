using AbstractFactory.Data;
using AbstractFactory.Models;
using AbstractFactory.Models.Factorys;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AbstractFactory.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDBContext _dbContext;

        public HomeController(ILogger<HomeController> logger, ApplicationDBContext dbContext)
        {

            _logger = logger;
            _dbContext = dbContext;

        }

        public async Task<IActionResult> Index()
        {

            List<MonedaGameboy> listaMonedaGameboy = await _dbContext.MonedaGameboy.ToListAsync();

            List<MonedaNintendoDS> listaMonedaNintendoDS =  await _dbContext.MonedaNintendoDS.ToListAsync();

            List<BloqueInterroganteGameboy> listaBloqueInterroganteGameboy =  await _dbContext.BloqueInterroganteGameboy.ToListAsync();

            List<BloqueInterroganteNintendoDS> listaBloqueInterroganteNintendoDS =  await _dbContext.BloqueInterroganteNintendoDS.ToListAsync();

            // Asignación de ViewBags
            ViewBag.listaMonedaGameboy = listaMonedaGameboy;
            ViewBag.listaMonedaNintendoDS = listaMonedaNintendoDS;
            ViewBag.listaBloqueInterroganteGameboy = listaBloqueInterroganteGameboy;
            ViewBag.listaBloqueInterroganteNintendoDS = listaBloqueInterroganteNintendoDS;

            return View();

        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}
