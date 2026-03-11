using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace pro_invII
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = "product.txt";
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Add("Product", 150);
            listView1.Columns.Add("Price", 100);
            listView1.Columns.Add("Qty", 100);
            listView1.Columns.Add("Invoice ID", 120);
        }


        private void order_btn_Click(object sender, EventArgs e)
        {
            string productName = txtpro.Text.Trim();
            int orderQty;
            if (productName.Length < 0)
            {
                MessageBox.Show("Please enter a product name.");
                return;
            }

            if (!int.TryParse(txtqty.Text.Trim(), out orderQty) || orderQty <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            string filePath = "product.txt";
            List<product> products = new List<product>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                bool empty = string.IsNullOrWhiteSpace(line);
                if (empty) continue;
                string[] parts = line.Split('#');
                if (parts.Length == 3)
                {
                    products.Add(new product(parts[0], int.Parse(parts[1]), int.Parse(parts[2])));
                }
            }

            bool found = false;
            for (int i = 0; i < products.Count; i++)
            {
                // check wether thwe stock is enough
                if (products[i].name.Equals(productName, StringComparison.OrdinalIgnoreCase))
                {
                    if (products[i].quantity < orderQty)
                    {
                        MessageBox.Show("Not enough stock. Available: " + products[i].quantity);
                        return;
                    }
                    products[i].quantity -= orderQty;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("Product '" + productName + "' not found.");
                return;
            }
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                for (int i = 0; i < products.Count; i++)
                {
                    sw.WriteLine(products[i].name + "#" + products[i].price + "#" + products[i].quantity);
                }
            }
            int price = int.Parse(txtprice.Text.Trim());
            ListViewItem item = new ListViewItem(txtinv.Text.Trim());
            item.SubItems.Add(productName);
            item.SubItems.Add(price.ToString());
            item.SubItems.Add(orderQty.ToString());
            listView1.Items.Add(item);

            MessageBox.Show("Order placed. Quantity updated.");
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to delete.");
                return;
            }

            ListViewItem selected = listView1.SelectedItems[0];
            string productName = selected.SubItems[1].Text;
            int orderQty = int.Parse(selected.SubItems[3].Text);
            string filePath = "product.txt";
            if (File.Exists(filePath))
            {
                List<product> products = new List<product>();
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    string[] parts = line.Split('#');
                    if (parts.Length == 3)
                    {
                        products.Add(new product(parts[0], int.Parse(parts[1]), int.Parse(parts[2])));
                    }
                }

                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].name.Equals(productName, StringComparison.OrdinalIgnoreCase))
                    {
                        products[i].quantity += orderQty;
                        break;
                    }
                }

                using (StreamWriter sw = new StreamWriter(filePath, false))
                {
                    for (int i = 0; i < products.Count; i++)
                    {
                        sw.WriteLine(products[i].name + "#" + products[i].price + "#" + products[i].quantity);
                    }
                }
            }

            listView1.Items.Remove(selected);
        }

        private void txtpro_TextChanged(object sender, EventArgs e)
        {
            string productName = txtpro.Text.Trim();
            txtprice.Text = "";

            if (string.IsNullOrEmpty(productName)) return;

            string filePath = "product.txt";
            if (!File.Exists(filePath)) return;

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                string[] parts = line.Split('#');
                if (parts.Length == 3 && parts[0].Equals(productName, StringComparison.OrdinalIgnoreCase))
                {
                    txtprice.Text = parts[1];
                    txtqty.Text = parts[2];
                    return;
                }
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtinv.Text.Trim()))
            {
                MessageBox.Show("Please enter an invoice ID.");
                return;
            }
            string filePath = "invoice.txt";
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine("Invoice: " + txtinv.Text.Trim());
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    ListViewItem item = listView1.Items[i];
                    string line = item.Text + "\t" +
                                  item.SubItems[1].Text + "\t" +
                                  item.SubItems[2].Text + "\t" +
                                  item.SubItems[3].Text;
                    sw.WriteLine(line);
                }
                sw.WriteLine(); // one blank line between invoices
            }

            MessageBox.Show("Invoice saved.");
            listView1.Items.Clear();
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            string searchInv = txtinv.Text.Trim();
            if (string.IsNullOrEmpty(searchInv))
            {
                MessageBox.Show("Please enter an invoice ID.");
                return;
            }
            string filePath = "invoice.txt";
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Invoice file not found.");
                return;
            }
            string[] lines = File.ReadAllLines(filePath);
            bool found = false;
            listView1.Items.Clear();
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("Invoice: ") &&
                    lines[i].Substring(9).Trim().Equals(searchInv, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                    i++; 
                    while (i < lines.Length &&
                           !lines[i].StartsWith("Invoice: ") 
                           )
                    {
                        string[] parts = lines[i].Split('\t');
                        if (parts.Length == 4)
                        {
                            ListViewItem item = new ListViewItem(parts[0]);
                            item.SubItems.Add(parts[1]);
                            item.SubItems.Add(parts[2]);
                            item.SubItems.Add(parts[3]);
                            listView1.Items.Add(item);
                        }
                        i++;
                    }
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("Invoice '" + searchInv + "' not found.");
            }
        }
    }


    class product
    {
        public string name;
        public int price;
        public int quantity;
        public product(string name, int price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
    }
}

