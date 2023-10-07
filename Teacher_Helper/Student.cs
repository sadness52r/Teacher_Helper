using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_Helper
{
    class Student
    {
        public static int TotalNumber;

        private int id;
        private string name;
        private string surname;
        private string patronymic;
        private Variant variant;

        public int ID { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public Variant Variant { get; set; }

        public Student(string name, string surname, string patronymic, int id, Variant variant)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            ID = id;
            Variant = variant;
        }
    }
}
