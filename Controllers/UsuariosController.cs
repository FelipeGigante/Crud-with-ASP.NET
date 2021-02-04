using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crud.Models;
using Crud.Models.Contexto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Crud.Controllers
{
    public class UsuariosController : Controller
    {

        private readonly Contexto _contexto;
        public UsuariosController(Contexto contexto)
        {
            _contexto = contexto;
        }


        public IActionResult Index()
        {
            var lista = _contexto.Usuario.ToList();
            Types();
            StatusContainers();
            Category();
            Movimentation();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var usuario = new Usuario();
            Types();
            StatusContainers();
            Category();
            Movimentation();
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Create(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _contexto.Usuario.Add(usuario);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            Types();
            StatusContainers();
            Category();
            Movimentation();
            return View(usuario);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var usuario = _contexto.Usuario.Find(id);

            Types();
            StatusContainers();
            Category();
            Movimentation();
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Edit(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _contexto.Usuario.Update(usuario);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                Types();
                StatusContainers();
                Category();
                Movimentation();
                return View(usuario);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var usuario = _contexto.Usuario.Find(id);
            Types();
            StatusContainers();
            Category();
            Movimentation();
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Delete(Usuario _usuario)
        {
            var usuario = _contexto.Usuario.Find(_usuario.id);
            if (usuario != null)
            {
                _contexto.Usuario.Remove(usuario); 
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var usuario = _contexto.Usuario.Find(id);
            Types();
            StatusContainers();
            Category();
            Movimentation();
            return View(usuario);
        }

        public void Types()
        {
            var TypeList = new List<SelectListItem>
            {
                new SelectListItem{Value = "1", Text = "20"},
                new SelectListItem{Value = "2", Text = "40"}
            };

            ViewBag.Type = TypeList;
        }

        public void StatusContainers()
        {
            var Status = new List<SelectListItem>
            {
                new SelectListItem{Value = "1", Text = "Cheio"},
                new SelectListItem{Value = "2", Text = "Vazio"}
            };

            ViewBag.StatusContainer = Status;
        }

        public void Category()
        {
            var Categoria = new List<SelectListItem>
            {
                new SelectListItem{Value = "1", Text = "Importação"},
                new SelectListItem{Value = "2", Text = "Exportação"}
            };

            ViewBag.category = Categoria;
        }

        public void Movimentation()
        {
            var moves = new List<SelectListItem>
            {
                new SelectListItem{Value = "1", Text = "Embarque"},
                new SelectListItem{Value = "2", Text = "Descarga"},
                new SelectListItem{Value = "3", Text = "Gate IN"},
                new SelectListItem{Value = "4", Text = "Gate OUT"},
                new SelectListItem{Value = "5", Text = "Posicionamento Pilha"},
                new SelectListItem{Value = "6", Text = "Pesagem"},
                new SelectListItem{Value = "7", Text = "Scanner"},
            };

            ViewBag.Moviment = moves;
        }
    }
}