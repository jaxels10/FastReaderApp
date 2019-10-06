using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesperFormAppTest.Text
{
    interface ICopiedText
    {
        void setText(string text);
        List<string> getWords();
        void deleteText(); 
    }
}
