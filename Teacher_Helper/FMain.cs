using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Teacher_Helper
{
    public partial class FMain : Form
    {
        private string pathNames;

        public FMain()
        {
            InitializeComponent();
        }

        private void bCreateDB_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathNames = openFileDialog1.FileName;
                DataBaseController.CreateDB(pathNames);
                MessageBox.Show("Tables have created succesfully!");
                FView fCreateDB = new FView();
                fCreateDB.ShowDialog();
            }
        }
    }
}
