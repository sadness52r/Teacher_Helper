
namespace Teacher_Helper
{
    partial class FRemoveStudent
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
            this.bRemove = new System.Windows.Forms.Button();
            this.lStudentID = new System.Windows.Forms.Label();
            this.tbStudentID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bRemove
            // 
            this.bRemove.Location = new System.Drawing.Point(204, 238);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(172, 52);
            this.bRemove.TabIndex = 19;
            this.bRemove.Text = "REMOVE";
            this.bRemove.UseVisualStyleBackColor = true;
            this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // lStudentID
            // 
            this.lStudentID.Location = new System.Drawing.Point(177, 116);
            this.lStudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lStudentID.Name = "lStudentID";
            this.lStudentID.Size = new System.Drawing.Size(68, 38);
            this.lStudentID.TabIndex = 18;
            this.lStudentID.Text = "Student ID";
            // 
            // tbStudentID
            // 
            this.tbStudentID.Location = new System.Drawing.Point(304, 116);
            this.tbStudentID.Margin = new System.Windows.Forms.Padding(2);
            this.tbStudentID.Name = "tbStudentID";
            this.tbStudentID.Size = new System.Drawing.Size(102, 20);
            this.tbStudentID.TabIndex = 17;
            // 
            // FRemoveStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.bRemove);
            this.Controls.Add(this.lStudentID);
            this.Controls.Add(this.tbStudentID);
            this.Name = "FRemoveStudent";
            this.Text = "FRemoveStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bRemove;
        private System.Windows.Forms.Label lStudentID;
        private System.Windows.Forms.TextBox tbStudentID;
    }
}