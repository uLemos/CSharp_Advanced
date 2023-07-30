for (int i = 0; i < 5; i++)
{
    Thread t1 = new Thread(ThreadRepeticao);
    t1.Start(i);
}
Console.ReadKey();

//IO - Entrada e Saída de dados - Tela(Monitor), Rede e Armazinamento
static void ThreadRepeticao(Object Id)
{
    for (int i = 0; i < 1000; i++)
    {
            Console.WriteLine($"Thread: {Id} - Num: {i} {Thread.CurrentThread.ManagedThreadId}");
    }
}
