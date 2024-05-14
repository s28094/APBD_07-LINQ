using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = LinqTasks.Task1();

            foreach (var e in t)
            {
                Console.Write(e + " ");
            }
        }
    }
}
