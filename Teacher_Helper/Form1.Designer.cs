
namespace Teacher_Helper
{
    partial class FMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bCreateDB = new System.Windows.Forms.Button();
            this.bImportDB = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // bCreateDB
            // 
            this.bCreateDB.Location = new System.Drawing.Point(199, 35);
            this.bCreateDB.Name = "bCreateDB";
            this.bCreateDB.Size = new System.Drawing.Size(384, 139);
            this.bCreateDB.TabIndex = 0;
            this.bCreateDB.Text = "CREATE DATA BASE";
            this.bCreateDB.UseVisualStyleBackColor = true;
            this.bCreateDB.Click += new System.EventHandler(this.bCreateDB_Click);
            // 
            // bImportDB
            // 
            this.bImportDB.Location = new System.Drawing.Point(199, 227);
            this.bImportDB.Name = "bImportDB";
            this.bImportDB.Size = new System.Drawing.Size(384, 139);
            this.bImportDB.TabIndex = 1;
            this.bImportDB.Text = "IMPORT DATA BASE";
            this.bImportDB.UseVisualStyleBackColor = true;
            // 
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bImportDB);
            this.Controls.Add(this.bCreateDB);
            this.MaximizeBox = false;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bCreateDB;
        private System.Windows.Forms.Button bImportDB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

