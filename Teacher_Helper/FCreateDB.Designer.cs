
namespace Teacher_Helper
{
    partial class FCreateDB
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bStudents = new System.Windows.Forms.Button();
            this.bVariants = new System.Windows.Forms.Button();
            this.bTeacherT = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(631, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // bStudents
            // 
            this.bStudents.Location = new System.Drawing.Point(21, 410);
            this.bStudents.Name = "bStudents";
            this.bStudents.Size = new System.Drawing.Size(100, 23);
            this.bStudents.TabIndex = 1;
            this.bStudents.Text = "STUDENTS";
            this.bStudents.UseVisualStyleBackColor = true;
            this.bStudents.Click += new System.EventHandler(this.bStudents_Click);
            // 
            // bVariants
            // 
            this.bVariants.Location = new System.Drawing.Point(127, 410);
            this.bVariants.Name = "bVariants";
            this.bVariants.Size = new System.Drawing.Size(100, 23);
            this.bVariants.TabIndex = 2;
            this.bVariants.Text = "VARIANTS";
            this.bVariants.UseVisualStyleBackColor = true;
            this.bVariants.Click += new System.EventHandler(this.bVariants_Click);
            // 
            // bTeacherT
            // 
            this.bTeacherT.Location = new System.Drawing.Point(75, 439);
            this.bTeacherT.Name = "bTeacherT";
            this.bTeacherT.Size = new System.Drawing.Size(100, 45);
            this.bTeacherT.TabIndex = 3;
            this.bTeacherT.Text = "TEACHER TABLE";
            this.bTeacherT.UseVisualStyleBackColor = true;
            this.bTeacherT.Click += new System.EventHandler(this.bTeacherT_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(423, 410);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(100, 23);
            this.bAdd.TabIndex = 4;
            this.bAdd.Text = "ADD";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(529, 410);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(100, 23);
            this.bEdit.TabIndex = 5;
            this.bEdit.Text = "EDIT";
            this.bEdit.UseVisualStyleBackColor = true;
            // 
            // bRemove
            // 
            this.bRemove.Location = new System.Drawing.Point(477, 439);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(100, 45);
            this.bRemove.TabIndex = 6;
            this.bRemove.Text = "REMOVE";
            this.bRemove.UseVisualStyleBackColor = true;
            // 
            // FCreateDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 521);
            this.Controls.Add(this.bRemove);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bTeacherT);
            this.Controls.Add(this.bVariants);
            this.Controls.Add(this.bStudents);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FCreateDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCreateDB";
            this.Load += new System.EventHandler(this.FCreateDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bStudents;
        private System.Windows.Forms.Button bVariants;
        private System.Windows.Forms.Button bTeacherT;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bRemove;
    }
}