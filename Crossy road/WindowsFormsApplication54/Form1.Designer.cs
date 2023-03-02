namespace WindowsFormsApplication54
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_kretanje_gori = new System.Windows.Forms.Timer(this.components);
            this.timer_kretanje_doli = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.bt_score = new System.Windows.Forms.Button();
            this.igrac = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.auto4 = new System.Windows.Forms.PictureBox();
            this.auto3 = new System.Windows.Forms.PictureBox();
            this.auto2 = new System.Windows.Forms.PictureBox();
            this.btdoli = new System.Windows.Forms.Button();
            this.btgori = new System.Windows.Forms.Button();
            this.auto1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_nova_igra = new System.Windows.Forms.Button();
            this.btovr = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.igrac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_kretanje_gori
            // 
            this.timer_kretanje_gori.Interval = 40;
            this.timer_kretanje_gori.Tick += new System.EventHandler(this.timer_kretanje_gori_Tick);
            // 
            // timer_kretanje_doli
            // 
            this.timer_kretanje_doli.Interval = 40;
            this.timer_kretanje_doli.Tick += new System.EventHandler(this.timer_kretanje_doli_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 40;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 40;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 40;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // bt_score
            // 
            this.bt_score.BackColor = System.Drawing.Color.Green;
            this.bt_score.Location = new System.Drawing.Point(536, 15);
            this.bt_score.Name = "bt_score";
            this.bt_score.Size = new System.Drawing.Size(75, 24);
            this.bt_score.TabIndex = 17;
            this.bt_score.Text = "0";
            this.bt_score.UseVisualStyleBackColor = false;
            // 
            // igrac
            // 
            this.igrac.BackgroundImage = global::WindowsFormsApplication54.Properties.Resources.lik;
            this.igrac.Location = new System.Drawing.Point(250, 417);
            this.igrac.Name = "igrac";
            this.igrac.Size = new System.Drawing.Size(29, 29);
            this.igrac.TabIndex = 12;
            this.igrac.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::WindowsFormsApplication54.Properties.Resources.portal;
            this.pictureBox6.Location = new System.Drawing.Point(239, 45);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 35);
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // auto4
            // 
            this.auto4.BackgroundImage = global::WindowsFormsApplication54.Properties.Resources.ztauto1;
            this.auto4.Location = new System.Drawing.Point(148, 102);
            this.auto4.Name = "auto4";
            this.auto4.Size = new System.Drawing.Size(50, 35);
            this.auto4.TabIndex = 15;
            this.auto4.TabStop = false;
            // 
            // auto3
            // 
            this.auto3.BackgroundImage = global::WindowsFormsApplication54.Properties.Resources.nrauto2;
            this.auto3.Location = new System.Drawing.Point(289, 191);
            this.auto3.Name = "auto3";
            this.auto3.Size = new System.Drawing.Size(50, 35);
            this.auto3.TabIndex = 14;
            this.auto3.TabStop = false;
            // 
            // auto2
            // 
            this.auto2.BackgroundImage = global::WindowsFormsApplication54.Properties.Resources.plauto2;
            this.auto2.Location = new System.Drawing.Point(393, 283);
            this.auto2.Name = "auto2";
            this.auto2.Size = new System.Drawing.Size(50, 35);
            this.auto2.TabIndex = 13;
            this.auto2.TabStop = false;
            // 
            // btdoli
            // 
            this.btdoli.BackgroundImage = global::WindowsFormsApplication54.Properties.Resources.streldol;
            this.btdoli.Enabled = false;
            this.btdoli.Location = new System.Drawing.Point(490, 378);
            this.btdoli.Name = "btdoli";
            this.btdoli.Size = new System.Drawing.Size(62, 51);
            this.btdoli.TabIndex = 11;
            this.btdoli.UseVisualStyleBackColor = true;
            this.btdoli.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btdoli_MouseDown);
            this.btdoli.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btdoli_MouseUp);
            // 
            // btgori
            // 
            this.btgori.BackgroundImage = global::WindowsFormsApplication54.Properties.Resources.strelgor;
            this.btgori.Enabled = false;
            this.btgori.Location = new System.Drawing.Point(490, 319);
            this.btgori.Name = "btgori";
            this.btgori.Size = new System.Drawing.Size(62, 53);
            this.btgori.TabIndex = 10;
            this.btgori.UseVisualStyleBackColor = true;
            this.btgori.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btgori_MouseDown);
            this.btgori.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btgori_MouseUp);
            // 
            // auto1
            // 
            this.auto1.BackgroundImage = global::WindowsFormsApplication54.Properties.Resources.crauto1;
            this.auto1.Location = new System.Drawing.Point(116, 367);
            this.auto1.Name = "auto1";
            this.auto1.Size = new System.Drawing.Size(50, 35);
            this.auto1.TabIndex = 5;
            this.auto1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(116, 86);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(327, 51);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(116, 175);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(327, 51);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(116, 267);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(327, 51);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(116, 351);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(327, 51);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox1.Location = new System.Drawing.Point(116, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 405);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bt_nova_igra
            // 
            this.bt_nova_igra.BackColor = System.Drawing.Color.Green;
            this.bt_nova_igra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nova_igra.Location = new System.Drawing.Point(602, 295);
            this.bt_nova_igra.Name = "bt_nova_igra";
            this.bt_nova_igra.Size = new System.Drawing.Size(128, 64);
            this.bt_nova_igra.TabIndex = 18;
            this.bt_nova_igra.Text = "Nova igra";
            this.bt_nova_igra.UseVisualStyleBackColor = false;
            this.bt_nova_igra.Click += new System.EventHandler(this.bt_nova_igra_Click);
            // 
            // btovr
            // 
            this.btovr.BackColor = System.Drawing.Color.Green;
            this.btovr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btovr.Location = new System.Drawing.Point(173, 143);
            this.btovr.Name = "btovr";
            this.btovr.Size = new System.Drawing.Size(200, 69);
            this.btovr.TabIndex = 19;
            this.btovr.Text = "Game Over";
            this.btovr.UseVisualStyleBackColor = false;
            this.btovr.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(553, 102);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(79, 141);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(628, 102);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(80, 141);
            this.richTextBox2.TabIndex = 23;
            this.richTextBox2.Text = "";
            this.richTextBox2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(577, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Rezultati";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(465, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Score:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(602, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 64);
            this.button2.TabIndex = 27;
            this.button2.Text = "Ugasi";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(116, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(327, 38);
            this.button3.TabIndex = 28;
            this.button3.Text = "Crossy road";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(795, 467);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btovr);
            this.Controls.Add(this.bt_nova_igra);
            this.Controls.Add(this.igrac);
            this.Controls.Add(this.bt_score);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.auto4);
            this.Controls.Add(this.auto3);
            this.Controls.Add(this.auto2);
            this.Controls.Add(this.btdoli);
            this.Controls.Add(this.btgori);
            this.Controls.Add(this.auto1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.igrac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox auto1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btgori;
        private System.Windows.Forms.Button btdoli;
        private System.Windows.Forms.PictureBox igrac;
        private System.Windows.Forms.Timer timer_kretanje_gori;
        private System.Windows.Forms.Timer timer_kretanje_doli;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.PictureBox auto2;
        private System.Windows.Forms.PictureBox auto3;
        private System.Windows.Forms.PictureBox auto4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button bt_score;
        private System.Windows.Forms.Button bt_nova_igra;
        private System.Windows.Forms.Button btovr;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

