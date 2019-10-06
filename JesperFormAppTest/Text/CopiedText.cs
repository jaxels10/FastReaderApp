using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesperFormAppTest.Text
{
    class CopiedText : ICopiedText
    {
        
        List<string> words = new List<string>(); 

        public void deleteText()
        {
            words.Clear();  
        }

        public string popWordOne()
        {
            if (words.Count > 0)
            {
                string answer = words.ElementAt(0); 
                words.RemoveAt(0);
                return answer; 

            }
            else
            {
                return null; 
            }
                
        }

        public List<string> getWords()
        {
            return this.words; 
        }

        public void setText(string text)
        {
             words = text.Split(' ').ToList();
        }

        public CopiedText()
        {
        }

        public CopiedText(string text)
        {
            words = text.Split(' ').ToList();
        }
    }
}
