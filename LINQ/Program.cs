using System.Collections.Generic;

int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };

//var listas = lista.Where(x => x > 10).Select(x => x);
var listas = lista.Where(x => x > 10).OrderBy(x => x).Select(x => x);

foreach (var listagem in listas)
{
    Console.WriteLine(listagem);
}
