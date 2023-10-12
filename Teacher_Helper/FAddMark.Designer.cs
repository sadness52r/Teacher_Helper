
namespace Teacher_Helper
{
    partial class FAddMark
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
            this.bAdd = new System.Windows.Forms.Button();
            this.lStudentID = new System.Windows.Forms.Label();
            this.tbStudentID = new System.Windows.Forms.TextBox();
            this.lMark = new System.Windows.Forms.Label();
            this.tbMark = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(202, 224);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(172, 52);
            this.bAdd.TabIndex = 16;
            this.bAdd.Text = "ADD";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // lStudentID
            // 
            this.lStudentID.Location = new System.Drawing.Point(184, 63);
            this.lStudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lStudentID.Name = "lStudentID";
            this.lStudentID.Size = new System.Drawing.Size(68, 38);
            this.lStudentID.TabIndex = 15;
            this.lStudentID.Text = "Student ID";
            // 
            // tbStudentID
            // 
            this.tbStudentID.Location = new System.Drawing.Point(311, 63);
            this.tbStudentID.Margin = new System.Windows.Forms.Padding(2);
            this.tbStudentID.Name = "tbStudentID";
            this.tbStudentID.Size = new System.Drawing.Size(102, 20);
            this.tbStudentID.TabIndex = 14;
            // 
            // lMark
            // 
            this.lMark.Location = new System.Drawing.Point(184, 131);
            this.lMark.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lMark.Name = "lMark";
            this.lMark.Size = new System.Drawing.Size(68, 38);
            this.lMark.TabIndex = 18;
            this.lMark.Text = "Mark";
            // 
            // tbMark
            // 
            this.tbMark.Location = new System.Drawing.Point(311, 131);
            this.tbMark.Margin = new System.Windows.Forms.Padding(2);
            this.tbMark.Name = "tbMark";
            this.tbMark.Size = new System.Drawing.Size(102, 20);
            this.tbMark.TabIndex = 17;
            // 
            // FAddMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lMark);
            this.Controls.Add(this.tbMark);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.lStudentID);
            this.Controls.Add(this.tbStudentID);
            this.Name = "FAddMark";
            this.Text = "FAddMark";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label lStudentID;
        private System.Windows.Forms.TextBox tbStudentID;
        private System.Windows.Forms.Label lMark;
        private System.Windows.Forms.TextBox tbMark;
    }
}