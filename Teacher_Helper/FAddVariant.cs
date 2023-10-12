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
    public partial class FAddVariant : Form
    {
        private FView fView;

        public FAddVariant(FView fView)
        {
            this.fView = fView;
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (!DataBaseController.tableController.CheckTheSame(tbPathToFile.Text)){

                Variant.TotalNumber++;
                Variant variant = new Variant(Variant.TotalNumber, "var" + (DataBaseController.tableController.Variants.Count + 1));
                DataBaseController.tableController.Add(variant);
                MessageBox.Show("Variant " + tbPathToFile.Text + ' ' + " has succesfully added!");
                fView.UpdateTable();
            }
        }
    }
}
