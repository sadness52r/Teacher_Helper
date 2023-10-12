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
    public partial class FEditVariant : Form
    {
        FView fView;

        public FEditVariant(FView fView)
        {
            this.fView = fView;
            InitializeComponent();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (DataBaseController.tableController.CheckCorrectVariantID(tbVariantID.Text) &&
                !DataBaseController.tableController.CheckTheSame(tbPathToFile.Text))
            {
                DataBaseController.tableController.Edit(int.Parse(tbVariantID.Text), tbPathToFile.Text);
                MessageBox.Show("Variant with ID " + tbVariantID.Text + " has succesfully edited!");
                fView.UpdateTable();
            }
        }
    }
}
