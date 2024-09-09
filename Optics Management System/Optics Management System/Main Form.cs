using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Optics_Management_System
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product po = new Product();
            po.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier sp = new Supplier();
            sp.Show();
        }

        private void newPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase pr = new Purchase();
            pr.Show();
        }

        private void purchaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_History ph = new Purchase_History();
            ph.Show();
        }

        private void newSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void saleHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale_History sh = new Sale_History();
            sh.Show();
        }

        private void myStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My_Stock ms = new My_Stock();
            ms.Show();
        }

        private void saleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale_Report sr = new Sale_Report();
            sr.Show();
        }

        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchse_Report pr = new Purchse_Report();
            pr.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void saledProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saled_product sp = new saled_product();
            sp.Show();
        }

        private void newSaleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            New_Sale s = new New_Sale();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
