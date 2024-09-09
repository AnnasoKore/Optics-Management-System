using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Optics_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (textBox1.Text != "system")
            {
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "User Id Must be System ");
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text != "system")
            {
                textBox2.Focus();
                errorProvider1.SetError(textBox2, "Password Must be System ");
            }
            else
            {
                errorProvider1.SetError(textBox2, "");
                Main_Form mf = new Main_Form();
                mf.Show();

                this.Close();
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
