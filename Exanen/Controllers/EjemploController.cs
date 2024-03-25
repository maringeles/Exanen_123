using Exanen.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exanen.Controllers
{
    public class EjemploController : Controller
    {
        public IActionResult EjemploObjeto()
        {
            Producto prod = new Producto
            {
                Id = 1,
                Nombre = "Queso",
                Precio = 20.5,
                Foto = "queso.jpeg",
                Cantidad = 3
            };
                
            ViewBag.producto= prod;
            return View();
        }
    }
}
