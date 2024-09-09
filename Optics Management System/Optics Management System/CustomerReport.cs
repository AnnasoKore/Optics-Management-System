using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Optics_Management_System
{
    public partial class CustomerReport : Form
    {
        string constr= @"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Final Project\Optics Management System\Optics Management System\My Data.mdf;Integrated Security=True";
        public CustomerReport()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fdate = dateTimePicker1.Text;
            string tdate = dateTimePicker2.Text;
            SqlConnection con = new SqlConnection(constr);
            string abc = " select c.Name, c.Address, c.Contact_No, c.Dr_Name, c.Payable_Amount, c.Date, p.Frame_Name, p.Lens_Name from customer_info c inner join  product_info p on c.id = p.id where  Date between('" + fdate + "')and('" + tdate + "') ";
            SqlDataAdapter ad = new SqlDataAdapter(abc, con);
            SqlCommand cm = new SqlCommand(abc, con);
            con.Open();
            cm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            ad.Fill(dt);
            //CustomerReport1 cr = new CustomerReport1();
            Customerreport11 cr = new Customerreport11();
            cr.Database.Tables["customer_info"].SetDataSource(dt);
            cr.Database.Tables["product_info"].SetDataSource(dt);
            this.crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.RefreshReport();
            con.Close();
        }

        private void CustomerReport_Load(object sender, EventArgs e)
        {

        }
    }
}
