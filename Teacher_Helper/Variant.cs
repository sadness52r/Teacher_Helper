using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_Helper
{
    public class Variant
    {
        public const int INIT_NUMBER = 10;
        public static int TotalNumber;

        private int id;
        private string path_to_file;

        public int ID { get; set; }
        public string Path_to_file { get; set; }
        
        public Variant(int id, string path_to_file)
        {
            ID = id;
            Path_to_file = path_to_file;
        }
    }
}
