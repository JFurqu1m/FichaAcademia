using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FichaAcademia.Dominio.Models
{
    public class Objetivo
    {
        public int ObjetivosId { get; set; }
        [Required(ErrorMessage = "Campo obragatório")]
        [StringLength(50, ErrorMessage = "Use menos caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo obragatório")]
        [StringLength(500, ErrorMessage = "Use menos caracteres")]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        public ICollection<Aluno> Alunos { get; set; }

    }
}
