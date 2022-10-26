using FichaAcademia.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FichaAcademia.AcessoDados.Interfaces
{
    public interface IFichaRepositorio : IRepositorioGenerico<Ficha>
    {
        Task<IEnumerable<Ficha>> PegarTodasFichasAlunoId(int id);
        Task<Ficha> PegarFichaAlunoId(int id);
        Task<bool> FichaExisteAluno(string Nome, int AlunoId);
        Task<bool> FichaExiste(string Nome, int FichaId);
    }
}
