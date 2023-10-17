namespace Homework_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(var i = 0; i < 5; i++)
            {
                //var tmp = new MyClass().ReadFile();
                MyClass.ReadFile();
            }


            Console.ReadLine();
        }


    }

    public class MyClass
    {
        public static void ReadFile()
        {
            for(var i = 0; i < 5; i++)
            {
                Task.Run(async () =>
                {
                    using (var sr = new StreamReader("TestFile.txt"))
                    {
                        var timeStart = DateTime.Now;
                        var data = sr.ReadToEnd();
                        var timeEnd = DateTime.Now;
                        Console.WriteLine($"Stream: {i} | Start: {timeStart} | End: {timeEnd}");
                    }
                });
            }

        }
    }

}