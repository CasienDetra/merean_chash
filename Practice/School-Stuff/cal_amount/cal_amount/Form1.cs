using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cal_amount
{
    public partial class Form1 : Form

    {
        string store = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.Text = (int.Parse(textBox2.Text) * int.Parse(textBox3.Text) ).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            store += textBox1.Text + "\t" + textBox2.Text + "\t" + textBox3.Text + "\t" + textBox4.Text + "\r\n";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string[] s = store.Split('\n');
            foreach(string ss in s )
            {
                string[] st = ss.Split('\t');
                if (st[0] == textBox1.Text && st[1] == textBox2.Text)
                {
                    textBox3.Text = st[2];
                    textBox4.Text = st[3];
                    return ;

                }

            }
            MessageBox.Show(Text + " not found");
        }
    }
}
