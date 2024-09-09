using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Optics_Management_System
{
    public partial class New_Sale : Form
    {
        string constr= @"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Final Project\Optics Management System\Optics Management System\My Data.mdf;Integrated Security=True";
        public New_Sale()
        {
            InitializeComponent();
        }

        private void New_Sale_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
           
        }

        private void saled_product()
        {
            SqlConnection con = new SqlConnection(constr);
            string ins = "insert into saled_frame_product values ('" + textBox5.Text + "','" + textBox7.Text + "'," + textBox18.Text + "," + textBox9.Text + ")";
            string inse = "insert into saled_lens_product values ('" + textBox10.Text + "','" + textBox16.Text + "'," + textBox18.Text + "," + textBox15.Text + ")";
            SqlCommand cmd = new SqlCommand(ins, con);
            SqlCommand cmd1 = new SqlCommand(inse, con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            con.Close();
        }
        public void saled_prod_get_quantity()
        {
            //SqlConnection con = new SqlConnection(constr);
            //SqlCommand cmd = new SqlCommand("Select * from saled_lens_product where Lens_Name='" + textBox10.Text + "'", con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //SqlDataReader sdr = cmd.ExecuteReader();
            //dt.Load(sdr);
            //foreach (DataRow dr in dt.Rows)
            //{
            //    label36.Text = (dr["Quantity"].ToString());
            //}
            //SqlCommand cmd1 = new SqlCommand("Select * from saled_frame_product where Frame_Name='" + textBox5.Text + "'", con);
            ////con.Open();
            //cmd1.ExecuteNonQuery();
            //DataTable dt1 = new DataTable();
            //SqlDataReader sdr1 = cmd.ExecuteReader();
            //dt1.Load(sdr1);
            //foreach (DataRow dr in dt.Rows)
            //{
            //    label37.Text = (dr["Quantity"].ToString());
            //}
            //con.Close();
        }
        public void update_saled_product()
        {
            //if (textBox5.Text == label40.Text || textBox10.Text == label41.Text)
            //{
            //    //update_saled_lens_product_quantity();
            //    update_saled_frame_product_quantity();
            //}
            //else
            //{
            //    saled_product();
            //}           
        }
        public void update_saled_lens_product_quantity()
        {
            //int a, b, c;            
            //a = Convert.ToInt16(label36.Text);
            //b = Convert.ToInt32(textBox18.Text);
            //c = a + b;
            //label38.Text = ("" + c);
            //SqlConnection con = new SqlConnection(constr);
            //string update = "update saled_lens_product set Quantity=" + label38.Text + " where Lens_Name='" + textBox10.Text + "' ";
            //SqlCommand cmd = new SqlCommand(update, con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();
        }
        public void update_saled_frame_product_quantity()
        {
        //    int a, b, c;
        //    a = Convert.ToInt32(label37.Text);
        //    b = Convert.ToInt32(textBox18.Text);
        //    c = a + b;
        //    label39.Text = ("" + c);
        //    SqlConnection con = new SqlConnection(constr);
        //    string update = "update saled_frame_product set Quantity=" + label39.Text + " where Frame_Name='" + textBox5.Text + "' ";
        //    SqlCommand cmd = new SqlCommand(update, con);
        //    con.Open();
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        }
        private void UpdateLensQuantity()
        {
            int a, b, c;
            a = Convert.ToInt32(label32.Text);
            b = Convert.ToInt32(textBox18.Text);
            c = a - b;
            label34.Text = ("" + c);
            SqlConnection con = new SqlConnection(constr);
            string update = "update addlens set Quantity='" + label34.Text + "' where Lens_Name='" + textBox10.Text + "' ";
            SqlCommand cmd = new SqlCommand(update, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }


        private void UpdateFrameQuantity()
        {
            int a, b, c;
            a = Convert.ToInt32(label31.Text);
            b = Convert.ToInt32(textBox18.Text);
            c = a - b;
            label33.Text = ("" + c);
            SqlConnection con = new SqlConnection(constr);
            string update = "update addframe set Quantity='" + label33.Text + "' where Frame_Name='" + textBox5.Text + "' ";
            SqlCommand cmd = new SqlCommand(update, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void ChackStock()
        {
            int l,f,r;
            f=Convert.ToInt32(label31.Text);
           l =Convert.ToInt32(label32.Text);
            r=Convert.ToInt32(textBox18.Text);
           if(r > l)
           {
               if (MessageBox.Show("Stock are not Available \n Please Purchase the given Lens product \n Available Stock are =   " + l, "Stock Maintain", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
               {
                   textBox18.Focus();
               }
           }
           else if (r <= l)
           {
              
                   int a, b;
                   a = Convert.ToInt32(textBox17.Text);
                   b = Convert.ToInt32(textBox18.Text);
                   int res = a * b;
                   textBox19.Text = ("" + res);
                   textBox20.Text = ("" + res);
                   textBox21.Focus();
               
           }
            if (r > f)
           {
               if (MessageBox.Show("Stock are not Available \n Please Purchase the given Frame product \n Available Stock are =   " + f, "Stock Maintain", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
               {
                   textBox18.Focus();
               }
           }
           else if (r <= f)
           {
               
                   int a, b;
                   a = Convert.ToInt32(textBox17.Text);
                   b = Convert.ToInt32(textBox18.Text);
                   int res = a * b;
                   textBox19.Text = ("" + res);
                   textBox20.Text = ("" + res);
                   textBox21.Focus();
               
           }
        }

        private void FatchLensData()
        {
            SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("Select * from addlens where Lens_Name='" + textBox10.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                foreach (DataRow dr in dt.Rows)
                {
                    textBox11.Text = (dr["Lens_Type"].ToString());
                    textBox12.Text = (dr["Lens_For"].ToString());
                    textBox16.Text = (dr["Company_Name"].ToString());
                    textBox14.Text = (dr["Dia"].ToString());
                    textBox15.Text = (dr["Sale_Price"].ToString());
                    label32.Text = (dr["Quantity"].ToString());
                    textBox13.Text = (dr["Lens_Index"].ToString());
                }
                con.Close();
                int a = Convert.ToInt32(textBox9.Text);
                int b = Convert.ToInt32(textBox15.Text);
                int c = a + b;
                textBox17.Text = ("" + c);
        }

        private void FatchFrameData()
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("Select * from addframe where Frame_Name='" + textBox5.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            foreach (DataRow dr in dt.Rows)
            {
                textBox6.Text = (dr["Frame_type"].ToString());
                textBox7.Text = (dr["Design_No"].ToString());
                textBox8.Text = (dr["Color"].ToString());
                label31.Text = (dr["Quantity"].ToString());
                textBox9.Text = (dr["Sale_Price"].ToString());
            }
            con.Close();
        }

        private void textclear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            comboBox1.Text = "<  Select  >";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                string ins = "insert into product_info values ('" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "'," + textBox9.Text + ",'" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "'," + textBox15.Text + ",'" + textBox16.Text + "'," + textBox17.Text + "," + textBox18.Text + "," + textBox19.Text + ")";
                string inse = "insert into customer_info values ('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "'," + textBox20.Text + "," + textBox21.Text + "," + textBox22.Text + ",'" + comboBox1.Text + "','" + dateTimePicker1.Text + "')";
                SqlCommand cmd = new SqlCommand(ins, con);
                SqlCommand cmd1 = new SqlCommand(inse, con);
                con.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                //MessageBox.Show("DONE","Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
                UpdateFrameQuantity();
                UpdateLensQuantity();
                saled_product();
                //textclear();
                //update_saled_product();
                con.Close();
                if (MessageBox.Show("Do you want print ?...", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Dcustomerprint dcp = new Dcustomerprint(this);
                    dcp.Show();
                }
                else {
                    MessageBox.Show("DONE", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                textclear();
            }
            catch (Exception)
            {
                MessageBox.Show("Data are not Accurate/ Correctly Inserted or Missing....\n\nPlease Try Again....", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerPrint cp = new CustomerPrint();
            cp.Show();            
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab))
            {
                FatchFrameData();
                label40.Text = textBox5.Text;
                textBox10.Focus();
            }
        }

        private void textBox10_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab))
            {
                FatchLensData();
                label41.Text = textBox10.Text;
                textBox18.Focus();
            }
        }

        private void textBox18_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Tab) || (e.KeyCode == Keys.Enter))
            {
                ChackStock();
            }
            //if ((e.KeyCode == Keys.Tab) || (e.KeyCode == Keys.Enter))
            //{
            //   int a, b;
            //    a = Convert.ToInt32(textBox17.Text);
            //    b = Convert.ToInt32(textBox18.Text);
            //    int res = a * b;
            //    textBox19.Text = ("" + res);
            //    textBox20.Text = ("" + res);
            //    textBox21.Focus();
            //}
        }

        private void textBox21_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Tab) || (e.KeyCode == Keys.Enter))
            {
                int a, b;
                a = Convert.ToInt32(textBox20.Text);
                b = Convert.ToInt32(textBox21.Text);
                int res = (a * b) / 100;
                int c = a - res;
                textBox22.Text = ("" + c);
                comboBox1.Focus();
                comboBox1.Text = "<  Select  >";
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Tab) || (e.KeyCode == Keys.Enter))
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Tab) || (e.KeyCode == Keys.Enter))
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Tab) || (e.KeyCode == Keys.Enter))
            {
                textBox4.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Tab) || (e.KeyCode == Keys.Enter))
            {
                textBox5.Focus();
            }
        }

        private void textBox3_Validated(object sender, EventArgs e)
        {
            if ((textBox3.MaxLength != 10) || (textBox3.TextLength != 10))
            {
                errorProvider1.SetError(textBox3, "Please enter 10 digit number");
                textBox3.Focus();
            }
            else
            {
                errorProvider1.SetError(textBox3, "");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           textclear();
           
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBox3, "Please enter 10 digit number.");
                textBox3.Focus();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==20||char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBox1, "Please enter Char Name.");
                textBox1.Focus();
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(textBox1, "");
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            update_saled_product();
            saled_prod_get_quantity();
            //update_saled_lens_product_quantity();
            //update_saled_frame_product_quantity();
        }
    }
}
