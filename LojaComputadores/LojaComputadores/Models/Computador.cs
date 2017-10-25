using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaComputadores.Models
{
    public class Computador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string HD { get; set; }
        public string Ram { get; set; }
        public string PlacaMae { get; set; }
        public string PlacaVideo { get; set; }
        public string Processador { get; set; }
        public string ImageUrl { get; set; }        
        public float Preco { get; set; }
    }
}
