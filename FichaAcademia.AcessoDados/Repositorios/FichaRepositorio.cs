using FichaAcademia.AcessoDados.Interfaces;
using FichaAcademia.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaAcademia.AcessoDados.Repositorios
{
    public class FichaRepositorio : RepositorioGenerico<Ficha>, IFichaRepositorio
    {
        public readonly Contexto _contexto;

        public FichaRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public async Task<bool> FichaExisteAluno(string Nome, int AlunoId)
        {
            return await _contexto.Fichas.AnyAsync(f => f.Nome == Nome && f.AlunoId == AlunoId);
        }

        public async  Task<bool> FichaExiste(string Nome, int FichaId)
        {
            return await _contexto.Fichas.AnyAsync(f => f.Nome == Nome && f.FichaId != FichaId);
        }

        public async Task<Ficha> PegarFichaAlunoId(int id)
        {
            return await _contexto.Fichas.Include(F => F.Aluno).FirstOrDefaultAsync(F => F.FichaId == id);
        }

        public async Task<IEnumerable<Ficha>> PegarTodasFichasAlunoId(int id)
        {
            return await _contexto.Fichas.Include(F => F.Aluno).ThenInclude(f => f.Objetivo).Where(F => F.AlunoId == id).ToListAsync();
        }
    }
}
