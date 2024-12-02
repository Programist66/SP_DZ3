namespace SP_DZ3
{
    internal class Program
    {
        static int count = 0;
        static void IncrementOperation() 
        {
            for (int i = 0; i < 100_000; i++)
            {
                count++;
            }
        }

        static void Main(string[] args)
        {
            const int threadCount = 4;
            Thread[] threads = new Thread[threadCount];
            for (int i = 0; i < threadCount; i++)
            {
                threads[i] = new Thread(IncrementOperation);
                threads[i].Start();
            }
            for (int i = 0; i < threadCount; i++)
            {
                threads[i].Join();
            }
            Console.WriteLine(count);
        }
    }
}
