using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //image diagram and table
            buo.Visible = false;
            q0.Visible = true;
            q1.Visible = false;
            q2.Visible = false;
            q3.Visible = false;
            btnpause.Text = "pause";
      
     
            pictureBox2.Visible = false;
            pictureBox8.Visible = false;
            

        }
        //find button
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            pictureBox2.Visible = true;
            pictureBox8.Visible = true;
            buo.Visible = false;
         q0.Visible = false;
           
            q2.Visible = false;
            q3.Visible = false;
          
           
         
            q1.Visible = true;
          
            openFileDialog.Filter = "MP3 files|*.mp3|All files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //select music
                axWindowsMediaPlayer1.URL = openFileDialog.FileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                
            }
        }

        

        private void btnstop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
        //rewind button
        private void btnrewind_Click(object sender, EventArgs e)

        {
            q2.Visible = false;
            q1.Visible = false;
        
            buo.Visible=false;
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition -= 5.0; // Rewind 5 seconds
            pictureBox2.Visible = true;
            pictureBox8.Visible = true;
           
                q3.Visible = true;
            
        }
        //fastforward button
        private void btnfastforward_Click(object sender, EventArgs e)

        {
            q2.Visible = false;
            q1.Visible = false;
        
            buo.Visible = false;
            pictureBox2.Visible = true;
            pictureBox8.Visible = true;
          
            
                q3.Visible = true;
            
            
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition += 5.0; // Fast forward 5 seconds
            
        }

        

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       //stop button

        private void button2_Click(object sender, EventArgs e)
        {
            q2.Visible = false;
            q3.Visible = false;
            q1.Visible = false;
            q0.Visible = false;
            pictureBox2.Visible = true;
            pictureBox8.Visible = true;
            buo.Visible = true;
           
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            
        }
        //paly and pause button
        private void btnpause_Click_1(object sender, EventArgs e)
        {q2.Visible = true;
            q0.Visible = false;
            q1.Visible = false;
            buo.Visible = false;
            pictureBox2.Visible = true;
            pictureBox8.Visible = true;

            q3.Visible = false;

            buo.Visible=false;
                
           
            

            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                btnpause.Text = "play";
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                btnpause.Text = "pause";
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
             Application.Exit(); 

        }
    }
}
