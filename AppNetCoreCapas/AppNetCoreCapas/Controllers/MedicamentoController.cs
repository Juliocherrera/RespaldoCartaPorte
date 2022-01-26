using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppNetCoreCapas.Controllers
{
    public class MedicamentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Saludos()
        {
            return "Buenos días";
        }
        public int Numero()
        {
            return 7;
        }
    }
}
