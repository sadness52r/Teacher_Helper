
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
            this.bCreateDB.Location = new System.Drawing.Point(149, 28);
            this.bCreateDB.Margin = new System.Windows.Forms.Padding(2);
            this.bCreateDB.Name = "bCreateDB";
            this.bCreateDB.Size = new System.Drawing.Size(288, 113);
            this.bCreateDB.TabIndex = 0;
            this.bCreateDB.Text = "CREATE DATA BASE";
            this.bCreateDB.UseVisualStyleBackColor = true;
            this.bCreateDB.Click += new System.EventHandler(this.bCreateDB_Click);
            // 
            // bImportDB
            // 
            this.bImportDB.Location = new System.Drawing.Point(149, 184);
            this.bImportDB.Margin = new System.Windows.Forms.Padding(2);
            this.bImportDB.Name = "bImportDB";
            this.bImportDB.Size = new System.Drawing.Size(288, 113);
            this.bImportDB.TabIndex = 1;
            this.bImportDB.Text = "IMPORT DATA BASE";
            this.bImportDB.UseVisualStyleBackColor = true;
            this.bImportDB.Click += new System.EventHandler(this.bImportDB_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "text files(*.txt)|*.txt*";
            this.openFileDialog1.InitialDirectory = "AppDomain.CurrentDomain.BaseDirectory";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.bImportDB);
            this.Controls.Add(this.bCreateDB);
            this.Margin = new System.Windows.Forms.Padding(2);
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

