using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using T2Pokemon.Models;

namespace T2Pokemon.Controllers
{

    public class PokemonController : BaseController
    {

        private readonly PokemonContext _context;
        private readonly IHostEnvironment _hostEnv;
        private readonly IConfiguration configuration;
        public PokemonController(PokemonContext context, IHostEnvironment hostEnv, IConfiguration configuration) : base(context)
        {
            this.configuration = configuration;
            _context = context;
            _hostEnv = hostEnv;
        }

        public IActionResult Index(string search)
        {

            ViewBag.Buscar = search;
            var pokemon = _context.Pokemones
                //.Where(o => o.UserId == LoggedUser().Id)
                .Include(o => o.Elementos)
                .ToList();

            //Buscar
            if (!string.IsNullOrEmpty(search))
            {
                pokemon = pokemon.Where(s => s.Nombre.Contains(search)).ToList();
                return View("Index", pokemon);
            }

            return View("Index", pokemon);
        }

        [Authorize]
        [HttpGet]
        public ActionResult Registrar()
        {
            ViewBag.Elementos = _context.Elementos.ToList();
            return View("Registrar", new Pokemon());
        }

        [Authorize]
        [HttpPost]
        public ActionResult Registrar(Pokemon pokemon, IFormFile image, string nombre)
        {
            pokemon.UserId = LoggedUser().Id;

            if (image != null && image.Length > 0)
            {
                var basePath = _hostEnv.ContentRootPath + @"\wwwroot";
                var ruta = @"\Files\" + image.FileName;
                using (var strem = new FileStream(basePath + ruta, FileMode.Create))
                {
                    image.CopyTo(strem);
                    pokemon.Imagen = ruta;
                }
            }
            else 
            {
                ModelState.AddModelError("Imagen","Este campo es obligatorio");
            }

           var pokemons = _context.Pokemones
                .Where(o => o.UserId == LoggedUser().Id)
                .Include(o => o.Elementos)
                .ToList();

            foreach (var item in pokemons)
            {
                if (item.Nombre == nombre) {
                    ModelState.AddModelError("Nom", "Este campo es obligatorio");
                }
            }



            if (ModelState.IsValid)
            {
                _context.Pokemones.Add(pokemon);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Elementos = _context.Elementos.ToList();
                return View("Registrar", pokemon);
            }
        }

        [Authorize]
        [HttpGet]
        public ActionResult Editar(int id)
        {
            ViewBag.Elementos = _context.Elementos.ToList();

            var pokemon = _context.Pokemones.Where(o => o.Id == id).FirstOrDefault(); 
            return View("Editar", pokemon);

        }

        [Authorize]
        [HttpPost]
        public ActionResult Editar(Pokemon pokemon, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                // Guardar archivos en el servidor:
                if (image != null && image.Length > 0)
                {
                    var basePath = _hostEnv.ContentRootPath + @"\wwwroot";
                    var ruta = @"\Files\" + image.FileName;
                    using (var strem = new FileStream(basePath + ruta, FileMode.Create))
                    {
                        image.CopyTo(strem);
                        pokemon.Imagen = ruta;
                    }
                }
                _context.Pokemones.Update(pokemon);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Elementos = _context.Elementos.ToList();
                return View("Editar", pokemon);
            }
        }

        [Authorize]
        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            var cuenta = _context.Pokemones.Where(o => o.Id == id).FirstOrDefault();
            _context.Pokemones.Remove(cuenta);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
