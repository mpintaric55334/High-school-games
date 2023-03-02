using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vjesala
{
    public partial class Form1 : Form
    {
        string rijec = "";
        int brojac_tocnih_ukupno = 0;
        
        int brojac_krivih = 0;
        
        TextBox[] lista_texta = new TextBox[8];
        PictureBox[] lista_slika = new PictureBox[9];
        string[] lista_string = { "pas", "mačka", "lopta", "lopata", "kruh", "krug", "košarka","nogomet",
        "auto","avion","kamion","Zadar","Zagreb","Split","Osijek","Rijeka","vješala","cvijet","kanta"};
        public Form1()
        {
            InitializeComponent();
            //spremi textBoxove u listu
            lista_texta[0] = textBox1;
            lista_texta[1] = textBox2;
            lista_texta[2] = textBox3;
            lista_texta[3] = textBox4;
            lista_texta[4] = textBox5;
            lista_texta[5] = textBox6;
            lista_texta[6] = textBox7;
            lista_texta[7] = textBox8;
            //spremi pictureboxove
            lista_slika[0] = glava;
            lista_slika[1] = loko;
            lista_slika[2] = doko;
            lista_slika[3] = usta;
            lista_slika[4] = lruka;
            lista_slika[5] = druka;
            lista_slika[6] = drob;
            lista_slika[7] = lnoga;
            lista_slika[8] = dnoga;

            
            
        }
        //nova riječ
        private void bt_nova_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int index = rnd.Next(lista_string.Length);
            rijec = lista_string[index];
            Reset();
            for(int i = 0; i < rijec.Length; i++)
            {
                lista_texta[i].Visible = true;
            }
            
            
        }

        private void bt_ugasi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_provjeri_Click(object sender, EventArgs e)
        {
            bool nasli_gr = false;

            //pogledajmo koliko tocnih slova imamo
            for (int i = 0; i < rijec.Length; i++)
            {
                
                string znak = "";//ova varijabla sluzi za konverziju chara u string
                znak += rijec[i];
                if (znak.ToUpper() == lista_texta[i].Text.ToUpper() && lista_texta[i].Enabled==true){
                    brojac_tocnih_ukupno += 1;
                    
                    lista_texta[i].BackColor = Color.Green;
                    lista_texta[i].Enabled = false;
                    if (brojac_tocnih_ukupno == rijec.Length)
                    {
                        Pobjeda();
                    }
                }else if(znak!=lista_texta[i].Text && lista_texta[i].Text != "" && lista_texta[i].Enabled == true)
                {
                    
                    if (!nasli_gr)
                    {
                        brojac_krivih += 1;
                        ObradiGresku(brojac_krivih);
                        if (brojac_krivih == 9)
                        {
                            Gubitak();
                        }
                    }
                    nasli_gr = true;
                    lista_texta[i].BackColor = Color.Red;
                    

                    
                    
                }else if (lista_texta[i].Text == "")
                {
                    lista_texta[i].BackColor = Color.White;
                }
                

            }
        }
        public void ObradiGresku(int br)
        {
            lista_slika[br - 1].Visible = false;
        }
        public void Reset()
        {
            for(int i = 0; i < 8; i++)
            {
                lista_texta[i].Text = "";
                lista_texta[i].BackColor = Color.White;
                lista_texta[i].Enabled = true;
                lista_texta[i].Visible = false;
                lista_slika[i].Visible = true;
                brojac_krivih = 0;
                brojac_tocnih_ukupno = 0;
                bt_gotovo.Visible = false;
                bt_nova.Enabled = false;
                bt_provjeri.Enabled = true;
                bt_provjeri.Enabled = true;
            }
            lista_slika[8].Visible = true;
        }
        
        public void Pobjeda()
        {
            bt_gotovo.Text = "Uspjeh!";
            bt_gotovo.Visible = true;
            bt_nova.Enabled = true;
            bt_provjeri.Enabled = false;
        }

        public void Gubitak()
        {
            bt_gotovo.Text = "Neuspjeh, ubili ste čovječuljka!\n Točna riječ je "+ rijec;
            bt_gotovo.Visible = true;
            bt_nova.Enabled = true;
            bt_provjeri.Enabled = false;
        }

        
    }
}
