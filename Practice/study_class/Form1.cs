using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study_class
{
    public partial class Form1 : Form
    {

        Book[] b;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            b = new Book[3] {new Book("b001","C#","Mr.cs",25), new Book("b002", "C++", "Mr.cs", 65), new Book("b003", "khmer","Mr.cs", 25) };
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            Array.Resize(ref b, b.Length + 1);
            int n = b.Length -  1;
            b[n] = new Book();
            b[n].id = text_Bid.Text;
            b[n].title = text_title.Text.Trim();
            b[n].aname = text_author.Text.Trim();
            b[n].qty = int.Parse(text_qty.Text);
        }

        private void show_btn_Click(object sender, EventArgs e)
        {

            foreach(Book s in b)
            {
                MessageBox.Show("Book ID: " + s.id + "\n" + "Title: " + s.title + "\n" + "Author Name: " + s.aname + "\n" + "Quantity: " + s.qty);
            }
        }
        private void remove_btn_Click(object sender, EventArgs e)
        {

        }
    }
    class Book
    {
        public string id;
        public string title;
        public string aname;
        public int qty;

        // 👉 Default constructor
        public Book()
        {
            id = "";
            title = "";
            aname = "";
            qty = 0;
        }

        // 👉 Parameterized constructor
        public Book(string id, string title, string aname, int qty)
        {
            this.id = id;
            this.title = title;
            this.aname = aname;
            this.qty = qty;
        }
    }
}
