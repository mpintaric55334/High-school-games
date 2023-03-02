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
        
        bool promijenjen = false;
        int skok=0;
        bool stisnut=true;
        bool odabran=false;
        int i = 0;
        int j = 0;
        int score = 0;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void Kraj()
        {
            timerGravitacija.Enabled = false;
            timer_din_nozice.Enabled = false;
            timerPodloga.Enabled = false;
            timerGlavni.Enabled = false;
            timerSkok.Enabled = false;
            timerK11.Enabled = false;
            timerK12.Enabled = false;
            timerK13.Enabled = false;
            timerK14.Enabled = false;
            timerK21.Enabled = false;
            timerK22.Enabled = false;
            timerK23.Enabled = false;
            timerK24.Enabled = false;
            timer_score.Enabled = false;
            btovr.Visible = true;
            stisnut=true;
            
        }

        private void Start()
        {
            stisnut = false;
            btovr.Visible = false;
            timerK11.Enabled = false;
            timerK12.Enabled = false;
            timerK13.Enabled = false;
            timerK14.Enabled = false;
            timerK21.Enabled = false;
            timerK22.Enabled = false;
            timerK23.Enabled = false;
            timerK24.Enabled = false;
            picK11.Visible = false;
            picK12.Visible = false;
            picK13.Visible = false;
            picK14.Visible = false;
            picK21.Visible = false;
            picK22.Visible = false;
            picK23.Visible = false;
            picK24.Visible = false;
            picK11.Location = new Point(0, 0);
            picK12.Location = new Point(0, 0);
            picK13.Location = new Point(0, 0);
            picK14.Location = new Point(0, 0);
            picK21.Location = new Point(0, 0);
            picK22.Location = new Point(0, 0);
            picK23.Location = new Point(0, 0);
            picK24.Location = new Point(0, 0);
            picDin.Location = new Point(153, 458);
            timerGravitacija.Enabled = true;
            timer_din_nozice.Enabled = true;
            timerPodloga.Enabled = true;
            timerGlavni.Enabled = true;
            timer_score.Enabled = true;
            score = 0;
            lascore.Text = "0";
        }
        private void timer1_Tick(object sender, EventArgs e)//dinosaurove nozice
        {
            if (picDin.AccessibleDescription=="1" && promijenjen==false)
            {
                picDin.BackgroundImage = Properties.Resources.dinosaur2;
                picDin.AccessibleDescription= "2";
                promijenjen = true;
            }
            if (picDin.AccessibleDescription == "2" && promijenjen==false)
            {
                picDin.BackgroundImage = Properties.Resources.dinosaur1;
                picDin.AccessibleDescription = "1";
                promijenjen = true;
            }
            promijenjen = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer_din_nozice.Enabled = true;
        }

        private void timerPodloga_Tick(object sender, EventArgs e)//pomicanje podloge
        {
            picPodloga1.Left -= 10;
            if (picPodloga1.Left < 20)
            {
                picPodloga1.Location = new Point(1150, 513);
            }

            picPodloga2.Left -= 10;
            if (picPodloga2.Left < 20)
            {
                picPodloga2.Location = new Point(1150, 513);
            }

            picPodloga3.Left -= 10;
            if (picPodloga3.Left < 20)
            {
                picPodloga3.Location = new Point(1150, 513);
            }

            picPodloga4.Left -= 10;
            if (picPodloga4.Left < 20)
            {
                picPodloga4.Location = new Point(1150, 513);
            }

            picPodloga5.Left -= 10;
            if (picPodloga5.Left < 20)
            {
                picPodloga5.Location = new Point(1150, 513);
            }

            picPodloga6.Left -= 10;
            if (picPodloga6.Left < 20)
            {
                picPodloga6.Location = new Point(1150, 513);
            }

            picPodloga7.Left -= 10;
            if (picPodloga7.Left < 20)
            {
                picPodloga7.Location = new Point(1150, 513);
            }

            picPodloga8.Left -= 10;
            if (picPodloga8.Left < 20)
            {
                picPodloga8.Location = new Point(1150, 513);
            }

            picPodloga9.Left -= 10;
            if (picPodloga9.Left < 20)
            {
                picPodloga9.Location = new Point(1150, 513);
            }

            picPodloga10.Left -= 10;
            if (picPodloga10.Left < 20)
            {
                picPodloga10.Location = new Point(1150, 513);
            }

            picPodloga11.Left -= 10;
            if (picPodloga11.Left < 20)
            {
                picPodloga11.Location = new Point(1150, 513);
            }
        }

        private void timerGravitacija_Tick(object sender, EventArgs e)//gravitacija
        {
            if (picDin.Top < 458)
            {
                picDin.Top += 6;
            }
        }

        private void timerSkok_Tick(object sender, EventArgs e)//ovo skace
        {
            if (skok <= 30)
            {
                picDin.Top -=12;
                skok += 1;
            }
            if (skok > 30)
            {
                skok = 0;
                timerSkok.Enabled = false;
                stisnut = false;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)//ovo pokrece skakanje i sprecava da se vise puta klikne w
        {
            if (stisnut == false && e.KeyCode == Keys.W && picDin.Top == 458)
            {
                timerSkok.Enabled = true;
                stisnut = true;

            }
            if (e.KeyCode == Keys.Z)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.R)
            {
                Start();
            }
            
                
            
        }

        private void timerK11_Tick(object sender, EventArgs e)//jedn kaktus
        {
            picK11.Left -= 10;
            if (picK11.Left > 116 && picK11.Left < 200)
            {
                if (picDin.Top > 400 && picDin.Top < 460)
                {
                    Kraj();
                }
            }
            if (picK11.Left < 90)
            {
                picK11.Visible = false;
                timerK11.Enabled = false;
            }
        }

        private void timerK21_Tick(object sender, EventArgs e)//dva kaktus
        {
            picK21.Left -= 10;
            if (picK21.Left > 95 && picK21.Left < 215)
            {
                if (picDin.Top > 400 && picDin.Top < 460)
                {
                    Kraj();
                }
            }
            if (picK21.Left < 90)
            {
                picK21.Visible = false;
                timerK21.Enabled = false;
            }
        }

        private void timerK12_Tick(object sender, EventArgs e)//jedn kaktus
        {
            picK12.Left -= 10;
            if (picK12.Left > 116 && picK12.Left < 200)
            {
                if (picDin.Top > 400 && picDin.Top < 460)
                {
                    Kraj();
                }
            }
            if (picK12.Left < 90)
            {
                picK12.Visible = false;
                timerK12.Enabled = false;
            }
        }

        private void timerK13_Tick(object sender, EventArgs e)//jedn kaktus
        {
            picK13.Left -= 10;
            if (picK13.Left > 116 && picK13.Left < 200)
            {
                if (picDin.Top > 400 && picDin.Top < 460)
                {
                    Kraj();
                }
            }
            if (picK13.Left < 90)
            {
                picK13.Visible = false;
                timerK13.Enabled = false;
            }
        }

        private void timerK14_Tick(object sender, EventArgs e)//jedn kaktus
        {
            picK14.Left -= 10;
            if (picK14.Left > 116 && picK14.Left < 200)
            {
                if (picDin.Top > 400 && picDin.Top < 460)
                {
                    Kraj();
                }
            }
            if (picK14.Left < 90)
            {
                picK14.Visible = false;
                timerK14.Enabled = false;
            }
        }

        private void timerK22_Tick(object sender, EventArgs e)
        {
            picK22.Left -= 10;
            if (picK22.Left > 95 && picK22.Left < 215)
            {
                if (picDin.Top > 400 && picDin.Top < 460)
                {
                    Kraj();
                }
            }
            if (picK22.Left < 90)
            {
                picK22.Visible = false;
                timerK22.Enabled = false;
            }
        }

        private void timerK23_Tick(object sender, EventArgs e)
        {
            picK23.Left -= 10;
            if (picK23.Left > 95 && picK23.Left < 215)
            {
                if (picDin.Top > 400 && picDin.Top < 460)
                {
                    Kraj();
                }
            }
            if (picK23.Left < 90)
            {
                picK23.Visible = false;
                timerK23.Enabled = false;
            }
        }

        private void timerK24_Tick(object sender, EventArgs e)
        {
            picK24.Left -= 10;
            if (picK24.Left > 95 && picK24.Left < 215)
            {
                if (picDin.Top > 400 && picDin.Top < 460)
                {
                    Kraj();
                }
            }
            if (picK24.Left < 90)
            {
                picK24.Visible = false;
                timerK24.Enabled = false;
            }
        }

        private void timerGlavni_Tick(object sender, EventArgs e)
        {
            if (j == 0 && odabran == false)
            {
                odabran = true;
                i = random.Next(2);
                if (i == 0)
                {
                    picK11.Location = new Point(1000, 458);
                    picK11.Visible = true;
                    timerK11.Enabled = true;
                }
                if (i == 1)
                {
                    picK21.Location = new Point(1000, 458);
                    picK21.Visible = true;
                    timerK21.Enabled = true;
                }
                j += 1;
            }

            if (j == 1 && odabran == false)
            {
                odabran = true;
                i = random.Next(2);
                if (i == 0)
                {
                    picK12.Location = new Point(1000, 458);
                    picK12.Visible = true;
                    timerK12.Enabled = true;
                }
                if (i == 1)
                {
                    picK22.Location = new Point(1000, 458);
                    picK22.Visible = true;
                    timerK22.Enabled = true;
                }
                j += 1;
            }

            if (j == 2 && odabran == false)
            {
                odabran = true;
                i = random.Next(2);
                if (i == 0)
                {
                    picK13.Location = new Point(1000, 458);
                    picK13.Visible = true;
                    timerK13.Enabled = true;
                }
                if (i == 1)
                {
                    picK23.Location = new Point(1000, 458);
                    picK23.Visible = true;
                    timerK23.Enabled = true;
                }
                j += 1;
            }

            if (j == 3 && odabran == false)
            {
                odabran = true;
                i = random.Next(2);
                if (i == 0)
                {
                    picK14.Location = new Point(1000, 458);
                    picK14.Visible = true;
                    timerK14.Enabled = true;
                }
                if (i == 1)
                {
                    picK24.Location = new Point(1000, 458);
                    picK24.Visible = true;
                    timerK24.Enabled = true;
                }
                j =0;
            }
            odabran = false;
 
        }

        private void timer_score_Tick(object sender, EventArgs e)
        {
            score += 1;
            lascore.Text = score.ToString();
            if (score > 100)
            {
                timer_score.Interval = 175;
                timerPodloga.Interval = 40;
                timerK11.Interval = 40;
                timerK12.Interval = 40;
                timerK13.Interval = 40;
                timerK14.Interval = 40;
                timerK21.Interval = 40;
                timerK22.Interval = 40;
                timerK23.Interval = 40;
                timerK24.Interval = 40;
            }
            if (score > 200)
            {
                timer_score.Interval = 150;
                timerPodloga.Interval = 35;
                timerK11.Interval = 35;
                timerK12.Interval = 35;
                timerK13.Interval = 35;
                timerK14.Interval = 35;
                timerK21.Interval = 35;
                timerK22.Interval = 35;
                timerK23.Interval = 35;
                timerK24.Interval = 35;
            }
            if (score > 300)
            {
                timer_score.Interval = 130;
                timerPodloga.Interval = 30;
                timerK11.Interval = 30;
                timerK12.Interval = 30;
                timerK13.Interval = 30;
                timerK14.Interval = 30;
                timerK21.Interval = 30;
                timerK22.Interval = 30;
                timerK23.Interval = 30;
                timerK24.Interval = 30;
            }
            if (score > 400)
            {
                timer_score.Interval = 100;
                timerPodloga.Interval = 35;
                timerK11.Interval = 25;
                timerK12.Interval = 25;
                timerK13.Interval = 25;
                timerK14.Interval = 25;
                timerK21.Interval = 25;
                timerK22.Interval = 25;
                timerK23.Interval = 25;
                timerK24.Interval = 25;
            }
        }

        


      

        
    }
}
