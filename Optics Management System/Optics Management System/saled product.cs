using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optics_Management_System
{
    public partial class saled_product : Form
    {
        string constr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Final Project\Optics Management System\Optics Management System\My Data.mdf;Integrated Security=True";
        public saled_product()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string product = comboBox1.Text;
            switch (product) { 
            
                case "Frame":
                    GetInfoFrame();
                    break;
                case "Lens":
                    GetInfoLens();
                    break;
                case "":         
                    MessageBox.Show("Please select product \n   Frame\n   Lens...", "Select product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    comboBox1.Focus();
                    break;
                default:
                     MessageBox.Show("Please enter product name...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox1.Focus();
                    break;
            }
            //if (comboBox1.SelectedItem == "Frame")
            //{
            //    GetInfoFrame();
            //}
            //if (comboBox1.SelectedItem == "Lens")
            //{
            //    GetInfoLens();
            //}
            
        }
        private void GetInfoFrame()
        {
           
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("select * from saled_frame_product where Frame_Name='" + textBox1.Text + "' ", con);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                dataGridView1.DataSource = dt;
                con.Close();        
           
        }

        private void GetInfoLens()
        {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("select * from saled_lens_product where  Lens_Name='" + textBox1.Text + "'", con);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                dataGridView1.DataSource = dt;
                con.Close();           
        }

        private void comboBox1_Validated(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(comboBox1.Text))
            //{
              
            //    MessageBox.Show("Please select the product.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    comboBox1.Focus();
            //}

        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab )
            {
                textBox1.Focus();
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(textBox1.Text))
            //{
            //    MessageBox.Show("Please select the product Name.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //     textBox1.Focus();
            //  }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (comboBox1.SelectedItem == "Frame")
            //{
            //    SqlConnection con = new SqlConnection(constr);
            //    SqlCommand cmd = new SqlCommand("select * from saled_frame_product", con);
            //    DataTable dt = new DataTable();
            //    con.Open();
            //    SqlDataReader sdr = cmd.ExecuteReader();
            //    dt.Load(sdr);
            //    dataGridView1.DataSource = dt;
            //    con.Close();
            //}
            //if (comboBox1.SelectedItem == "Lens")
            //{
            //    SqlConnection con = new SqlConnection(constr);
            //    SqlCommand cmd = new SqlCommand("select * from saled_lens_product", con);
            //    DataTable dt = new DataTable();
            //    con.Open();
            //    SqlDataReader sdr = cmd.ExecuteReader();
            //    dt.Load(sdr);
            //    dataGridView1.DataSource = dt;
            //    con.Close();
            //}
            string product = comboBox1.Text;
            switch (product)
            {

                case "Frame":
                    saledframeproduct();
                    break;
                case "Lens":
                    saledlensproduct();
                    break;
                default:
                    MessageBox.Show("Please select product \n   Frame\n   Lens...", "Select product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    comboBox1.Focus();
                    break;
               
                     
            }
        }

        public void saledframeproduct() {

            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("select * from saled_frame_product", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void saledlensproduct() {

            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("select * from saled_lens_product", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
