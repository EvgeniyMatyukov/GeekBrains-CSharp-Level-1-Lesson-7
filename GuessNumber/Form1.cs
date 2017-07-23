using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuessNumber
{
    public partial class Form1 : Form
    {

        RandomNum randomnum = new RandomNum();

        public Form1()
        {
            InitializeComponent();
            randomnum.NewGame(); //генерируем новое число, обнуляем попытки

        }

        private void buttonNewGame_Click(object sender, EventArgs e) //нажата кнопка "новая игра"
        {
            listBoxHistory.Items.Clear(); //очищаем историю
            randomnum.NewGame(); //генерируем новое число, обнуляем попытки
        }

        private void buttonShowNum_Click(object sender, EventArgs e) //нажата кнопка "показать число"
        {
            MessageBox.Show("Загадано число " + randomnum.SetNum); 
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) //нажата кнопка в поле для ввода числа
        {
            int currentNum;

            if (e.KeyCode == Keys.Enter)    //нажат enter?
            {
                string str = textBox1.Text; //запоминаем введенное число
                bool strEqu = false; //true, если число угадано верно

                textBox1.Text = ""; //очищаем поле для ввода

                try
                {
                    currentNum = Convert.ToInt16(str); //если введено число, запомнить его

                }
                catch
                {
                    return; //если введено не число, выход
                }

                if (currentNum < 0 || currentNum > 100) return; //если введенное число не входит в допустимый диапазон

                if (currentNum > randomnum.SetNum) str = "< " + str;   //загаданное число меньше введенного
                else if (currentNum < randomnum.SetNum) str = "> " + str; //загаданное число больше введенного
                else
                {

                    str = "= " + str; //число угадано верно
                    strEqu = true;
                }
                
                randomnum.IncStep(); //инкрементируем попытку

                listBoxHistory.Items.Add(str); //добавляем результат в историю
                

                if (listBoxHistory.Items.Count > 14) listBoxHistory.Items.RemoveAt(0); //если список длиннее 14 строк, удалить первую строку

                if (strEqu) MessageBox.Show("Поздравляем, вы угадали число с " + randomnum.Step + " попытки");
            
            }
        }

       
    }
}
