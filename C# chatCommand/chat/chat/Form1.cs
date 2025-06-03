using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
            chatBox.Text = "Bot : hello!" + Environment.NewLine + Environment.NewLine;
            this.AcceptButton = button1;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            q0.Visible = true;
            q1.Visible = false;
            q2.Visible = false;
            q3.Visible = false;
            panel1.Visible = false;
          

        }

        private void button1_Click(object sender, EventArgs e)

        {
            q1.Visible = false;


            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            if (textBox2.Text == "/h")
            {
                q3.Visible = false;
                q2.Visible = true;
                chatBox.AppendText("You: /h" + Environment.NewLine);
                chatBox.AppendText("Bot: Here are the list of commands that you can use:" + Environment.NewLine);
                chatBox.AppendText(" /h (Help) - Show commands" + Environment.NewLine);
                chatBox.AppendText(" /r (Reminder) - Sets a reminder for you" + Environment.NewLine);
                chatBox.AppendText(" /i (Invite) - Generates invite link" + Environment.NewLine);
                chatBox.AppendText(" /clear (Clear) - Clear history" + Environment.NewLine + Environment.NewLine);
            }
            else if (textBox2.Text == "/r")
            {
                q3.Visible = false;
                q2.Visible = true;
                chatBox.AppendText("You: /r" + Environment.NewLine);
                chatBox.AppendText("Bot: Reminder set: Automata Presentation at 05/30/25" + Environment.NewLine + Environment.NewLine);
            }
            else if (textBox2.Text == "/clear")
            {
                q3.Visible = false;
                q2.Visible = true;
                chatBox.Clear();
                chatBox.Text = "bot : hello!" + Environment.NewLine + Environment.NewLine;
            }
            else if (textBox2.Text == "/i")
            {
                q3.Visible = false;
                q2.Visible = true;
                chatBox.AppendText("You: /i" + Environment.NewLine);
                chatBox.AppendText("Bot: https:208866998-Invites-101" + Environment.NewLine + Environment.NewLine);
            }
            else
            {
                q2.Visible = false;
                q3.Visible = true;
                chatBox.AppendText("You: " + textBox2.Text + Environment.NewLine);
                chatBox.AppendText("Bot: Wrong command" + Environment.NewLine + Environment.NewLine);
            }
            textBox2.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void start_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            start.Visible = false;
            q1.Visible = true;
            q0.Visible=false;
        }
    }
}
