using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace machineeee
{
    public partial class Form1 : Form
    {
        int change = 0;
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            green.Visible = false;
            yellow.Visible = false;
            red.Visible = false;
            assembly.Visible = false;
            inspect.Visible = false;
            package.Visible = false;
            next.Visible = false;
            label1.Text = "            start the process";
            q0.Visible = true;
            q1.Visible = false;
            q2.Visible = false;
            q3.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            q0.Visible = false;
            q1.Visible = true;
            q2.Visible = false;
            q3.Visible = false;
            start.Visible = false;
            green.Visible = true;
            yellow.Visible = false;
            red.Visible = false;
            assembly.Visible =true;
            inspect.Visible = false;
            package.Visible = false;

            label1.Text = "    The assembly station is operating";
            timer1.Interval = 8000; 
            change = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (change == 5)
            {
                label1.Text = "        Well Done, can proceed back";
                next.Visible = true;
                next.Text = "back";
                q0.Visible = false;
                q1.Visible = false;
                q2.Visible = false;
                q3.Visible = true;
                timer1.Stop();
            }
            else
            {
                label1.Text = "           proceed to next station";
                next.Visible = true;
                timer1.Stop();
            }

            
        }

        private void next_Click(object sender, EventArgs e)
        {
          if (next.Text == "back")
            {
                green.Visible = false;
                yellow.Visible = false;
                red.Visible = false;
                assembly.Visible = false;
                inspect.Visible = false;
                package.Visible = false;
                next.Visible = false;
                label1.Text = "         start the process";
                next.Text = "next station";
                start.Visible = true;


                timer1.Stop();
                q0.Visible = true;
                q1.Visible = false;
                q2.Visible = false;
                q3.Visible = false;
            }
      

            if (change == 0)
            {
                label1.Text = "Items are being inspected in the inspection area";
                change = 1;
                green.Visible = false;
                yellow.Visible = true;
                red.Visible = false;
                assembly.Visible = false;
                next.Visible = false;
                inspect.Visible = true;
                package.Visible = false;
                q0.Visible = false;
                q1.Visible = false;
                q2.Visible = true;
                q3.Visible = false;
            }
            else if (change == 1) {

                label1.Text = "Packaging is in progress in the packaging area";
                change = 5;
                green.Visible = false;
                yellow.Visible = false;
                red.Visible = true;
                assembly.Visible = false;
                inspect.Visible = false;
                package.Visible = true;
                next.Visible = false;
                q1.Visible = true;
                q2.Visible = false;
              
            }



                timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
