using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessNumber
{
    class RandomNum
    {
        int step = 0;
        int setNum = 0;
     

        Random rand = new Random();

        public int SetNum
        {
            get { return setNum; }
        }

        public int Step
        {
            get { return step; }
        }

        public void NewGame() //новая игра
        {
            setNum = rand.Next(0, 100);
            step = 0;
           
        }
        
        public void IncStep() //новая игра
        {
            step++;
        }

    }
}
