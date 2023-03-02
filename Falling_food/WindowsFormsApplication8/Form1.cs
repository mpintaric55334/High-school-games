using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        int score = 0;
        int vrijeme = 0;
        int i = 1;
        Random random = new Random();
        int odabrani = 0;
        public Form1()
        {
            InitializeComponent();
            bt11.Click += bt_Click;
            bt12.Click += bt_Click;
            bt13.Click += bt_Click;
            bt14.Click += bt_Click;
            bt21.Click += bt_Click;
            bt22.Click += bt_Click;
            bt23.Click += bt_Click;
            bt24.Click += bt_Click;
            bt31.Click += bt_Click;
            bt32.Click += bt_Click;
            bt33.Click += bt_Click;
            bt34.Click += bt_Click;
            bt41.Click += bt_Click;
            bt42.Click += bt_Click;
            bt43.Click += bt_Click;
            bt44.Click += bt_Click;
            bt51.Click += bt_Click;
            bt52.Click += bt_Click;
            bt53.Click += bt_Click;
            bt54.Click += bt_Click;
        }
        private void Padanje(Button bt)//za svaki botun posebno
        {
            if (bt.AccessibleDescription == "2")//2 će imati hrana
            {
                bt.Top += 6;
                if (bt.Top > 385)
                {
                    bt.AccessibleDescription = "1";//jedan će imati hrana
                    bt.Visible = false;
                    bt.Location = new Point(94, 12);
                }
            }
            if (bt.AccessibleDescription == "3")//3 će imati vino
            {
                bt.Top += 6;
                if (bt.Top > 385)
                {
                    bt.AccessibleDescription = "0";//0 ima vino
                    bt.Visible = false;
                    bt.Location = new Point(94, 12);
                }
            }
        }

        private void timer_skupina1_Tick(object sender, EventArgs e)//jedan timer je za sve(timer_padanja)
        {
            Padanje(bt11);
            Padanje(bt12);
            Padanje(bt13);
            Padanje(bt14);
            Padanje(bt21);
            Padanje(bt22);
            Padanje(bt23);
            Padanje(bt24);
            Padanje(bt31);
            Padanje(bt32);
            Padanje(bt33);
            Padanje(bt34);
            Padanje(bt41);
            Padanje(bt42);
            Padanje(bt43);
            Padanje(bt44);
            Padanje(bt51);
            Padanje(bt52);
            Padanje(bt53);
            Padanje(bt54);
            
        }
        private void bt_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (bt.AccessibleDescription=="2")//ako klikneš na hranu
            {
                bt.Visible=false;
                bt.Location = new Point(94, 12);
                score += 1;
                bt_score.Text = score.ToString();
                bt.AccessibleDescription = "1";
            }
            if (bt.AccessibleDescription == "3")//ako klikneš na nešto što nije hrana
            {
                bt.Visible = false;
                bt.Location = new Point(94, 12);
                score -= 1;
                bt_score.Text = score.ToString();
                bt.AccessibleDescription = "0";
            }
        }

        private void timer_main_Tick(object sender, EventArgs e)
        {
            odabrani = random.Next(5) + 1;
            //prva skupina
            if (odabrani == 1 && i == 1)//prvi
            {
                bt11.Location = new Point(94, 67);
                bt11.AccessibleDescription = "2";
                bt11.Visible = true;
            }
            if (odabrani == 1 && i == 2)//drugi
            {
                bt12.Location = new Point(94, 67);
                bt12.AccessibleDescription = "3";
                bt12.Visible = true;
            }
            if (odabrani == 1 && i == 3)//treci
            {
                bt13.Location = new Point(94, 67);
                bt13.AccessibleDescription = "2";
                bt13.Visible = true;
            }
            if (odabrani == 1 && i == 4)//cetvrti
            {
                bt14.Location = new Point(94, 67);
                bt14.AccessibleDescription = "3";
                bt14.Visible = true;
            }
            //druga skupina
            if (odabrani == 2 && i == 1)//prvi
            {
                bt21.Location = new Point(216, 67);
                bt21.AccessibleDescription = "2";
                bt21.Visible = true;
            }
            if (odabrani == 2 && i == 2)//drugi
            {
                bt22.Location = new Point(216, 67);
                bt22.AccessibleDescription = "3";
                bt22.Visible = true;
            }
            if (odabrani == 2 && i == 3)//treci
            {
                bt23.Location = new Point(216, 67);
                bt23.AccessibleDescription = "2";
                bt23.Visible = true;
            }
            if (odabrani == 2 && i == 4)//cetvrti
            {
                bt24.Location = new Point(216, 67);
                bt24.AccessibleDescription = "3";
                bt24.Visible = true;
            }
            //treca skupina
            if (odabrani == 3 && i == 1)//prvi
            {
                bt31.Location = new Point(352, 67);
                bt31.AccessibleDescription = "2";
                bt31.Visible = true;
            }
            if (odabrani == 3 && i == 2)//drugi
            {
                bt32.Location = new Point(352, 67);
                bt32.AccessibleDescription = "3";
                bt32.Visible = true;
            }
            if (odabrani == 3 && i == 3)//treci
            {
                bt33.Location = new Point(352, 67);
                bt33.AccessibleDescription = "2";
                bt33.Visible = true;
            }
            if (odabrani == 3 && i == 4)//cetvrti
            {
                bt34.Location = new Point(352, 67);
                bt34.AccessibleDescription = "3";
                bt34.Visible = true;
            }
            //cetvrta skupina
            if (odabrani == 4 && i == 1)//prvi
            {
                bt41.Location = new Point(469, 67);
                bt41.AccessibleDescription = "2";
                bt41.Visible = true;
            }
            if (odabrani == 4 && i == 2)//drugi
            {
                bt42.Location = new Point(469, 67);
                bt42.AccessibleDescription = "3";
                bt42.Visible = true;
            }
            if (odabrani == 4 && i == 3)//treci
            {
                bt43.Location = new Point(469, 67);
                bt43.AccessibleDescription = "2";
                bt43.Visible = true;
            }
            if (odabrani == 4 && i == 4)//cetvrti
            {
                bt44.Location = new Point(469, 67);
                bt44.AccessibleDescription = "3";
                bt44.Visible = true;
            }
            //peta skupina
            if (odabrani == 5 && i == 1)//prvi
            {
                bt51.Location = new Point(575, 67);
                bt51.AccessibleDescription = "2";
                bt51.Visible = true;
            }
            if (odabrani == 5 && i == 2)//drugi
            {
                bt52.Location = new Point(575, 67);
                bt52.AccessibleDescription = "3";
                bt52.Visible = true;
            }
            if (odabrani == 5 && i == 3)//treci
            {
                bt53.Location = new Point(575, 67);
                bt53.AccessibleDescription = "2";
                bt53.Visible = true;
            }
            if (odabrani == 5 && i == 4)//cetvrti
            {
                bt54.Location = new Point(575, 67);
                bt54.AccessibleDescription = "3";
                bt54.Visible = true;
            }
            i += 1;
            if (i == 5)
            {
                i = 1;
            }
        }
        private void Kraj()
        {
            bt_ovr.Visible = true;
            timer_main.Enabled = false;
            timer_padanja.Enabled = false;
            timer_vrijeme.Enabled = false;
            bt11.Visible = false;
            bt12.Visible = false;
            bt13.Visible = false;
            bt14.Visible = false;
            bt21.Visible = false;
            bt22.Visible = false;
            bt23.Visible = false;
            bt24.Visible = false;
            bt31.Visible = false;
            bt32.Visible = false;
            bt33.Visible = false;
            bt34.Visible = false;
            bt41.Visible = false;
            bt42.Visible = false;
            bt43.Visible = false;
            bt44.Visible = false;
            bt51.Visible = false;
            bt52.Visible = false;
            bt53.Visible = false;
            bt54.Visible = false;
           
        }
        

       

        private void timer_vrijeme_Tick(object sender, EventArgs e)
        {
            vrijeme += 1;
            bt_vrijeme.Text = vrijeme.ToString();
            if (vrijeme == 30)
            {
                Kraj();
            }
        }

        private void bt_nova_Click(object sender, EventArgs e)
        {
           
            bt_ovr.Visible = false;
            timer_main.Enabled = true;
            timer_padanja.Enabled = true;
            timer_vrijeme.Enabled = true;
            bt11.Visible = false;
            bt12.Visible = false;
            bt13.Visible = false;
            bt14.Visible = false;
            bt21.Visible = false;
            bt22.Visible = false;
            bt23.Visible = false;
            bt24.Visible = false;
            bt31.Visible = false;
            bt32.Visible = false;
            bt33.Visible = false;
            bt34.Visible = false;
            bt41.Visible = false;
            bt42.Visible = false;
            bt43.Visible = false;
            bt44.Visible = false;
            bt51.Visible = false;
            bt52.Visible = false;
            bt53.Visible = false;
            bt54.Visible = false;
           
            bt11.Location = new Point(94, 12);
            bt12.Location = new Point(94, 12);
            bt13.Location = new Point(94, 12);
            bt14.Location = new Point(94, 12);

            bt21.Location = new Point(94, 12);
            bt22.Location = new Point(94, 12);
            bt23.Location = new Point(94, 12);
            bt24.Location = new Point(94, 12);

            bt31.Location = new Point(94, 12);
            bt32.Location = new Point(94, 12);
            bt33.Location = new Point(94, 12);
            bt34.Location = new Point(94, 12);

            bt41.Location = new Point(94, 12);
            bt42.Location = new Point(94, 12);
            bt43.Location = new Point(94, 12);
            bt44.Location = new Point(94, 12);

            bt51.Location = new Point(94, 12);
            bt52.Location = new Point(94, 12);
            bt53.Location = new Point(94, 12);
            bt54.Location = new Point(94, 12);

            bt11.AccessibleDescription = "1";
            bt12.AccessibleDescription = "0";
            bt13.AccessibleDescription = "1";
            bt14.AccessibleDescription = "0";

            bt21.AccessibleDescription = "1";
            bt22.AccessibleDescription = "0";
            bt23.AccessibleDescription = "1";
            bt24.AccessibleDescription = "0";

            bt31.AccessibleDescription = "1";
            bt32.AccessibleDescription = "0";
            bt33.AccessibleDescription = "1";
            bt34.AccessibleDescription = "0";

            bt41.AccessibleDescription = "1";
            bt42.AccessibleDescription = "0";
            bt43.AccessibleDescription = "1";
            bt44.AccessibleDescription = "0";

            bt51.AccessibleDescription = "1";
            bt52.AccessibleDescription = "0";
            bt53.AccessibleDescription = "1";
            bt54.AccessibleDescription = "0";

            score = 0;
            vrijeme = 0;
            bt_score.Text = "0";
            bt_vrijeme.Text = "0";
            i = 0;
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
