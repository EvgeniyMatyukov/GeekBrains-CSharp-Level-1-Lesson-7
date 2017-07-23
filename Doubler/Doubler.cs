using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Doubler
{
class Doubler
    {
        int current = 0;
        int step = 0;
        int setNum = 0;
        Stack<int> myStack;// история изменения current num
        
        Random rand = new Random();

        public int Current
        {
            get { return current; }
        }

        public int Step
        {
            get { return step; }
        }

        public int SetNum
        {
            get { return setNum; }
        }

        public void Reset() //новая игра
        {
            setNum = rand.Next(100, 200);
            current = 0;
            step = 0;
            myStack = new Stack<int>();
           
        }

        public void Inc() //увеличить на единицу current num
        {
            myStack.Push(current); //запомнить в стек
            current++;
            step++;
            
        }

        public void Mul() //умножить на два current num
        {
            myStack.Push(current); //запомнить в стек
            current *= 2;
            step++;
            
        }

        public void Back()
        {
            if (myStack.Count == 0) return;
           
            current = myStack.Pop(); //считать из стека
            step--;
        }

        


    }
}
