using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Optics_Management_System
{
    public partial class Purchase : Form
    {
        string constr= @"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Final Project\Optics Management System\Optics Management System\My Data.mdf;Integrated Security=True";
        public Purchase()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Purchase_Frame pf = new Purchase_Frame();
            pf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Purchase_Lens pl = new Purchase_Lens();
            pl.Show();
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
                default:
                    MessageBox.Show("Please select product...\n   Frame\n   Lens", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            SqlCommand cmd = new SqlCommand("select * from purchaseframe ", con);
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
            SqlCommand cmd = new SqlCommand("select * from purchaselens ", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (comboBox1.SelectedItem == "Frame")
            //    {
            //        try
            //        {
            //            SqlConnection con = new SqlConnection(constr);
            //            SqlCommand cmd = new SqlCommand("Update purchaseframe set Purchase_Price=" + textBox2.Text + " where Frame_Name='" + textBox1.Text + "' ", con);
            //            con.Open();
            //            cmd.ExecuteNonQuery();
            //            MessageBox.Show("DONE");
            //            GetInfoFrame();
            //            textBox1.Clear();
            //            textBox2.Clear();
            //            con.Close();
            //        }
            //        catch
            //        {
            //            MessageBox.Show("Please enter Frame Name\n   And New price...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }

            //    if (comboBox1.SelectedItem == "Lens")
            //    {
            //        try
            //        {
            //            SqlConnection con = new SqlConnection(constr);
            //            SqlCommand cmd = new SqlCommand("Update purchaselens set Purchase_Price=" + textBox2.Text + " where Lens_Name='" + textBox1.Text + "' ", con);
            //            con.Open();
            //            cmd.ExecuteNonQuery();
            //            MessageBox.Show("DONE");
            //            GetInfoLens();
            //            textBox1.Clear();
            //            textBox2.Clear();
            //            con.Close();
            //        }
            //        catch
            //        {
            //            MessageBox.Show("Please enter Lens Name\n   And New price...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Please enter valied data...");
            //}
            string product = comboBox1.Text;
            switch (product) { 
            
                case "Frame":
                    updateframe();
                    break;
                case "Lens":
                    updatelens();
                    break;
                default:
                    MessageBox.Show("please select product....\n  Frame \n  Lens", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        public void updateframe() {

            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("Update purchaseframe set Purchase_Price=" + textBox2.Text + " where Frame_Name='" + textBox1.Text + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("DONE");
                GetInfoFrame();
                textBox1.Clear();
                textBox2.Clear();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Please enter Frame Name\n   And New price...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void updatelens() {

            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("Update purchaselens set Purchase_Price=" + textBox2.Text + " where Lens_Name='" + textBox1.Text + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("DONE");
                GetInfoLens();
                textBox1.Clear();
                textBox2.Clear();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Please enter Lens Name\n   And New price...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //if (comboBox1.SelectedItem == "Frame")
            //{
            //    try
            //    {
            //        SqlConnection con = new SqlConnection(constr);
            //        SqlCommand cmd = new SqlCommand("Delete from purchaseframe where id=" + textBox3.Text + " ", con);
            //        con.Open();
            //        cmd.ExecuteNonQuery();
            //        MessageBox.Show("DONE");
            //        GetInfoFrame();
            //        textBox3.Clear();
            //        con.Close();
            //    }
            //    catch
            //    {
            //            MessageBox.Show("Please enter product id...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //if (comboBox1.SelectedItem == "Lens")
            //{
            //    try
            //    {
            //        SqlConnection con = new SqlConnection(constr);
            //        SqlCommand cmd = new SqlCommand("Delete from purchaselens where id=" + textBox3.Text + " ", con);
            //        con.Open();
            //        cmd.ExecuteNonQuery();
            //        MessageBox.Show("DONE");
            //        GetInfoLens();
            //        textBox3.Clear();
            //        con.Close();
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Please enter product id..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            string product = comboBox1.Text;
            switch (product)
            {

                case "Frame":
                    deleteframe();
                    break;
                case "Lens":
                    deletelens();
                    break;
                default:
                    MessageBox.Show("please select product....\n  Frame \n  Lens", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        public void deleteframe() {

            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("Delete from purchaseframe where id=" + textBox3.Text + " ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("DONE");
                GetInfoFrame();
                textBox3.Clear();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Please enter product id...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void deletelens() {

            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("Delete from purchaselens where id=" + textBox3.Text + " ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("DONE");
                GetInfoLens();
                textBox3.Clear();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Please enter product id..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
