using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_mag
{
    class data
    {
        public string Invid { get; set; }
        public string Proid { get; set; }
        public int Qty { get; set; }
        public float Price { get; set; }
        // default constructor
        public data()
        {
            Invid = "";
            Proid = "";
            Qty = 0;
            Price = 0.0f;
        }
    }
    public partial class Form1 : Form
    {
        List<data> store = new List<data>();
        public Form1()
        {
            InitializeComponent();
            //listView1.Items.Add("Item 1");
            //listView1.Items[listView1.Items.Count - 1].SubItems.Add("Subitem 1a");
            //listView1.Items[listView1.Items.Count - 1].SubItems.Add("Subitem 2a");
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            data d = new data()
            {
                Invid = inv_txt.Text,
                Proid = pro_txt.Text,
                Qty = int.Parse(qty_txt.Text),
                Price = float.Parse(price_txt.Text)
            };
            store.Add(d);
             ListViewItem lvi = new ListViewItem(d.Invid);
              lvi.SubItems.Add(d.Proid);
              lvi.SubItems.Add(d.Qty.ToString());
              lvi.SubItems.Add(d.Price.ToString());
              listView1.Items.Add(lvi);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
