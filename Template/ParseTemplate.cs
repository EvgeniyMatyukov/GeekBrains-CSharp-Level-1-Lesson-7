using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Template
{
    class ParseTemplate
    {
        bool status; //true, если файл обработан
 
        string content; //содержимое файла хранится в этой строке
        string filename; //название файла

        public List<string> text = new List<string>(); //список распарсенного текста в шаблоне
                                                //список хранится в таком виде
                                                //например у нас обработан текст "Директору <имя директора=Иванову C.C.>"
                                                //в первой строке будет "Директору "
                                                //во второй строке будет "имя директора"
                                                //в третьей строке будет "Иванову C.C." - текст по умолчанию (может быть пустым)
                                                //указатель будет указывать на вторую строку

        public List<int> pointerPattern = new List<int>(); //список указателей на строки в шаблоне, которые подлежат редактированию 
           
        public bool Status //true, если файл обработан
        {
            get { return status; }
        }

        public string Content //
        {
            get { return content; }
        }

        public string Filename //
        {
            get { return filename; }
        }

        public ParseTemplate() //открыть файл по умолчанию Template.txt
        {
            filename = "Template.txt";
            ParseTemplateC();
        }

        public ParseTemplate(string path) //открыть файл по умолчанию Template.txt
        {
            filename = path;
            ParseTemplateC();
        }

        private void ParseTemplateC()
        {
            status = false;  //true, если файл обработан
            //Если файл существует
            if (File.Exists(filename))
            {
                // Считываем файл
                content = File.ReadAllText(filename);

                if (content.Length > 2) //если считано хотя бы три символа файл обработан
                {
                    ParseText();  //распарсить текст
                    status = true;
                }
            }
            else MessageBox.Show("Error load file");
        }


        public override string ToString() //возвращает отредактированный шаблон 
        {
            

            if (!status) return ""; //если файл не обработан

            if (pointerPattern.Count == 0) return content; //если нет ни одной редактируемой строки

            string answer = ""; // text[0]; //

            for (int i = 0; i < text.Count; i += 3)  //сложим весь текст, кроме названий строк в элементах списка
                answer += text[i] + text[i+2];

            return answer;
        }

        private void ParseText() //распарсить текст
        {
            int n = 0, i;
            bool symEqu = false; //true, если символ '=' уже был

            for (i = 0; i < content.Length; i++) //пройдемся по всему тексту
            {
                if (content[i] == '<') //нашли вхождение
                {
                    //помещаем всю строку от символа n до символа '<' в список
                    text.Add(content.Substring(n, i - n)); //в первой строке будет "Директору "

                    n = i; //запоминаем начало строки n указывает на символ '<'

                    while (i < content.Length-1) //ищем символ '=' или '>'
                    {
                        i++;
                    
                        if (!symEqu && content[i] == '=') //если символа '=' еще не было и нашли вхождение '='
                        {
                            //помещаем всю строку от символа n+1 до символа '=' в список
                            text.Add(content.Substring(n + 1, i - n - 1) + ' ');   //во второй строке будет "имя директора "
                            n = i; //n указывает на символ '='
                            
                            symEqu = true;
                        }

                        if (i == content.Length-1 || content[i] == '>') //нашли вхождение '>'
                        {
                            if (!symEqu)   //если символа '=' не было
                            {
                                text.Add(content.Substring(n + 1, i - n - 1)); //во второй строке будет "имя директора"
                                text.Add('<' + content.Substring(n + 1, i - n - 1) + '>');  //в третьей строке будет "имя директора"
                            }

                            if (symEqu)   //если символ '=' был
                            {
                                text.Add(content.Substring(n + 1, i - n - 1)); //в третьей строке будет "Иванову C.C." - текст по умолчанию
                            }

                            pointerPattern.Add(text.Count - 1); //указатель будет указывать на вторую строку
                            
                            n = i + 1;
                            
                            symEqu = false; //true, если символ '=' уже был

                            break;
                        }
                    }
                }
            }
        }
    }
}
