using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Optics_Management_System
{
    public partial class Product : Form
    {
        string constr=@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Final Project\Optics Management System\Optics Management System\My Data.mdf;Integrated Security=True";
        public Product()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Add_Frame af = new Add_Frame();
            af.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Add_Lens al = new Add_Lens();
            al.Show();
        }

        private void Product_Load(object sender, EventArgs e)
        {
           
        }

        private void GetInfoFrame()
        {           
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("select * from addframe ", con);
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
                SqlCommand cmd = new SqlCommand("select * from addlens ", con);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                dataGridView1.DataSource = dt;
                con.Close();         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (comboBox1.Text == "")
            //{
            //   MessageBox.Show("Please select product...\n Frame\n Lens ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    if (comboBox1.SelectedItem == "Frame")
            //    {
            //        GetInfoFrame();
            //    }
            //    if (comboBox1.SelectedItem == "Lens")
            //    {
            //        GetInfoLens();
            //    }
            //}
            string product = comboBox1.Text;
            switch (product)
            {

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
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                //if (comboBox1.SelectedItem == "Frame")
                //{
                //    try
                //    {
                //        SqlConnection con = new SqlConnection(constr);
                //        SqlCommand cmd = new SqlCommand("Update addframe set Sale_Price=" + textBox2.Text + " where Frame_Name='" + textBox1.Text + "' ", con);
                //        con.Open();
                //        cmd.ExecuteNonQuery();
                //        MessageBox.Show("DONE");
                //        GetInfoFrame();
                //        textBox1.Clear();
                //        textBox2.Clear();
                //        con.Close();
                //    }
                //    catch { 
                //    MessageBox.Show("Please enter product name...","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //    textBox1.Focus();
                //    }
                //}
                //if (comboBox1.SelectedItem == "Lens")
                //{
                //    try
                //    {
                //        SqlConnection con = new SqlConnection(constr);
                //        SqlCommand cmd = new SqlCommand("Update addlens set Sale_Price=" + textBox2.Text + " where Lens_Name='" + textBox1.Text + "' ", con);
                //        con.Open();
                //        cmd.ExecuteNonQuery();
                //        MessageBox.Show("DONE");
                //        GetInfoLens();
                //        textBox1.Clear();
                //        textBox2.Clear();
                //        con.Close();
                //    }
                //    catch {
                //        MessageBox.Show("Please enter product name...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        textBox1.Focus();
                //    }
                //}

                string product = comboBox1.Text;
                switch (product)
                {

                    case "Frame":
                        updateframe();
                        break;
                    case "Lens":
                        updatelens();
                        break;
                    default:
                        MessageBox.Show("Please select product...\n   Frame\n   Lens", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                }
        }

        public void updateframe() {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("Update addframe set Sale_Price=" + textBox2.Text + " where Frame_Name='" + textBox1.Text + "' ", con);
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
                MessageBox.Show("Please enter product name...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
        }
        public void updatelens() {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("Update addlens set Sale_Price=" + textBox2.Text + " where Lens_Name='" + textBox1.Text + "' ", con);
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
                MessageBox.Show("Please enter product name...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            //if (comboBox1.SelectedItem == "Frame")
            //{
            //    try
            //    {
            //        SqlConnection con = new SqlConnection(constr);
            //        SqlCommand cmd = new SqlCommand("Delete from addframe where id=" + textBox3.Text + " ", con);
            //        con.Open();
            //        cmd.ExecuteNonQuery();
            //        MessageBox.Show("DONE");
            //        GetInfoFrame();
            //        textBox3.Clear();
            //        con.Close();
            //    }
            //    catch {
            //        MessageBox.Show("Please enter product id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        textBox3.Focus();
            //    }
            //}
            //if (comboBox1.SelectedItem == "Lens")
            //{
            //    try
            //    {
            //        SqlConnection con = new SqlConnection(constr);
            //        SqlCommand cmd = new SqlCommand("Delete from addlens where id=" + textBox3.Text + " ", con);
            //        con.Open();
            //        cmd.ExecuteNonQuery();
            //        MessageBox.Show("DONE");
            //        GetInfoLens();
            //        textBox3.Clear();
            //        con.Close();
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Please enter product id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        textBox3.Focus();
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
                    MessageBox.Show("Please select product...\n   Frame\n   Lens", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        public void deleteframe(){
            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("Delete from addframe where id=" + textBox3.Text + " ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("DONE");
                GetInfoFrame();
                textBox3.Clear();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Please enter product id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
            }
        }
        public void deletelens() {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("Delete from addlens where id=" + textBox3.Text + " ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("DONE");
                GetInfoLens();
                textBox3.Clear();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Please enter product id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
