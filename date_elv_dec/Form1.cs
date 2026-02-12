using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace date_elv_dec
{
    public partial class Form1 : Form
    {
        private delegate double del_amount(int qty, double price);
        List<product> store = new List<product>();

        public Form1()
        {
            InitializeComponent();
            product.delegate_amount = this.delegate_amount;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
                store.Add(new product(item_txt.Text,
                    int.Parse(qty_txt.Text), double.Parse(price_txt.Text)));
        }

        private void Search_Click(object sender, EventArgs e)
        {
            foreach (product p in store)
            {
                if (p.pname.Equals(item_txt.Text)) 
                {
                    qty_txt.Text = p.qty.ToString();
                    price_txt.Text = p.price.ToString();
                    amont_txt.Text = p.Amount().ToString("F2");
                    return;
                }
            }
            MessageBox.Show("Item not found");
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < store.Count; i++)
            {
                if (store[i].pname.Equals(item_txt.Text))
                {
                    store.RemoveAt(i);
                    MessageBox.Show("Item deleted successfully!");
                    return;
                }
            }
            MessageBox.Show("Item not found");
        }

        private void amont_txt_Enter(object sender, EventArgs e)
        {
                amont_txt.Text = (int.Parse(qty_txt.Text) * double.Parse(price_txt.Text)).
                    ToString("F2");
        }

        private double delegate_amount(int qty, double price)
        {
            double base_amount = qty * price;
            double final_amount;

            if (base_amount > 75.0)
            {
                final_amount = base_amount * 0.75;
            }
            else if (base_amount >= 50.0)
            {
                final_amount = base_amount * 0.85; 
            }
            else 
            {
                final_amount = base_amount; 
            }
            return final_amount;
        }
    }

    class product
    {
        public static Func<int, double, double> delegate_amount;

        public string pname { get; set; }
        public int qty { get; set; }
        public double price { get; set; }

        public product(string pname, int qty, double price)
        {
            this.pname = pname;
            this.qty = qty;
            this.price = price;
        }

        public double Amount()
        {
            return delegate_amount(qty, price);
        }
    }
}