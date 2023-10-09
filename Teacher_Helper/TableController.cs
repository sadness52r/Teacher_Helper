using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Teacher_Helper
{
    public enum SHOWED_T
    {
        StudentsT, VariantsT, TeacherT
    }

    public class TableController
    {
        private string pathNames;
        private string pathDB;
        private string pathStudents;
        private string pathVariants;
        private string pathTeacherTable;
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
            pathTeacherTable = pathDB + "/marks.txt";

            CreateTableVariants();
            CreateTableStudents();
            CreateTeacherTable();
        }

        public void Add(string name, string surname, string patronymic)
        {
            int numberRepeated = CheckTheSame(name, surname, patronymic);
            Student student;
            Student.TotalNumber++;
            if (numberRepeated != 0)
                student = new Student(name, surname + numberRepeated.ToString(), patronymic, Student.TotalNumber, Variants[DataBaseController.rnd.Next(Variants.Count)]); 
            else
                student = new Student(name, surname, patronymic, Student.TotalNumber, Variants[DataBaseController.rnd.Next(Variants.Count)]);
            Students.Add(student);
            WriteToFile(student);
        }

        public void Add(string pathToFile)
        {
            int numberRepeated = CheckTheSame(pathToFile);
            Variant variant;
            Variant.TotalNumber++;
            if (numberRepeated == 0)
            {
                string path_to_file = "var" + (Variants.Count + 1);
                variant = new Variant(Variant.TotalNumber, path_to_file);
                Variants.Add(variant);
                WriteToFile(variant);
            }
        }

        private int CheckTheSame(string name, string surname, string patronymic)
        {
            int numRepeated = 0;
            foreach (var student in Students)
                if (student.Name == name && (student.Surname == surname || student.Surname == surname + numRepeated.ToString()) && student.Patronymic == patronymic)
                    numRepeated++;
            return numRepeated;
        }

        private int CheckTheSame(string pathToFile)
        {
            int numRepeated = 0;
            foreach (var variant in Variants)
                if (variant.Path_to_file == pathToFile)
                    numRepeated++;
            return numRepeated;
        }

        private void CreateHeader(FileStream file, StreamWriter sWriter)
        {
            if (file.Name.Contains("students.txt"))
                sWriter.WriteLine("id\t\tname\t\tsurname\t\tpatronymic");
            else if (file.Name.Contains("variants.txt"))
                sWriter.WriteLine("id\t\tpath_to_file");
            else if (file.Name.Contains("marks.txt"))
                sWriter.WriteLine("full_name\t\tpath_to_file\t\tmark");
        }

        private void CreateTableVariants()
        {
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
        }

        private void CreateTableStudents()
        {
            using (fStreamStudents = new FileStream(pathStudents, FileMode.OpenOrCreate))
            {
                using (StreamWriter sWriter = new StreamWriter(fStreamStudents))
                {
                    CreateHeader(fStreamStudents, sWriter);

                    using (fStreamNames = new FileStream(pathNames, FileMode.Open))
                        ReadNames(fStreamNames);

                    foreach (var student in Students)
                        sWriter.WriteLine(student.ID.ToString() + "\t\t" + student.Name + "\t\t" + student.Surname + "\t\t" + student.Patronymic);
                }
            }
        }

        private void CreateTeacherTable()
        {
            using (fStreamTeacherTable = new FileStream(pathTeacherTable, FileMode.OpenOrCreate))
            {
                using (StreamWriter sWriter = new StreamWriter(fStreamTeacherTable))
                {
                    CreateHeader(fStreamTeacherTable, sWriter);

                    foreach (var student in Students)
                        sWriter.WriteLine(student.Surname + "\t\t\t" + student.Variant.Path_to_file + '\n' + student.Name + '\n' + student.Patronymic + '\n');
                }
            }
        }

        private void WriteToFile(Student student)
        {
            using (StreamWriter sWriter = new StreamWriter(pathStudents, true))
                sWriter.WriteLine(student.ID.ToString() + "\t\t" + student.Name + "\t\t" + student.Surname + "\t\t" + student.Patronymic);
            using (StreamWriter sWriter = new StreamWriter(pathTeacherTable, true))
                sWriter.WriteLine(student.Surname + "\t\t\t" + student.Variant.Path_to_file + '\n' + student.Name + '\n' + student.Patronymic + '\n');
        }

        private void WriteToFile(Variant variant)
        {
            using (StreamWriter sWriter = new StreamWriter(pathVariants, true))
                sWriter.WriteLine(variant.ID.ToString() + "\t\t" + variant.Path_to_file);
        }

        private void ReadNames(FileStream fileNames)
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
