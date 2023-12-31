﻿using System;
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
    public partial class FView : Form
    {
        private DataTable dTable;
        private SHOWED_T ShowedT;

        public FView()
        {
            InitializeComponent();
        }

        public void UpdateTable()
        {
            switch (ShowedT)
            {
                case SHOWED_T.StudentsT:
                    ShowStudentsTable();
                    break;
                case SHOWED_T.VariantsT:
                    ShowVariantsTable();
                    break;
                case SHOWED_T.TeacherT:
                    ShowTeacherTable();
                    break;
                default:
                    break;
            }
        }

        private void FCreateDB_Load(object sender, EventArgs e)
        {
            ShowStudentsTable();
        }

        private void ShowStudentsTable()
        {
            dTable = new DataTable();
            dTable.Columns.Add("id", typeof(int));
            dTable.Columns.Add("name", typeof(string));
            dTable.Columns.Add("surname", typeof(string));
            dTable.Columns.Add("patronymic", typeof(string));

            foreach (var student in DataBaseController.tableController.Students)
                dTable.Rows.Add(student.ID, student.Name, student.Surname, student.Patronymic);

            dataGridView1.DataSource = dTable;
            ShowedT = SHOWED_T.StudentsT;
        }

        private void ShowVariantsTable()
        {
            dTable = new DataTable();
            dTable.Columns.Add("id", typeof(int));
            dTable.Columns.Add("path_to_file", typeof(string));

            foreach (var variant in DataBaseController.tableController.Variants)
                dTable.Rows.Add(variant.ID, variant.Path_to_file);

            dataGridView1.DataSource = dTable;
            ShowedT = SHOWED_T.VariantsT;
        }

        private void ShowTeacherTable()
        {
            dTable = new DataTable();
            dTable.Columns.Add("full_name", typeof(string));
            dTable.Columns.Add("path_to_file", typeof(string));
            dTable.Columns.Add("mark", typeof(string));

            foreach (var student in DataBaseController.tableController.Students)
                dTable.Rows.Add(student.Surname + ' ' + student.Name + ' ' + student.Patronymic, student.Variant.Path_to_file, (student.Mark != int.MaxValue ? student.Mark.ToString() : ""));
            dataGridView1.DataSource = dTable;
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
            FAddStudent fAddStudents;
            FAddVariant fAddVariant;
            FAddMark fAddMark;

            switch (ShowedT)
            {
                case SHOWED_T.StudentsT:
                    fAddStudents = new FAddStudent(this);
                    fAddStudents.ShowDialog();
                    break;
                case SHOWED_T.VariantsT:
                    fAddVariant = new FAddVariant(this);
                    fAddVariant.ShowDialog();
                    break;
                case SHOWED_T.TeacherT:
                    fAddMark = new FAddMark(this);
                    fAddMark.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            FRemoveStudent fRemoveStudent;

            switch (ShowedT)
            {
                case SHOWED_T.StudentsT:
                    fRemoveStudent = new FRemoveStudent(this);
                    fRemoveStudent.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            FEditStudent fEditStudent;
            FEditVariant fEditVariant;

            switch (ShowedT)
            {
                case SHOWED_T.StudentsT:
                    fEditStudent = new FEditStudent(this);
                    fEditStudent.ShowDialog();
                    break;
                case SHOWED_T.VariantsT:
                    fEditVariant = new FEditVariant(this);
                    fEditVariant.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            DataBaseController.Save();
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            FLoad fLoad = new FLoad();
            fLoad.ShowDialog();
        }
    }
}
