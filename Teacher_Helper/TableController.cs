using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Teacher_Helper
{
    class TableController
    {
        private string pathNames;
        private string pathDB;
        private string pathStudents;
        private string pathVariants;
        private FileStream fStreamNames, fStreamStudents, fStreamVars, fStreamTeacherTable;
        
        public int NumberStudents { get; set; }
        public int NumberVariants { get; set; }

        public List<Student> Students; 
        public List<Variant> Variants; 

        public TableController(string pathNames, string pathDB)
        {
            this.pathDB = pathDB;
            this.pathNames = pathNames;
            Students = new List<Student>();
            Variants = new List<Variant>();
            NumberStudents = 0;
            NumberVariants = 0;
        }

        public void CreateTables()
        {
            pathStudents = pathDB + "/students.txt";
            pathVariants = pathDB + "/variants.txt";
            using (fStreamVars = new FileStream(pathVariants, FileMode.OpenOrCreate))
            {
                using (StreamWriter sWriter = new StreamWriter(fStreamVars))
                {
                    CreateHeader(fStreamVars, sWriter);

                    for (int i = 0; i < Variant.INIT_NUMBER; i++)
                    {
                        Variant.TotalNumber++;
                        string path_to_file = "var" + (Variants.Count + 1);
                        Variant variant = new Variant(Variant.TotalNumber, path_to_file);
                        sWriter.WriteLine(Variant.TotalNumber.ToString() + "\t\t" + path_to_file);
                        Variants.Add(variant);
                    }
                }
            }
            using (fStreamStudents = new FileStream(pathStudents, FileMode.OpenOrCreate))
            {
                using (StreamWriter sWriter = new StreamWriter(fStreamStudents))
                {
                    CreateHeader(fStreamStudents, sWriter);

                    using (fStreamNames = new FileStream(pathNames, FileMode.Open))
                        ReadNames(fStreamNames, pathStudents);

                    foreach (var student in Students)
                    {
                        sWriter.WriteLine(student.ID.ToString() + "\t\t" + student.Name + "\t\t" + student.Surname + "\t\t" + student.Patronymic);
                    }
                }
            }
        }

        private void CreateHeader(FileStream file, StreamWriter sWriter)
        {
            if (file.Name.Contains("students.txt"))
            {
                sWriter.WriteLine("id\t\tname\t\tsurname\t\tpatronymic");
            }
            else if (file.Name.Contains("variants.txt"))
            {
                sWriter.WriteLine("id\t\tpath_to_file");
            }
        }

        void ReadNames(FileStream fileNames, string destPath)
        {
            using (StreamReader sReader = new StreamReader(fileNames))
            {
                string line = sReader.ReadLine();
                while (line != null)
                {
                    string[] init_student = line.Split();

                    Student.TotalNumber++;
                    Student student = new Student(init_student[0], init_student[1], init_student[2], Student.TotalNumber, Variants[DataBaseController.rnd.Next(Variants.Count)]);
                    Students.Add(student);

                    line = sReader.ReadLine();
                }
            }
        }
    }
}
