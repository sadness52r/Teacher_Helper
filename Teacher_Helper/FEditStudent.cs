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
    public partial class FEditStudent : Form
    {
        FView fView;

        public FEditStudent(FView fView)
        {
            this.fView = fView;
            InitializeComponent();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (DataBaseController.tableController.CheckCorrectStudentID(tbID.Text))
            {
                DataBaseController.tableController.Edit(int.Parse(tbID.Text), tbName.Text, tbSurname.Text, tbPatronymic.Text);
                MessageBox.Show("Student with ID " + tbID.Text + " has succesfully edited!");
                fView.UpdateTable();
            }
        }
    }
}
