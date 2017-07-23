namespace Doubler
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
            this.labelCurrentNum = new System.Windows.Forms.Label();
            this.buttonInc = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelCondition = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSetNum = new System.Windows.Forms.Label();
            this.labelStep = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCurrentNum
            // 
            this.labelCurrentNum.AutoSize = true;
            this.labelCurrentNum.Location = new System.Drawing.Point(118, 110);
            this.labelCurrentNum.Name = "labelCurrentNum";
            this.labelCurrentNum.Size = new System.Drawing.Size(13, 13);
            this.labelCurrentNum.TabIndex = 0;
            this.labelCurrentNum.Text = "0";
            //this.labelCurrentNum.Click += new System.EventHandler(this.labelCurrentNum_Click);
            // 
            // buttonInc
            // 
            this.buttonInc.Location = new System.Drawing.Point(194, 71);
            this.buttonInc.Name = "buttonInc";
            this.buttonInc.Size = new System.Drawing.Size(75, 23);
            this.buttonInc.TabIndex = 1;
            this.buttonInc.Text = "+1";
            this.buttonInc.UseVisualStyleBackColor = true;
            this.buttonInc.Click += new System.EventHandler(this.buttonInc_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(194, 26);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(75, 23);
            this.buttonNewGame.TabIndex = 2;
            this.buttonNewGame.Text = "Новая игра";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.Location = new System.Drawing.Point(194, 100);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(75, 23);
            this.buttonMul.TabIndex = 3;
            this.buttonMul.Text = "*2";
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.buttonMul_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(194, 153);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Шаг назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Location = new System.Drawing.Point(12, 9);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(262, 13);
            this.labelCondition.TabIndex = 5;
            this.labelCondition.Text = "Нажимая кнопки +1 и *2 получите заданное число";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Заданное число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Текущее число";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Шаг";
            // 
            // labelSetNum
            // 
            this.labelSetNum.AutoSize = true;
            this.labelSetNum.Location = new System.Drawing.Point(118, 58);
            this.labelSetNum.Name = "labelSetNum";
            this.labelSetNum.Size = new System.Drawing.Size(13, 13);
            this.labelSetNum.TabIndex = 9;
            this.labelSetNum.Text = "0";
            // 
            // labelStep
            // 
            this.labelStep.AutoSize = true;
            this.labelStep.Location = new System.Drawing.Point(118, 158);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(13, 13);
            this.labelStep.TabIndex = 10;
            this.labelStep.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 188);
            this.Controls.Add(this.labelStep);
            this.Controls.Add(this.labelSetNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCondition);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.buttonInc);
            this.Controls.Add(this.labelCurrentNum);
            this.Name = "Form1";
            this.Text = "Игра удвоитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentNum;
        private System.Windows.Forms.Button buttonInc;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSetNum;
        private System.Windows.Forms.Label labelStep;
    }
}

