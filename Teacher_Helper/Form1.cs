using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teacher_Helper
{
    public partial class FMain : Form
    {
        OpenFileDialog fileDialog;

        public FMain()
        {
            InitializeComponent();
        }

        private void bCreateDB_Click(object sender, EventArgs e)
        {
            fileDialog = new OpenFileDialog();
            fileDialog.Title = "File";
            fileDialog.Filter = "text files(*.txt)|*.txt*";
            fileDialog.InitialDirectory = "../..Names";
            fileDialog.ShowDialog();
        }

        private void fileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
