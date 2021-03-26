using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using landing_page.Models;

namespace landing_page.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            MantenimientoUsuario ma = new MantenimientoUsuario();
            return View(ma.RecuperarTodos());
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            MantenimientoUsuario ma = new MantenimientoUsuario();
            Usuario usu = new Usuario
            {
                Nombre = collection["nombre"],
                Email = collection["email"],
                Ciudad = collection["ciudad"]
            };
            ma.Alta(usu);

            if (ModelState.IsValid)
            {
                return View("Correcto");
            }
            else
            {
                return View(ma.RecuperarTodos());
            }
                
                
        }
        

        //// GET: Home/Details/5
        //public ActionResult Details(int id)
        //{
        //    MantenimientoUsuarios ma = new MantenimientoUsuarios();
        //    Usuarios usu = ma.Recuperar(id);
        //    return View(usu);
        //}



        //// GET: Home/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    MantenimientoUsuarios ma = new MantenimientoUsuarios();
        //    Usuarios usu = ma.Recuperar(id);
        //    return View(usu);
        //}

        //// POST: Home/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    MantenimientoUsuarios ma = new MantenimientoUsuarios();
        //    Usuarios usu = new Usuarios
        //    {
        //        Id = id,
        //        Documento = collection["documento"].ToString(),
        //        TipoDocumento = collection["tipodocumento"].ToString(),
        //        Nombre = collection["nombre"].ToString(),
        //        Celular = collection["celular"].ToString(),
        //        Email = collection["email"].ToString(),
        //        Genero = collection["genero"].ToString(),
        //        Aprendiz = int.Parse(collection["aprendiz"].ToString()),
        //        Egresado = int.Parse(collection["egresado"].ToString()),
        //        AreaFormacion = collection["areaformacion"].ToString(),
        //        FechaEgresado = DateTime.Parse(collection["fechaegresado"].ToString()),
        //        Direccion = collection["direccion"].ToString(),
        //        Barrio = collection["barrio"].ToString(),
        //        Ciudad = collection["ciudad"].ToString(),
        //        Departamento = collection["departamento"].ToString(),
        //        FechaRegistro = DateTime.Parse(collection["fecharegistro"].ToString())
        //    };
        //    ma.Modificar(usu);
        //    return RedirectToAction("Index");
        //}

        //// GET: Home/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    MantenimientoUsuarios ma = new MantenimientoUsuarios();
        //    Usuarios usu = ma.Recuperar(id);
        //    return View(usu);
        //}

        //// POST: Home/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    MantenimientoUsuarios ma = new MantenimientoUsuarios();
        //    ma.Borrar(id);
        //    return RedirectToAction("Index");
        //}
    }
}