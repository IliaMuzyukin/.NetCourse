using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public delegate void MessageBye(string name);
    public delegate void MessageGreet(string name, int time);

    class Person
    {
        public string Name { get; set; }
        public int Time { get; set; }

        public void Greet(string anotherPerson, int time)
        {
            if (time < 12)
            {
                Console.WriteLine("'Good morning, {0}!', {1} said.", anotherPerson, Name);
            }
            else if (time > 17)
            {
                Console.WriteLine("'Good evening, {0}!', {1} said.", anotherPerson, Name);
            }
            else
            {
                Console.WriteLine("'Good afternoon, {0}!', {1} said.", anotherPerson, Name);
            }
        }

        public event MessageGreet Came;

        public void OnCame()
        {
            if (Came != null)
            {
                Came(Name, Time);
            }
        }

        public void GoodBye (string anotherPerson)
        {
            Console.WriteLine($"Goodbye, {anotherPerson}!, - {Name} said.");
        }

        public event MessageBye Quit;

        public void OnQuit()
        {
            if (Quit != null)
            {
                Quit(Name);
            }
        }
    }
}
