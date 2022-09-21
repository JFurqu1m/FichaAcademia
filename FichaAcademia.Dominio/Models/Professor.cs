﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FichaAcademia.Dominio.Models
{
    public class Professor
    {
        public int ProfessorId { get; set; }
        [Required(ErrorMessage = "Campo obragatório")]
        [StringLength(50, ErrorMessage = "Use menos caracteres!")]
        public string Nome { get; set; }

        public string Foto { get; set; }

        [Required(ErrorMessage = "Campo obragatório!")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Campo obragatório")]
        [StringLength(10, ErrorMessage = "Use menos caracteres!")]
        public string Turno { get; set; }

        public ICollection<Aluno>Alunos  { get; set; }

    }
}