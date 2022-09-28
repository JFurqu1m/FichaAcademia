using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FichaAcademia.ViewModels
{
    public class AdministradorViewModel
    {
        [Required(ErrorMessage = "Campo obragatório")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obragatório")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
