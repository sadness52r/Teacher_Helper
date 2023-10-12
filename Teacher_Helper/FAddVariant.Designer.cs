
namespace Teacher_Helper
{
    partial class FAddVariant
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
            this.lPathToFIle = new System.Windows.Forms.Label();
            this.tbPathToFile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(194, 242);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(172, 52);
            this.bAdd.TabIndex = 13;
            this.bAdd.Text = "ADD";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // lPathToFIle
            // 
            this.lPathToFIle.Location = new System.Drawing.Point(130, 112);
            this.lPathToFIle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lPathToFIle.Name = "lPathToFIle";
            this.lPathToFIle.Size = new System.Drawing.Size(68, 38);
            this.lPathToFIle.TabIndex = 8;
            this.lPathToFIle.Text = "Path to file";
            // 
            // tbPathToFile
            // 
            this.tbPathToFile.Location = new System.Drawing.Point(247, 109);
            this.tbPathToFile.Margin = new System.Windows.Forms.Padding(2);
            this.tbPathToFile.Multiline = true;
            this.tbPathToFile.Name = "tbPathToFile";
            this.tbPathToFile.Size = new System.Drawing.Size(207, 41);
            this.tbPathToFile.TabIndex = 7;
            // 
            // FAddVariant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.lPathToFIle);
            this.Controls.Add(this.tbPathToFile);
            this.Name = "FAddVariant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAddVariant";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label lPathToFIle;
        private System.Windows.Forms.TextBox tbPathToFile;
    }
}