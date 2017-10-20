using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaComputadores.Models;

namespace LojaComputadores
{
    public class ComputadorService : IComputador
    {   //Implementação das funções da interface
        private LojaContext _context;
        public ComputadorService(LojaContext context)
        {
            _context = context;
        }

        public void Add(Computador novoComputador)
        {
            _context.Add(novoComputador);
            _context.SaveChanges();
        }

        public IEnumerable<Computador> GetAll()
        {
            return _context.Computadores;
        }

        public Computador GetById(int id)
        {
            return _context.Computadores.FirstOrDefault(computador => computador.Id == id);
        }

        public string GetHD(int id)
        {
            return _context.Computadores.FirstOrDefault(computador => computador.Id == id).HD;
        }

        public string GetImageUrl(int id)
        {
            return _context.Computadores.FirstOrDefault(computador => computador.Id == id).ImageUrl;
        }

        public string GetNome(int id)
        {
            return _context.Computadores.FirstOrDefault(computador => computador.Id == id).Nome;
        }

        public string GetPlacaMae(int id)
        {
            return _context.Computadores.FirstOrDefault(computador => computador.Id == id).PlacaMae;
        }

        public string GetPlacaVideo(int id)
        {
            return _context.Computadores.FirstOrDefault(computador => computador.Id == id).PlacaVideo;
        }

        public float GetPreco(int id)
        {
            return _context.Computadores.FirstOrDefault(computador => computador.Id == id).Preco;
        }

        public string GetProcessador(int id)
        {
            return _context.Computadores.FirstOrDefault(computador => computador.Id == id).Processador;
        }

        public string GetRam(int id)
        {
            return _context.Computadores.FirstOrDefault(computador => computador.Id == id).Ram;
        }
    }
}
