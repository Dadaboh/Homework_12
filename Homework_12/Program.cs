namespace Homework_12
{
    internal class Program
    {
        public static Semaphore sema = new Semaphore(2, 2);
        static void Main(string[] args)
        {

            for(var i = 0; i < 5; i++)
            {
                var thread = new Thread(async () => await ReadFile(i));
                thread.Start();              
            }

            Console.ReadLine();

        }

        public static async Task ReadFile(int i)
        {
            sema.WaitOne();
            
            using (var sr = new StreamReader("TestFile.txt"))
            {
                var timeStart = DateTime.Now;
                var data = sr.ReadToEnd();
                var timeEnd = DateTime.Now;
                Console.WriteLine($"Stream: {i} | Start: {timeStart} | End: {timeEnd}");
            }

            sema.Release();
        }


    }


}