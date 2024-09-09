using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Optics_Management_System
{
    public partial class Add_Frame : Form
    {
        string constr=@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Final Project\Optics Management System\Optics Management System\My Data.mdf;Integrated Security=True";
        public Add_Frame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                string ins = "insert into addframe values ('" + textBox1.Text + "','" + comboBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'," + textBox4.Text + "," + textBox5.Text + ")";
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
            cleardata();
        }

        private void cleardata()
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                FetchFrameInfo();
                textBox5.Focus();
            }
        }
        public void FetchFrameInfo()
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("Select * from purchaseframe where Frame_Name='" + textBox1.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Text = (dr["Frame_type"].ToString());
                textBox2.Text = (dr["Design_No"].ToString());
                textBox3.Text = (dr["Color"].ToString());                
                textBox4.Text = (dr["Quantity"].ToString());
            }
            con.Close();
        }
    }
}
