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

        public static void Load()
        {
            //DirectoryInfo dbFolder = new DirectoryInfo(tableController.pathDB + "/Versions");
            //if (!dbFolder.Exists)
            //    dbFolder.Create();
            //int currNumDB = DataBaseController.CountDB(tableController.pathDB + "/Versions");
            //DirectoryInfo newSave = dbFolder.CreateSubdirectory("Version" + currNumDB);

            //File.Copy(tableController.pathStudents, tableController.pathDB + "/Versions/Version" + currNumDB + "/students.txt", true);
            //File.Copy(tableController.pathVariants, tableController.pathDB + "/Versions/Version" + currNumDB + "/variants.txt", true);
            //File.Copy(tableController.pathTeacherTable, tableController.pathDB + "/Versions/Version" + currNumDB + "/marks.txt", true);
        }

        public static List<DirectoryInfo> CreateList()
        {
            List<DirectoryInfo> data_bases = new List<DirectoryInfo>();
            DirectoryInfo dbFolder = new DirectoryInfo("../../DataBases");
            if (dbFolder.Exists)
            {
                int numberDB = DataBaseController.CountDB("../../DataBases");
                for (int i = 0; i < numberDB - 1; i++)
                {
                    DirectoryInfo dataBase = new DirectoryInfo("../../DataBases/DataBase" + (i + 1));
                    data_bases.Add(dataBase);
                }
            }
            return data_bases;
        }

        private static int CountDB(string pathDir)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(pathDir);
            return dirInfo.GetDirectories().Length + 1;
        }
    }
}
