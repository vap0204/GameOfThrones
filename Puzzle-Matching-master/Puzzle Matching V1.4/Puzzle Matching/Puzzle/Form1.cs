using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class Form1 : Form
    {
        private int b1 = 0, b2 = 0, b3 = 0, b4 = 0, b5 = 0, b6 = 0, b7 = 0, b8 = 0, b9 = 0, b10 = 0, b11 = 0, b12 = 0, b13 = 0, b14 = 0, b15 = 0, b16 = 0;
        private Timer timerObj;
        private int tick = 61;
        public Form1()
        {
            InitializeComponent();

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;

            timerObj = new Timer();
            timerObj.Enabled = true;
            timerObj.Interval = 1000;
            timerObj.Tick += timerObj_Tick;
        }

        void timerObj_Tick(object sender, EventArgs e)
        {
            tick--;
            if (tick >= 10)
            {
                labelTick.Text = "00:" + tick;
            }
            else if (tick < 10) 
            {
                labelTick.Text = "00:0" + tick;
            }
            if (tick == 0 && (b1+b2+b3+b4+b5+b6+b7+b8+b9+b10+b11+b12+b13+b14+b15+b16==16)) 
            {
                timerObj.Enabled = false;
                labelTick.Visible = false;
                this.BackgroundImage = global::Puzzle.Resource1.NightKing;
                labelCopyRight.Visible = true;
                buttonRestart.Visible = true;
                buttonQuit.Visible = true;
                labelWon.Visible = true;
            }
            else if(tick==0 && (b1+b2+b3+b4+b5+b6+b7+b8+b9+b10+b11+b12+b13+b14+b15+b16 !=16))
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                button10.Visible = false;
                button11.Visible = false;
                button12.Visible = false;
                button13.Visible = false;
                button14.Visible = false;
                button15.Visible = false;
                button16.Visible = false;

                timerObj.Enabled = false;
                labelTick.Visible = false;
                labelDead.Visible = true;
                labelCopyRight.Visible = true;
                this.BackgroundImage = global::Puzzle.Resource1.Dead;
                buttonRestart.Visible = true;
                buttonQuit.Visible = true;
                labelLose.Visible = true;
            }
        }

        public void setAll() 
        {
            b1=0;
            b2=0;
            b3=0;
            b4=0;
            b5=0;
            b6=0;
            b7=0;
            b8=0;
            b9=0;
            b10=0;
            b11=0;
            b12=0;
            b13=0;
            b14=0;
            b15=0;
            b16=0;
   
            this.button1.BackgroundImage = global::Puzzle.Resource1.Faceless;
            this.button2.BackgroundImage = global::Puzzle.Resource1.Faceless;
            this.button3.BackgroundImage = global::Puzzle.Resource1.Faceless;
            this.button4.BackgroundImage = global::Puzzle.Resource1.Faceless;
            this.button5.BackgroundImage = global::Puzzle.Resource1.Faceless;
            this.button6.BackgroundImage = global::Puzzle.Resource1.Faceless;
            this.button7.BackgroundImage = global::Puzzle.Resource1.Faceless;
            this.button8.BackgroundImage = global::Puzzle.Resource1.Faceless;
            this.button9.BackgroundImage = global::Puzzle.Resource1.Faceless;
            this.button10.BackgroundImage = global::Puzzle.Resource1.Faceless;
            this.button11.BackgroundImage = global::Puzzle.Resource1.Faceless;
            this.button12.BackgroundImage = global::Puzzle.Resource1.Faceless;
            this.button13.BackgroundImage = global::Puzzle.Resource1.Faceless;
            this.button14.BackgroundImage = global::Puzzle.Resource1.Faceless;
            this.button15.BackgroundImage = global::Puzzle.Resource1.Faceless;
            this.button16.BackgroundImage = global::Puzzle.Resource1.Faceless;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b1 = 1;
            if (b2==0)
            {
                setAll();
                b1 = 1;
                this.button1.BackgroundImage = global::Puzzle.Resource1.Stark;
            }
            else if (b1==1 && b2==1)
            {
                this.button1.Visible = false;
                this.button2.Visible = false;
            }
            EndGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b2 = 1;
            if (b1==0)
            {
                setAll();
                b2 = 1;
                this.button2.BackgroundImage = global::Puzzle.Resource1.Stark;
            }
            else if (b1==1 && b2==1)
            {
                this.button1.Visible = false;
                this.button2.Visible = false;
            }
            EndGame();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            b3 = 1;
            if (b4 == 0)
            {
                setAll();
                b3 = 1;
                this.button3.BackgroundImage = global::Puzzle.Resource1.Baratheon;
            }
            else if (b3 == 1 && b4 == 1)
            {
                this.button3.Visible = false;
                this.button4.Visible = false;
            }
            EndGame();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            b4 = 1;
            if(b3==0)
            {
                setAll();
                b4 = 1;
                this.button4.BackgroundImage = global::Puzzle.Resource1.Baratheon;
            }
            else if (b3 == 1 && b4 == 1)
            {
                this.button3.Visible = false;
                this.button4.Visible = false;
            }
            EndGame();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            b5 = 1;
            if (b6 == 0)
            {
                setAll();
                b5 = 1;
                this.button5.BackgroundImage = global::Puzzle.Resource1.Lannister;
            }
            else if (b5 == 1 && b6 == 1)
            {
                this.button5.Visible = false;
                this.button6.Visible = false;
            }
            EndGame(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            b6 = 1;
            if (b5 == 0)
            {
                setAll();
                b6 = 1;
                this.button6.BackgroundImage = global::Puzzle.Resource1.Lannister;
            }
            else if (b5 == 1 && b6 == 1)
            {
                this.button5.Visible = false;
                this.button6.Visible = false;
            }
            EndGame();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            b7 = 1;
            if (b8 == 0)
            {
                setAll();
                b7 = 1;
                this.button7.BackgroundImage = global::Puzzle.Resource1.Targaryen;
            }
            else if (b7 == 1 && b8 == 1)
            {
                this.button7.Visible = false;
                this.button8.Visible = false;
            }
            EndGame();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            b8 = 1;
            if (b7 == 0)
            {
                setAll();
                b8 = 1;
                this.button8.BackgroundImage = global::Puzzle.Resource1.Targaryen;
            }
            else if (b7 == 1 && b8 == 1)
            {
                this.button7.Visible = false;
                this.button8.Visible = false;
            }
            EndGame();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            b9 = 1;
            if (b10 == 0)
            {
                setAll();
                b9 = 1;
                this.button9.BackgroundImage = global::Puzzle.Resource1.Arryn;
            }
            else if (b9 == 1 && b10 == 1)
            {
                this.button9.Visible = false;
                this.button10.Visible = false;
            }
            EndGame();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            b10 = 1;
            if (b9 == 0)
            {
                setAll();
                b10 = 1;
                this.button10.BackgroundImage = global::Puzzle.Resource1.Arryn;
            }
            else if (b9 == 1 && b10 == 1)
            {
                this.button9.Visible = false;
                this.button10.Visible = false;
            }
            EndGame();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            b11 = 1;
            if (b12 == 0)
            {
                setAll();
                b11 = 1;
                this.button11.BackgroundImage = global::Puzzle.Resource1.Tully;
            }
            else if (b11 == 1 && b12 == 1)
            {
                this.button11.Visible = false;
                this.button12.Visible = false;
            }
            EndGame();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            b12 = 1;
            if (b11 == 0)
            {
                setAll();
                b12 = 1;
                this.button12.BackgroundImage = global::Puzzle.Resource1.Tully;
            }
            else if (b11 == 1 && b12 == 1)
            {
                this.button11.Visible = false;
                this.button12.Visible = false;
            }
            EndGame();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            b13 = 1;
            if (b14 == 0)
            {
                setAll();
                b13 = 1;
                this.button13.BackgroundImage = global::Puzzle.Resource1.Bolton;
            }
            else if (b13 == 1 && b14 == 1)
            {
                this.button13.Visible = false;
                this.button14.Visible = false;
            }
            EndGame();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            b14 = 1;
            if (b13 == 0)
            {
                setAll();
                b14 = 1;
                this.button14.BackgroundImage = global::Puzzle.Resource1.Bolton;
            }
            else if (b13 == 1 && b14 == 1)
            {
                this.button13.Visible = false;
                this.button14.Visible = false;
            }
            EndGame();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            b15 = 1;
            if (b16 == 0)
            {
                setAll();
                b15 = 1;
                this.button15.BackgroundImage = global::Puzzle.Resource1.Greyjoyjpg;
            }
            else if (b15 == 1 && b16 == 1)
            {
                this.button15.Visible = false;
                this.button16.Visible = false;
            }
            EndGame();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            b16 = 1;
            if (b15 == 0)
            {
                setAll();
                b16 = 1;
                this.button16.BackgroundImage = global::Puzzle.Resource1.Greyjoyjpg;
            }
            else if (b15 == 1 && b16 == 1)
            {
                this.button15.Visible = false;
                this.button16.Visible = false;
            }
            EndGame();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            labelTick.Visible = true;
            label1.Visible = false;
            buttonStart.Visible = false;
            buttonExit.Visible = false;


            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;

            Random r = new Random();

            this.button1.Location = new Point(r.Next(this.Size.Width - this.button1.Size.Width), r.Next(this.Size.Height - this.button1.Size.Height));
            this.button2.Location = new Point(r.Next(this.Size.Width - this.button1.Size.Width), r.Next(this.Size.Height - this.button1.Size.Height));

            this.button3.Location = new Point(r.Next(this.Size.Width - this.button1.Size.Width), r.Next(this.Size.Height - this.button1.Size.Height));
            this.button4.Location = new Point(r.Next(this.Size.Width - this.button1.Size.Width), r.Next(this.Size.Height - this.button1.Size.Height));

            this.button5.Location = new Point(r.Next(this.Size.Width - this.button1.Size.Width), r.Next(this.Size.Height - this.button1.Size.Height));
            this.button6.Location = new Point(r.Next(this.Size.Width - this.button1.Size.Width), r.Next(this.Size.Height - this.button1.Size.Height));

            this.button7.Location = new Point(r.Next(this.Size.Width - this.button1.Size.Width), r.Next(this.Size.Height - this.button1.Size.Height));
            this.button8.Location = new Point(r.Next(this.Size.Width - this.button1.Size.Width), r.Next(this.Size.Height - this.button1.Size.Height));

            this.button9.Location = new Point(r.Next(this.Size.Width - this.button1.Size.Width), r.Next(this.Size.Height - this.button1.Size.Height));
            this.button10.Location = new Point(r.Next(this.Size.Width - this.button1.Size.Width), r.Next(this.Size.Height - this.button1.Size.Height));

            this.button11.Location = new Point(r.Next(this.Size.Width - this.button1.Size.Width), r.Next(this.Size.Height - this.button1.Size.Height));
            this.button12.Location = new Point(r.Next(this.Size.Width - this.button1.Size.Width), r.Next(this.Size.Height - this.button1.Size.Height));

            this.button13.Location = new Point(r.Next(this.Size.Width - this.button1.Size.Width), r.Next(this.Size.Height - this.button1.Size.Height));
            this.button14.Location = new Point(r.Next(this.Size.Width - this.button1.Size.Width), r.Next(this.Size.Height - this.button1.Size.Height));

            this.button15.Location = new Point(r.Next(this.Size.Width - this.button1.Size.Width), r.Next(this.Size.Height - this.button1.Size.Height));
            this.button16.Location = new Point(r.Next(this.Size.Width - this.button1.Size.Width), r.Next(this.Size.Height - this.button1.Size.Height));
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void EndGame() 
        {
            if (button1.Visible == false && button2.Visible == false && button3.Visible == false && button4.Visible == false && button5.Visible == false && button6.Visible == false && button7.Visible == false && button8.Visible == false && button9.Visible == false && button10.Visible == false && button11.Visible == false && button12.Visible == false && button13.Visible == false && button14.Visible == false && button15.Visible == false && button16.Visible == false) 
            {
                this.BackgroundImage = global::Puzzle.Resource1.NightKing;
                label2.Visible = true;
                labelCopyRight.Visible = true;
                labelTick.Visible = false;
                buttonRestart.Visible = true;
                buttonQuit.Visible = true;
                labelWon.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
