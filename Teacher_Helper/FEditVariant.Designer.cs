
namespace Teacher_Helper
{
    partial class FEditVariant
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
            this.lPath = new System.Windows.Forms.Label();
            this.tbPathToFile = new System.Windows.Forms.TextBox();
            this.bEdit = new System.Windows.Forms.Button();
            this.lVariantID = new System.Windows.Forms.Label();
            this.tbVariantID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lPath
            // 
            this.lPath.Location = new System.Drawing.Point(186, 145);
            this.lPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lPath.Name = "lPath";
            this.lPath.Size = new System.Drawing.Size(68, 38);
            this.lPath.TabIndex = 23;
            this.lPath.Text = "Path to file";
            // 
            // tbPathToFile
            // 
            this.tbPathToFile.Location = new System.Drawing.Point(313, 145);
            this.tbPathToFile.Margin = new System.Windows.Forms.Padding(2);
            this.tbPathToFile.Name = "tbPathToFile";
            this.tbPathToFile.Size = new System.Drawing.Size(102, 20);
            this.tbPathToFile.TabIndex = 22;
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(204, 238);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(172, 52);
            this.bEdit.TabIndex = 21;
            this.bEdit.Text = "EDIT";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // lVariantID
            // 
            this.lVariantID.Location = new System.Drawing.Point(186, 77);
            this.lVariantID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lVariantID.Name = "lVariantID";
            this.lVariantID.Size = new System.Drawing.Size(68, 38);
            this.lVariantID.TabIndex = 20;
            this.lVariantID.Text = "Variant ID";
            // 
            // tbVariantID
            // 
            this.tbVariantID.Location = new System.Drawing.Point(313, 77);
            this.tbVariantID.Margin = new System.Windows.Forms.Padding(2);
            this.tbVariantID.Name = "tbVariantID";
            this.tbVariantID.Size = new System.Drawing.Size(102, 20);
            this.tbVariantID.TabIndex = 19;
            // 
            // FEditVariant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lPath);
            this.Controls.Add(this.tbPathToFile);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.lVariantID);
            this.Controls.Add(this.tbVariantID);
            this.Name = "FEditVariant";
            this.Text = "FEditVariant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lPath;
        private System.Windows.Forms.TextBox tbPathToFile;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Label lVariantID;
        private System.Windows.Forms.TextBox tbVariantID;
    }
}