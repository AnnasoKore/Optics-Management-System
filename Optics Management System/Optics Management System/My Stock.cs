using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Optics_Management_System
{
    public partial class My_Stock : Form
    {
        string constr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Final Project\Optics Management System\Optics Management System\My Data.mdf;Integrated Security=True";
        public My_Stock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string product = comboBox1.Text;
            switch (product) { 
            
                case "Frame":
                    addframe();
                    break;

                case "Lens":
                    addlens();
                    break;
                default:
                    MessageBox.Show("Please select product...\n   Frame\n   Lens", "Select Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    comboBox1.Focus();
                    break;
            }
            
            //if (comboBox1.SelectedItem == "Frame")
            //{
            //    SqlConnection con = new SqlConnection(constr);
            //    SqlCommand cmd = new SqlCommand("select * from addframe ", con);
            //    DataTable dt = new DataTable();
            //    con.Open();
            //    SqlDataReader sdr = cmd.ExecuteReader();
            //    dt.Load(sdr);
            //    dataGridView1.DataSource = dt;
            //    con.Close();
            //}
            // if (comboBox1.SelectedItem == "Lens")
            // {
            //     SqlConnection con = new SqlConnection(constr);
            //     SqlCommand cmd = new SqlCommand("select * from addlens ", con);
            //     DataTable dt = new DataTable();
            //     con.Open();
            //     SqlDataReader sdr = cmd.ExecuteReader();
            //     dt.Load(sdr);
            //     dataGridView1.DataSource = dt;
            //     con.Close();
            // }
        }

        public void addframe() {

            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("select * from addframe ", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void addlens() {

            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("select * from addlens ", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
