﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Validacao
{
    public class Usuario
    {
        [Required(ErrorMessage = "O campo 'Nome' é de preenchimento obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Idiomas.Linguagem), ErrorMessageResourceName = "MSG_Obrigatorio"), EmailAddress]
        public string Email { get; set; }

        [Required, StringLength(10, MinimumLength = 6)]
        public string Senha { get; set; }
    }
}
