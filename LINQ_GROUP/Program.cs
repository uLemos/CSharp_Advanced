int[] listaNum = { 1, 1, 1, 1, 4, 4, 2, 3, 5, 6, 6, 10, 9, 8 };

//GROUP DISTINCT
//var listaFiltrada = listaNum.Distinct().OrderBy(x => x).Select(x => x); SQL HAVING
//var listaFiltrada = listaNum.OrderBy(x => x);
var listaFiltrada = listaNum.OrderBy(x=>x).GroupBy(x => x).Select(x=>x);

foreach (var item in listaFiltrada)
{
    Console.WriteLine(item.Key);
}

