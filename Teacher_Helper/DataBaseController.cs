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

        private static int CountDB(string pathDir)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(pathDir);
            return dirInfo.GetDirectories().Length + 1;
        }
    }
}
