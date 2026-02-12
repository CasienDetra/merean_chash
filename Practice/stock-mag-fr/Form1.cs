using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_mag_fr
{

    public partial class Form1 : Form
    {
        List<data> store = new List<data>();

        public Form1()
        {
            InitializeComponent();
            listView1.Columns.Add("Inv ID", 158);
            listView1.Columns.Add("Pro ID", 108);
            listView1.Columns.Add("Qty", 108);
            listView1.Columns.Add("Price", 108);
            remove_btn.Enabled = false;
        }

             private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                data d = new data()
                {
                    Invid = inv_txt.Text,
                    Proid = pro_txt.Text,
                    Qty = int.Parse(qty_txt.Text),
                    Price = float.Parse(price_txt.Text)
                };
                store.Add(d);
                pro_txt.Clear();
                qty_txt.Clear();
                price_txt.Clear();
            }
            catch (Exception ex)
            {
                DialogResult dr = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            foreach (data d in store)
            {
                ListViewItem item = new ListViewItem(d.Invid);
                item.SubItems.Add(d.Proid);
                item.SubItems.Add(d.Qty.ToString());
                item.SubItems.Add(d.Price.ToString("0.00"));

                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            remove_btn.Enabled = true;

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string Searchtext = inv_txt.Text;
            List<data> result = new List<data>();
            foreach (data d in store)// find macthcing in list store
            {
                if (d.Invid == Searchtext)
                {
                    result.Add(d);
                }
            }
            foreach (data d in result)
            {
                ListViewItem item = new ListViewItem(d.Invid);
                item.SubItems.Add(d.Proid);
                item.SubItems.Add(d.Qty.ToString());
                item.SubItems.Add(d.Price.ToString("0.00"));
                listView1.Items.Add(item);
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = listView1.SelectedIndices[0];
                string store_of_inv = listView1.Items[selectedIndex].SubItems[0].Text;
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                foreach (data d in store.ToList())
                {
                    if (d.Invid == store_of_inv)
                    {
                        store.Remove(d);
                    }
                }
            }
            catch (Exception ex)
            {
                DialogResult dr = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        class data
        {
            public string Invid;
            public string Proid;
            public int Qty;
            public float Price;

        }
    }
}
