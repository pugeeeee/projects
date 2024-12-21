using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (textBox1.Text == "")
            {

                textBox1.Text = "" + 0;
            }
            if (textBox2.Text == "")
            {

                textBox2.Text = "" + 0;
            }
            if (textBox3.Text == "")
            {

                textBox3.Text = "" + 0;
            }
            if (textBox4.Text == "")
            {

                textBox4.Text = "" + 0;
            }
            if (textBox5.Text == "")
            {

                textBox5.Text = "" + 0;
            }
            if (textBox6.Text == "")
            {

                textBox6.Text = "" + 0;
            }
            if (textBox7.Text =="")
            {

                textBox7.Text = "" + 0;
            }
            if (textBox8.Text == "")
            {

                textBox8.Text = "" + 0;
            }
           float exam = int.Parse(textBox7.Text);
            float  exam_ = int.Parse(textBox8.Text);
            float final = exam + exam_;
            float final_ =final/2;
            float finals_ = final_* 0.4f;
           

            float act = int.Parse(textBox3.Text);
            float act_ = int.Parse(textBox4.Text);
            float quiz = int.Parse(textBox5.Text);
            float quiz_ = int.Parse(textBox6.Text);

            float act_s = act_ * 2;
            float quizs = quiz * 10;
            float quiz_s = quiz_ * 2;
            float all = act + act_s + quizs + quiz_s;
            float all_ = all / 4;
            float alls = all_ * 0.3f;
           

            float attend = int.Parse(textBox1.Text);
            float reci = int.Parse(textBox2.Text);
            float attends = attend * 100;
            float recit = reci * 24;
            float com = attends + recit;
            float com_ = com / 48;
            float complete = com_ * 0.3f;

            float Overall = finals_ + alls + complete;

            float Overall_ =    Overall / 2;
            float  overAll = Overall_ + 50;
            textBox9.Text = "" + overAll;


            if(overAll > 100.0f)
            {
                textBox10.Text = "wrong input";

            }

            else if (overAll >= 97.5)
            {
                textBox10.Text = "1.00";

            }
            else if (overAll >= 94.5)
            {
                textBox10.Text = "1.25";

            }
            else if (overAll >= 91.5)
            {
                textBox10.Text = "1.50";

            }
            else if (overAll >= 88.5)
            {
                textBox10.Text = "1.75";

            }
            else if (overAll >= 85.5)
            {
                textBox10.Text = "2.00";

            }
            else if (overAll >= 82.5)
            {
                textBox10.Text = "2.25";

            }
            else if (overAll >= 79.5)
            {
                textBox10.Text = "2.50";

            }
            else if (overAll >= 76.5)
            {
                textBox10.Text = "2.75";

            }
            else if (overAll >= 75)
            {
                textBox10.Text = "3.00";

            }
            else 
            {
                textBox10.Text = "5.00";
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
