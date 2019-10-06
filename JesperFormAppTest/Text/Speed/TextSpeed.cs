using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesperFormAppTest.Text.Speed
{
    class TextSpeed : ItextSpeed
    {
        private int WordsPerMinute;

        public TextSpeed()
        {
        }
        public TextSpeed(int wordsPerMinute)
        {
            WordsPerMinute = wordsPerMinute;
        }

        public int getspeed()
        {
            return this.WordsPerMinute; 
        }

        public void setSpeed(int speed)
        {
            this.WordsPerMinute = speed; 
        }
    }
}
