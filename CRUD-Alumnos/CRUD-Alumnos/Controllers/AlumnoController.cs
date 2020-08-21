using CRUD_Alumnos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_Alumnos.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumno
        public ActionResult Index()
        {
            try
            {
                //string sql = @"SELECT a.Id AS CodAlumno, a.Nombres, a.Apellidos, a.Edad, a.Sexo, c.Nombre AS NombreCiudad, a.FechaRegistro 
                //                FROM Alumno a 
                //                INNER JOIN Ciudad c ON a.CodCiudad = c.Id";

                using (var db = new AlumnosContext1())
                {
                    var data = from a in db.Alumno
                               join c in db.Ciudad on a.CodCiudad equals c.Id
                               select new AlumnoCE()
                               {
                                   Id = a.Id,
                                   Nombres = a.Nombres,
                                   Apellidos = a.Apellidos,
                                   Edad = a.Edad,
                                   Sexo = a.Sexo,
                                   NombreCiudad = c.Nombre,
                                   FechaRegistro = a.FechaRegistro

                               };

                    //List<Alumno> lista = db.Alumno.Where(a => a.Edad > 18).ToList();   
                    return View(data.ToList());
                    //return View(lista);
                    //return View(db.Database.SqlQuery<AlumnoCE>(sql).ToList());
                }
            }
            catch (Exception)
            {

                throw;
            }
         
        }


        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Alumno a)
        {
            if (!ModelState.IsValid)
                return View();

            try
            {
                using (var db = new AlumnosContext1())
                {
                    a.FechaRegistro = DateTime.Now;

                    db.Alumno.Add(a);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error: " + ex.Message);
                return View();
            }    
        }

        public ActionResult Agregar2()
        {
            return View();
        }

        public ActionResult ListaCiudades()
        {
            using (var db = new AlumnosContext1())
            {
                return PartialView(db.Ciudad.ToList());
            }
        }

        public ActionResult Editar(int id)
        {
            try
            {
                using (var db = new AlumnosContext1())
                {
                    //Alumno al = db.Alumno.Where(a => a.Id == id).FirstOrDefault();
                    Alumno alu = db.Alumno.Find(id);
                    return View(alu);
                }
            }
            catch (Exception )
            {

                throw;
            } 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Alumno a)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View();

                using (var db = new AlumnosContext1())
                {
                    Alumno al = db.Alumno.Find(a.Id);
                    al.Nombres = a.Nombres;
                    al.Apellidos = a.Apellidos;
                    al.Edad = a.Edad;
                    al.Sexo = a.Sexo;

                    db.SaveChanges();

                    return RedirectToAction("index");
                } 
            }
            catch (Exception)
            {

                throw;
            } 
        }

        public ActionResult DetalleAlumno(int id)
        {
            try
            {
                using (var db = new AlumnosContext1())
                {
                    Alumno alu = db.Alumno.Find(id);
                    return View(alu);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ActionResult EliminarAlumno(int id)
        {
            try
            {
                using (var db = new AlumnosContext1())
                {
                    Alumno alu = db.Alumno.Find(id);
                    db.Alumno.Remove(alu);
                    db.SaveChanges();
                    return RedirectToAction("index");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static string NombreCiudad(int CodCiudad)
        {
            using (var db = new AlumnosContext1())
            {
                return db.Ciudad.Find(CodCiudad).Nombre;
            }
        }


    
    }
}