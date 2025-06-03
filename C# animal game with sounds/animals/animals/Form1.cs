using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animals
{
    public partial class Form1 : Form
    {
        int a = 0;
        string mp3File = "C:\\Users\\Gerald\\Desktop\\animals\\level.mp3";

        public Form1()
        {
           
            InitializeComponent();
            axWindowsMediaPlayer1.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible= true;   
            wew.Visible = false;
            wow.Visible = false;
            q1.Visible = false;
            q2.Visible = false;
            q3.Visible = false;
            q4.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            q1.Visible = false;
            q2.Visible = false;
            q3.Visible = false;
            q4.Visible = true;
            panel1.Visible=false;
            panel4.Visible=true;
            lvl.Text ="lose Play again";
            next.Visible=false;
            again.Visible=true;

        }

        private void start_Click(object sender, EventArgs e)
        {
            
         
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void tiger_Click(object sender, EventArgs e)
        {
            a= 1;
            panel1.Visible=false;
            panel4.Visible=true;
            lvl.Text ="Level Complete";
            next.Visible=true;
            again.Visible=false;
            axWindowsMediaPlayer1.URL = mp3File;

            axWindowsMediaPlayer1.Ctlcontrols.play();
            q1.Visible = false;
            q2.Visible = true;
            q3.Visible = false;
            q4.Visible = false;
        }

        private void dog_Click(object sender, EventArgs e)
        {
            a=0;
            panel1.Visible=false;
            panel4.Visible=true;
            lvl.Text ="lose Play again";
            next.Visible=false;
            again.Visible=true;
            q1.Visible = false;
            q2.Visible = false;
            q3.Visible = false;
            q4.Visible = true;
        }

        private void cat_Click(object sender, EventArgs e)
        {
            a=0;
            panel1.Visible=false;
            panel4.Visible=true;
            lvl.Text ="lose Play again";
            next.Visible=false;
            again.Visible=true;
            q1.Visible = false;
            q2.Visible = false;
            q3.Visible = false;
            q4.Visible = true;
        }

        private void again_Click(object sender, EventArgs e)
        {
            panel1.Visible= true;
            panel2.Visible=false;
            panel3.Visible=false;
            panel4.Visible=false;
            a=0;
            q1.Visible = true;
            q2.Visible = false;
            q3.Visible = false;
            q4.Visible = false;
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (a==1)
            {
                panel4.Visible=false;
                panel2.Visible=true;
            }
            else if (a==2)
            {
                panel4.Visible=false;
                panel3.Visible=true;
            }
            else if (a==5) {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                start.Visible=false;
                a=0;
                start.Visible = true;
                panel5.Visible=true;

            }

        }

        private void crocodile_Click(object sender, EventArgs e)
        {
            a= 2;
            panel2.Visible=false;
            panel4.Visible=true;
            lvl.Text ="Level Complete";
            next.Visible=true;
            again.Visible=false;
            axWindowsMediaPlayer1.URL = mp3File;

            axWindowsMediaPlayer1.Ctlcontrols.play();
            q1.Visible = false;
            q2.Visible = true;
            q3.Visible = false;
            q4.Visible = false;
        }

        private void lizard_Click(object sender, EventArgs e)
        {
            a=0;
            panel2.Visible=false;
            panel4.Visible=true;
            lvl.Text ="lose Play again";
            next.Visible=false;
            again.Visible=true;
            q1.Visible = false;
            q2.Visible = false;
            q3.Visible = false;
            q4.Visible = true;
        }

        private void gecko_Click(object sender, EventArgs e)
        {
            a=0;
            panel2.Visible=false;
            panel4.Visible=true;
            lvl.Text ="lose Play again";
            next.Visible=false;
            again.Visible=true;
            q1.Visible = false;
            q2.Visible = false;
            q3.Visible = false;
            q4.Visible = true;
        }

        private void fish_Click(object sender, EventArgs e)
        {
            a=0;
            panel2.Visible=false;
            panel4.Visible=true;
            lvl.Text ="lose Play again";
            next.Visible=false;
            again.Visible=true;
            q1.Visible = false;
            q2.Visible = false;
            q3.Visible = false;
            q4.Visible = true;
        }

        private void ostrich_Click(object sender, EventArgs e)
        {
            a= 5;
            panel3.Visible=false;
            panel4.Visible=true;
            lvl.Text ="All Level Complete";
            next.Text = "CONGRATS";
            next.Visible=true;
            again.Visible=false;
            axWindowsMediaPlayer1.URL = mp3File;

            axWindowsMediaPlayer1.Ctlcontrols.play();
            q1.Visible = false;
            q2.Visible = false;
            q3.Visible = true;
            q4.Visible = false;

        }

        private void chicken_Click(object sender, EventArgs e)
        {
            a=0;
            panel3.Visible=false;
            panel4.Visible=true;
            lvl.Text ="lose Play again";
            next.Visible=false;
            again.Visible=true;
            q1.Visible = false;
            q2.Visible = false;
            q3.Visible = false;
            q4.Visible = true;
        }

        private void dove_Click(object sender, EventArgs e)
        {
            a=0;
            panel3.Visible=false;
            panel4.Visible=true;
            lvl.Text ="lose Play again";
            next.Visible=false;
            again.Visible=true;
            q1.Visible = false;
            q2.Visible = false;
            q3.Visible = false;
            q4.Visible = true;
        }

        private void duck_Click(object sender, EventArgs e)
        {
            a=0;
            panel3.Visible=false;
            panel4.Visible=true;
            lvl.Text ="lose Play again";
            next.Visible=false;
            again.Visible=true;
            q1.Visible = false;
            q2.Visible = false;
            q3.Visible = false;
            q4.Visible = true;
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {

        }

        private void start_Click_1(object sender, EventArgs e)
        {
            wew.Visible = true;
            wow.Visible = true;
            q0.Visible = false;
            q1.Visible = true;
            q2.Visible = false;
            q3.Visible = false;
            q4.Visible = false;




            panel1.Visible = true;
            start.Visible=false;
            panel5.Visible=false;
            next.Text = "Next";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void wew_Click(object sender, EventArgs e)
        {

        }
    }
}
