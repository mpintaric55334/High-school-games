using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace WindowsFormsApplication34
{
    public partial class Form1 : Form
    {
        int zbrajac=0;
        int i=0;
        int score;
        int j;
        int bio = 0;
        int odabrani = 0;
        bool speak = false;
        Random random = new Random();
        int lista_broj = 0;
        int[] lista1 = new int[4];
        int[] lista2 = new int[4];
        int[] lista3 = new int[4];
        int[] lista4 = new int[4];
        
        
        
        
        public Form1()
        {
            InitializeComponent();
        }
        private void NovaIgra()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer5.Enabled = false;
            j = 0;
            for (i = 1; i < 5; i++)
            {
                lista1[j] = i;
                j += 1;
            }
            j = 0;
            for (i = 5; i < 9; i++)
            {
                lista2[j] = i;
                j += 1;
            }
            
            j = 0;
            for (i = 9; i < 13; i++)
            {
                lista3[j] = i;
                j += 1;
            }
            j = 0;
            for (i = 13; i < 17; i++)
            {
                lista4[j] = i;
                j += 1;
            }
            j = 0;
            
            
            
            

            

        }
            


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (zbrajac < 15)
            {
                picBird.Top -= 8;
                zbrajac += 1;
            }
            if (zbrajac == 14)
            {
                timer1.Enabled = false;
                zbrajac = 0;
            }
            
        }

        private void btskoc_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            
            
            
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            picBird.Top += 7;
            if (picBird.Top >= 630)
                btovr.Visible=true;
            lascore.Text = (score / 90).ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            bt1.Left -= 5;
            bt2.Left -= 5;
            if (bt1.Left < 60)
            {
                bt1.Visible = false;
                bt2.Visible = false;
                timer3.Enabled = false;
            }
            if (bt2.Left>=150&&bt2.Left<=220)
            {
                if (picBird.Top < 330)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 410)
                {
                    btovr.Visible=true;
                }
                score += 5;
            }
            if (bt1.Left >= 150 && bt1.Left <= 220)
            {
                if (picBird.Top < 330)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 410)
                {
                    btovr.Visible=true;
                }
                score += 5;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            bt3.Left -= 5;
            bt4.Left -= 5;
            if (bt3.Left < 60)
            {
                bt3.Visible = false;
                bt4.Visible = false;
                timer4.Enabled = false;
            }
            if (bt4.Left >= 150 && bt4.Left <= 220)
            {
                if (picBird.Top < 260)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 325)
                {
                    btovr.Visible=true;
                }
                score += 5;

            }
            if (bt3.Left >= 150 && bt3.Left <= 220)
            {
                if (picBird.Top < 260)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 325)
                {
                    btovr.Visible=true;
                }
                score += 5;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NovaIgra();
            
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (j == 0)
            {
                odabrani = (random.Next(4));
                if (lista1[odabrani] == 1)
                {
                    bt1.Visible = true;
                    bt2.Visible = true;
                    bt1.Location = new Point(785, 435);
                    bt2.Location = new Point(785, 12);
                    timer3.Enabled = true;
                }
                if (lista1[odabrani] == 2)
                {
                    bt3.Visible = true;
                    bt4.Visible = true;
                    bt3.Location = new Point(785, 349);
                    bt4.Location = new Point(785, 12);
                    timer4.Enabled = true;

                }
                if (lista1[odabrani] == 3)
                {
                    bt5.Visible = true;
                    bt6.Visible = true;
                    bt5.Location = new Point(785, 537);
                    bt6.Location = new Point(785, 12);
                    timer6.Enabled = true;

                }
                if (lista1[odabrani] == 4)
                {
                    bt7.Visible = true;
                    bt8.Visible = true;
                    bt7.Location = new Point(785, 282);
                    bt8.Location = new Point(785, 12);
                    timer7.Enabled = true;


                }
            }
            if (j == 1)
            {
                odabrani = (random.Next(4));
                if (lista2[odabrani] == 5)
                {
                    bt9.Visible = true;
                    bt10.Visible = true;
                    bt9.Location = new Point(785, 435);
                    bt10.Location = new Point(785, 12);
                    timer8.Enabled = true;
                }
                if (lista2[odabrani] == 6)
                {
                    bt11.Visible = true;
                    bt12.Visible = true;
                    bt11.Location = new Point(785, 349);
                    bt12.Location = new Point(785, 12);
                    timer11.Enabled = true;

                }
                if (lista2[odabrani] == 7)
                {
                    bt13.Visible = true;
                    bt14.Visible = true;
                    bt13.Location = new Point(785, 537);
                    bt14.Location = new Point(785, 12);
                    timer14.Enabled = true;

                }
                if (lista2[odabrani] == 8)
                {
                    bt15.Visible = true;
                    bt16.Visible = true;
                    bt15.Location = new Point(785, 282);
                    bt16.Location = new Point(785, 12);
                    timer17.Enabled = true;


                }
            }
            if (j == 2)
            {
                odabrani = (random.Next(4));
                if (lista3[odabrani] == 9)
                {
                    bt17.Visible = true;
                    bt18.Visible = true;
                    bt17.Location = new Point(785, 435);
                    bt18.Location = new Point(785, 12);
                    timer10.Enabled = true;
                }
                if (lista3[odabrani] == 10)
                {
                    bt19.Visible = true;
                    bt20.Visible = true;
                    bt19.Location = new Point(785, 349);
                    bt20.Location = new Point(785, 12);
                    timer12.Enabled = true;

                }
                if (lista3[odabrani] == 11)
                {
                    bt21.Visible = true;
                    bt22.Visible = true;
                    bt21.Location = new Point(785, 537);
                    bt22.Location = new Point(785, 12);
                    timer15.Enabled = true;

                }
                if (lista3[odabrani] == 12)
                {
                    bt23.Visible = true;
                    bt24.Visible = true;
                    bt23.Location = new Point(785, 282);
                    bt24.Location = new Point(785, 12);
                    timer18.Enabled = true;


                }
            }
            if (j == 3)
            {
                odabrani = (random.Next(4));
                if (lista4[odabrani] == 13)
                {
                    bt25.Visible = true;
                    bt26.Visible = true;
                    bt25.Location = new Point(785, 435);
                    bt26.Location = new Point(785, 12);
                    timer9.Enabled = true;
                }
                if (lista4[odabrani] == 14)
                {
                    bt27.Visible = true;
                    bt28.Visible = true;
                    bt27.Location = new Point(785, 349);
                    bt28.Location = new Point(785, 12);
                    timer13.Enabled = true;

                }
                if (lista4[odabrani] == 15)
                {
                    bt29.Visible = true;
                    bt30.Visible = true;
                    bt29.Location = new Point(785, 537);
                    bt30.Location = new Point(785, 12);
                    timer16.Enabled = true;

                }
                if (lista4[odabrani] == 16)
                {
                    bt31.Visible = true;
                    bt32.Visible = true;
                    bt31.Location = new Point(785, 282);
                    bt32.Location = new Point(785, 12);
                    timer19.Enabled = true;


                }
            }
                
            
            j+=1;
            if (j == 4)
                j = 0;

            


                

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            bt5.Left -= 5;
            bt6.Left -= 5;
            if (bt5.Left < 60)
            {
                bt5.Visible = false;
                bt6.Visible = false;
                timer6.Enabled = false;
            }
            if (bt6.Left >= 150 && bt6.Left <= 220)
            {
                if (picBird.Top < 440)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 510)
                {
                    btovr.Visible=true;
                }
                score += 5;

            }
            if (bt5.Left >= 150 && bt5.Left <= 220)
            {
                if (picBird.Top < 440)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 510)
                {
                    btovr.Visible=true;
                }
                score += 5;
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            bt7.Left -= 5;
            bt8.Left -= 5;
            if (bt7.Left < 60)
            {
                bt7.Visible = false;
                bt8.Visible = false;
                timer7.Enabled = false;
            }
            if (bt8.Left >= 150 && bt8.Left <= 220)
            {
                if (picBird.Top < 190)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 260)
                {
                    btovr.Visible=true;
                }
                score += 5;

            }
            if (bt7.Left >= 150 && bt7.Left <= 220)
            {
                if (picBird.Top < 190)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 260)
                {
                    btovr.Visible=true;
                }
                score += 5;
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            bt9.Left -= 5;
            bt10.Left -= 5;
            if (bt10.Left < 60)
            {
                bt9.Visible = false;
                bt10.Visible = false;
                timer8.Enabled = false;
            }
            if (bt9.Left >= 150 && bt9.Left <= 220)
            {
                if (picBird.Top < 330)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 410)
                {
                    btovr.Visible=true;
                }
                score += 5;
            }
            if (bt10.Left >= 150 && bt10.Left <= 220)
            {
                if (picBird.Top < 330)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 410)
                {
                    btovr.Visible=true;
                }
                
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            bt18.Left -= 5;
            bt17.Left -= 5;
            if (bt17.Left < 60)
            {
                bt17.Visible = false;
                bt18.Visible = false;
                timer10.Enabled = false;
            }
            if (bt18.Left >= 150 && bt18.Left <= 220)
            {
                if (picBird.Top < 330)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 410)
                {
                    btovr.Visible=true;
                }
                score += 5;
            }
            if (bt17.Left >= 150 && bt17.Left <= 220)
            {
                if (picBird.Top < 330)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 410)
                {
                    btovr.Visible=true;
                }
                
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            bt25.Left -= 5;
            bt26.Left -= 5;
            if (bt25.Left < 60)
            {
                bt25.Visible = false;
                bt26.Visible = false;
                timer9.Enabled = false;
            }
            if (bt25.Left >= 150 && bt25.Left <= 220)
            {
                if (picBird.Top < 330)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 410)
                {
                    btovr.Visible=true;
                }
                score += 5;
            }
            if (bt26.Left >= 150 && bt26.Left <= 220)
            {
                if (picBird.Top < 330)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 410)
                {
                    btovr.Visible=true;
                }
                score += 5;
            }
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            bt11.Left -= 5;
            bt12.Left -= 5;
            if (bt11.Left < 60)
            {
                bt11.Visible = false;
                bt12.Visible = false;
                timer11.Enabled = false;
            }
            if (bt11.Left >= 150 && bt11.Left <= 220)
            {
                if (picBird.Top < 260)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 325)
                {
                    btovr.Visible=true;
                }
                score += 5;

            }
            if (bt12.Left >= 150 && bt12.Left <= 220)
            {
                if (picBird.Top < 260)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 325)
                {
                    btovr.Visible=true;
                }
                
            }
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            bt19.Left -= 5;
            bt20.Left -= 5;
            if (bt19.Left < 60)
            {
                bt19.Visible = false;
                bt20.Visible = false;
                timer12.Enabled = false;
            }
            if (bt19.Left >= 150 && bt19.Left <= 220)
            {
                if (picBird.Top < 260)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 325)
                {
                    btovr.Visible=true;
                }
                score += 5;

            }
            if (bt20.Left >= 150 && bt20.Left <= 220)
            {
                if (picBird.Top < 260)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 325)
                {
                    btovr.Visible=true;
                }
                
            }
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            bt27.Left -= 5;
            bt28.Left -= 5;
            if (bt27.Left < 60)
            {
                bt27.Visible = false;
                bt28.Visible = false;
                timer13.Enabled = false;
            }
            if (bt28.Left >= 150 && bt28.Left <= 220)
            {
                if (picBird.Top < 260)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 325)
                {
                    btovr.Visible=true;
                }
                score += 5;

            }
            if (bt27.Left >= 150 && bt27.Left <= 220)
            {
                if (picBird.Top < 260)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 325)
                {
                    btovr.Visible=true;
                }
                score += 5;
            }
        }

        private void timer14_Tick(object sender, EventArgs e)
        {
            bt13.Left -= 5;
            bt14.Left -= 5;
            if (bt13.Left < 60)
            {
                bt13.Visible = false;
                bt14.Visible = false;
                timer14.Enabled = false;
            }
            if (bt13.Left >= 150 && bt13.Left <= 220)
            {
                if (picBird.Top < 440)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 510)
                {
                    btovr.Visible=true;
                }
                score += 5;

            }
            if (bt14.Left >= 150 && bt14.Left <= 220)
            {
                if (picBird.Top < 440)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 510)
                {
                    btovr.Visible=true;
                }
                
            }
        }

        private void timer15_Tick(object sender, EventArgs e)
        {
            bt21.Left -= 5;
            bt22.Left -= 5;
            if (bt21.Left < 60)
            {
                bt21.Visible = false;
                bt22.Visible = false;
                timer15.Enabled = false;
            }
            if (bt21.Left >= 150 && bt21.Left <= 220)
            {
                if (picBird.Top < 440)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 510)
                {
                    btovr.Visible=true;
                }
                score += 5;

            }
            if (bt22.Left >= 150 && bt22.Left <= 220)
            {
                if (picBird.Top < 440)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 510)
                {
                    btovr.Visible=true;
                }
                
            }
        }

        private void timer16_Tick(object sender, EventArgs e)
        {
            bt29.Left -= 5;
            bt30.Left -= 5;
            if (bt29.Left < 60)
            {
                bt29.Visible = false;
                bt30.Visible = false;
                timer16.Enabled = false;
            }
            if (bt29.Left >= 150 && bt29.Left <= 220)
            {
                if (picBird.Top < 440)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 510)
                {
                    btovr.Visible=true;
                }
                score += 5;

            }
            if (bt30.Left >= 150 && bt30.Left <= 220)
            {
                if (picBird.Top < 440)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 510)
                {
                    btovr.Visible=true;
                }
                score += 5;
            }
        }

        private void timer17_Tick(object sender, EventArgs e)
        {
            bt15.Left -= 5;
            bt16.Left -= 5;
            if (bt15.Left < 60)
            {
                bt15.Visible = false;
                bt16.Visible = false;
                timer17.Enabled = false;
            }
            if (bt16.Left >= 150 && bt16.Left <= 220)
            {
                if (picBird.Top < 190)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 260)
                {
                    btovr.Visible=true;
                }
                score += 5;

            }
            if (bt15.Left >= 150 && bt15.Left <= 220)
            {
                if (picBird.Top < 190)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 260)
                {
                    btovr.Visible=true;
                }
                
            }
        }

        private void timer18_Tick(object sender, EventArgs e)
        {
            bt23.Left -= 5;
            bt24.Left -= 5;
            if (bt23.Left < 60)
            {
                bt23.Visible = false;
                bt24.Visible = false;
                timer18.Enabled = false;
            }
            if (bt23.Left >= 150 && bt23.Left <= 220)
            {
                if (picBird.Top < 190)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 260)
                {
                    btovr.Visible=true;
                }
                score += 5;

            }
            if (bt24.Left >= 150 && bt24.Left <= 220)
            {
                if (picBird.Top < 190)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 260)
                {
                    btovr.Visible=true;
                }
                
            }
        }

        private void timer19_Tick(object sender, EventArgs e)
        {
            bt31.Left -= 5;
            bt32.Left -= 5;
            if (bt31.Left < 60)
            {
                bt31.Visible = false;
                bt32.Visible = false;
                timer19.Enabled = false;
            }
            if (bt31.Left >= 150 && bt31.Left <= 220)
            {
                if (picBird.Top < 190)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 260)
                {
                    btovr.Visible=true;
                }
                score += 5;

            }
            if (bt32.Left >= 150 && bt32.Left <= 220)
            {
                if (picBird.Top < 190)
                {
                    btovr.Visible=true;
                }
                if (picBird.Top > 260)
                {
                    btovr.Visible=true;
                }
                score += 5;
            }
        }

        private void timer20_Tick(object sender, EventArgs e)
        {
            if (btovr.Visible == true)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                timer6.Enabled = false;
                timer7.Enabled = false;
                timer8.Enabled = false;
                timer9.Enabled = false;
                timer10.Enabled = false;
                timer11.Enabled = false;
                timer12.Enabled = false;
                timer13.Enabled = false;
                timer14.Enabled = false;
                timer15.Enabled = false;
                timer16.Enabled = false;
                timer17.Enabled = false;
                timer18.Enabled = false;
                timer19.Enabled = false;
                btskoc.Enabled = false;
                
                bt1.Visible = false;
                bt2.Visible = false;
                bt3.Visible = false;
                bt4.Visible = false;
                bt5.Visible = false;
                bt6.Visible = false;
                bt7.Visible = false;
                bt8.Visible = false;
                bt9.Visible = false;
                bt10.Visible = false;
                bt11.Visible = false;
                bt12.Visible = false;
                bt13.Visible = false;
                bt14.Visible = false;
                bt15.Visible = false;
                bt16.Visible = false;
                bt17.Visible = false;
                bt18.Visible = false;
                bt19.Visible = false;
                bt20.Visible = false;
                bt21.Visible = false;
                bt22.Visible = false;
                bt23.Visible = false;
                bt24.Visible = false;
                bt25.Visible = false;
                bt26.Visible = false;
                bt27.Visible = false;
                bt28.Visible = false;
                bt29.Visible = false;
                bt30.Visible = false;
                bt31.Visible = false;
                bt32.Visible = false;
                
                
                
            }
        }

        private void btnov_Click(object sender, EventArgs e)
        {
            timer20.Enabled = true;
            btskoc.Enabled = true;
            btovr.Visible = false;
            
            timer2.Enabled = true;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = true;
            timer6.Enabled = false;
            timer7.Enabled = false;
            timer8.Enabled = false;
            timer9.Enabled = false;
            timer10.Enabled = false;
            timer11.Enabled = false;
            timer12.Enabled = false;
            timer13.Enabled = false;
            timer14.Enabled = false;
            timer15.Enabled = false;
            timer16.Enabled = false;
            timer17.Enabled = false;
            timer18.Enabled = false;
            timer19.Enabled = false;
            btskoc.Enabled = true;

            bt1.Visible = false;
            bt2.Visible = false;
            bt3.Visible = false;
            bt4.Visible = false;
            bt5.Visible = false;
            bt6.Visible = false;
            bt7.Visible = false;
            bt8.Visible = false;
            bt9.Visible = false;
            bt10.Visible = false;
            bt11.Visible = false;
            bt12.Visible = false;
            bt13.Visible = false;
            bt14.Visible = false;
            bt15.Visible = false;
            bt16.Visible = false;
            bt17.Visible = false;
            bt18.Visible = false;
            bt19.Visible = false;
            bt20.Visible = false;
            bt21.Visible = false;
            bt22.Visible = false;
            bt23.Visible = false;
            bt24.Visible = false;
            bt25.Visible = false;
            bt26.Visible = false;
            bt27.Visible = false;
            bt28.Visible = false;
            bt29.Visible = false;
            bt30.Visible = false;
            bt31.Visible = false;
            bt32.Visible = false;
            i = 0;
            j = 0;
            score = 0;
            lascore.Text = "";
            picBird.Location = new Point(180, 315);
            speak = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }






    }
}
