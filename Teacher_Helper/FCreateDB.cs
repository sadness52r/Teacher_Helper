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
    public partial class FCreateDB : Form
    {
        private DataTable dtStudents;
        private DataTable dtVariants;
        private DataTable dtTeacher;
        private SHOWED_T ShowedT;

        public FCreateDB()
        {
            InitializeComponent();
        }

        private void FCreateDB_Load(object sender, EventArgs e)
        {
            ShowStudentsTable();
        }

        private void ShowStudentsTable()
        {
            dtStudents = new DataTable();
            dtStudents.Columns.Add("id", typeof(int));
            dtStudents.Columns.Add("name", typeof(string));
            dtStudents.Columns.Add("surname", typeof(string));
            dtStudents.Columns.Add("patronymic", typeof(string));

            foreach (var student in DataBaseController.tableController.Students)
                dtStudents.Rows.Add(student.ID, student.Name, student.Surname, student.Patronymic);

            dataGridView1.DataSource = dtStudents;
            ShowedT = SHOWED_T.StudentsT;
        }

        private void ShowVariantsTable()
        {
            dtVariants = new DataTable();
            dtVariants.Columns.Add("id", typeof(int));
            dtVariants.Columns.Add("path_to_file", typeof(string));

            foreach (var variant in DataBaseController.tableController.Variants)
                dtVariants.Rows.Add(variant.ID, variant.Path_to_file);

            dataGridView1.DataSource = dtVariants;
            ShowedT = SHOWED_T.VariantsT;
        }

        private void ShowTeacherTable()
        {
            dtTeacher = new DataTable();
            dtTeacher.Columns.Add("full_name", typeof(string));
            dtTeacher.Columns.Add("path_to_file", typeof(string));
            dtTeacher.Columns.Add("mark", typeof(int));

            foreach (var student in DataBaseController.tableController.Students)
                dtTeacher.Rows.Add(student.Surname + ' ' + student.Name + ' ' + student.Patronymic, student.Variant.Path_to_file);
            dataGridView1.DataSource = dtTeacher;
            ShowedT = SHOWED_T.TeacherT;
        }

        private void bStudents_Click(object sender, EventArgs e)
        {
            ShowStudentsTable();
        }

        private void bVariants_Click(object sender, EventArgs e)
        {
            ShowVariantsTable();
        }

        private void bTeacherT_Click(object sender, EventArgs e)
        {
            ShowTeacherTable();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (ShowedT == SHOWED_T.StudentsT)
            {

            }
            else if (ShowedT == SHOWED_T.VariantsT)
            {

            }
            else if (ShowedT == SHOWED_T.TeacherT)
            {

            }
        }
    }
}
