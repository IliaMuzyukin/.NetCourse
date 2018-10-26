using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    //public class User
    //{
    //    private string name;
    //    private string secondName;
    //    private string patronymic;
    //    private string dateOfBirth;
    //    private int age;
    //    Regex regex = new Regex(@"\b[A-ZА-Я][a-zа-я][^0-9\s]\S+\b");

    //    public string Name
    //    {
    //        get { return name; }
    //        set
    //        {
    //            if (regex.IsMatch(value) && String.IsNullOrEmpty(value))
    //            {
    //                throw new ArgumentException("Name can't be empty or null");
    //            }
    //            name = value;
    //        }
    //    }
    //    public string SecondName
    //    {
    //        get
    //        {
    //            return secondName;
    //        }
    //        set
    //        {
    //            if (regex.IsMatch(value) && String.IsNullOrEmpty(value))
    //            {
    //                throw new ArgumentException("SecondName can't be empty or null");
    //            }
    //            secondName = value;
    //        }
    //    }
    //    public string Patronymic
    //    {
    //        get { return patronymic; }
    //        set { if (regex.IsMatch(value)) { patronymic = value; } }
    //    }
    //    public string  DateOfBirth
    //    {
    //        get { return dateOfBirth; }
    //        set { if (DateTime.TryParse(value,out DateTime dateTime) && (DateTime.Today.Year-Age)==dateTime.Year) { dateOfBirth = value; } }
    //    }
    //    public int Age
    //    {
    //        get { return age; }
    //        set { if (value>7 && value<100) { age = value; } }
    //    }

    //    }
    //}
    class User
    {
        private string name;
        private string surname;
        private DateTime birthDay;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can't be empty or null");
                }

                name = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Surname can't be empty or null");
                }

                surname = value;
            }
        }

        public string MiddleName
        {
            get; set;
        }

        public int Age
        {
            get
            {
                int age = 0;
                if (DateTime.Today.Month >= BirthDay.Month)
                {
                    return age=(DateTime.Today.Year - BirthDay.Year);
                }
                else if (DateTime.Today.Day < BirthDay.Day)
                {
                    return age=(DateTime.Today.Year - BirthDay.Year - 1);
                }
                return age;
            }
        }

        public DateTime BirthDay
        {
            get
            {
                return birthDay.Date;
            }
            set
            {
                if (value > DateTime.Today)
                {
                    throw new ArgumentException("Date of birth can't be in the future");
                }

                birthDay = value;
            }
        }
        public void GetInformation(User user)
        {
            Console.WriteLine(new string('-', 42));
            Console.WriteLine("|{0,-20}|{1,-19}|", "Name", user.Name);
            Console.WriteLine(new string('-', 42));
            Console.WriteLine("|{0,-20}|{1,-19}|", "Middle Name Name", user.MiddleName);
            Console.WriteLine(new string('-', 42));
            Console.WriteLine("|{0,-20}|{1,-19}|", "Surname Name Name", user.Surname);
            Console.WriteLine(new string('-', 42));
            Console.WriteLine("|{0,-20}|{1,-19}|", "Age", user.Age);
            Console.WriteLine(new string('-', 42));
            Console.WriteLine("|{0,-20}|{1,-19}|", "Date of birth", user.BirthDay);
            Console.WriteLine(new string('-', 42));
            

        }

        class Program
        {
            static void Main(string[] args)
            {
                User user = new User();
                user.Name = "Ilia";
                user.MiddleName = "Alekseevich";
                user.Surname = "Muzyukin";
                user.BirthDay = DateTime.Parse("06.10.1997");
              //  Console.WriteLine($"{user.Name}, {user.Surname}, {user.MiddleName}, {user.Age}, {user.BirthDay}");
              //  Console.ReadKey();
                user.GetInformation(user);
                Console.ReadLine();
            }
        }
    }
}
