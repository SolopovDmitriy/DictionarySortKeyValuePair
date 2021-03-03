using System;

namespace Library
{
    internal class Author
    {
        private string _name;
        private string _surname;
        private string _patronimyc;
        private DateTime _birthDate;

        public string Name
        {
            get; set;
        }
        public string Surname
        {
            get; set;
        }
        public string Patronimyc
        {
            get; set;
        }
        public DateTime BirthDate
        {
            get;
            set;
        }
        public Author(string name, string surname, string patronimyc, DateTime birthDate)
        {
            Name = name;
            Surname = surname;
            Patronimyc = patronimyc;
            BirthDate = birthDate;
        }
        public override string ToString()
        {
            return $"Surname: {Surname}; Name: {Name}; Patronimyc: {Patronimyc}; BirthDate: {BirthDate}; ";
        }

    }
}