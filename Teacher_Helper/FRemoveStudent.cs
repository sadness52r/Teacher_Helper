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
    public partial class FRemoveStudent : Form
    {
        FView fView;

        public FRemoveStudent(FView fView)
        {
            this.fView = fView;
            InitializeComponent();
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            if (DataBaseController.tableController.CheckCorrectStudentID(tbStudentID.Text))
            {
                DataBaseController.tableController.RemoveStudent(int.Parse(tbStudentID.Text));
                MessageBox.Show("Student with ID " + tbStudentID.Text + " has succesfully removed!");
                fView.UpdateTable();
            }
        }
    }
}
