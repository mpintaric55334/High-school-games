using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication16
{
    public partial class Form1 : Form
    {
        int broj;
        int brojje;
        int brojpot;
        bool pobjedakriz;
        bool pobjedakrug;
        Random random = new Random();
        int pobx;
        int pobo;
        public Form1()
        {
            
            InitializeComponent();
            bt1.Click+=bt_Click;
            bt2.Click+=bt_Click;
            bt3.Click+=bt_Click;
            bt4.Click+=bt_Click;
            bt5.Click+=bt_Click;
            bt6.Click+=bt_Click;
            bt7.Click+=bt_Click;
            bt8.Click+=bt_Click;
            bt9.Click+=bt_Click;
            btsto.Text = "x";
            brojje = 0;
        }

        private void bt_Click(object sender, EventArgs e)
        {
            
            if (broj!=2)
            {
                Button bt = (Button)sender;
                if (brojje == 0)
                {
            
                    if (bt.Text == "" && broj == 0)
                    {
                        bt.Text = "x";
                        broj = 1;
                        btsto.Text = "o";
                    }
                    if (bt.Text == "" && broj == 1)
                    {
                        bt.Text = "o";
                        broj = 0;
                        btsto.Text = "x";
                    }
                }
                if(brojje==1)
                {
                    if (bt.Text == "" && broj == 0)
                    {
                        bt.Text = "x";
                        broj = 1;
                        btsto.Text = "o";
                    }
                    if (bt.Text == "" && broj == 1)
                    {
                        bt.Text = "o";
                        broj = 0;
                        btsto.Text = "x";
                    }
                }
       
                brojpot = brojpot + 1;
                Pobjeda();
            }

        }
        private void Pobjeda()
        {
            pobjedakriz = false;
            pobjedakrug = false;
            if (bt1.Text == "x" && bt2.Text == "x" && bt3.Text == "x")
            {
                pobjedakriz = true;
            }
            if (bt3.Text == "x" && bt6.Text == "x" && bt9.Text == "x")
            {
                pobjedakriz = true;
            }
            if (bt1.Text == "x" && bt4.Text == "x" && bt7.Text == "x")
            {
                pobjedakriz = true;
            }
            if (bt1.Text == "x" && bt5.Text == "x" && bt9.Text == "x")
            {
                pobjedakriz = true;
            }
            if (bt2.Text == "x" && bt5.Text == "x" && bt8.Text == "x")
            {
                pobjedakriz = true;
            }
            if (bt3.Text == "x" && bt5.Text == "x" && bt7.Text == "x")
            {
                pobjedakriz = true;
            }
            if (bt4.Text == "x" && bt5.Text == "x" && bt6.Text == "x")
            {
                pobjedakriz = true;
            }
            if (bt7.Text == "x" && bt8.Text == "x" && bt9.Text == "x")
            {
                pobjedakriz = true;
            }



            if (bt1.Text == "o" && bt2.Text == "o" && bt3.Text == "o")
            {
                pobjedakrug = true;
            }
            if (bt3.Text == "o" && bt6.Text == "o" && bt9.Text == "o")
            {
                pobjedakrug = true;
            }
            if (bt1.Text == "o" && bt4.Text == "o" && bt7.Text == "o")
            {
                pobjedakrug = true;
            }
            if (bt1.Text == "o" && bt5.Text == "o" && bt9.Text == "o")
            {
                pobjedakrug = true;
            }
            if (bt2.Text == "o" && bt5.Text == "o" && bt8.Text == "o")
            {
                pobjedakrug = true;
            }
            if (bt3.Text == "o" && bt5.Text == "o" && bt7.Text == "o")
            {
                pobjedakrug = true;
            }
            if (bt4.Text == "o" && bt5.Text == "o" && bt6.Text == "o")
            {
                pobjedakrug = true;
            }
            if (bt7.Text == "o" && bt8.Text == "o" && bt9.Text == "o")
            {
                pobjedakrug = true;
            }

            if (brojpot == 9 && pobjedakriz == false && pobjedakrug == false)
            {
                btrez.Text = "Neriješeno";
                broj=2;
                brojje = random.Next(2);
            }
            if (pobjedakrug == true)
            {
                btrez.Text = "Pobjeda kruga";
                broj=2;
                brojje = 0;
                pobo = pobo + 1;
                btkruz.Text = pobo.ToString();
                    
               
            }
            if (pobjedakriz == true)
            {
                btrez.Text = "Pobjeda krizica";
                broj = 2;
                brojje = 1;
                pobx = pobx + 1;
                btx.Text = pobx.ToString();
                    
                
            }
        }

        private void btNovaIgra_Click(object sender, EventArgs e)
        {
            brojpot = 0;
            bt1.Text = "";
            bt2.Text = "";
            bt3.Text = "";
            bt4.Text = "";
            bt5.Text = "";
            bt6.Text = "";
            bt7.Text = "";
            bt8.Text = "";
            bt9.Text = "";
            if (brojje == 0)
            {
                btsto.Text = "x";
                broj = 0;
            }
            if (brojje == 1)
            {
                btsto.Text = "o";
                broj=1;
            }
            btrez.Text = "";
        }

        private void btkraj_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }

       


            

    }
}
