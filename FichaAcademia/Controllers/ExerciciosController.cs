using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FichaAcademia.AcessoDados;
using FichaAcademia.Dominio.Models;
using FichaAcademia.AcessoDados.Interfaces;

namespace FichaAcademia.Controllers
{
    public class ExerciciosController : Controller
    {
        private readonly IExercicioRepositorio _exercicioRepositorio;
        private readonly ICategoriaExercicioRepositorio _categoriaExercicioRepositorio;
        private readonly ILIstaExercicioRepositorio _lIstaExercicioRepositorio;

        public ExerciciosController(IExercicioRepositorio exercicioRepositorio, ICategoriaExercicioRepositorio categoriaExercicioRepositorio, ILIstaExercicioRepositorio lIstaExercicioRepositorio)
        {
            _lIstaExercicioRepositorio = lIstaExercicioRepositorio;
            _exercicioRepositorio = exercicioRepositorio;
            _categoriaExercicioRepositorio = categoriaExercicioRepositorio;
        }

        public async Task<IActionResult> Index()
        {

            return View(await _exercicioRepositorio.PegarTodos());
        }

        public async Task<IActionResult> Listagem(int FichaId, int AlunoId)
        {
            ViewData["FichaId"] = FichaId;
            ViewData["AlunoId"] = AlunoId;

            return View(await _exercicioRepositorio.PegarTodos());
        }

        public async Task<IActionResult> AdicionarExercicio(int exercicioId, int frequencia, int repeticoes, int carga, int fichaId)
        {
            if (await _lIstaExercicioRepositorio.ExercicioExisteNaFicha(exercicioId))
                return Json(false);

            ListaExercicio listaExercicio = new ListaExercicio
            {
                ExercicioId = exercicioId,
                Frequencia = frequencia,
                Repeticoes = repeticoes,
                Carga = carga,
                FichaId = fichaId
            };

            if (ModelState.IsValid)
            {
                await _lIstaExercicioRepositorio.Inserir(listaExercicio);
                return Json(true);
            } else
            {
                return Json(false);
            }


        }

        public async Task<IActionResult> Create()
        {
            ViewData["CategoriaExercicioId"] = new SelectList(_categoriaExercicioRepositorio.PegarTodos(), "CategoriaExercicioId", "Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ExercicioId,Nome,CategoriaExercicioId")] Exercicio exercicio)
        {
            if (ModelState.IsValid)
            {
                await _exercicioRepositorio.Inserir(exercicio);
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaExercicioId"] = new SelectList(_categoriaExercicioRepositorio.PegarTodos(), "CategoriaExercicioId", "Nome", exercicio.CategoriaExercicioId);
            return View(exercicio);
        }


        public async Task<IActionResult> Edit(int id)
        {

            var exercicio = await _exercicioRepositorio.PegarPeloId(id);
            if (exercicio == null)
            {
                return NotFound();
            }
            ViewData["CategoriaExercicioId"] = new SelectList(_categoriaExercicioRepositorio.PegarTodos(), "CategoriaExercicioId", "Nome", exercicio.CategoriaExercicioId);
            return View(exercicio);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ExercicioId,Nome,CategoriaExercicioId")] Exercicio exercicio)
        {
            if (id != exercicio.ExercicioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                await _exercicioRepositorio.Atualizar(exercicio);

                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaExercicioId"] = new SelectList(_categoriaExercicioRepositorio.PegarTodos(), "CategoriaExercicioId", "Nome", exercicio.CategoriaExercicioId);
            return View(exercicio);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _exercicioRepositorio.Excluir(id);

            return RedirectToAction(nameof(Index));
        }

        public async Task<JsonResult> ExercicioExiste(string nome, int ExercicioId)
        {
            if (ExercicioId == 0)
            {
                if (await _exercicioRepositorio.ExercicioExiste(nome))
                    return Json("Exercício já existe!");

                return Json(true);
            }

            else
            {
                if (await _exercicioRepositorio.ExercicioExiste(nome, ExercicioId))
                    return Json("Exercício já existe!");

                return Json(true);
            }
        }

    }
}
