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
        bool igra=true;
        int zpro=0;
        int cpro=0;
        string orjentacija1;
        string orjentacija11;//ima više orjentacija jer ako je samo jedna kad se tenk zakrene zakrenu se i projektili
        string orjentacija12;
        string orjentacija13;
        string orjentacija14;
        string orjentacija15;
        string orjentacija2;
        string orjentacija21;
        string orjentacija22;
        string orjentacija23;
        string orjentacija24;
        string orjentacija25;
        int scorez;
        int scorec;
        public Form1()
        {
            InitializeComponent();
        }
        private void KrajZ()
        {
            timerzlpro1.Enabled = false;//ako ne ugasim timere dobivace poene sve dok je timer upaljen
            timerzlpro2.Enabled = false;
            timerzlpro3.Enabled = false;
            timerzlpro4.Enabled = false;
            timerzlpro5.Enabled = false;
            timercrpro1.Enabled = false;
            timercrpro2.Enabled = false;
            timercrpro3.Enabled = false;
            timercrpro4.Enabled = false;
            timercrpro5.Enabled = false;
            igra = false;
            scorez += 1;
            btovr.BackColor = Color.Green;
            lascorez.Text = scorez.ToString();
            btovr.Text = "Zeleni je pobijedio";
            btovr.Visible = true;
            
        }
        private void KrajC()
        {
            timerzlpro1.Enabled = false;
            timerzlpro2.Enabled = false;
            timerzlpro3.Enabled = false;
            timerzlpro4.Enabled = false;
            timerzlpro5.Enabled = false;
            timercrpro1.Enabled = false;
            timercrpro2.Enabled = false;
            timercrpro3.Enabled = false;
            timercrpro4.Enabled = false;
            timercrpro5.Enabled = false;
            igra = false;
            scorec += 1;
            lascorec.Text = scorec.ToString();
            btovr.BackColor = Color.Red;
            btovr.Text = "Crveni je pobijedio";
            btovr.Visible = true;
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)//zeleni
        {
            if (e.KeyCode == Keys.W && piczl.Top>130 &&igra==true )
            {
                piczl.Top -= 5;
                s.Top -= 5;//ovo služi da nemoram sa kodom centrirat misto pucnja
                piczl.BackgroundImage = Properties.Resources.tankzg;
                orjentacija1 = "gore";
            }
            if (e.KeyCode == Keys.S && piczl.Top < 490 && igra == true)
            {
                piczl.Top += 5;
                s.Top += 5;//ovo služi da nemoram sa kodom centrirat misto pucnja
                piczl.BackgroundImage = Properties.Resources.tankzd;
                orjentacija1 = "dolje";
            }
            if (e.KeyCode == Keys.A && piczl.Left > 180 && igra == true)
            {
                piczl.Left -= 5;
                s.Left -= 5;//ovo služi da nemoram sa kodom centrirat misto pucnja
                piczl.BackgroundImage = Properties.Resources.tankzl;
                orjentacija1 = "lijevo";
            }
            if (e.KeyCode == Keys.D && piczl.Left < 900 && igra == true)
            {
                piczl.Left += 5;
                s.Left += 5;//ovo služi da nemoram sa kodom centrirat misto pucnja
                piczl.BackgroundImage = Properties.Resources.tankzde;
                orjentacija1 = "desno";
            }
            if (e.KeyCode == Keys.E && orjentacija1 != null && igra == true)
            {
                if(zpro>=5)
                {
                    zpro = 0;
                }
                if (zpro == 0 && picprz1.Left==32 && picprz1.Top==305)
                {
                    timerzlpro1.Enabled = true;
                    picprz1.Location = s.Location;
                    orjentacija11 = orjentacija1;
                }
                if (zpro == 1 && picprz2.Left == 48 && picprz2.Top == 305)
                {
                    timerzlpro2.Enabled = true;
                    picprz2.Location = s.Location;
                    orjentacija12 = orjentacija1;
                }
                if (zpro == 2 && picprz3.Left == 64 && picprz3.Top == 305)
                {
                    timerzlpro3.Enabled = true;
                    picprz3.Location = s.Location;
                    orjentacija13 = orjentacija1;
                }
                if (zpro == 3 && picprz4.Left == 80 && picprz4.Top == 305)
                {
                    timerzlpro4.Enabled = true;
                    picprz4.Location = s.Location;
                    orjentacija14 = orjentacija1;
                }
                if (zpro == 4 && picprz5.Left == 96 && picprz5.Top == 305)
                {
                    timerzlpro5.Enabled = true;
                    picprz5.Location = s.Location;
                    orjentacija15 = orjentacija1;
                }
                zpro += 1;
            }
            if (e.KeyCode == Keys.T)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Z)
            {
                igra = true;
                btovr.Visible = false;
                piczl.Location = new Point(260, 456);
                s.Location = new Point(274, 476);
                piccr.Location= new Point(830,153);
                s1.Location = new Point(845, 167);
                picprz1.Location = new Point(32, 305);
                picprz2.Location = new Point(48, 305);
                picprz3.Location = new Point(64, 305);
                picprz4.Location = new Point(80, 305);
                picprz5.Location = new Point(96, 305);
                picprc1.Location = new Point(1027, 281);
                picprc2.Location = new Point(1043, 281);
                picprc3.Location = new Point(1059, 281);
                picprc4.Location = new Point(1075, 281);
                picprc5.Location = new Point(1091, 281);
            }

            

        }


        private void timerzlpro1_Tick(object sender, EventArgs e)//zeleni
        {
            
            if (orjentacija11 == "gore")
            {
                picprz1.Top -= 6;
                if (picprz1.Top < 120)
                {
                    timerzlpro1.Enabled = false;
                    picprz1.Location = new Point(32, 305);
                }
            }
            if (orjentacija11 == "dolje")
            {
                picprz1.Top += 6;
                if (picprz1.Top > 520)
                {
                    timerzlpro1.Enabled = false;
                    picprz1.Location = new Point(32, 305);
                }
            }
            if (orjentacija11 == "lijevo")
            {
                picprz1.Left -= 6;
                if (picprz1.Left < 180)
                {
                    timerzlpro1.Enabled = false;
                    picprz1.Location = new Point(32, 305);
                }
            }
            if (orjentacija11 == "desno")
            {
                picprz1.Left += 6;
                if (picprz1.Left > 930)
                {
                    timerzlpro1.Enabled = false;
                    picprz1.Location = new Point(32, 305);
                }
            }
            if (picprz1.Left > piccr.Left-10 && picprz1.Left < piccr.Left+40)
            {
                if (picprz1.Top > piccr.Top-10 && picprz1.Top < piccr.Top+40)
                {
                    KrajZ();
                }
            }

        }
        //od ode pa do doli je za kretanje crvenog,jbg u visualu se nemore oba dva na tipkovnici
        private void piccrup_MouseDown(object sender, MouseEventArgs e)
        {
            timercrkretanje.Enabled = true;
            orjentacija2 = "gore";
            piccr.BackgroundImage = Properties.Resources.tankcg;

        }

        private void piccrup_MouseUp(object sender, MouseEventArgs e)
        {
            timercrkretanje.Enabled = false;
        }

        private void piccrdown_MouseDown(object sender, MouseEventArgs e)
        {
            timercrkretanje.Enabled = true;
            orjentacija2 = "dolje";
            piccr.BackgroundImage = Properties.Resources.tankcd;
        }

        private void piccrdown_MouseUp(object sender, MouseEventArgs e)
        {
            timercrkretanje.Enabled = false;
        }

        private void piccrleft_MouseDown(object sender, MouseEventArgs e)
        {
            timercrkretanje.Enabled = true;
            orjentacija2 = "lijevo";
            piccr.BackgroundImage = Properties.Resources.tankcl;
        }

        private void piccrleft_MouseUp(object sender, MouseEventArgs e)
        {
            timercrkretanje.Enabled = false;
        }

        private void piccrright_MouseDown(object sender, MouseEventArgs e)
        {
            timercrkretanje.Enabled = true;
            orjentacija2 = "desno";
            piccr.BackgroundImage = Properties.Resources.tankcde;
        }

        private void piccrright_MouseUp(object sender, MouseEventArgs e)
        {
            timercrkretanje.Enabled = false;
        }

        private void timercrketanje_Tick(object sender, EventArgs e)//zeleni
        {
            if (orjentacija2 == "gore" && piccr.Top > 130 && igra == true)
            {
                piccr.Top -= 10;
                s1.Top -= 10;
            }
            if (orjentacija2 == "dolje" && piccr.Top < 490 && igra == true)
            {
                piccr.Top += 10;
                s1.Top += 10;
            }
            if (orjentacija2 == "lijevo" && piccr.Left > 180 && igra == true)
            {
                piccr.Left -= 10;
                s1.Left -= 10;
            }
            if (orjentacija2 == "desno" && piccr.Left < 900 && igra == true)
            {
                piccr.Left += 10;
                s1.Left += 10;
            }
        }
        //gotovo s kretanjem crvenog

        private void timerzlpro2_Tick(object sender, EventArgs e)//zeleni
        {
            if (orjentacija12 == "gore")
            {
                picprz2.Top -= 6;
                if (picprz2.Top < 120)
                {
                    timerzlpro2.Enabled = false;
                    picprz2.Location = new Point(48, 305);
                }
            }
            if (orjentacija12 == "dolje")
            {
                picprz2.Top += 6;
                if (picprz2.Top > 520)
                {
                    timerzlpro2.Enabled = false;
                    picprz2.Location = new Point(48, 305);
                }
            }
            if (orjentacija12 == "lijevo")
            {
                picprz2.Left -= 6;
                if (picprz2.Left < 180)
                {
                    timerzlpro2.Enabled = false;
                    picprz2.Location = new Point(48, 305);
                }
            }
            if (orjentacija12 == "desno")
            {
                picprz2.Left += 6;
                if (picprz2.Left > 930)
                {
                    timerzlpro2.Enabled = false;
                    picprz2.Location = new Point(48, 305);
                }
            }
            if (picprz2.Left > piccr.Left - 10 && picprz2.Left < piccr.Left + 40)
            {
                if (picprz2.Top > piccr.Top - 10 && picprz2.Top < piccr.Top + 40)
                {
                    KrajZ();
                }
            }
        }

        private void timerzlpro3_Tick(object sender, EventArgs e)//zeleni
        {
            if (orjentacija13 == "gore")
            {
                picprz3.Top -= 6;
                if (picprz3.Top < 120)
                {
                    timerzlpro3.Enabled = false;
                    picprz3.Location = new Point(64, 305);
                }
            }
            if (orjentacija13 == "dolje")
            {
                picprz3.Top += 6;
                if (picprz3.Top > 520)
                {
                    timerzlpro3.Enabled = false;
                    picprz3.Location = new Point(64, 305);
                }
            }
            if (orjentacija13 == "lijevo")
            {
                picprz3.Left -= 6;
                if (picprz3.Left < 180)
                {
                    timerzlpro3.Enabled = false;
                    picprz3.Location = new Point(64, 305);
                }
            }
            if (orjentacija13 == "desno")
            {
                picprz3.Left += 6;
                if (picprz3.Left > 930)
                {
                    timerzlpro3.Enabled = false;
                    picprz3.Location = new Point(64, 305);
                }
            }
            if (picprz3.Left > piccr.Left - 10 && picprz3.Left < piccr.Left + 40)
            {
                if (picprz3.Top > piccr.Top - 10 && picprz3.Top < piccr.Top + 40)
                {
                    KrajZ();
                }
            }
        }

        private void timerzlpro4_Tick(object sender, EventArgs e)//zeleni
        {
            if (orjentacija14 == "gore")
            {
                picprz4.Top -= 6;
                if (picprz4.Top < 120)
                {
                    timerzlpro4.Enabled = false;
                    picprz4.Location = new Point(80, 305);
                }
            }
            if (orjentacija14 == "dolje")
            {
                picprz4.Top += 6;
                if (picprz4.Top > 520)
                {
                    timerzlpro4.Enabled = false;
                    picprz4.Location = new Point(80, 305);
                }
            }
            if (orjentacija14 == "lijevo")
            {
                picprz4.Left -= 6;
                if (picprz4.Left < 180)
                {
                    timerzlpro4.Enabled = false;
                    picprz4.Location = new Point(80, 305);
                }
            }
            if (orjentacija14 == "desno")
            {
                picprz4.Left += 6;
                if (picprz4.Left > 930)
                {
                    timerzlpro4.Enabled = false;
                    picprz4.Location = new Point(80, 305);
                }
            }
            if (picprz4.Left > piccr.Left - 10 && picprz4.Left < piccr.Left + 40)
            {
                if (picprz4.Top > piccr.Top - 10 && picprz4.Top < piccr.Top + 40)
                {
                    KrajZ();
                }
            }
        }

        private void timerzlpro5_Tick(object sender, EventArgs e)//zeleni
        {
            if (orjentacija15 == "gore")
            {
                picprz5.Top -= 6;
                if (picprz5.Top < 120)
                {
                    timerzlpro5.Enabled = false;
                    picprz5.Location = new Point(96, 305);
                }
            }
            if (orjentacija15 == "dolje")
            {
                picprz5.Top += 6;
                if (picprz5.Top > 520)
                {
                    timerzlpro5.Enabled = false;
                    picprz5.Location = new Point(96, 305);
                }
            }
            if (orjentacija15 == "lijevo")
            {
                picprz5.Left -= 6;
                if (picprz5.Left < 180)
                {
                    timerzlpro5.Enabled = false;
                    picprz5.Location = new Point(96, 305);
                }
            }
            if (orjentacija15 == "desno")
            {
                picprz5.Left += 6;
                if (picprz5.Left > 930)
                {
                    timerzlpro5.Enabled = false;
                    picprz5.Location = new Point(96, 305);
                }
            }
            if (picprz5.Left > piccr.Left - 10 && picprz5.Left < piccr.Left + 40)
            {
                if (picprz5.Top > piccr.Top - 10 && picprz5.Top < piccr.Top + 40)
                {
                    KrajZ();
                }
            }
        }

        private void piccrbam_Click(object sender, EventArgs e)//crveni projektili botun
        {
            
            if (cpro >= 5)
            {
                cpro = 0;
            }
            if (orjentacija2 != null && igra == true)
            {
                
                if (cpro == 0 && picprc1.Left == 1027 && picprc1.Top == 281)
                {
                    timercrpro1.Enabled = true;
                    picprc1.Location = s1.Location;
                    orjentacija21 = orjentacija2;
                }
                if (cpro == 1 && picprc2.Left == 1043 && picprc2.Top == 281)
                {
                    timercrpro2.Enabled = true;
                    picprc2.Location = s1.Location;
                    orjentacija22 = orjentacija2;
                }
                if (cpro == 2 && picprc3.Left == 1059 && picprc3.Top == 281)
                {
                    timercrpro3.Enabled = true;
                    picprc3.Location = s1.Location;
                    orjentacija23 = orjentacija2;
                }
                if (cpro == 3 && picprc4.Left == 1075 && picprc4.Top == 281)
                {
                    timercrpro4.Enabled = true;
                    picprc4.Location = s1.Location;
                    orjentacija24 = orjentacija2;
                }
                if (cpro == 4 && picprc5.Left == 1091 && picprc5.Top == 281)
                {
                    timercrpro5.Enabled = true;
                    picprc5.Location = s1.Location;
                    orjentacija25 = orjentacija2;
                }
                cpro += 1;
            }
        }

        private void timercrpro1_Tick(object sender, EventArgs e)
        {
            if (orjentacija21 == "gore")
            {
                picprc1.Top -= 6;
                if (picprc1.Top < 120)
                {
                    timercrpro1.Enabled = false;
                    picprc1.Location = new Point(1027, 281);
                }
            }
            if (orjentacija21 == "dolje")
            {
                picprc1.Top += 6;
                if (picprc1.Top > 520)
                {
                    timercrpro1.Enabled = false;
                    picprc1.Location = new Point(1027, 281);
                }
            }
            if (orjentacija21 == "lijevo")
            {
                picprc1.Left -= 6;
                if (picprc1.Left < 180)
                {
                    timercrpro1.Enabled = false;
                    picprc1.Location = new Point(1027, 281);
                }
            }
            if (orjentacija21 == "desno")
            {
                picprc1.Left += 6;
                if (picprc1.Left > 930)
                {
                    timercrpro1.Enabled = false;
                    picprc1.Location = new Point(1027, 281);
                }
            }
            if (picprc1.Left > piczl.Left - 10 && picprc1.Left < piczl.Left + 40)
            {
                if (picprc1.Top > piczl.Top - 10 && picprc1.Top < piczl.Top + 40)
                {
                    KrajC();
                }
            }
        }

        private void timercrpro2_Tick(object sender, EventArgs e)
        {
            if (orjentacija22 == "gore")
            {
                picprc2.Top -= 6;
                if (picprc2.Top < 120)
                {
                    timercrpro2.Enabled = false;
                    picprc2.Location = new Point(1043, 281);
                }
            }
            if (orjentacija22 == "dolje")
            {
                picprc2.Top += 6;
                if (picprc2.Top > 520)
                {
                    timercrpro2.Enabled = false;
                    picprc2.Location = new Point(1043, 281);
                }
            }
            if (orjentacija22 == "lijevo")
            {
                picprc2.Left -= 6;
                if (picprc2.Left < 180)
                {
                    timercrpro2.Enabled = false;
                    picprc2.Location = new Point(1043, 281);
                }
            }
            if (orjentacija22 == "desno")
            {
                picprc2.Left += 6;
                if (picprc2.Left > 930)
                {
                    timercrpro2.Enabled = false;
                    picprc2.Location = new Point(1043, 281);
                }
            }
            if (picprc2.Left > piczl.Left - 10 && picprc2.Left < piczl.Left + 40)
            {
                if (picprc2.Top > piczl.Top - 10 && picprc2.Top < piczl.Top + 40)
                {
                    KrajC();
                }
            }
        }

        private void timercrpro3_Tick(object sender, EventArgs e)
        {
            if (orjentacija23 == "gore")
            {
                picprc3.Top -= 6;
                if (picprc3.Top < 120)
                {
                    timercrpro3.Enabled = false;
                    picprc3.Location = new Point(1059, 281);
                }
            }
            if (orjentacija23 == "dolje")
            {
                picprc3.Top += 6;
                if (picprc3.Top > 520)
                {
                    timercrpro3.Enabled = false;
                    picprc3.Location = new Point(1059, 281);
                }
            }
            if (orjentacija23 == "lijevo")
            {
                picprc3.Left -= 6;
                if (picprc3.Left < 180)
                {
                    timercrpro3.Enabled = false;
                    picprc3.Location = new Point(1059, 281);
                }
            }
            if (orjentacija23 == "desno")
            {
                picprc3.Left += 6;
                if (picprc3.Left > 930)
                {
                    timercrpro3.Enabled = false;
                    picprc3.Location = new Point(1059, 281);
                }
            }
            if (picprc3.Left > piczl.Left - 10 && picprc3.Left < piczl.Left + 40)
            {
                if (picprc3.Top > piczl.Top - 10 && picprc3.Top < piczl.Top + 40)
                {
                    KrajC();
                }
            }
        }

        private void timercrpro4_Tick(object sender, EventArgs e)
        {
            if (orjentacija24 == "gore")
            {
                picprc4.Top -= 6;
                if (picprc4.Top < 120)
                {
                    timercrpro4.Enabled = false;
                    picprc4.Location = new Point(1075, 281);
                }
            }
            if (orjentacija24 == "dolje")
            {
                picprc4.Top += 6;
                if (picprc4.Top > 520)
                {
                    timercrpro4.Enabled = false;
                    picprc4.Location = new Point(1075, 281);
                }
            }
            if (orjentacija24 == "lijevo")
            {
                picprc4.Left -= 6;
                if (picprc4.Left < 180)
                {
                    timercrpro4.Enabled = false;
                    picprc4.Location = new Point(1075, 281);
                }
            }
            if (orjentacija24 == "desno")
            {
                picprc4.Left += 6;
                if (picprc4.Left > 930)
                {
                    timercrpro4.Enabled = false;
                    picprc4.Location = new Point(1075, 281);
                }
            }
            if (picprc4.Left > piczl.Left - 10 && picprc4.Left < piczl.Left + 40)
            {
                if (picprc4.Top > piczl.Top - 10 && picprc4.Top < piczl.Top + 40)
                {
                    KrajC();
                }
            }
        }

        private void timercrpro5_Tick(object sender, EventArgs e)
        {
            if (orjentacija25 == "gore")
            {
                picprc5.Top -= 6;
                if (picprc5.Top < 120)
                {
                    timercrpro5.Enabled = false;
                    picprc5.Location = new Point(1091, 281);
                }
            }
            if (orjentacija25 == "dolje")
            {
                picprc5.Top += 6;
                if (picprc5.Top > 520)
                {
                    timercrpro5.Enabled = false;
                    picprc5.Location = new Point(1091, 281);
                }
            }
            if (orjentacija25 == "lijevo")
            {
                picprc5.Left -= 6;
                if (picprc5.Left < 180)
                {
                    timercrpro5.Enabled = false;
                    picprc5.Location = new Point(1091, 281);
                }
            }
            if (orjentacija25 == "desno")
            {
                picprc5.Left += 6;
                if (picprc5.Left > 930)
                {
                    timercrpro5.Enabled = false;
                    picprc5.Location = new Point(1091, 281);
                }
            }
            if (picprc5.Left > piczl.Left - 10 && picprc5.Left < piczl.Left + 40)
            {
                if (picprc5.Top > piczl.Top - 10 && picprc5.Top < piczl.Top + 40)
                {
                    KrajC();
                }
            }
        }

        

        


        

        

        

        


        
        

        

        

        

        
    }
}
