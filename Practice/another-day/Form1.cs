using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace another_day
{
    public partial class Form1 : Form
    {
        byte[][] store = new byte[1][];
        int n; 
        public Form1()
        {
            InitializeComponent();
        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);

            MemoryStream M = new MemoryStream();
            pictureBox1.Image.Save(M, pictureBox1.Image.RawFormat);
            store[store.Length - 1] = M.GetBuffer();
            n = store.Length;
            Array.Resize(ref store, store.Length + 1);


        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;

        }

        private void previousll_btn_Click(object sender, EventArgs e)
        {
            if (store.Length == 0 || n == 0)
            {
                MessageBox.Show("No Previous Image");
                return;
            }

            n--;
            pictureBox1.Image = Image.FromStream(new MemoryStream(store[n]));
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (store.Length == 0 || n >= store.Length - 2)
            {
                MessageBox.Show("No Next Image");
                return;
            }

            n++;
            MemoryStream M = new MemoryStream(store[n]);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromStream(M);
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            if (store.Length <= 1 || n >= store.Length)
            {
                MessageBox.Show("No image to remove.");
                return;
            }
            byte [][] temp = new byte[store.Length - 1][];
            if(n == 0)
            {
                Array.Copy(store, 1, temp, 0, store.Length - 1);
            }
            else if(n == store.Length - 1)
            {
                Array.Copy(store, 0, temp, 0, store.Length - 1);
            }
            else
            {
                Array.Copy(store, 0, temp, 0, n);
                Array.Copy(store, n + 1, temp, n, store.Length - n - 1);
            }
            store = temp;
            pictureBox1.Image = null;
        }
    }
}
