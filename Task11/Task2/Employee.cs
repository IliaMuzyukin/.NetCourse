using System;
using System.Text.RegularExpressions;

namespace Task1
{
    class Employee : User,IEquatable<Employee>
    {
        private int experience;
        private int salary;

        public Employee(string name, string surname, DateTime birthday,
                        string post, int experience, int salary) : base(name, surname, birthday)
        {
            Post = post;
            Experience = experience;
            Salary = salary;
        }

        public Employee(string name, string surname, string middlename, DateTime birthday,
                        string post, int experience, int salary) : base(name, surname, middlename, birthday)
        {
            Post = post;
            Experience = experience;
            Salary = salary;
        }

        public string Post { get; set; }

        public int Experience
        {
            get => experience;
            set
            {
                if ((value < 0) || (value > Age))
                {
                    throw new Exception("Неверное значение стажа");
                }
                experience = value;
            }
        }

        public int Salary
        {
            get => salary;
            set
            {
                if ((value <= 0))
                {
                    throw new Exception("Неверное значение зарплаты");
                }
                salary = value;
            }
        }

        public bool Equals(Employee other)
        {
            if (other == null)
            {
                return false;
            }
            if ((Experience == other.Experience) && (Salary == other.Salary) 
                && (Birthday == other.Birthday) && (Name == other.Name)
                && (Surname == other.Surname) && (Middlename == other.Middlename))
                return true;
            return false;
        }
    }
}
        