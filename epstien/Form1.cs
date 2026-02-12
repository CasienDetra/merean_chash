using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace epstien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            List<product> products = new List<product>();
            MessageBox.Show("Product Added");
        }
    }
    public abstract class store_pro 
    {
        public event EventHandler AfterAdd;
        public event EventHandler BeforeAdd;

        public abstract void Add(object obj);
        public abstract object Get(string name);
        public abstract void Delete(string name);
    }
    public class product
    {
       public string pname { get; set; } 
       public string qty { get; set; } 
       public string price { get; set; } 

        public product (string pname,string qty,string price)
        {
            this.pname = pname;
            this.qty = qty;
            this.price= price;
        }
    }
}
