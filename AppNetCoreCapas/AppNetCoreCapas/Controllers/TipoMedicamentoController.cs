using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using CapaNegocio;
using CapaEntidad;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace AppNetCoreCapas.Controllers
{
    public class TipoMedicamentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Inicio()
        {
            return View();
        }

        public IActionResult SinMenu()
        {
            return View();
        }

        //Return string, numeros enteros, numeros decimlaes
        public string Saludo()
        {
            return "Hola mundo";
        }
        public int NumeroEntero()
        {
            return 10;
        }
        public double NumeroDecimal()
        {
            return 10.12;
        }

        //Recibiendo un parametro
        public string SaludoNombre(string nombre)
        {
            return "Bienvenido " + nombre;
        }

        //Recibiendo dos parametros
        public string SaludoNombreApellido(string nombre, string apellido)
        {
            return "Bienvenido " + nombre + " " + apellido;
        }

        //Metodo para listar los medicamentos
        public List<TipoMedicamentoCLS> listarTipoMedicamento()
        {
            TipoMedicamentoBL obj = new TipoMedicamentoBL();
            return obj.listarMedicamentos();
        }

        //Ejemplo de cadena de conexion a base de datos
        public string cadena()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"));
            var root = builder.Build();
            var bd = root.GetConnectionString("cn");
            return bd;
        }
    }
}
