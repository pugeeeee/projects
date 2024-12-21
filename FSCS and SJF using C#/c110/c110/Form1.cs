using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace c110
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (bt1.Text == "")
            {
                bt1.Text = "" + 0;
            }
            if (bt2.Text == "")
            {
                bt2.Text = "" + 0;
            }
            if (bt3.Text == "")
            {
                bt3.Text = "" + 0;
            }
            if (bt4.Text == "")
            {
                bt4.Text = "" + 0;
            }
            if (bt5.Text == "")
            {
                bt5.Text = "" + 0;
            }
            if (at1.Text == "")
            {
                at1.Text = "" + 0;
            }
            if (at2.Text == "")
            {
                at2.Text = "" + 0;
            }
            if (at3.Text == "")
            {
                at3.Text = "" + 0;
            }
            if (at4.Text == "")
            {
                at4.Text = "" + 0;
            }
            if (at5.Text == "")
            {
                at5.Text = "" + 0;
            }
            chart1.Text = "P1"; chart2.Text = "P2"; chart3.Text = "P3"; chart4.Text = "P4"; chart5.Text = "P5";
            float a1 = int.Parse(bt1.Text);
            float a2 = int.Parse(bt2.Text);
            float a3 = int.Parse(bt3.Text);
            float a4 = int.Parse(bt4.Text);
            float a5 = int.Parse(bt5.Text);
            float a0 = 0;
            float aa1 = a0 + a1;
            float aa2 = a0 + a1 + a2;
            float aa3 = a0 + a1 + a2 + a3;
            float aa4 = a0 + a1 + a2 + a3 + a4;
            float aa5 = a0 + a1 + a2 + a3 + a4 + a5;
            c0.Text = "" + a0; c1.Text = "" + aa1; c2.Text = "" + aa2;
            c3.Text = "" + aa3; c4.Text = "" + aa4; c5.Text = "" + aa5;
            float b1 = int.Parse(at1.Text);
            float b2 = int.Parse(at2.Text);
            float b3 = int.Parse(at3.Text);
            float b4 = int.Parse(at4.Text);
            float b5 = int.Parse(at5.Text);
            float bb = a0 + aa1 + aa2 + aa3 + aa4;
            float bb1 = b1 + b2 + b3 + b4 + b5;
            float bb2 = bb - bb1;
            float bb3 = bb2 / 5;
            awtPre.Text = "" + bb3;
            float bbb = a0 + aa1 + aa2 + aa3 + aa4 + aa5;
            float bb22 = bbb - bb1;
            float bb33 = bb22 / 5;
            atatPre.Text = "" + bb33;
            float nonb = bb / 5;
            float nonbb = bbb / 5;
            awtNon.Text = "" + nonb;
            atatNon.Text = "" + nonbb;
        }

        private void form_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (bt1.Text == "")
            {
                bt1.Text = "" + 0;
            }
            if (bt2.Text == "")
            {
                bt2.Text = "" + 0;
            }
            if (bt3.Text == "")
            {
                bt3.Text = "" + 0;
            }
            if (bt4.Text == "")
            {
                bt4.Text = "" + 0;
            }
            if (bt5.Text == "")
            {
                bt5.Text = "" + 0;
            }
            if (at1.Text == "")
            {
                at1.Text = "" + 0;
            }
            if (at2.Text == "")
            {
                at2.Text = "" + 0;
            }
            if (at3.Text == "")
            {
                at3.Text = "" + 0;
            }
            if (at4.Text == "")
            {
                at4.Text = "" + 0;
            }
            if (at5.Text == "")
            {
                at5.Text = "" + 0;
            }
            float[] a = new float[5];
            a[0] = int.Parse(bt1.Text);
            a[1] = int.Parse(bt2.Text);
            a[2] = int.Parse(bt3.Text);
            a[3] = int.Parse(bt4.Text);
            a[4] = int.Parse(bt5.Text);
            float b1 = int.Parse(at1.Text);
            float b2 = int.Parse(at2.Text);
            float b3 = int.Parse(at3.Text);
            float b4 = int.Parse(at4.Text);
            float b5 = int.Parse(at5.Text);
            float bb1 = b1 + b2 + b3 + b4 + b5;
            float low = a[0], low2 = a[1];
            float high = a[0];         
            for (int i = 0; i < 5; i++)
            {
                if (a[i] < low)
                {
                    low2 = low;
                    low = a[i];                                                       
                }               
                else if (a[i] < low2 && a[i] != low)
                {
                    low2 = a[i];                                      
                }                              
            }        
                for (int i = 0; i < 5; i++)
            {
                if (a[i] > high)
                {
                    high = a[i];                                       
                }               
            }
            float low4 = a[0];

            for (int i = 0; i < 5; i++)
            {
                if (a[i] > low2 && a[i]<high)
                    {
                    low4 = a[i];                    
                    }               
            }
            for (int i = 0; i < 5; i++) {
                if (a[0] > low4 && a[0]<high) {
                    low4 = a[0];                                      
                } 
            }
            for (int i = 0; i < 5; i++)
            {
                if (a[1] > low4 && a[1] < high)
                {
                    low4 = a[1];                    
                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (a[2]>low4&& a[2] != high)
                {
                    low4 = a[2];
                }
            }
            float low3 = a[0];           
            for (int i = 0; i < 5; i++)
            {
                if (a[i] < low4 && a[i] > low2)
                {
                    low3 = a[i];                  
                }                      
            }           
            float a00 = 0;
            float pp = 0, pp2 = 0, pp3 = 0, pp4 = 0, pp5 = 0;

               for(int i = 0;i < 5;i++)
              {
                if (a[i]==low)
                {
                    pp= (i+1);
                }
                else if (a[i]==low2)
                {
                    pp2 = (i+1);
                }
                else if (a[i] == low3)
                {
                    pp3 = (i + 1);
                }
                else if (a[i] == low4)
                {
                    pp4 = (i + 1);
                }
                else if (a[i] == high)
                {
                    pp5 = (i + 1);
                }
               }                                       
            chart1.Text = "P" + pp;
            chart2.Text = "P" + pp2;
            chart3.Text = "P" + pp3;
            chart4.Text = "P" + pp4;
            chart5.Text = "P" + pp5;
            float aa1 = a00 + low;
            float aa2 = a00 + low + low2;
            float aa3 = a00 +low+low2 + low3;
            float aa4 = a00 + low+low2+low3+low4;
            float aa5 = a00 + low + low2 + low3 + low4+high;
            c0.Text = "" + a00;
            c1.Text = "" + aa1;
            c2.Text = "" + aa2;
            c3.Text = "" + aa3;
            c4.Text = "" + aa4;
            c5.Text = "" + aa5;
            float aa6 =a00 + aa1 + aa2 + aa3 +aa4;
            float bbb = b1 + b2 + b3 +  b4 + b5;
            float aa7 =a00 + aa1 + aa2 + aa3 +aa4 + aa5;
            float bb2 = aa6 - bbb;
            float bb3 = bb2 / 5;
            awtPre.Text = "" + bb3;
            float bb22 = aa7 - bbb;
            float bb33 = bb22 / 5;
            atatPre.Text = "" + bb33;
            float nonb = aa6 / 5;
            awtNon.Text = "" + nonb;
            float nonbb = aa7 / 5;
            atatNon.Text=""+ nonbb;
        }
    }
    }
