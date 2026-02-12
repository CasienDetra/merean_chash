using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forreal
{
    public partial class Form1 : Form
    {
        string store = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtamount_Enter(object sender, EventArgs e)
        {
            txtamount.Text = (double.Parse(txtqty.Text) * double.Parse(txtprice.Text)).ToString();

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
           store = store + txtid.Text + "\t" + txtname.Text + "\t" + txtqty.Text + "\t" + txtprice.Text +"\t" + txtamount.Text +"\n";
            txtid.Clear();
            txtname.Clear();
            txtqty.Clear();
            txtprice.Clear();
            txtamount.Clear();
            txtname.Focus();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string[] s = store.Split('\n');
            foreach (string item in s)
            {
                string [] ss = item.Split('\t');
                if (ss[0] == txtid.Text && ss[1] == txtname.Text)
                {
                    deletebtn.Enabled = true;
                    txtqty.Text = ss[2];
                    txtprice.Text = ss[3];
                    txtamount.Text = ss[4];
                    return;
                }
                deletebtn.Enabled = false;
                MessageBox.Show("Not Found" + txtid.Text + txtname.Text);
            }
        }

        private void reportbtn_Click(object sender, EventArgs e)
        {
           string[] s = store.Split('\n');
            string report = "ID\tName\tQty\tPrice\tAmount\n";
            foreach (string item in s)
            {
                string[] ss = item.Split('\t');
                if (ss.Length > 1)
                {
                    report = report + item + "\n";
                }
            }
            MessageBox.Show(report); 
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            deletebtn.Enabled = false;
            string[] s = store.Split('\n');
            string newstore = "";
            bool found = false;

            foreach (string item in s)
            {
                if (item.Length > 0) 
                {
                    string[] ss = item.Split('\t');
                    if (ss.Length > 1 && ss[0] == txtid.Text && ss[1] == txtname.Text)
                    {
                        found = true;
                        continue;
                    }
                    newstore = newstore + item + "\n";
                }
            }

            if (found)
            {
                store = newstore;
                MessageBox.Show("deleted successfully!");
                txtid.Clear();
                txtname.Clear();
                txtqty.Clear();
                txtprice.Clear();
                txtamount.Clear();
                deletebtn.Enabled = false;
                txtname.Focus();
            }
            else
            {
                MessageBox.Show("not found!");
            }
        }
    }
}
