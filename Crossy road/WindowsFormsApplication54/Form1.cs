using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication54
{
    public partial class Form1 : Form
    {
        string orjentacija1 = "desno";
        string orjentacija2 = "lijevo";
        string orjentacija3 = "lijevo";
        string orjentacija4 = "desno";
        bool prva_nagrada = false;
        bool druga_nagrada = false;
        bool treca_nagrada = false;
        int score = 0;
        int x = 7;//kolikp ce se brzo kretat
        int interval = 40;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)// za prvu cestu
        {
            if (orjentacija1 == "desno")//krece se u desno
            {
                auto1.Left += x;
                if (auto1.Left > 390)
                {
                    orjentacija1 = "lijevo";
                    auto1.BackgroundImage = Properties.Resources.crauto2;//mijenja sliku auta
                }
            }
            if (orjentacija1 == "lijevo")//krece se u lijevo
            {
                auto1.Left -= x;
                if (auto1.Left < 120)
                {
                    orjentacija1 = "desno";
                    auto1.BackgroundImage = Properties.Resources.crauto1;//mijenja sliku auta
                }
            }
            if (igrac.Top < auto1.Top + 35 && igrac.Top + 29 > auto1.Top)
            {
                if (auto1.Left + 55 > 250 && auto1.Left + 55 < 280)
                {
                    Kraj();
                }
                if(auto1.Left<280 && auto1.Left>250)
                {
                    Kraj();
                }
                
              
            }
        }


        private void btgori_MouseDown(object sender, MouseEventArgs e)//kada se drži botun timer za kretanje je true
        {
            timer_kretanje_gori.Enabled = true;
        }

        private void btgori_MouseUp(object sender, MouseEventArgs e)//kada se pusti je false
        {
            timer_kretanje_gori.Enabled = false;
        }

        private void timer_kretanje_gori_Tick(object sender, EventArgs e)
        {
            if (igrac.Top > 44)//ograničavamo dokle se može kretati
            {
                igrac.Top -= 7;
            }
            if (igrac.Top < 340 && igrac.Top > 330 && prva_nagrada== false)
            {
                score += 1;
                prva_nagrada = true;
                bt_score.Text = score.ToString();
            }
            if (igrac.Top < 250 && igrac.Top > 230 && druga_nagrada == false)
            {
                score += 1;
                druga_nagrada = true;
                bt_score.Text = score.ToString();
            }
            if (igrac.Top < 160 && igrac.Top > 140 && treca_nagrada == false)
            {
                score += 1;
                treca_nagrada = true;
                bt_score.Text = score.ToString();
            }
            if (igrac.Top < 60 && igrac.Top > 50)
            {
                score += 1;
                bt_score.Text = score.ToString();
                prva_nagrada = false;
                druga_nagrada = false;
                treca_nagrada = false;
                igrac.Location = new Point(250, 417);
                if (x < 14)
                {
                    x += 1;
                }
                if (interval > 30)
                {
                    interval -= 2;
                }
                timer1.Interval = interval;
                timer2.Interval = interval;
                timer3.Interval = interval;
                timer4.Interval = interval;
            }

        }

        private void btdoli_MouseDown(object sender, MouseEventArgs e)//kada se drži botun timer za kretanje je true
        {
            timer_kretanje_doli.Enabled = true;
        }

        private void btdoli_MouseUp(object sender, MouseEventArgs e)//kada se pusti je false
        {
            timer_kretanje_doli.Enabled = false;
        }

        private void timer_kretanje_doli_Tick(object sender, EventArgs e)
        {
            if (igrac.Top < 415)//ograničavamo dokle se može kretati
            {
                igrac.Top += 7;
            }
        }
        private void Kraj()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer_kretanje_gori.Enabled = false;
            timer_kretanje_doli.Enabled = false;
            btdoli.Enabled = false;
            btgori.Enabled = false;
            btovr.Visible = true;
            
        }

        private void timer2_Tick(object sender, EventArgs e)//druga cesta
        {
            if (orjentacija2 == "desno")//krece se u desno
            {
                auto2.Left += x;
                if (auto2.Left > 390)
                {
                    orjentacija2 = "lijevo";
                    auto2.BackgroundImage = Properties.Resources.plauto2;//mijenja sliku auta
                }
            }
            if (orjentacija2 == "lijevo")//krece se u lijevo
            {
                auto2.Left -= x;
                if (auto2.Left < 120)
                {
                    orjentacija2 = "desno";
                    auto2.BackgroundImage = Properties.Resources.plauto1;//mijenja sliku auta
                }
            }
            if (igrac.Top < auto2.Top + 35 && igrac.Top + 29 > auto2.Top)
            {
                if (auto2.Left + 55 > 250 && auto2.Left + 55 < 280)
                {
                    Kraj();
                }
                if (auto2.Left < 280 && auto2.Left > 250)
                {
                    Kraj();
                }


            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (orjentacija3 == "desno")//krece se u desno
            {
                auto3.Left += x;
                if (auto3.Left > 390)
                {
                    orjentacija3 = "lijevo";
                    auto3.BackgroundImage = Properties.Resources.nrauto2;//mijenja sliku auta
                }
            }
            if (orjentacija3 == "lijevo")//krece se u lijevo
            {
                auto3.Left -= x;
                if (auto3.Left < 120)
                {
                    orjentacija3 = "desno";
                    auto3.BackgroundImage = Properties.Resources.nrauto1;//mijenja sliku auta
                }
            }
            if (igrac.Top < auto3.Top + 35 && igrac.Top + 29 > auto3.Top)
            {
                if (auto3.Left + 55 > 250 && auto3.Left + 55 < 280)
                {
                    Kraj();
                }
                if (auto3.Left < 280 && auto3.Left > 250)
                {
                    Kraj();
                }


            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (orjentacija4 == "desno")//krece se u desno
            {
                auto4.Left += x;
                if (auto4.Left > 390)
                {
                    orjentacija4 = "lijevo";
                    auto4.BackgroundImage = Properties.Resources.ztauto2;//mijenja sliku auta
                }
            }
            if (orjentacija4 == "lijevo")//krece se u lijevo
            {
                auto4.Left -= x;
                if (auto4.Left < 120)
                {
                    orjentacija4 = "desno";
                    auto4.BackgroundImage = Properties.Resources.ztauto1;//mijenja sliku auta
                }
            }
            if (igrac.Top < auto4.Top + 35 && igrac.Top + 29 > auto4.Top)
            {
                if (auto4.Left + 55 > 250 && auto4.Left + 55 < 280)
                {
                    Kraj();
                }
                if (auto4.Left < 280 && auto4.Left > 250)
                {
                    Kraj();
                }


            }
        }

        private void bt_nova_igra_Click(object sender, EventArgs e)
        {
            btovr.Visible = false;
            auto1.Location = new Point(116, 367);
            auto2.Location = new Point(393, 283);
            auto3.Location = new Point(289, 191);
            auto4.Location = new Point(148, 102);
            orjentacija1 = "desno";
            orjentacija2 = "lijevo";
            orjentacija3 = "lijevo";
            orjentacija4 = "desno";
            auto1.BackgroundImage = Properties.Resources.crauto1;
            auto2.BackgroundImage = Properties.Resources.plauto2;
            auto3.BackgroundImage = Properties.Resources.nrauto2;
            auto4.BackgroundImage = Properties.Resources.ztauto1;
            igrac.Location = new Point(250, 417);
            score = 0;
            bt_score.Text = "0";
            prva_nagrada = false;
            druga_nagrada = false;
            treca_nagrada = false;
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            btgori.Enabled = true;
            btdoli.Enabled = false;
            richTextBox1.Text = "Igrači";
            richTextBox2.Text = "Rezultati";
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            label2.Visible = false;
            
        }
        
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        

        
    }
}
