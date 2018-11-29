using System;
using System.Text.RegularExpressions;

namespace Task1
{
    class User
    {
        protected string name;
        protected string surname;
        protected string middlename;
        protected DateTime birthday;

        public User(string name, string surname, DateTime birthday)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
        }

        public User(string name, string surname, string middlename, DateTime birthday) : this(name, surname, birthday)
        {
            Middlename = middlename;
        }

        public string Name
        {
            get => name;
            set
            {
                const string patternName = @"^([А-Я][а-я]+[\-\s][А-Я][а-я]+)|([А-Я][а-я]+)$";
                if (!CheckFullName(patternName, value))
                {
                    throw new Exception("Некорректное значение имени");
                }

                name = value;
            }
        }

        public string Surname
        {
            get => surname;
            set
            {
                string patternSurname = "^([А-Я][а-я]+-[А-Я][а-я]+)|([А-Я][а-я]+)$";
                if (!CheckFullName(patternSurname, value))
                {
                    throw new ArgumentException("Некорректное значение фамилии");
                }
                else
                {
                    surname = value;
                }
            }
        }

        public string Middlename
        {
            get => middlename;
            set
            {
                string patternMiddleName = @"(^([А-Я][а-я]+-[А-Я][а-я]+)|([А-Я][а-я]+))|(^)$";
                if (!CheckFullName(patternMiddleName, value))
                {
                    throw new ArgumentException("Некорректное значение отчества");
                }
                else
                {
                    middlename = value;
                }
            }
        }

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException ("Дата позже текущей!");
                }


                birthday = value;
            }
        }

        public int Age
        {
            get
            {
                return GetAge();
            }
        }

        private int GetAge()
        {
            DateTime today = DateTime.Now;
            int fullAge = today.Year - birthday.Year - 1;

            if (today.Month < birthday.Month)
            {
                return fullAge;
            }

            if (today.Month > birthday.Month)
            {
                return fullAge + 1;
            }

            if (today.Day < birthday.Day)
            {
                return fullAge;
            }

            return fullAge + 1;
        }

        private bool CheckFullName(string pattern, string str)
        {
            return Regex.IsMatch(str, pattern);
        }
    }
}
