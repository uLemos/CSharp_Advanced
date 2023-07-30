using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ValidacaoCustomizada
{
    public class Usuario
    {
        [Required(ErrorMessage = "O campo 'Nome' é de preenchimento obrigatório!")]
        public string Nome { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, StringLength(10, MinimumLength = 6)]
        [MyValidationAttribute(ErrorMessage = "O campo senha deve possuir 10 caracteres!")]
        public string Senha { get; set; }
    }
}
