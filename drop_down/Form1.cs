using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace drop_down
{
    public partial class Form1 : Form
    {
        List<data> store = new List<data>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {


            string selected_combo = p_txt.SelectedItem.ToString();
            string[] parts = selected_combo.Split(' ');
            string name = parts[0].Trim();
            int qty = int.Parse(parts[1]);
            int buy = int.Parse(qty_txt.Text.Trim());

            qty =  qty - buy;

            string updatedText = $"{name} {qty}";
            p_txt.Items[p_txt.SelectedIndex] = updatedText;

            data d = new data()
            {
                invid = inv_txt.Text,
                proname = p_txt.Text,
                qty = int.Parse(qty_txt.Text),
                price = double.Parse(price_txt.Text)
            };
            store.Add(d);

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string searchtxt = inv_txt.Text;
            List<data> new_result = new List<data>();
            foreach (data d in store)
            {
                if (d.invid == searchtxt)
                {
                    new_result.Add(d);
                }
            }
            foreach (data d in new_result)
            {
                ListViewItem lv = new ListViewItem(d.invid);
                lv.SubItems.Add(d.proname);
                lv.SubItems.Add(d.qty.ToString());
                lv.SubItems.Add(d.price.ToString());
                listView1.Items.Add(lv);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = listView1.SelectedIndices[0];
                string store_the_invid = listView1.Items[selectedIndex].SubItems[0].Text;
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                foreach (data d in store.ToList())
                {
                    if (d.invid == store_the_invid)
                    {
                        store.Remove(d);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("please select item in listview to delete");

            }
        }

        private void p_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
    class data {
        public string invid;
        public string proname;
        public int qty;
        public double price;
    }
}
