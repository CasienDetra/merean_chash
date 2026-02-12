using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workingwithclass
{
    class Data
    {
        private string id;
        private string pro_name;
        private float pro_price;
        private int pro_qty;


        public string Id { get; set; } 
        public string Pro_name { get; set; } 
        public float Pro_price { get; set; } 
        public int Pro_qty { get; set; } 
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string file = openFileDialog1.FileName;
        }
    }
}
