using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Template
{
    public partial class Form1 : Form
    {

        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        
        ParseTemplate template = new ParseTemplate(); //новый шаблон
        int formHeight;

        List<Label> label = new List<Label>();
        List<TextBox> textbox = new List<TextBox>();

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Title = "Выберите файл";
            openFileDialog1.Filter = "Текстовые файлы|*.txt";
            
            formHeight = this.Height;

            TemplateShow();
        }

        private void buttonChangeFile_Click(object sender, EventArgs e)
        {
            string[] parsePath = new string[3];

            openFileDialog1.FileName = template.Filename;

            // выход, если была нажата кнопка Отмена и прочие (кроме ОК)
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            // всё. имя файла теперь хранится в openFileDialog1.FileName
            MessageBox.Show("Выбран файл: " + openFileDialog1.FileName);

   
            //убрать старые надписи с формы
            for (int i = 0; i < label.Count; i++)
            {
                this.Controls.Remove(label[i]);
                this.Controls.Remove(textbox[i]);
            }

            this.Height = formHeight; //уменьшить высоту формы


            label = new List<Label>();
            textbox = new List<TextBox>();

            template = new ParseTemplate(openFileDialog1.FileName); //новый шаблон
            TemplateShow(); //показать новые надписи
        }



        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonShowAnswer_Click(object sender, EventArgs e)
        {
 

          //  for (int i = 0; i < template.text.Count; i += 3)  //сложим весь текст, кроме названий строк в элементах списка
           //     answer += text[i] + text[i + 2];

           // MessageBox.Show(template.ToString());
          
            MessageBox.Show(TemplateShowAnswer());
        }

        private string TemplateShowAnswer()
        {

             if (!template.Status) return ""; //если файл не обработан

            if (template.pointerPattern.Count == 0) return template.Content; //если нет ни одной редактируемой строки

            string answer = ""; // text[0]; //

            for (int i = 0; i < template.text.Count; i += 3)  //сложим весь текст, кроме названий строк в элементах списка
                answer += template.text[i] + textbox[i / 3].Text;

            return answer;
            
        }

        private void TemplateShow()
        {
            if (!template.Status) return;


            //Label[] label = new Label[3];

            var height = 70;
            
            int i = 0;
            for (int n = 0; n < template.text.Count; n += 3)
            {
                try
                {
                    label.Add(new Label { Parent = this });
                    textbox.Add(new TextBox { Parent = this });
                    
                    label[i].Text = template.text[n + 1];
                    textbox[i].Text = template.text[n + 2];

                    label[i].Name = "label" + i;
                    textbox[i].Name = "textbox" + i;

                    label[i].Location = new Point(20, height);
                    textbox[i].Location = new Point(120, height);

                    height += label[i].Height;
                    this.Controls.Add(label[i]);
                    this.Controls.Add(textbox[i]);

                    this.Height = formHeight + i * label[i].Height;
                    i++;
                }

                catch
                {
                    return;
                }

            }


        }
    }
}
