using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Im_and_Em
{
    public partial class Form1 : Form
    {
        string[] report_inv = new string[100];
        string[] report_price = new string[100];
        string[] report_qty = new string[100];
        string[] report_amount = new string[100];
        // track the index of the arrays
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void calculate_amount()
        {
            bool a = double.TryParse(price_txt.Text, out double price);
            bool b = double.TryParse(qty_txt.Text, out double qty);

            if (a && b)
            {
                double amount = price * qty;
                amount_txt.Text = amount.ToString("0.00") ;
            }
            else
            {
                amount_txt.Text = "0.00" 
                  //+"$"
                    ;
            }

        }

        private void amount_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void qty_txt_TextChanged(object sender, EventArgs e)
        {
            calculate_amount();
        }

        private void price_txt_TextChanged(object sender, EventArgs e)
        {
            calculate_amount();
        }

        private void report_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (index < 100)
                {
                    report_inv[index] = inv_txt.Text;
                    report_price[index] = price_txt.Text;
                    report_qty[index] = qty_txt.Text;
                    report_amount[index] = amount_txt.Text;
                    index++;
                    string allReports = "";
                    double totalAmount = 0;

                    allReports += "--------------------------------------------------------\n";
                    allReports += "Invoice: " .PadRight(15);
                    allReports += "Price: "  .PadRight(15);
                    allReports += "Quantity: ".PadRight(15);
                    allReports += "Amount: "  .PadRight(15)+"\n";
                    allReports += "--------------------------------------------------------\n";
                    for (int i = 0; i < index; i++)
                    {
                        double sub_total = 0;
                        double .TryParse(report_amount[i], out sub_total);
                        totalAmount += sub_total;
                        allReports += report_inv[i].PadRight(15);
                        allReports += (report_price[i] + "$").PadRight(18);
                        allReports += report_qty[i].PadRight(18);
                        allReports += (report_amount[i] + "$").PadRight(18)+"\n";
                    allReports += "--------------------------------------------------------\n";
                    }
                    allReports += "Total Amount: " + totalAmount.ToString("0.00") + "$\n";

                    MessageBox.Show(allReports);
                }
                else
                {
                    MessageBox.Show("Report limit reached");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error in adding report");

            }
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("succesfully pay");
        }
    }
}
