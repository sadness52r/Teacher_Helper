
namespace Teacher_Helper
{
    partial class FEditStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bEdit = new System.Windows.Forms.Button();
            this.lPatronymic = new System.Windows.Forms.Label();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.lSurname = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(187, 292);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(172, 52);
            this.bEdit.TabIndex = 13;
            this.bEdit.Text = "EDIT";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // lPatronymic
            // 
            this.lPatronymic.Location = new System.Drawing.Point(140, 224);
            this.lPatronymic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lPatronymic.Name = "lPatronymic";
            this.lPatronymic.Size = new System.Drawing.Size(68, 38);
            this.lPatronymic.TabIndex = 12;
            this.lPatronymic.Text = "Patronymic";
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Location = new System.Drawing.Point(255, 221);
            this.tbPatronymic.Margin = new System.Windows.Forms.Padding(2);
            this.tbPatronymic.Multiline = true;
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(207, 41);
            this.tbPatronymic.TabIndex = 11;
            // 
            // lSurname
            // 
            this.lSurname.Location = new System.Drawing.Point(140, 154);
            this.lSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lSurname.Name = "lSurname";
            this.lSurname.Size = new System.Drawing.Size(68, 38);
            this.lSurname.TabIndex = 10;
            this.lSurname.Text = "Surname";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(255, 151);
            this.tbSurname.Margin = new System.Windows.Forms.Padding(2);
            this.tbSurname.Multiline = true;
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(207, 41);
            this.tbSurname.TabIndex = 9;
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(140, 88);
            this.lName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(68, 38);
            this.lName.TabIndex = 8;
            this.lName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(255, 85);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(207, 41);
            this.tbName.TabIndex = 7;
            // 
            // lID
            // 
            this.lID.Location = new System.Drawing.Point(140, 27);
            this.lID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(68, 38);
            this.lID.TabIndex = 15;
            this.lID.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(255, 24);
            this.tbID.Margin = new System.Windows.Forms.Padding(2);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(82, 41);
            this.tbID.TabIndex = 14;
            // 
            // FEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lID);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.lPatronymic);
            this.Controls.Add(this.tbPatronymic);
            this.Controls.Add(this.lSurname);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.tbName);
            this.Name = "FEditStudent";
            this.Text = "FEditStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Label lPatronymic;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.Label lSurname;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.TextBox tbID;
    }
}