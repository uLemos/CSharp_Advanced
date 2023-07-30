Console.WriteLine($"DateTime: {DateTime.Now}");

for (int i = 0; i < 5; i++)
{
    Thread t1 = new Thread(ThreadRepeticao);
    t1.IsBackground = true;
    t1.Start();
}
Console.ReadKey();

//IO - Entrada e Saída de dados - Tela(Monitor), Rede e Armazinamento
static void ThreadRepeticao()
{
    var rede = 0;
    Object variavelDeControle = 0;

    
    for (int i = 0; i < 1000; i++)
    {
        lock (variavelDeControle)
        {
            Console.WriteLine($"Num: {i}");
            rede++;
        }

    }
    Console.WriteLine($"DateTime: {DateTime.Now}");

}
