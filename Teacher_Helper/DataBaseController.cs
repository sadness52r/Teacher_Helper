using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Teacher_Helper
{
    public static class DataBaseController
    {
        public static TableController tableController;
        public static Random rnd;

        public static void CreateDB(string pathNames)
        {
            rnd = new Random();
            DirectoryInfo dbFolder = new DirectoryInfo("../../DataBases");
            if (!dbFolder.Exists)
                dbFolder.Create();
            int currDB = DataBaseController.CountDB("../../DataBases");
            dbFolder.CreateSubdirectory("DataBase" + currDB);
            tableController = new TableController(pathNames, "../../DataBases/DataBase" + currDB);
            tableController.CreateTables();
        }

        public static void OpenDB(string pathDB)
        {
            tableController = new TableController(pathDB);
            tableController.ImportTables();
        }

        public static void Save()
        {
            DirectoryInfo dbFolder = new DirectoryInfo(tableController.pathDB + "/Versions");
            if (!dbFolder.Exists)
                dbFolder.Create();
            int currNumDB = DataBaseController.CountDB(tableController.pathDB + "/Versions");
            DirectoryInfo newSave = dbFolder.CreateSubdirectory("Version" + currNumDB);

            File.Copy(tableController.pathStudents, tableController.pathDB + "/Versions/Version" + currNumDB + "/students.txt", true);
            File.Copy(tableController.pathVariants, tableController.pathDB + "/Versions/Version" + currNumDB + "/variants.txt", true);
            File.Copy(tableController.pathTeacherTable, tableController.pathDB + "/Versions/Version" + currNumDB + "/marks.txt", true);
        }

        public static void Load(string versionName)
        {
            DirectoryInfo folder = new DirectoryInfo(versionName);
            if (folder.Exists)
            {
                File.Copy(versionName + "/students.txt", tableController.pathStudents, true);
                File.Copy(versionName + "/variants.txt", tableController.pathVariants, true);
                File.Copy(versionName + "/marks.txt", tableController.pathTeacherTable, true);
            }
        }

        public static List<DirectoryInfo> CreateList(string path, string inner_path)
        {
            List<DirectoryInfo> list = new List<DirectoryInfo>();
            DirectoryInfo folder = new DirectoryInfo(path);
            if (folder.Exists)
            {
                int number = DataBaseController.CountDB(path);
                for (int i = 0; i < number - 1; i++)
                {
                    DirectoryInfo dataBase = new DirectoryInfo(inner_path + (i + 1));
                    list.Add(dataBase);
                }
            }
            return list;
        }

        private static int CountDB(string pathDir)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(pathDir);
            return dirInfo.GetDirectories().Length + 1;
        }
    }
}
