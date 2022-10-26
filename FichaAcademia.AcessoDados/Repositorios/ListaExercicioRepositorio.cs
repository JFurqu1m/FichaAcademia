using FichaAcademia.AcessoDados.Interfaces;
using FichaAcademia.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FichaAcademia.AcessoDados.Repositorios
{
    public class ListaExercicioRepositorio : RepositorioGenerico<ListaExercicio>,ILIstaExercicioRepositorio
    {
        private readonly Contexto _contexto;

        public ListaExercicioRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public async Task<bool> ExercicioExisteNaFicha(int exercicioId, int fichaID)
        {
            return await _contexto.ListasExercicios.AnyAsync(e => e.ExercicioId == exercicioId && e.FichaId == fichaID);
        }
    }

}
