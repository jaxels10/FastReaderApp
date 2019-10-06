using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Threading;
using JesperFormAppTest.Text;
using JesperFormAppTest.Text.Speed; 

namespace JesperFormAppTest
{
    public partial class Form1 : Form
    {
        CopiedText text;
        TextSpeed textSpeed = new TextSpeed(100);
        private static System.Windows.Forms.Timer timer;
        static bool exitFlag = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void FontSizeSelector_ValueChanged(object sender, EventArgs e)
        {
            DisplayText.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)FontSizeSelector.Value);
        }

        private void ClipBoardCopyButton_Click(object sender, EventArgs e)
        {
            this.text = new CopiedText(Clipboard.GetText());
            DisplayText.Text = "Copied!";

        }

        private void WPMSelector_ValueChanged(object sender, EventArgs e)
        {
            this.textSpeed.setSpeed((int)WPMSelector.Value);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            DisplayText.Text = text.popWordOne(); 
            int delay = 1000 / (textSpeed.getspeed() / 60);
            timer1.Interval = delay;
            timer1.Start();

            while (exitFlag == false)
            {
                Application.DoEvents();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if(text.getWords().Count == 0)
            {
                exitFlag = true;
            } else
            {
                DisplayText.Text = text.popWordOne();
                timer1.Enabled = true;
            }   
        }
    }
}
