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
    public partial class FramePurchaseReport : Form
    {
        string constr= @"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Final Project\Optics Management System\Optics Management System\My Data.mdf;Integrated Security=True";
        public FramePurchaseReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fdate = dateTimePicker1.Text;
            string tdate = dateTimePicker2.Text;
            SqlConnection con = new SqlConnection(constr);
            string abc = " select *from purchaseframe where  Data between('" + fdate + "')and('" + tdate + "') ";
            SqlDataAdapter ad = new SqlDataAdapter(abc, con);
            SqlCommand cm = new SqlCommand(abc, con);
            con.Open();
            cm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            ad.Fill(dt);
            FramePurchaseReport1 cr = new FramePurchaseReport1();
            cr.Database.Tables["purchaseframe"].SetDataSource(dt);
            this.crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.RefreshReport();
            con.Close();
        }

        private void FramePurchaseReport_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            string abc = " select *from purchaseframe ";
            SqlDataAdapter ad = new SqlDataAdapter(abc, con);
            SqlCommand cm = new SqlCommand(abc, con);
            con.Open();
            cm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            ad.Fill(dt);
            FramePurchaseReport1 cr = new FramePurchaseReport1();
            cr.Database.Tables["purchaseframe"].SetDataSource(dt);
            this.crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.RefreshReport();
            con.Close();
        }
    }
}
