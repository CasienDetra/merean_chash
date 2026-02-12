using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace give_stu_grade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            decimal score;
            if (decimal.TryParse(textBox1.Text, out score))
            {
                if (score >= 90)
                    textBox2.Text = "A";
                else if (score >= 80)
                    textBox2.Text = "B";
                else if (score >= 70)
                    textBox2.Text = "C";
                else if (score >= 60)
                    textBox2.Text = "D";
                else
                    textBox2.Text = "F";
            }
            else
            {
                textBox2.Text = "";
            }
        }
    }
}
