public class Program
{
    static ManualResetEvent manual01;
    static AutoResetEvent auto01;
    private static void Main(string[] args)
    {
        manual01 = new ManualResetEvent(false);
        auto01 = new AutoResetEvent(false);

        //Thread t1 = new Thread(Executa1);
        //t1.Start();

        Thread t2 = new Thread(Executa2);
        t2.Start();

        Thread.Sleep(5000);
        manual01.Set();//LIBERA
        manual01.Reset();//RESETA

        auto01.Set();

        Thread.Sleep(5000);
        manual01.Set();//LIBERA
        auto01.Set();

        Console.ReadKey();

        static void Executa1()
        {
            Console.WriteLine("01 - Iniciando!");
            manual01.WaitOne();
            Console.WriteLine("02 - Em Execução!");
            manual01.WaitOne();
            Console.WriteLine("03 - Finalizando!");
        }

        static void Executa2()
        {
            Console.WriteLine("01 - Iniciando!");
            auto01.WaitOne();
            Console.WriteLine("02 - Em Execução!");
            auto01.WaitOne();
            Console.WriteLine("03 - Finalizando!");
        }
    }
}