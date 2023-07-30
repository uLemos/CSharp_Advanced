using System.Collections.Generic;

int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };

//var listas = lista.Where(x => x > 10).Select(x => x);
//var listas = lista.Where(x => x > 10).OrderBy(x => x).Select(x => x);
var listas = from list in lista where list > 10 orderby list select list;

Console.WriteLine("MANEIRA ALTERANATIVA");

foreach (var listagem in listas)
{
    Console.WriteLine(listagem);
}

