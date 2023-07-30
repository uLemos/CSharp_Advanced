using _03_ValidacaoCustomizada;
using System.ComponentModel.DataAnnotations;

Usuario usuario = new Usuario() { Nome = "José", Email = "Lemos", Senha = "123456" };
ValidationContext contexto = new ValidationContext(usuario);
List<ValidationResult> resultados = new List<ValidationResult>();



if (Validator.TryValidateObject(usuario, contexto, resultados, true) == false)
{
    //Mensagens
    foreach (var erro in resultados)
    {
        Console.WriteLine(erro.ErrorMessage);
    }
}