using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace LojaComputadores.Models.CatalogoComputadores
{
    public class ComputadorCadastroModel 
    {
        public string Nome { get; internal set; }
        public string HD { get; internal set; }
        public string Ram { get; internal set; }
        public string PlacaMae { get; internal set; }
        public string PlacaVideo { get; internal set; }
        public string Processador { get; internal set; }
        public float Preco { get; internal set; }

        [HttpPost]
        public void Cadastro(FormCollection form)
        {
            
            Computador NovoComputador = new Computador
            {
                Nome = form["Nome"],
                HD = form["HD"],
                Ram = form["Ram"],
                PlacaMae = form["PlacaMae"],
                PlacaVideo = form["PlacaVideo"],
                Processador = form["Processador"],
                Preco = float.Parse(form["Preco"])
            };
            
            
        }
        
    }
}
