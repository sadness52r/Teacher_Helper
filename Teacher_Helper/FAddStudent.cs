﻿using System;
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
        private FView fView;

        public FAddStudent(FView fView)
        {
            this.fView = fView;
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "" && tbSurname.Text != "" && tbPatronymic.Text != "")
            {
                DataBaseController.tableController.Add(tbName.Text, tbSurname.Text, tbPatronymic.Text);
                MessageBox.Show("Student " + tbName.Text + ' ' + tbSurname.Text + ' ' + tbPatronymic.Text + " has succesfully added!");
                fView.UpdateTable();
            }
        }
    }
}
