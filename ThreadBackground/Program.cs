
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
    for (int i = 0; i < 1000; i++)
    { 
        Console.WriteLine($"Num: {i}");
    }
    Console.WriteLine($"DateTime: {DateTime.Now}");
}
