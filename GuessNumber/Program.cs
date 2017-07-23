using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

//Автор Матюков Евгений
//Задача
//2. Используя Windows Forms, разработать игру “Угадай число”. 
//Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. 
//Для ввода данных от человека используется элемент TextBox


namespace GuessNumber
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
