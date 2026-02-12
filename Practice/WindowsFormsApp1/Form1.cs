using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // The header text is now a constant for clarity.
        private const string HeaderText = "id\tname\tsex\tphone";

        public Form1()
        {
            InitializeComponent();
            // Add the header when the form loads.
            listBox1.Items.Add(HeaderText);
        }

        // This event is now used to populate textboxes when a user selects an item.
        // This is much more useful than the original, empty event handler.
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure something is selected and it's not the header row.
            if (listBox1.SelectedIndex > 0 && listBox1.SelectedItem != null)
            {
                // Split the selected item's text by the tab character.
                string[] parts = listBox1.SelectedItem.ToString().Split('\t');

                // Check if the data is valid before trying to access it.
                if (parts.Length == 4)
                {
                    // Populate the textboxes with the data from the selected row.
                    id_txt.Text = parts[0];
                    name_txt.Text = parts[1];
                    sex_txt.Text = parts[2];
                    phone_txt.Text = parts[3];
                }
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            // Check that the ID textbox is not empty before adding.
            if (string.IsNullOrWhiteSpace(id_txt.Text))
            {
                MessageBox.Show("ID cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                id_txt.Focus();
                return;
            }

            // Your original logic for adding an item was correct.
            string item = $"{id_txt.Text}\t{name_txt.Text}\t{sex_txt.Text}\t{phone_txt.Text}";
            listBox1.Items.Add(item);

            // Clear the textboxes for the next entry.
            id_txt.Clear();
            name_txt.Clear();
            sex_txt.Clear();
            phone_txt.Clear();

            id_txt.Focus();
        }

        // This click event was causing issues by adding blank lines.
        // It's not needed if you use SelectedIndexChanged, so it has been cleared.
        private void listBox1_Click(object sender, EventArgs e)
        {
            // This event is intentionally left empty to prevent the previous bug.
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            // Get the search term from the ID textbox.
            string searchTerm = id_txt.Text;

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please enter an ID to search for.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool itemFound = false;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string item = listBox1.Items[i].ToString();
                string[] parts = item.Split('\t');

                // Check if the first part (the ID) matches the search term.
                if (parts.Length > 0 && parts[0] == searchTerm)
                {
                    // If a match is found, select the item in the list.
                    listBox1.SelectedIndex = i;
                    itemFound = true;
                    // Stop searching once the item is found.
                    break;
                }
            }

            if (!itemFound)
            {
                MessageBox.Show($"No item found with ID: {searchTerm}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            // Check if an actual item is selected (and not the header at index 0).
            if (listBox1.SelectedIndex > 0)
            {
                // Remove the item at the currently selected index.
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                // Clear the textboxes to avoid showing data for a deleted item.
                id_txt.Clear();
                name_txt.Clear();
                sex_txt.Clear();
                phone_txt.Clear();

                id_txt.Focus();
            }
            else
            {
                // Inform the user if they haven't selected an item or tried to select the header.
                MessageBox.Show("Please select an item from the list to remove.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}