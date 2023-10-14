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
        private FileStream fStreamNames, fStreamStudents, fStreamVars, fStreamTeacherTable;

        public string pathDB;
        public string pathStudents;
        public string pathVariants;
        public string pathTeacherTable;
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

        public TableController(string pathDB)
        {
            this.pathDB = pathDB;
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

        public void ImportTables()
        {
            pathStudents = pathDB + "/students.txt";
            pathVariants = pathDB + "/variants.txt";
            pathTeacherTable = pathDB + "/marks.txt";

            ReadTableStudents();
            ReadTableVariants();
            ReadTeacherTable();
        }

        public void Add(string name, string surname, string patronymic)
        {
            int numberRepeated = CheckTheSame(name, surname, patronymic);
            Student student;
            Student.TotalNumber++;
            if (numberRepeated != 0)
            {
                DataBaseController.rnd = new Random();
                student = new Student(name, surname + numberRepeated.ToString(), patronymic, Student.TotalNumber, Variants[DataBaseController.rnd.Next(Variants.Count)]);
            } 
            else
            {
                DataBaseController.rnd = new Random();
                student = new Student(name, surname, patronymic, Student.TotalNumber, Variants[DataBaseController.rnd.Next(Variants.Count)]);
            }
                
            Students.Add(student);
            WriteToFile(student);
        }

        public void Add(Variant variant)
        {
            Variants.Add(variant);
            WriteToFile(variant); 
        }

        public void Add(string mark, string studentID)
        {
            int ind = BinSearchStudents(Students, int.Parse(studentID));
            Students[ind].Mark = int.Parse(mark);
            WriteToFile(ind, mark);
        }

        public void RemoveStudent(int id)
        {
            int ind = BinSearchStudents(Students, id);
            Students.RemoveAt(ind);
            UpdateDataStudents();
        }

        public void Edit(int id, string path_to_file)
        {
            int ind = BinSearchVariants(Variants, id);
            Variants[ind].Path_to_file = path_to_file;
            UpdateDataVariants();
        }

        public void Edit(int id, string name, string surname, string patronymic)
        {
            int numberRepeated = CheckTheSame(name, surname, patronymic);
            int ind = BinSearchStudents(Students, id);
            if (numberRepeated != 0)
            {
                Students[ind].Name = name;
                Students[ind].Surname = surname + numberRepeated.ToString();
                Students[ind].Patronymic = patronymic;
            }
            else
            {
                Students[ind].Name = name;
                Students[ind].Surname = surname;
                Students[ind].Patronymic = patronymic;
            }
            UpdateDataStudents();
        }

        public bool CheckTheSame(string pathToFile)
        {
            foreach (var variant in Variants)
                if (variant.Path_to_file == pathToFile)
                    return true;
            return false;
        }

        public bool CheckCorrectStudentID(string studentID)
        {
            int result;
            if (int.TryParse(studentID, out result))
                if (result > 0)
                    if (BinSearchStudents(Students, result) != -1)
                        return true;
                    
            return false;
        }

        public bool CheckCorrectVariantID(string variantID)
        {
            int result;
            if (int.TryParse(variantID, out result))
                if (result > 0)
                    if (BinSearchVariants(Variants, result) != -1)
                        return true;

            return false;
        }

        public bool CheckCorrectMark(string mark)
        {
            int result;
            if (int.TryParse(mark, out result))
                return true;
            return false;
        }

        public void UpdateData()
        {
            Students.Clear();
            Variants.Clear();
            ReadTableStudents();
            ReadTableVariants();
            ReadTeacherTable();
        }

        private int CheckTheSame(string name, string surname, string patronymic)
        {
            int numRepeated = 0;
            foreach (var student in Students)
                if (student.Name == name && (student.Surname == surname || student.Surname == surname + numRepeated.ToString()) && student.Patronymic == patronymic)
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
            Variant.TotalNumber = 0;
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
            Student.TotalNumber = 0;
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

        private void ReadTableStudents()
        {
            int maxID = -1;
            using (fStreamStudents = new FileStream(pathStudents, FileMode.OpenOrCreate))
            {
                using (StreamReader sReader = new StreamReader(fStreamStudents))
                {
                    string line = sReader.ReadLine(); line = sReader.ReadLine();
                    while (line != null)
                    {
                        string[] init_student = line.Split(new char[] {'\t'}, StringSplitOptions.RemoveEmptyEntries);

                        Student student = new Student(init_student[1], init_student[2], init_student[3], int.Parse(init_student[0]), null);

                        maxID = Math.Max(int.Parse(init_student[0]), maxID);

                        Students.Add(student);

                        line = sReader.ReadLine();
                    }

                    if (maxID == -1)
                        maxID = 0;

                    Student.TotalNumber = maxID;
                }
            }
        }

        private void ReadTableVariants()
        {
            int maxID = -1;
            using (fStreamVars = new FileStream(pathVariants, FileMode.OpenOrCreate))
            {
                using (StreamReader sReader = new StreamReader(fStreamVars))
                {
                    string line = sReader.ReadLine(); line = sReader.ReadLine();
                    while (line != null)
                    {
                        string[] init_var = line.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);

                        Variant variant = new Variant(int.Parse(init_var[0]), init_var[1]);

                        maxID = Math.Max(int.Parse(init_var[0]), maxID);

                        Variants.Add(variant);

                        line = sReader.ReadLine();
                    }

                    if (maxID == -1)
                        maxID = 0;

                    Variant.TotalNumber = maxID;
                }
            }
        }

        private void ReadTeacherTable()
        {
            string name = "", surname = "", patronymic = "", pathToFile = "";
            int mark = int.MinValue, enters = 1;
            using (fStreamTeacherTable = new FileStream(pathTeacherTable, FileMode.OpenOrCreate))
            {
                using (StreamReader sReader = new StreamReader(fStreamTeacherTable))
                {
                    string line = sReader.ReadLine(); line = sReader.ReadLine();
                    while (line != null)
                    {
                        string[] init_data = line.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        if (init_data.Length == 2)
                        {
                            surname = init_data[0];
                            pathToFile = init_data[1];
                        }
                        else if (init_data.Length == 3)
                        {
                            surname = init_data[0];
                            pathToFile = init_data[1];
                            mark = int.Parse(init_data[2]);
                        }
                        else if (init_data.Length == 1 && enters == 1)
                        {
                            name = init_data[0];
                            enters = 2;
                        }
                        else if (init_data.Length == 1 && enters == 2)
                        {
                            patronymic = init_data[0];
                            enters = 1;
                        }
                        else
                        {
                            int indS = SearchInd(Students, name, surname, patronymic);
                            if (mark != int.MinValue && indS != -1)
                                Students[indS].Mark = mark;
                            int indV = SearchInd(Variants, pathToFile);
                            if (indV != -1)
                                Students[indS].Variant = Variants[indV];

                            name = surname = patronymic = pathToFile = "";
                            mark = int.MinValue;
                        }
                        line = sReader.ReadLine();
                    }
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

        private void WriteToFile(int studentID, string mark)
        {
            File.WriteAllText(pathTeacherTable, string.Empty);

            using (fStreamTeacherTable = new FileStream(pathTeacherTable, FileMode.OpenOrCreate))
            {
                using (StreamWriter sWriter = new StreamWriter(fStreamTeacherTable))
                {
                    CreateHeader(fStreamTeacherTable, sWriter);

                    foreach (var student in Students)
                        sWriter.WriteLine(student.Surname + "\t\t\t" + student.Variant.Path_to_file + "\t\t\t" + (student.Mark != int.MaxValue ? student.Mark.ToString() : "") + '\n' + student.Name + '\n' + student.Patronymic + '\n');
                }
            }
        }

        private void UpdateDataStudents()
        {
            File.WriteAllText(pathStudents, string.Empty);
            File.WriteAllText(pathTeacherTable, string.Empty);

            using (fStreamStudents = new FileStream(pathStudents, FileMode.OpenOrCreate))
            {
                using (StreamWriter sWriter = new StreamWriter(fStreamStudents))
                {
                    CreateHeader(fStreamStudents, sWriter);
                    foreach (var student in Students)
                        sWriter.WriteLine(student.ID.ToString() + "\t\t" + student.Name + "\t\t" + student.Surname + "\t\t" + student.Patronymic);
                }
            }

            using (fStreamTeacherTable = new FileStream(pathTeacherTable, FileMode.OpenOrCreate))
            {
                using (StreamWriter sWriter = new StreamWriter(fStreamTeacherTable))
                {
                    CreateHeader(fStreamTeacherTable, sWriter);
                    foreach (var student in Students)
                        sWriter.WriteLine(student.Surname + "\t\t\t" + student.Variant.Path_to_file + "\t\t\t" + (student.Mark != int.MaxValue ? student.Mark.ToString() : "") + '\n' + student.Name + '\n' + student.Patronymic + '\n');
                }
            }
        }

        private void UpdateDataVariants()
        {
            File.WriteAllText(pathVariants, string.Empty);
            File.WriteAllText(pathTeacherTable, string.Empty);

            using (fStreamVars = new FileStream(pathVariants, FileMode.OpenOrCreate))
            {
                using (StreamWriter sWriter = new StreamWriter(fStreamVars))
                {
                    CreateHeader(fStreamVars, sWriter);
                    foreach (var variant in Variants)
                        sWriter.WriteLine(variant.ID + "\t\t" + variant.Path_to_file);
                }
            }

            using (fStreamTeacherTable = new FileStream(pathTeacherTable, FileMode.OpenOrCreate))
            {
                using (StreamWriter sWriter = new StreamWriter(fStreamTeacherTable))
                {
                    CreateHeader(fStreamTeacherTable, sWriter);
                    foreach (var student in Students)
                        sWriter.WriteLine(student.Surname + "\t\t\t" + student.Variant.Path_to_file + "\t\t\t" + (student.Mark != int.MaxValue ? student.Mark.ToString() : "") + '\n' + student.Name + '\n' + student.Patronymic + '\n');
                }
            }
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

        private int BinSearchStudents(List<Student> arr, int target)
        {
            int l = 0, r = arr.Count - 1;
            while (l <= r)
            {
                int mid = (l + r) / 2;
                if(arr[mid].ID < target)
                    l = mid + 1;
                else if (arr[mid].ID > target)
                    r = mid - 1;
                else
                    return mid;
            }
            return -1;
        }

        private int BinSearchVariants(List<Variant> arr, int target)
        {
            int l = 0, r = arr.Count - 1;
            while (l <= r)
            {
                int mid = (l + r) / 2;
                if (arr[mid].ID < target)
                    l = mid + 1;
                else if (arr[mid].ID > target)
                    r = mid - 1;
                else
                    return mid;
            }
            return -1;
        }

        private int SearchInd(List<Student> arr, string name, string surname, string patronymic)
        {
            for (int i = 0; i < arr.Count; i++)
                if (arr[i].Name == name && arr[i].Surname == surname && arr[i].Patronymic == patronymic)
                    return i;
            return -1;
        }

        private int SearchInd(List<Variant> arr, string pathToFile)
        {
            for (int i = 0; i < arr.Count; i++)
                if (arr[i].Path_to_file == pathToFile)
                    return i;
            return -1;
        }
    }
}
