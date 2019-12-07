using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using NanoStore.Helpers.Auth;
using NanoStore.Models;
using NanoStore.Models.RawSql;
using NanoStore.Models.ViewModels;

namespace NanoStore.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var productos = db.Productos
                .Include(p => p.Categoria)
                .OrderByDescending(a => a.FechaIngreso)
                .Where(d => d.EstadoProducto == true && d.UnidadesEnAlmacen > 0)
                .Take(8);
            return View(productos);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Store()
        {
            HomeViewModel homeModel = new HomeViewModel();

            var productos = db.Productos
                .Include(p => p.Categoria)
                .Where(d => d.EstadoProducto == true && d.UnidadesEnAlmacen > 0);
            var cantCategorias = db.Database.SqlQuery<CategoriasContadorRQ>(
                    "SELECT COUNT(*) AS cantidad, c.NombreCategoria AS categoria " +
                    "FROM Productos p JOIN Categorias c ON p.CategoriaID = c.CategoriaID " +
                    "WHERE p.EstadoProducto = 1 AND p.UnidadesEnAlmacen > 0 " +
                    "GROUP BY c.NombreCategoria;").ToList();

            homeModel.Productos = productos;
            homeModel.CategoriasContador = cantCategorias;

            return View(homeModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}