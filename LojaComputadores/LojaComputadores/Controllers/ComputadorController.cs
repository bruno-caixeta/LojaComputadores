using LojaComputadores.Models;
using LojaComputadores.Models.CatalogoComputadores;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaComputadores.Controllers
{
    public class ComputadorController : Controller
    {   //Controlador
        private IComputador _computadores;
        public ComputadorController(IComputador computadores)
        {
            _computadores = computadores;
        }

        public IActionResult Index()
        {
            var computadorModels = _computadores.GetAll();
            var listingResult = computadorModels.Select(result => new ComputadorIndexListingModel
            {
                Id = result.Id,
                ImageUrl = result.ImageUrl,
                Nome = result.Nome,
                HD = result.HD,
                Ram = result.Ram,
                PlacaMae = result.PlacaMae,
                PlacaVideo = result.PlacaVideo,
                Processador = result.Processador,
                Preco = result.Preco
               
            });

            var model = new ComputadorIndexModel()
            {
                Computadores = listingResult
            };

            return View(model);

        }

        public IActionResult Detail(int id)
        {
            var computador = _computadores.GetById(id);

            var model = new ComputadorDetailModel
            {
                ComputadorId = id,
                Nome = computador.Nome,
                HD = computador.HD,
                Ram = computador.Ram,
                PlacaMae = computador.PlacaMae,
                PlacaVideo = computador.PlacaVideo,
                Processador = computador.Processador,
                PrecoVista = computador.Preco - computador.Preco * 10 / 100,
                PrecoVistaCartao = computador.Preco,
                PrecoParcelado = Math.Round(Convert.ToDouble(computador.Preco) * Math.Pow(1.0 + 0.02, 10.0), 2),
                ImageUrl = computador.ImageUrl
            };

            return View(model);
        }

        public IActionResult Cadastro()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Cadastrar(Computador form)
        {

            Computador NovoComputador = new Computador
            {
                Nome = form.Nome,
                HD = form.HD,
                Ram = form.Ram,
                PlacaMae = form.PlacaMae,
                PlacaVideo = form.PlacaVideo,
                Processador = form.Processador,
                Preco = form.Preco,
                ImageUrl = form.ImageUrl
            };

            _computadores.Add(NovoComputador);
            return View("Cadastro");
             
        }

        

        
    }
}
