using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaComputadores.Models.CatalogoComputadores
{
    public class ComputadorCadastroModel
    {
        private ComputadorService _computadores;
        [HttpPost]
        public void Cadastro(string nome, string HD, string Ram, string PlacaMae, string PlacaVideo, string Processador, float Preco)
        {
            Computador NovoComputador = new Computador
            {
                Nome = nome,
                HD = HD,
                Ram = Ram,
                PlacaMae = PlacaMae,
                PlacaVideo = PlacaVideo,
                Processador = Processador,
                Preco = Preco
            };
            _computadores.Add(NovoComputador);
        }
    }
}
