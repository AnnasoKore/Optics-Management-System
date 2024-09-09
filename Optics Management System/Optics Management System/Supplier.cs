using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Optics_Management_System
{
    public partial class Supplier : Form
    {
        string constr= @"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Final Project\Optics Management System\Optics Management System\My Data.mdf;Integrated Security=True";
        public Supplier()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("insert into supplier values ('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("DONE", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadInfo(); textclear();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Data Are Not Accurate inserted \n\n Please Try Again... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void textclear()
        {
            textBox5.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox1.Clear();
        }

        private void LoadInfo()
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("select * from supplier ",con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                //SqlCommand cmd = new SqlCommand("Update supplier set Name= '" + textBox1.Text + "',Address='" + textBox2.Text + "',Contact_No=" + textBox3.Text + ",Email_Id='" + textBox4.Text + "' where id=" + textBox5.Text + "", con);
                SqlCommand cmd = new SqlCommand("Update supplier set Address='" + textBox2.Text + "',Contact_No=" + textBox3.Text + ",Email_Id='" + textBox4.Text + "' where Name= '" + textBox1.Text + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("DONE", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadInfo(); textclear();
                con.Close();
            }
            catch (Exception)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please enter supplier name  \n Please Try Again... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                }
                else {
                    MessageBox.Show("Please enter currect information\n  Data are not found  \n Please Try Again... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("delete from supplier where id=" + textBox5.Text + "", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("DONE", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadInfo(); textclear();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter supplier Id \n Please Try Again... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox5.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("select * from supplier where id="+textBox5.Text+"", con);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                dataGridView1.DataSource = dt;
                textBox5.Clear();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter Supplier Id \n     AND    \n  Try Again... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox5.Focus();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter)||(e.KeyCode==Keys.Tab))
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab))
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab))
            {
                textBox4.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            //if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab))
            //{
            //    button1.Focus();
            //}
        }

        private void textBox3_Validated(object sender, EventArgs e)
        {
            if ((textBox3.MaxLength != 10) || (textBox3.TextLength != 10))
            {
                textBox3.Focus();
                errorProvider1.SetError(textBox3, "Please enter the 10 digit number...");
            }
            else
            {
                errorProvider1.SetError(textBox3, "");
            }
            
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(textBox1.Text))
            //{
            //    textBox1.Focus();
            //    errorProvider1.SetError(textBox1, "Please enter the Name...");
            //}
            //else
            //{
            //    errorProvider1.SetError(textBox1, "");
            //}
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(textBox2.Text))
            //{
            //    textBox2.Focus();
            //    errorProvider1.SetError(textBox2, "Please enter the Supplier Address...");
            //}
            //else
            //{
            //    errorProvider1.SetError(textBox2, "");
            //}

        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {

            //if (string.IsNullOrWhiteSpace(textBox4.Text))
            //{
            //    textBox4.Focus();
            //    errorProvider1.SetError(textBox4, "Please enter the valied Email ID ...");
            //}
            //else
            //{
            //    errorProvider1.SetError(textBox4, "");
            //}
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 10 || char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBox3, "Please enter 10 digit Number..");
                textBox3.Focus();  
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 20 || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBox4, "Please enter valied Email_ID.");
                textBox4.Focus();
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(textBox4, "");
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            if (Regex.IsMatch(textBox4.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else {
                errorProvider1.SetError(textBox4, "Please enter valied Email_ID.");
                textBox4.Focus();
            }
        }
    }
}
