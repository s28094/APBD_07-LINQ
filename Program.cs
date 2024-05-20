using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            /*{
                var t = LinqTasks.Task1();

                foreach (var e in t)
                {
                    Console.WriteLine(e + " ");
                }
            }*/

            /*{
                var t = LinqTasks.Task2();

                foreach (var e in t)
                {
                    Console.WriteLine(e + " ");
                }
            }*/
            
            /*{
                int t = LinqTasks.Task3();

                Console.Write(t);
            }*/
            
            /*{
                var t = LinqTasks.Task4();

                foreach (var e in t)
                {
                    Console.WriteLine(e + " ");
                }
            }*/
            
            /*{
                var t = LinqTasks.Task5();

                foreach (var e in t)
                {
                    Console.WriteLine(e + " ");
                }
            }*/
            Console.WriteLine("\nTask 6:");
            var task6 = LinqTasks.Task6();
            foreach (var item in task6)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nTask 7:");
            var task7 = LinqTasks.Task7();
            foreach (var item in task7)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nTask 8:");
            var task8 = LinqTasks.Task8();
            Console.WriteLine(task8);

            Console.WriteLine("\nTask 9:");
            var task9 = LinqTasks.Task9();
            Console.WriteLine($"{task9?.Ename} - {task9?.Job} - {task9?.HireDate}");

            Console.WriteLine("\nTask 10:");
            var task10 = LinqTasks.Task10();
            foreach (var item in task10)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nTask 11:");
            var task11 = LinqTasks.Task11();
            foreach (var item in task11)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nTask 12:");
            var task12 = LinqTasks.Task12();
            foreach (var emp in task12)
            {
                Console.WriteLine($"{emp.Ename} - {emp.Job} - {emp.Salary}");
            }

            Console.WriteLine("\nTask 13:");
            var task13 = LinqTasks.Task13(new int[] { 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 });
            Console.WriteLine(task13);

            Console.WriteLine("\nTask 14:");
            var task14 = LinqTasks.Task14();
            foreach (var dept in task14)
            {
                Console.WriteLine($"{dept.Dname}");
            }

            Console.WriteLine("\nTask 15:");
            var task15 = LinqTasks.Task15();
            foreach (var item in task15)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nTask 16:");
            var task16 = LinqTasks.Task16();
            foreach (var item in task16)
            {
                Console.WriteLine(item);
            }
        }
    }
}
