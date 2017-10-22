using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaComputadores.Models.CatalogoComputadores
{
    public class ComputadorDetailModel
    {
        public int ComputadorId { get; set; }
        public string Nome { get; set; }
        public string HD { get; set; }
        public string Ram { get; set; }
        public string PlacaMae { get; set; }
        public string PlacaVideo { get; set; }
        public string Processador { get; set; }
        public float PrecoVista { get; set; }
        public float PrecoVistaCartao { get; set; }
        public double PrecoParcelado { get; set; }
        public string ImageUrl { get; set; }
    }
}
