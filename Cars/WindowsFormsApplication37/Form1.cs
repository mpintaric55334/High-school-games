using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication37
{
    public partial class Form1 : Form
    {
        int zivot1;
        
        int zivot=0;
        bool zivotprikazan=false;
        bool iskoristeno = false;
        int score;
        bool ogranici = true;
        int x;
        int y;
        int j1=0;
        int j;
        int broj1;
        int broj2;
        int broj;
        Random random = new Random();
        Random randomzivot1 = new Random();
        Random randomzivot2 = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D && picplayr.Left<600 &&ogranici==false)
            {
                picplayr.Left += 30;
            }
            if (e.KeyCode == Keys.A && picplayr.Left > 185 && ogranici == false)
            {
                picplayr.Left -= 30;
            }
            if (e.KeyCode == Keys.P)
            {
                timertr1.Enabled = false;
                timertr2.Enabled = false;
                timertr3.Enabled = false;
                timertr4.Enabled = false;
                timerscore.Enabled = false;
                btovr.Text = "Pauza";
                btovr.Visible = true;
                timerglavni.Enabled = false;
                timerljub1.Enabled = false;
                timerljub2.Enabled = false;
                timerljub3.Enabled = false;
                timerljub4.Enabled = false;
                timercr1.Enabled = false;
                timercr2.Enabled = false;
                timercr3.Enabled = false;
                timercr4.Enabled = false;
                timerpl1.Enabled = false;
                timerpl2.Enabled = false;
                timerpl3.Enabled = false;
                timerpl4.Enabled = false;
                timerz1.Enabled = false;
                timerz2.Enabled = false;
                timerz3.Enabled = false;
                timerz4.Enabled = false;
                timerzivot.Enabled = false;
                
                ogranici = true;
            }
            if (e.KeyCode == Keys.K)
            {
                timertr1.Enabled = true;
                timertr2.Enabled = true;
                timertr3.Enabled = true;
                timertr4.Enabled = true;
                timerscore.Enabled = true;
                btovr.Visible = false;
                btovr.Text = "Game over";
                timerglavni.Enabled = true;
                timerljub1.Enabled = true;
                timerljub2.Enabled = true;
                timerljub3.Enabled = true;
                timerljub4.Enabled = true;
                timercr1.Enabled = true;
                timercr2.Enabled = true;
                timercr3.Enabled = true;
                timercr4.Enabled = true;
                timerpl1.Enabled = true;
                timerpl2.Enabled = true;
                timerpl3.Enabled = true;
                timerpl4.Enabled = true;
                timerz1.Enabled = true;
                timerz2.Enabled = true;
                timerz3.Enabled = true;
                timerz4.Enabled = true;
                timerzivot.Enabled = true;
                
                ogranici = false;
            }
            if (e.KeyCode == Keys.S)
            {
                j1 = 0;
                j = 0;
                pictr1.Location = new Point(394, 34);
                pictr2.Location = new Point(394, 209);
                pictr3.Location = new Point(394, 396);
                pictr4.Location = new Point(394, 570);
                timertr1.Enabled = true;
                timertr2.Enabled = true;
                timertr3.Enabled = true;
                timertr4.Enabled = true;
                picplayr.Location = new Point(394, 550);
                timerscore.Enabled = true;
                timerglavni.Enabled = true;
                timerljub1.Enabled = false;
                timerljub2.Enabled = false;
                timerljub3.Enabled = false;
                timerljub4.Enabled = false;
                timercr1.Enabled = false;
                timercr2.Enabled = false;
                timercr3.Enabled = false;
                timercr4.Enabled = false;
                timerpl1.Enabled = false;
                timerpl2.Enabled = false;
                timerpl3.Enabled = false;
                timerpl4.Enabled = false;
                timerz1.Enabled = false;
                timerz2.Enabled = false;
                timerz3.Enabled = false;
                timerz4.Enabled = false;
                btovr.Visible =false;
                ogranici = false;
                picljub1.Visible = false;
                picljub1.Location = new Point(0, 0);
                picljub2.Visible = false;
                picljub2.Location = new Point(0, 0);
                picljub3.Visible = false;
                picljub3.Location = new Point(0, 0);
                picljub4.Visible = false;
                picljub4.Location = new Point(0, 0);
                picpl1.Visible = false;
                picpl1.Location = new Point(0, 0);
                picpl2.Visible = false;
                picpl2.Location = new Point(0, 0);
                picpl3.Visible = false;
                picpl3.Location = new Point(0, 0);
                picpl4.Visible = false;
                picpl4.Location = new Point(0, 0);
                piccr1.Visible = false;
                piccr1.Location = new Point(0, 0);
                piccr2.Visible = false;
                piccr2.Location = new Point(0, 0);
                piccr3.Visible = false;
                piccr3.Location = new Point(0, 0);
                piccr4.Visible = false;
                piccr4.Location = new Point(0, 0);
                picz1.Visible = false;
                picz1.Location = new Point(0, 0);
                picz2.Visible = false;
                picz2.Location = new Point(0, 0);
                picz3.Visible = false;
                picz3.Location = new Point(0, 0);
                picz4.Visible = false;
                picz4.Location = new Point(0, 0);
                score = 0;
                lascore.Text = "0";
                piczivot.Visible = false;
                piczivot.Location = new Point(0, 0);
                timerzivot.Enabled = false;
                zivot = 0;
                lazivot.Text = "0";
                iskoristeno = false;
                zivotprikazan = false;


            }
            if(e.KeyCode==Keys.E)
            {
                this.Close();
            }
            
            
           
        }
        private void Kraj()
        {
            if (zivot == 0 && iskoristeno==false)
            {
                timertr1.Enabled = false;
                timertr2.Enabled = false;
                timertr3.Enabled = false;
                timertr4.Enabled = false;
                timerscore.Enabled = false;
                timerglavni.Enabled = false;
                timerljub1.Enabled = false;
                timerljub2.Enabled = false;
                timerljub3.Enabled = false;
                timerljub4.Enabled = false;
                timercr1.Enabled = false;
                timercr2.Enabled = false;
                timercr3.Enabled = false;
                timercr4.Enabled = false;
                timerpl1.Enabled = false;
                timerpl2.Enabled = false;
                timerpl3.Enabled = false;
                timerpl4.Enabled = false;
                timerz1.Enabled = false;
                timerz2.Enabled = false;
                timerz3.Enabled = false;
                timerz4.Enabled = false;
                btovr.Text = "Game over";
                btovr.Visible = true;
                ogranici = true;
                timerzivot.Enabled = false;
            }
            if(zivot>0)
            {
                
                zivot = zivot - 1;
                iskoristeno = true;//iskoristeno postaje false tek u glavnom timeru zato sto se Kraj odvija sve dok su auti jedan u drugom,sto je vise od par intervala
                lazivot.Text = zivot.ToString();
                
            }
        }

        private void timerljub1_Tick(object sender, EventArgs e)
        {
            picljub1.Top += 5;
            if (picljub1.Top > 650)
            {
                timerljub1.Enabled = false;
                picljub1.Visible = false;
            }
            if (picljub1.Top > 425 && picljub1.Top < 650)
            {
                if (picljub1.Left >= picplayr.Left && picljub1.Left + 60 <= picplayr.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left + 60 >= picljub1.Left && picplayr.Left + 60 <= picljub1.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left <= picljub1.Left + 60 && picplayr.Left > picljub1.Left)
                {
                    Kraj();
                }
            }
        }

        private void timerglavni_Tick(object sender, EventArgs e)
        {
            iskoristeno=false;
            broj = random.Next(6) + 1;
            broj2 = random.Next(2) + 1;
            if (broj2 == 1)//ovo služi da se osiguramo da se ne moze skrivati vjecno izmedu auta
            {
                y = 10;
            }
            if (broj2 == 2)
            {
                y = 0;
            }
            if(broj==1)
            {
                x=200+y;
            }
            if (broj == 2)
            {
                x=330-y;
            }
            if (broj == 3)
            {
                x=450-(y/2);
            }
            if (broj == 4)
            {
                x=580-2*y;
            }
            if (broj == 5)
            {
                x = 260-y;
            }
            if (broj == 6)
            {
                x = 380+y;
            }
            zivot1 = randomzivot1.Next(20);
            
            if (zivot1 == 0 && zivotprikazan == false && zivot==0 && score>20 )// za dodatan zivot
            {
                if (x < 400)
                {
                    piczivot.Location = new Point(x + 100, 10);
                }
                if (x > 400)
                {
                    piczivot.Location = new Point(x - 100, 10);
                }
                piczivot.Visible = true;
                zivotprikazan = true;
                timerzivot.Enabled = true;
            }
            
            

            broj1=random.Next(4);
            if (j1 >= 4)
            {
                j1 = 0;
            }
            if (j1 < 4)
            {
                if (j1 ==0)
                {
                    if (broj1 == 0)
                    {
                        picljub1.Location = new Point(x, 10);
                        timerljub1.Enabled = true;
                        picljub1.Visible = true;
                        if (score > 30 && x < 400)//malo iznenadenje
                        {
                            picpl1.Visible = true;
                            picpl1.Location = new Point(x + 200, 10);
                            timerpl1.Enabled = true;
                        }
                        if (score > 30 && x > 400)
                        {
                            picpl1.Visible = true;
                            picpl1.Location = new Point(x - 200, 10);
                            timerpl1.Enabled = true;
                        }

                    }
                    if (broj1 == 1)
                    {
                        picpl1.Location = new Point(x, 10);
                        timerpl1.Enabled = true;
                        picpl1.Visible = true;
                        if (score > 50 && x < 400)//malo dodatno iznenadenje
                        {
                            piccr1.Visible = true;
                            piccr1.Location = new Point(x + 200, 10);
                            timercr1.Enabled = true;
                        }
                        if (score > 50 && x > 400)
                        {
                            piccr1.Visible = true;
                            piccr1.Location = new Point(x - 200, 10);
                            timercr1.Enabled = true;
                        }
                    }
                    if (broj1 == 2)
                    {
                        piccr1.Location = new Point(x, 10);
                        timercr1.Enabled = true;
                        piccr1.Visible = true;
                        if (score > 30 && x < 400)//malo iznenadenje
                        {
                            picpl1.Visible = true;
                            picpl1.Location = new Point(x + 200, 10);
                            timerpl1.Enabled = true;
                        }
                        if (score > 30 && x > 400)
                        {
                            picpl1.Visible = true;
                            picpl1.Location = new Point(x - 200, 10);
                            timerpl1.Enabled = true;
                        }
                    }
                    if (broj1 == 3)
                    {
                        picz1.Location = new Point(x, 10);
                        timerz1.Enabled = true;
                        picz1.Visible = true;
                        if (score > 70 && x < 400)//malo dodatnije iznenadenje
                        {
                            picpl1.Visible = true;
                            picpl1.Location = new Point(x + 200, 10);
                            timerpl1.Enabled = true;
                        }
                        if (score > 70 && x > 400)
                        {
                            picpl1.Visible = true;
                            picpl1.Location = new Point(x - 200, 10);
                            timerpl1.Enabled = true;
                        }
                    }
                }
                if (j1 == 1)
                {
                    if (broj1 == 0)
                    {

                        picljub2.Location = new Point(x, 10);
                        timerljub2.Enabled = true;
                        picljub2.Visible = true;
                        if (score > 30 && x < 400)//malo iznenadenje
                        {
                            piccr2.Visible = true;
                            piccr2.Location = new Point(x + 200, 10);
                            timercr2.Enabled = true;
                        }
                        if (score > 30 && x > 400)
                        {
                            piccr2.Visible = true;
                            piccr2.Location = new Point(x - 200, 10);
                            timercr2.Enabled = true;
                        }
                    }
                    if (broj1 == 1)
                    {
                        picpl2.Location = new Point(x, 10);
                        timerpl2.Enabled = true;
                        picpl2.Visible = true;
                        if (score > 50 && x < 400)//malo dodatno iznenadenje
                        {
                            piccr2.Visible = true;
                            piccr2.Location = new Point(x + 200, 10);
                            timercr2.Enabled = true;
                        }
                        if (score > 50 && x > 400)
                        {
                            piccr2.Visible = true;
                            piccr2.Location = new Point(x - 200, 10);
                            timercr2.Enabled = true;
                        }
                        
                    }
                    if (broj1 == 2)
                    {
                        piccr2.Location = new Point(x, 10);
                        timercr2.Enabled = true;
                        piccr2.Visible = true;
                        if (score > 30 && x < 400)//malo iznenadenje
                        {
                            picz2.Visible = true;
                            picz2.Location = new Point(x + 200, 10);
                            timerz2.Enabled = true;
                        }
                        if (score > 30 && x > 400)
                        {
                            picz2.Visible = true;
                            picz2.Location = new Point(x - 200, 10);
                            timerz2.Enabled = true;
                            if (score > 70 && x < 400)//malo dodatnije iznenadenje
                            {
                                piccr2.Visible = true;
                                piccr2.Location = new Point(x + 200, 10);
                                timercr2.Enabled = true;
                            }
                            if (score > 70 && x > 400)
                            {
                                piccr2.Visible = true;
                                piccr2.Location = new Point(x - 200, 10);
                                timercr2.Enabled = true;
                            }
                        }
                    }
                    if (broj1 == 3)
                    {
                        picz2.Location = new Point(x, 10);
                        timerz2.Enabled = true;
                        picz2.Visible = true;
                    }
                }
                if (j1 == 2)
                {
                    if (broj1 == 0)
                    {

                        picljub3.Location = new Point(x, 10);
                        timerljub3.Enabled = true;
                        picljub3.Visible = true;
                        if (score > 30 && x < 400)//malo iznenadenje
                        {
                            picz3.Visible = true;
                            picz3.Location = new Point(x + 200, 10);
                            timerz3.Enabled = true;
                        }
                        if (score > 30 && x > 400)
                        {
                            picz3.Visible = true;
                            picz3.Location = new Point(x - 200, 10);
                            timerz3.Enabled = true;
                        }
                    }
                    if (broj1 == 1)
                    {
                        picpl3.Location = new Point(x, 10);
                        timerpl3.Enabled = true;
                        picpl3.Visible = true;
                        if (score > 50 && x < 400)//malo dodatno iznenadenje
                        {
                            picljub3.Visible = true;
                            picljub3.Location = new Point(x + 200, 10);
                            timerljub3.Enabled = true;
                        }
                        if (score > 50 && x > 400)
                        {
                            picljub3.Visible = true;
                            picljub3.Location = new Point(x - 200, 10);
                            timerljub3.Enabled = true;
                        }
                    }
                    if (broj1 == 2)
                    {
                        piccr3.Location = new Point(x, 10);
                        timercr3.Enabled = true;
                        piccr3.Visible = true;
                        if (score > 30 && x < 400)//malo iznenadenje
                        {
                            picljub3.Visible = true;
                            picljub3.Location = new Point(x + 200, 10);
                            timerljub3.Enabled = true;
                        }
                        if (score > 30 && x > 400)
                        {
                            picljub3.Visible = true;
                            picljub3.Location = new Point(x - 200, 10);
                            timerljub3.Enabled = true;
                        }
                    }
                    if (broj1 == 3)
                    {
                        picz3.Location = new Point(x, 10);
                        timerz3.Enabled = true;
                        picz3.Visible = true;
                        if (score > 70 && x < 400)//malo dodatnije iznenadenje
                        {
                            picljub3.Visible = true;
                            picljub3.Location = new Point(x + 200, 10);
                            timerljub3.Enabled = true;
                        }
                        if (score > 70 && x > 400)
                        {
                            picljub3.Visible = true;
                            picljub3.Location = new Point(x - 200, 10);
                            timerljub3.Enabled = true;
                        }
                    }
                }
                if (j1 == 3)
                {
                    if (broj1 == 0)
                    {

                        picljub4.Location = new Point(x, 10);
                        timerljub4.Enabled = true;
                        picljub4.Visible = true;
                        if (score > 30 && x < 400)//malo iznenadenje
                        {
                            picz4.Visible = true;
                            picz4.Location = new Point(x+200, 10);
                            timerz4.Enabled = true;
                        }
                        if (score > 30 && x > 400)
                        {
                            picz4.Visible = true;
                            picz4.Location = new Point(x-200, 10);
                            timerz4.Enabled = true;
                        }
                    }
                    if (broj1 == 1)
                    {
                        picpl4.Location = new Point(x, 10);
                        timerpl4.Enabled = true;
                        picpl4.Visible = true;
                        if (score > 50 && x < 400)//malo dodatno iznenadenje
                        {
                            picz4.Visible = true;
                            picz4.Location = new Point(x + 200, 10);
                            timerz4.Enabled = true;
                        }
                        if (score > 50 && x > 400)
                        {
                            picz4.Visible = true;
                            picz4.Location = new Point(x - 200, 10);
                            timerz4.Enabled = true;
                        }
                    }
                    if (broj1 == 2)
                    {
                        piccr4.Location = new Point(x, 10);
                        timercr4.Enabled = true;
                        piccr4.Visible = true;
                        if (score > 30 && x < 400)//malo iznenadenje
                        {
                            picz4.Visible = true;
                            picz4.Location = new Point(x + 200, 10);
                            timerz4.Enabled = true;
                        }
                        if (score > 30 && x > 400)
                        {
                            picz4.Visible = true;
                            picz4.Location = new Point(x - 200, 10);
                            timerz4.Enabled = true;
                        }
                    }
                    if (broj1 == 3)
                    {
                        picz4.Location = new Point(x, 10);
                        timerz4.Enabled = true;
                        picz4.Visible = true;
                        if (score > 70 && x < 400)//malo dodatnije iznenadenje
                        {
                            picljub4.Visible = true;
                            picljub4.Location = new Point(x + 200, 10);
                            timerljub4.Enabled = true;
                        }
                        if (score > 70 && x > 400)
                        {
                            picljub4.Visible = true;
                            picljub4.Location = new Point(x - 200, 10);
                            timerljub4.Enabled = true;
                        }
                    }
                }
            }
            j1 += 1;

        }

        private void timerljub2_Tick(object sender, EventArgs e)
        {
            picljub2.Top += 5;
            if (picljub2.Top > 650)
            {
                timerljub2.Enabled = false;
                picljub2.Visible = false;
            }
            if (picljub2.Top > 425 && picljub2.Top < 650)
            {
                if (picljub2.Left >= picplayr.Left && picljub2.Left + 60 <= picplayr.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left + 60 >= picljub2.Left && picplayr.Left + 60 <= picljub2.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left <= picljub2.Left + 60 && picplayr.Left > picljub2.Left)
                {
                    Kraj();
                }
            }
        }

        private void timerljub3_Tick(object sender, EventArgs e)
        {
            picljub3.Top += 5;
            if (picljub3.Top > 650)
            {
                timerljub3.Enabled = false;
                picljub3.Visible = false;
            }
            if (picljub3.Top > 425 && picljub3.Top < 650)
            {
                if (picljub3.Left >= picplayr.Left && picljub3.Left + 60 <= picplayr.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left + 60 >= picljub3.Left && picplayr.Left + 60 <= picljub3.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left <= picljub3.Left + 60 && picplayr.Left > picljub3.Left)
                {
                    Kraj();
                }
            }
        }

        private void timerljub4_Tick(object sender, EventArgs e)
        {
            picljub4.Top += 5;
            if (picljub4.Top > 650)
            {
                timerljub4.Enabled = false;
                picljub4.Visible = false;
            }
            if (picljub4.Top > 425 && picljub4.Top < 650)
            {
                if (picljub4.Left >= picplayr.Left && picljub4.Left + 60 <= picplayr.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left + 60 >= picljub4.Left && picplayr.Left + 60 <= picljub4.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left <= picljub4.Left + 60 && picplayr.Left > picljub4.Left)
                {
                    Kraj();
                }
            }
        }

        private void timerpl1_Tick(object sender, EventArgs e)
        {
            picpl1.Top += 5;
            if (picpl1.Top > 650)
            {
                timerpl1.Enabled = false;
                picpl1.Visible = false;
            }
            if (picpl1.Top > 425 && picpl1.Top < 650)
            {
                if (picpl1.Left >= picplayr.Left && picpl1.Left + 60 <= picplayr.Left + 60)
                {
                    Kraj();
                    
                }
                if (picplayr.Left + 60 >= picpl1.Left && picplayr.Left + 60 <= picpl1.Left + 60)
                {
                    Kraj();
                    
                }
                if (picplayr.Left <= picpl1.Left + 60 && picplayr.Left > picpl1.Left)
                {
                    Kraj();
                    
                }
            }
        }

        private void timerpl2_Tick(object sender, EventArgs e)
        {
            picpl2.Top += 5;
            if (picpl2.Top > 650)
            {
                timerpl2.Enabled = false;
                picpl2.Visible = false;
            }
            if (picpl2.Top > 425 && picpl2.Top < 650)
            {
                if (picpl2.Left >= picplayr.Left && picpl2.Left + 60 <= picplayr.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left + 60 >= picpl2.Left && picplayr.Left + 60 <= picpl2.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left <= picpl2.Left + 60 && picplayr.Left > picpl2.Left)
                {
                    Kraj();
                }
            }
        }

        private void timerpl3_Tick(object sender, EventArgs e)
        {
            picpl3.Top += 5;
            if (picpl3.Top > 650)
            {
                timerpl3.Enabled = false;
                picpl3.Visible = false;
            }
            if (picpl3.Top > 425 && picpl3.Top < 650)
            {
                if (picpl3.Left >= picplayr.Left && picpl3.Left + 60 <= picplayr.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left + 60 >= picpl3.Left && picplayr.Left + 60 <= picpl3.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left <= picpl3.Left + 60 && picplayr.Left > picpl3.Left)
                {
                    Kraj();
                }
            }
        }

        private void timerpl4_Tick(object sender, EventArgs e)
        {
            picpl4.Top += 5;
            if (picpl4.Top > 650)
            {
                timerpl4.Enabled = false;
                picpl4.Visible = false;
            }
            if (picpl4.Top > 425 && picpl4.Top < 650)
            {
                if (picpl4.Left >= picplayr.Left && picpl4.Left + 60 <= picplayr.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left + 60 >= picpl4.Left && picplayr.Left + 60 <= picpl4.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left <= picpl4.Left + 60 && picplayr.Left > picpl4.Left)
                {
                    Kraj();
                }
            }
        }

        private void timercr1_Tick(object sender, EventArgs e)
        {
            piccr1.Top += 5;
            if (piccr1.Top > 650)
            {
                timercr1.Enabled = false;
                piccr1.Visible = false;
            }
            if (piccr1.Top > 425 && piccr1.Top < 650)
            {
                if (piccr1.Left >= picplayr.Left && piccr1.Left + 60 <= picplayr.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left + 60 >= piccr1.Left && picplayr.Left + 60 <= piccr1.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left <= piccr1.Left + 60 && picplayr.Left > piccr1.Left)
                {
                    Kraj();
                }
            }
        }

        private void timercr2_Tick(object sender, EventArgs e)
        {
            piccr2.Top += 5;
            if (piccr2.Top > 650)
            {
                timercr2.Enabled = false;
                piccr2.Visible = false;
            }
            if (piccr2.Top > 425 && piccr2.Top < 650)
            {
                if (piccr2.Left >= picplayr.Left && piccr2.Left + 60 <= picplayr.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left + 60 >= piccr2.Left && picplayr.Left + 60 <= piccr2.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left <= piccr2.Left + 60 && picplayr.Left > piccr2.Left)
                {
                    Kraj();
                }
            }
        }

        private void timercr3_Tick(object sender, EventArgs e)
        {
            piccr3.Top += 5;
            if (piccr3.Top > 650)
            {
                timercr3.Enabled = false;
                piccr3.Visible = false;
            }
            if (piccr3.Top > 425 && piccr3.Top < 650)
            {
                if (piccr3.Left >= picplayr.Left && piccr3.Left + 60 <= picplayr.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left + 60 >= piccr3.Left && picplayr.Left + 60 <= piccr3.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left <= piccr3.Left + 60 && picplayr.Left > piccr3.Left)
                {
                    Kraj();
                }
            }
        }

        private void timercr4_Tick(object sender, EventArgs e)
        {
            piccr4.Top += 5;
            if (piccr4.Top > 650)
            {
                timercr4.Enabled = false;
                piccr4.Visible = false;
            }
            if (piccr4.Top > 425 && piccr4.Top < 650)
            {
                if (piccr4.Left >= picplayr.Left && piccr4.Left + 60 <= picplayr.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left + 60 >= piccr4.Left && picplayr.Left + 60 <= piccr4.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left <= piccr4.Left + 60 && picplayr.Left > piccr4.Left)
                {
                    Kraj();
                }
            }
        }

        private void timerz1_Tick(object sender, EventArgs e)
        {
            picz1.Top += 5;
            if (picz1.Top > 650)
            {
                timerz1.Enabled = false;
                picz1.Visible = false;
            }
            if (picz1.Top > 425 && picz1.Top < 650)
            {
                if (picz1.Left >= picplayr.Left && picz1.Left + 60 <= picplayr.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left + 60 >= picz1.Left && picplayr.Left + 60 <= picz1.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left <= picz1.Left + 60 && picplayr.Left > picz1.Left)
                {
                    Kraj();
                }
            }
        }

        private void timerz2_Tick(object sender, EventArgs e)
        {
            picz2.Top += 5;
            if (picz2.Top > 650)
            {
                timerz2.Enabled = false;
                picz2.Visible = false;
            }
            if (picz2.Top > 425 && picz2.Top < 650)
            {
                if (picz2.Left >= picplayr.Left && picz2.Left + 60 <= picplayr.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left + 60 >= picz2.Left && picplayr.Left + 60 <= picz2.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left <= picz2.Left + 60 && picplayr.Left > picz2.Left)
                {
                    Kraj();
                }
            }
        }

        private void timerz3_Tick(object sender, EventArgs e)
        {
            picz3.Top += 5;
            if (picz3.Top > 650)
            {
                timerz3.Enabled = false;
                picz3.Visible = false;
            }
            if (picz3.Top > 425 && picz3.Top < 650)
            {
                if (picz3.Left >= picplayr.Left && picz3.Left + 60 <= picplayr.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left + 60 >= picz3.Left && picplayr.Left + 60 <= picz3.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left <= picz3.Left + 60 && picplayr.Left > picz3.Left)
                {
                    Kraj();
                }
            }
        }

        private void timerz4_Tick(object sender, EventArgs e)
        {
            picz4.Top += 5;
            if (picz4.Top > 650)
            {
                timerz4.Enabled = false;
                picz4.Visible = false;
            }
            if (picz4.Top > 425 && picz4.Top < 650)
            {
                if (picz4.Left >= picplayr.Left && picz4.Left + 60 <= picplayr.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left + 60 >= picz4.Left && picplayr.Left + 60 <= picz4.Left + 60)
                {
                    Kraj();
                }
                if (picplayr.Left <= picz4.Left + 60 && picplayr.Left > picz4.Left)
                {
                    Kraj();
                }
            }
        }

        private void timerscore_Tick(object sender, EventArgs e)
        {
            score += 1;
            lascore.Text = (score.ToString());
           
        }

        private void timertr1_Tick(object sender, EventArgs e)
        {
            pictr1.Top += 7;
            if(pictr1.Top>700)
            {
                pictr1.Location = new Point(394, 0);
            }
        }

        private void timertr2_Tick(object sender, EventArgs e)
        {
            pictr2.Top += 7;
            if(pictr2.Top>700)
            {
                pictr2.Location = new Point(394, 0);
            }
        }

        private void timertr3_Tick(object sender, EventArgs e)
        {
            pictr3.Top += 7;
            if(pictr3.Top>700)
            {
                pictr3.Location = new Point(394, 0);
            }
        }

        private void timertr4_Tick(object sender, EventArgs e)
        {
            pictr4.Top += 7;
            if(pictr4.Top>700)
            {
                pictr4.Location = new Point(394, 0);
            }
        }

        private void timerzivot_Tick(object sender, EventArgs e)//zivot
        {
            piczivot.Top += 5;
            if (piczivot.Top > 470 && piczivot.Top < 670)
            {
                if (picplayr.Left > piczivot.Left-50 && picplayr.Left +20 < piczivot.Left+60)
                {
                    zivot += 1;
                    lazivot.Text = zivot.ToString();
                    zivotprikazan = false;
                    piczivot.Visible = false;
                    timerzivot.Enabled = false;
                }
            }
            if (piczivot.Top > 680)
            {
                zivotprikazan = false;
                piczivot.Visible = false;
                timerzivot.Enabled = false;
            }
        }

        

       
    }
}
