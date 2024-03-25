using Exanen.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exanen.Controllers
{
    public class EjemploController : Controller
    {
        public IActionResult EjemploListaObjeto()
        {
            List<Producto> prods=new List<Producto> 
            { 
                new Producto
            {
                 Id = 1,
                 Nombre = "Atun VAnCAmps",
                 Precio = 12,
                 Foto = "ATUN.jpeg",
                 Accion="Comprar uno",
                 Cantidad = 2
                 
                
            },
             new Producto
            {
                 Id = 2,
                 Nombre = "Queso Menonita",
                 Precio = 45,
                 Foto = "queso.jpeg",
                 Accion="Comprar uno",
                 Cantidad = 3
            }
        };
            ViewBag.productos = prods;
            return View();
        }
        public IActionResult EjemploLista1Objeto()
        {
            List<Producto> prods = new List<Producto>
            {
                new Producto
            {
                 Id = 1,
                 Nombre = "Queso Menonita",
                 Precio = 45,
                 Foto = "queso.jpeg",
                 Accion="Eliminar uno",
                 Cantidad = 3
                

            },
             new Producto
            {
                 Id = 2,
                 Nombre = "Atun VanCamps",
                 Precio = 12,
                 Foto = "ATUN.jpeg",
                 Accion="Eliminar uno",
                 Cantidad = 2
            }
        };
            ViewBag.productos = prods;
            return View();
        }
   
    }
}
