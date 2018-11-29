using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Mriamuz\Desktop\Epam\Repository\Task12\Task1\disposable_task_file2.txt";
            //string writePath = @"C:\Users\Mriamuz\Desktop\Epam\Repository\Task12\Task1\disposable_task_file1.txt";
            List<int> numbers = new List<int>();
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                string line;
                int parsedLine = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    if (Int32.TryParse(line, out parsedLine))
                    {
                        numbers.Add(parsedLine);
                    }
                    else
                    {
                        throw new ArgumentException("Bad parse/");
                    }
                    
                    Console.WriteLine(line);
                }
            }

            using (StreamWriter sw = new StreamWriter(path, false, Encoding.Default))
            {
                for (var i = 0; i < numbers.Count; i++)
                {
                    sw.WriteLine(Math.Pow(numbers[i], 2).ToString());
                }
            }


            Console.ReadKey();
        }
    }
}
