using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teacher_Helper
{
    public partial class FLoad : Form
    {
        public FLoad()
        {
            InitializeComponent();
        }

        private void FLoad_Load(object sender, EventArgs e)
        {
            List<DirectoryInfo> dInfo = DataBaseController.CreateList(DataBaseController.tableController.pathDB + "/Versions", DataBaseController.tableController.pathDB + "/Versions/Version");
            foreach (var version in dInfo)
                listView1.Items.Add(version.Name);
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            DataBaseController.Load(DataBaseController.tableController.pathDB + "/Versions/" + listView1.SelectedItems[0].Text);
            MessageBox.Show("Data has loaded succesfully!");
            DataBaseController.tableController.UpdateData();
        }
    }
}
