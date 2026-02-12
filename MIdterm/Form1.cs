using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIdterm
{
    public partial class Form1 : Form
    {
        List<Staff> staffList = new List<Staff>(); 
        public Form1()
        {
            InitializeComponent();
            // init data
            Staff[] data = new Staff[] {
                new Staff("Dana", "Female", 25),
                new Staff("Rotha", "Male", 22),
                new Staff("Lola", "Male", 24),
            };
            this.staffList = data.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            string message = "NAME\tGENDER\tAGE\n";
            foreach (Staff s in staffList) { 
                if (s.Gender == "Female")
                {
                    string line = $"{s.Name}\t{s.Gender}\t{s.Age}\n";
                    message += line;
                }
            }
            MessageBox.Show(message);

        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            int removedCount = staffList.RemoveAll(s => s.Age < 20);

            if (removedCount > 0)
                MessageBox.Show($"{removedCount} staff removed!");
            else
                MessageBox.Show("No one under 20!");
        }
    }
    class Staff
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public Staff(string name , string gender ,int age )
        {
            Name = name;
            Gender = gender;
            Age = age;
        }
    }
}
