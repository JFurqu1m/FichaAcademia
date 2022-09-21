using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FichaAcademia.Dominio.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }

        [Required(ErrorMessage ="Campo obragatório")]
        [StringLength(100,ErrorMessage ="Use menos caracteres!")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "Campo obragatório")]
        [Range(14,100, ErrorMessage = "Idade inválida")]
        public int Idade { get; set; } 
        
        [Required(ErrorMessage = "Campo obragatório")]
        [Range(10,150, ErrorMessage = "Peso inválida")]
        public int Peso { get; set; }

        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }

        [Required(ErrorMessage = "Campo obragatório")]
        [Range(1, 7, ErrorMessage = "Frequencia inválida!")]
        public int FrequenciaSemanal { get; set; }

        public ICollection<Ficha> Fichas{ get; set; }
    }
}
