using LojaComputadores.Models.CatalogoComputadores;
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

    }
}
