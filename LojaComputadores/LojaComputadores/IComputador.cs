using LojaComputadores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaComputadores
{   //Interface com todas as funções
    public interface IComputador
    {
        IEnumerable<Computador> GetAll();
        Computador GetById(int id);
        void Add(Computador novoComputador);
        string GetNome(int id);
        string GetHD(int id);
        string GetRam(int id);
        string GetPlacaMae(int id);
        string GetPlacaVideo(int id);
        string GetProcessador(int id);
        float GetPreco(int id);
        string GetImageUrl(int id);
    }
}
