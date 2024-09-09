using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Optics_Management_System
{
    public partial class Sale_Report : Form
    {
        string constr= @"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Final Project\Optics Management System\Optics Management System\My Data.mdf;Integrated Security=True";
        public Sale_Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fdate = dateTimePicker1.Text;
            string tdate = dateTimePicker2.Text;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("select * from customer_info where Date between('" + fdate + "')and('" + tdate + "')", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerReport cr = new CustomerReport();
            cr.Show();
        }
    }
}
