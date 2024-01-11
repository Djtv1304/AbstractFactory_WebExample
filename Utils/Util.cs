using AbstractFactory.Data;
using AbstractFactory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AbstractFactory.Utils
{
    public class Util : ControllerBase
    {

        private readonly ApplicationDBContext _dbContext;

        public Util(ApplicationDBContext dBContext)
        {

            _dbContext = dBContext;

        }

        public List<MonedaGameboy> GetMonedaGameboy()
        {

            List<MonedaGameboy> membresias = _dbContext.MonedaGameboy.ToList();

            return membresias != null ? membresias : null;

        }

    }
}
