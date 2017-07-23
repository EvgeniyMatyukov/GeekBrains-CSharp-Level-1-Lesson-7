using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Doubler
{
    public partial class Form1 : Form
    {
        Doubler doubler = new Doubler();

        public Form1()
        {
            
            InitializeComponent();

            doubler.Reset();
            labelSetNum.Text = doubler.SetNum.ToString();

        }


        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            doubler.Reset();
            labelCurrentNum.Text = doubler.Current.ToString();
            labelStep.Text = doubler.Step.ToString();
            labelSetNum.Text = doubler.SetNum.ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            doubler.Back();
            labelCurrentNum.Text = doubler.Current.ToString();
            labelStep.Text = doubler.Step.ToString();

        }

        private void buttonInc_Click(object sender, EventArgs e)
        {
            doubler.Inc();
            labelCurrentNum.Text = doubler.Current.ToString();
            labelStep.Text = doubler.Step.ToString();
            VerifyEqually();
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            doubler.Mul();
            labelCurrentNum.Text = doubler.Current.ToString();
            labelStep.Text = doubler.Step.ToString();
            VerifyEqually();
        }

        private void VerifyEqually()
        {
            if (doubler.Current == doubler.SetNum) MessageBox.Show("Поздравляем, вы выиграли за " + doubler.Step + " шагов");

        }
    }
}
