﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ValidacaoCustomizada
{
    public class MyValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (((string)value).Length == 10)
                return true;

            return false;
        }
    }
}
