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
    public partial class FAddMark : Form
    {
        private FView fView;

        public FAddMark(FView fView)
        {
            this.fView = fView;
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (DataBaseController.tableController.CheckCorrectStudentID(tbStudentID.Text) && DataBaseController.tableController.CheckCorrectMark(tbMark.Text))
            {
                DataBaseController.tableController.Add(tbMark.Text, tbStudentID.Text);
                MessageBox.Show("Student with ID " + tbStudentID.Text + " has got a mark " + tbMark.Text);
                fView.UpdateTable();
            }
        }
    }
}
