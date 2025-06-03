using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jacknpoy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            q1.Visible = false;
            q2.Visible = false;
            q3.Visible = false;
            table.Visible = false;
            state.Visible = false;

            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            win.BackColor = Color.Transparent;
            vs.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.None;
            label2.BorderStyle = BorderStyle.None;
            win.BorderStyle = BorderStyle.None; 
            vs.BorderStyle = BorderStyle.None; 
            win.Text = "";


            bato1.BackColor = Color.Transparent;
            bato2.BackColor = Color.Transparent;
            papel1.BackColor = Color.Transparent;
            papel2.BackColor = Color.Transparent;
            gunting1.BackColor = Color.Transparent;
            gunting2.BackColor = Color.Transparent;
            vs.Visible = false;
            win.Visible = false;
            comboBox1.Visible = false;
            fight.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            bato1.Visible = false;
            bato2.Visible = false;
            papel1.Visible = false;
            papel2.Visible = false;
            gunting1.Visible = false;
            gunting2.Visible = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            q0.Visible = false;
            q1.Visible = true;
            state.Visible = true;
            table.Visible = true;
            label1.Visible = true;
            label2.Visible=true;
            vs.Visible = true;
            win.Visible = true;
            comboBox1.Visible = true;
            fight.Visible = true;

            pictureBox1.Visible = false;
            start.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            


            Random rng = new Random(); // random n bato papel gunting umber generator
            int random = 0;
            random = rng.Next(1, 4);

            bato1.Visible = false;
            bato2.Visible = false;
            papel1.Visible = false;
            papel2.Visible = false;
            gunting1.Visible = false;
            gunting2.Visible = false;
        

            if (comboBox1.Text == "rock" && random == 1) {

                win.Text = " DRAW!";
                bato1.Visible = true;
                bato2.Visible = true;
                q1.Visible = true;


            }
            else if(comboBox1.Text == "rock" && random == 2)
            {
                win.Text = "YOU LOSE!";
                bato1.Visible = true;
               papel2.Visible = true;
                q1.Visible = false;
                
            }
            else if (comboBox1.Text == "rock" && random == 3)
            {
                win.Text = "YOU WIN!";
                bato1.Visible = true;
                gunting2.Visible = true;
                q1.Visible = false;
                
            }
            else if (comboBox1.Text == "paper" && random == 1)
            {
                win.Text = "YOU WIN!";
                papel1.Visible = true;
                bato2.Visible = true;
                q1.Visible = false;
               

            }
            else if (comboBox1.Text == "paper" && random == 2)
            {
                win.Text = " DRAW!";
                papel1.Visible = true;
                papel2.Visible = true;
               
                q1.Visible = true;


            }
            else if (comboBox1.Text == "paper" && random == 3)
            {
                win.Text = "YOU LOSE!";
                papel1.Visible = true;
                gunting2.Visible = true;
                q1.Visible = false;
               
            }
            else if (comboBox1.Text == "scissor" && random == 1)
            {
                win.Text = "YOU LOSE!";
                gunting1.Visible = true;
                bato2.Visible = true;
                q1.Visible = false;
                

            }
            else if (comboBox1.Text == "scissor" && random == 2)
            {
                win.Text = "YOU WIN!";
                gunting1.Visible = true;
                papel2.Visible = true;
                q1.Visible = false;
             

            }
            else if (comboBox1.Text == "scissor" && random == 3)
            {
                win.Text = " DRAW!";
                gunting1.Visible = true;
                gunting2.Visible = true;
             
                q1.Visible = true;

            }

            if(win.Text == " DRAW!")

            {
             
                q2.Visible = false;
                q1.Visible = true;
                q3.Visible = false;
            
            }
            else if(win.Text == "YOU WIN!")
            {
              
                q2.Visible = true;
                q3.Visible = false;
             
            }
            else if (win.Text == "YOU LOSE!")
            {
              
                q3.Visible = true;
                q2.Visible = false;
            
            }



        }

        private void win_Click(object sender, EventArgs e)
        {

        }

        private void table_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
