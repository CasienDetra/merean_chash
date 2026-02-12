using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace palaceoa
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            staff s = new staff();
            s.name = txtname.Text;
            s.sex = txtsex.Text;
            s.phone = txtphone.Text;
            s.date = datestartwork.Value;

            Istaff istaff = new staff();
            istaff.Add_stuff(s);

            txtname.Clear();
            txtsex.Clear();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            Istaff istaff = new staff();
            staff s = istaff.Get_stuff(txtphone.Text) as staff;

            if (s != null)
            {
                MessageBox.Show(
                    $"Name: {s.name}\n" +
                    $"Sex: {s.sex}\n" +
                    $"Phone: {s.phone}\n" +
                    $"Worked: {s.date} days"
                );
            }
            else
            {
                MessageBox.Show("Staff not found");
            }
        }

        private void report_Click(object sender, EventArgs e)
        {
            Istaff istaff = new staff();
            istaff.show_stuff(365);
        }
        interface Istaff
        {
            void Add_stuff(object obj);
            object Get_stuff(string phone);
            void show_stuff();
            void show_stuff(int age);

        }

        class staff : Istaff
        {
            public List<staff> stafflist = new List<staff>();
            public string name { get; set; }
            public string sex { get; set; }
            public string phone { get; set; }
            public DateTime date { get; set; }

            public int age
            {
                get
                {
                    return (DateTime.Now - date).Days;
                }
            }
            public void Add_stuff(object obj)
            {
                staff s = obj as staff;
                if (s != null)
                {
                    stafflist.Add(s);
                }
            }
            public object Get_stuff(string phone)
            {
                throw new NotImplementedException();
            }
            public void show_stuff()
            {
                string result = "";
                foreach (var s in stafflist)
                {
                    result += $"{s.name} | {s.phone} | {s.date} days worked\n";
                }

                MessageBox.Show(result == "" ? "No staff data" : result);
            }
            public void show_stuff(int age)
            {

                string result = "";
                foreach (var s in stafflist.Where(s => s.age >= age))
                {
                    result += $"{s.name} - {s.age} days\n";
                }

                MessageBox.Show(result == "" ? "No matching staff" : result);
            }
        }
    }
}
