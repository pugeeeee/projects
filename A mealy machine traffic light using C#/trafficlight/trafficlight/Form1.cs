using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trafficlight
{
    public partial class Form1 : Form
    {
        int lb6, lb7,lb8;
        int wow = 0;
        public Form1()
        {
            InitializeComponent();
            red.Visible = false;
            yellow.Visible = false; 
            green.Visible = true;
            go.Visible = false;
            stop.Visible = true;
           
            label1.Visible =  false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = false;
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label7.Visible = false;
            label6.Visible = false;

            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(red.Visible == true)
            { 
                timer1.Interval = 11000;
                red.Visible = false;
                yellow.Visible = false;
                green.Visible = true;
                stop.Visible = true;
                go.Visible = false;
               
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = false;


                p2.Visible = false;
                p1.Visible = false;
                p3.Visible = true;
                stop.Visible = true;


            }
            else if(green.Visible == true)
            {
                timer1.Interval = 3100;
                red.Visible = false;
                yellow.Visible = true;
                green.Visible = false;
                stop.Visible = true;
                go.Visible = false;
                p0.Visible = false;
                label1.Visible = false;
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = true;
                label5.Visible = false;
                p2.Visible = false;
                p1.Visible = true;
                p3.Visible = false;
            }
            else if (yellow.Visible == true)

            {
                timer1.Interval = 12000;
                red.Visible = true;
                yellow.Visible = false;
                green.Visible = false;
                go.Visible = true;
                stop.Visible = false;
              
                label1.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = true;
                p2.Visible = true;
                p1.Visible = false;
                p3.Visible = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            lb6 = 10;
            lb7 = 3;
            lb8 = 10;
            timer1.Start();
            label6.Text = "" + 10;
            label7.Text = "" + 3;
           
            timer3.Start();

           
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled=false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void green_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {    
            label7.Text = lb7--.ToString();
            label7.Visible = true;
            if(lb7<0 )
            {   
                timer3.Stop();
               
                timer2.Start();
           
                label7.Visible = false;
                lb6 = 10;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            
            label8.Text = lb8--.ToString();
            label8.Visible = false;
           

            if (lb8 < 0)
            {
                timer4.Stop();
               
                lb7 = 3;
            
                timer3.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            label6.Text = lb6--.ToString();
            label6.Visible = true;
            if(lb6<0)
            { 

                timer2.Stop();
               
                lb8 = 10;
                label6.Visible = false;
              
                timer4.Start();

            }
            
            
        }
    }
}
