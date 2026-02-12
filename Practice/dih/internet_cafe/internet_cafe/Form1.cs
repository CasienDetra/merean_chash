using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace internet_cafe
{
    public partial class Form1 : Form
    {
        private string report;
        private bool is_Inused = false;
        private string[] pc_name = new string[100];
        private int pc_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pc_index = Convert.ToInt32(textBox4.Text);
            string[] pc = new string[pc_index];
            textBox1.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = DateTime.Now.ToString("hh:mm:ss");
            textBox3.Text = (Convert.ToDateTime(textBox2.Text) - Convert.ToDateTime(textBox1.Text)).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
