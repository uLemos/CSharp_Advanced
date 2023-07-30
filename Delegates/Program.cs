
Calcula calc = new Calcula(soma);

var novoCalc = calc(2, 3);

Calcula calc2 = new Calcula(subtrair);
var novoCalc2 = calc2(10, 5);

Console.WriteLine($"Soma: {novoCalc}\nSubtração: {novoCalc2}");

static int soma(int a, int b)
{
    return a + b;
}
static int subtrair(int a, int b)
{
    return a - b;
}

delegate int Calcula(int a, int b);