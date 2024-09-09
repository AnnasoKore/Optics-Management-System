using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Optics_Management_System
{
    public partial class Purchse_Report : Form
    {
        string constr= @"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Final Project\Optics Management System\Optics Management System\My Data.mdf;Integrated Security=True";
        public Purchse_Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (comboBox1.SelectedItem == "Frame")
            //{
            //    string fdate = dateTimePicker1.Text;
            //    string tdate = dateTimePicker2.Text;
            //    SqlConnection con = new SqlConnection(constr);
            //    SqlCommand cmd = new SqlCommand("select * from purchaseframe where Data between('" + fdate + "')and('" + tdate + "')", con);
            //    DataTable dt = new DataTable();
            //    con.Open();
            //    SqlDataReader sdr = cmd.ExecuteReader();
            //    dt.Load(sdr);
            //    dataGridView1.DataSource = dt;
            //    con.Close();
            //}
            //if (comboBox1.SelectedItem == "Lens")
            //{
            //    string fdate = dateTimePicker1.Text;
            //    string tdate = dateTimePicker2.Text;
            //    SqlConnection con = new SqlConnection(constr);
            //    SqlCommand cmd = new SqlCommand("select * from purchaselens  where Date between('" + fdate + "')and('" + tdate + "')", con);
            //    DataTable dt = new DataTable();
            //    con.Open();
            //    SqlDataReader sdr = cmd.ExecuteReader();
            //    dt.Load(sdr);
            //    dataGridView1.DataSource = dt;
            //    con.Close();
               
            //}
            string p = Convert.ToString(comboBox1.Text);
            switch (p) { 
            
                case "Lens":
                    lensreport();
                break;

                case "Frame":
                framereport();
                break;

                default :
                MessageBox.Show("please select product....\n  Frane  \n  Lens", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                break;

            }
           
        }
        public void lensreport() {

            string fdate = dateTimePicker1.Text;
            string tdate = dateTimePicker2.Text;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("select * from purchaselens  where Date between('" + fdate + "')and('" + tdate + "')", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void framereport() {

            string fdate = dateTimePicker1.Text;
            string tdate = dateTimePicker2.Text;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("select * from purchaseframe where Data between('" + fdate + "')and('" + tdate + "')", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string sle = comboBox1.Text;
            switch (sle) { 
            
                case "Frame":
                    FramePurchaseReport fr = new FramePurchaseReport();
                    fr.Show();
                    break;

                case "Lens":
                    Lens_Report lr = new Lens_Report();
                    lr.Show();
                    break;

                default:
                    MessageBox.Show("please select product....\n  Frane  \n  Lens", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comboBox1.Focus();
                    break;
            }
            //if (comboBox1.SelectedItem == "Frame")
            //{
            //    FramePurchaseReport fr = new FramePurchaseReport();
            //    fr.Show();
            //}
            //if (comboBox1.SelectedItem == "Lens")
            //{
            //    Lens_Report lr = new Lens_Report();
            //    lr.Show();
            //}
        }
    }
}
