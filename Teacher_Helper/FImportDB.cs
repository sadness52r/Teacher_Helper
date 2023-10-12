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
    public partial class FImportDB : Form
    {
        public FImportDB()
        {
            InitializeComponent();
        }

        private void FImportDB_Load(object sender, EventArgs e)
        {
            List<DirectoryInfo> dInfo = DataBaseController.CreateList();
            foreach (var dataBase in dInfo)
                listView1.Items.Add(dataBase.Name);
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            DataBaseController.OpenDB("../../DataBases/" + listView1.SelectedItems[0].Text);
            MessageBox.Show("Tables have imported succesfully!");
        }

        private void FImportDB_FormClosed(object sender, FormClosedEventArgs e)
        {
            FView fCreateDB = new FView();
            fCreateDB.Show();
        }
    }
}
