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
    public partial class FAddStudent : Form
    {
        private SHOWED_T showedT;
        private FView fView;

        public FAddStudent(SHOWED_T showedT, FView fView)
        {
            this.showedT = showedT;
            this.fView = fView;
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            switch (showedT)
            {
                case SHOWED_T.StudentsT:
                    DataBaseController.tableController.Add(tbName.Text, tbSurname.Text, tbPatronymic.Text);
                    MessageBox.Show("Student " + tbName.Text + ' ' + tbSurname.Text + ' ' + tbPatronymic.Text + " has succesfully added!");
                    fView.UpdateTable();
                    break;
                case SHOWED_T.VariantsT:
                    break;
                case SHOWED_T.TeacherT:
                    break;
                default:
                    break;
            }
        }
    }
}
