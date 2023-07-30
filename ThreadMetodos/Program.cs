//Thread Sleep
Console.WriteLine("INÍCIO DO NOSSO PROGRAMA!");
Thread.Sleep(3000);
Console.WriteLine("FINAL DO NOSSO PROGRAMA!");

//Thread Join
Thread t1 = new Thread(ThreadRepeticao);
t1.Start();
t1.Join();

Console.WriteLine("Termino do nosso programa!");
Console.WriteLine("Termino do nosso programa!");
Console.WriteLine("Termino do nosso programa!");
Console.WriteLine("Termino do nosso programa!");
Console.WriteLine("Termino do nosso programa!");



static void ThreadRepeticao(Object Id)
{
    for (int i = 0; i < 1000; i++)
    {
        Console.WriteLine($"Thread: {Id} - Num: {i} {Thread.CurrentThread.ManagedThreadId}");
    }
}
