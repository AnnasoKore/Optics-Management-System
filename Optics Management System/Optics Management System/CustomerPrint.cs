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
    public partial class CustomerPrint : Form
    {
        string constr= @"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Final Project\Optics Management System\Optics Management System\My Data.mdf;Integrated Security=True";
        public CustomerPrint()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            string abc = " select c.Name, c.Address, c.Contact_No,c.Dr_Name,c.Total_Amount, c.Discount, c.Payable_Amount, c.Payment_Method ,p.Frame_Name,p.Frame_Price, p.Lens_Name,p.Lens_price from customer_info c inner join  product_info p on c.id = p.id where  Name='"+textBox1.Text+"'";
            SqlDataAdapter ad = new SqlDataAdapter(abc, con);
            SqlCommand cm = new SqlCommand(abc, con);
            con.Open();
            cm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            ad.Fill(dt);
            CustomerPrintReport1 cr = new CustomerPrintReport1();
            cr.Database.Tables["customer_info"].SetDataSource(dt);
            cr.Database.Tables["product_info"].SetDataSource(dt);
            this.crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.RefreshReport();
            con.Close();
        }
    }
}
