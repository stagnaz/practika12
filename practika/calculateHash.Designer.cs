
namespace practika
{
    partial class calculateHash
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
            this.calculateHashButton = new System.Windows.Forms.Button();
            this.stringForHash = new System.Windows.Forms.TextBox();
            this.isString = new System.Windows.Forms.RadioButton();
            this.isFile = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.choseFileButton = new System.Windows.Forms.Button();
            this.pathToFile = new System.Windows.Forms.Label();
            this.calculatedHash = new System.Windows.Forms.TextBox();
            this.copyHashButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculateHashButton
            // 
            this.calculateHashButton.Location = new System.Drawing.Point(433, 150);
            this.calculateHashButton.Name = "calculateHashButton";
            this.calculateHashButton.Size = new System.Drawing.Size(95, 23);
            this.calculateHashButton.TabIndex = 0;
            this.calculateHashButton.Text = "Calculate hash";
            this.calculateHashButton.UseVisualStyleBackColor = true;
            this.calculateHashButton.Click += new System.EventHandler(this.calculateHashClick);
            // 
            // stringForHash
            // 
            this.stringForHash.Location = new System.Drawing.Point(69, 16);
            this.stringForHash.Name = "stringForHash";
            this.stringForHash.Size = new System.Drawing.Size(341, 20);
            this.stringForHash.TabIndex = 1;
            // 
            // isString
            // 
            this.isString.AutoSize = true;
            this.isString.Checked = true;
            this.isString.Location = new System.Drawing.Point(433, 17);
            this.isString.Name = "isString";
            this.isString.Size = new System.Drawing.Size(98, 17);
            this.isString.TabIndex = 2;
            this.isString.TabStop = true;
            this.isString.Text = "String(SHA256)";
            this.isString.UseVisualStyleBackColor = true;
            // 
            // isFile
            // 
            this.isFile.AutoSize = true;
            this.isFile.Location = new System.Drawing.Point(433, 63);
            this.isFile.Name = "isFile";
            this.isFile.Size = new System.Drawing.Size(70, 17);
            this.isFile.TabIndex = 3;
            this.isFile.Text = "File(MD5)";
            this.isFile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data";
            // 
            // choseFileButton
            // 
            this.choseFileButton.Location = new System.Drawing.Point(335, 63);
            this.choseFileButton.Name = "choseFileButton";
            this.choseFileButton.Size = new System.Drawing.Size(75, 23);
            this.choseFileButton.TabIndex = 5;
            this.choseFileButton.Text = "Chose file";
            this.choseFileButton.UseVisualStyleBackColor = true;
            this.choseFileButton.Click += new System.EventHandler(this.choseFileButton_Click);
            // 
            // pathToFile
            // 
            this.pathToFile.AutoSize = true;
            this.pathToFile.Location = new System.Drawing.Point(12, 68);
            this.pathToFile.Name = "pathToFile";
            this.pathToFile.Size = new System.Drawing.Size(63, 13);
            this.pathToFile.TabIndex = 6;
            this.pathToFile.Text = "Path to file..";
            // 
            // calculatedHash
            // 
            this.calculatedHash.Location = new System.Drawing.Point(15, 114);
            this.calculatedHash.Name = "calculatedHash";
            this.calculatedHash.ReadOnly = true;
            this.calculatedHash.Size = new System.Drawing.Size(513, 20);
            this.calculatedHash.TabIndex = 7;
            // 
            // copyHashButton
            // 
            this.copyHashButton.Location = new System.Drawing.Point(15, 149);
            this.copyHashButton.Name = "copyHashButton";
            this.copyHashButton.Size = new System.Drawing.Size(99, 23);
            this.copyHashButton.TabIndex = 8;
            this.copyHashButton.Text = "Copy Hash";
            this.copyHashButton.UseVisualStyleBackColor = true;
            this.copyHashButton.Click += new System.EventHandler(this.copyHashButton_Click);
            // 
            // calculateHash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 185);
            this.Controls.Add(this.copyHashButton);
            this.Controls.Add(this.calculatedHash);
            this.Controls.Add(this.pathToFile);
            this.Controls.Add(this.choseFileButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isFile);
            this.Controls.Add(this.isString);
            this.Controls.Add(this.stringForHash);
            this.Controls.Add(this.calculateHashButton);
            this.Name = "calculateHash";
            this.Text = "Calculate hash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateHashButton;
        private System.Windows.Forms.TextBox stringForHash;
        private System.Windows.Forms.RadioButton isString;
        private System.Windows.Forms.RadioButton isFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button choseFileButton;
        private System.Windows.Forms.Label pathToFile;
        private System.Windows.Forms.TextBox calculatedHash;
        private System.Windows.Forms.Button copyHashButton;
    }
}

