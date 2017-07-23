namespace Template
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonChangeFile = new System.Windows.Forms.Button();
            this.buttonShowAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChangeFile
            // 
            this.buttonChangeFile.Location = new System.Drawing.Point(12, 12);
            this.buttonChangeFile.Name = "buttonChangeFile";
            this.buttonChangeFile.Size = new System.Drawing.Size(117, 37);
            this.buttonChangeFile.TabIndex = 0;
            this.buttonChangeFile.Text = "Выбрать шаблон";
            this.buttonChangeFile.UseVisualStyleBackColor = true;
            this.buttonChangeFile.Click += new System.EventHandler(this.buttonChangeFile_Click);
            // 
            // buttonShowAnswer
            // 
            this.buttonShowAnswer.Location = new System.Drawing.Point(151, 12);
            this.buttonShowAnswer.Name = "buttonShowAnswer";
            this.buttonShowAnswer.Size = new System.Drawing.Size(121, 37);
            this.buttonShowAnswer.TabIndex = 1;
            this.buttonShowAnswer.Text = "Показать результат";
            this.buttonShowAnswer.UseVisualStyleBackColor = true;
            this.buttonShowAnswer.Click += new System.EventHandler(this.buttonShowAnswer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 103);
            this.Controls.Add(this.buttonShowAnswer);
            this.Controls.Add(this.buttonChangeFile);
            this.Name = "Form1";
            this.Text = "Генератор заявлений";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChangeFile;
        private System.Windows.Forms.Button buttonShowAnswer;
        

    }
}

