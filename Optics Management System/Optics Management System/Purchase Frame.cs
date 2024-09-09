using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Optics_Management_System
{
    public partial class Purchase_Frame : Form
    {
        string constr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Final Project\Optics Management System\Optics Management System\My Data.mdf;Integrated Security=True";
        public Purchase_Frame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                string ins = "insert into purchaseframe values ('" + textBox1.Text + "','" + comboBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'," + textBox4.Text + "," + textBox5.Text + ",'"+dateTimePicker1.Text+"')";
                SqlCommand cmd = new SqlCommand(ins, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("DONE", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Data are not Accurate/ Correctly Inserted....\n\nPlease Try Again....", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cleartxtb();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cleartxtb()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text = "Select";
        }
        private void Purchase_Frame_Load(object sender, EventArgs e)
        {

        }
    }
}
