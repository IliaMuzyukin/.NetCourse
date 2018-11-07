using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] workers = new Person[4];
            workers[0] = new Person { Name = "Mary"};
            workers[1] = new Person { Name = "Kate"};
            workers[2] = new Person { Name = "Hugo"};
            workers[3] = new Person { Name = "John"};

            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine($"{workers[i].Name} come");
                workers[i].Time = DateTime.Now.Hour;
                workers[i].OnCame();
                for (int j = 0; j < workers.Length; j++)
                {
                    if (i != j)
                    {
                        workers[j].Came += workers[i].Greet;
                    }
                }
                Console.WriteLine("\n");
            }

            for (int i = 0; i < workers.Length; i++)
            {
                for (int j = 0; j < workers.Length; j++)
                {
                    if (i != j)
                    {
                        workers[i].Quit += workers[j].GoodBye;
                    }
                }
            }

            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine($"{workers[i].Name} leave");
                workers[i].OnQuit();
                for (int j = 0; j < workers.Length; j++)
                {
                    if (i != j)
                    {
                        workers[j].Quit -= workers[i].GoodBye;
                    }
                }
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
}
