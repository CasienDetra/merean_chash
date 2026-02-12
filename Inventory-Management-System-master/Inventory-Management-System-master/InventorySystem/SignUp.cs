using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace InventorySystemCsharp
{
    public partial class SignUp : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly IFormNavigator _formNavigator;

        public SignUp()
        {
            InitializeComponent();
            _userRepository = new UserRepository(DatabaseConnection.Instance);
            _formNavigator = new FormNavigator();
        }

        // Constructor for testing with mock dependencies
        public SignUp(IUserRepository userRepository, IFormNavigator formNavigator)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _formNavigator = formNavigator;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _formNavigator.NavigateTo<Login>(this);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            if (!ValidatePasswordMatch())
                return;

            try
            {
                var newUser = new UserRegistration
                {
                    FirstName = bunifuMetroTextbox1.Text.Trim(),
                    LastName = bunifuMetroTextbox2.Text.Trim(),
                    Username = bunifuMetroTextbox3.Text.Trim(),
                    Phone = bunifuMetroTextbox4.Text.Trim(),
                    Password = MD5Hash(bunifuMetroTextbox5.Text.Trim())
                };

                bool success = _userRepository.RegisterUser(newUser);
    
                if (success)
                {
                    MessageBox.Show("Registration successful");
                    _formNavigator.NavigateTo<Login>(this);
                }
            }
            catch (MySqlException ex) when (ex.Number == 1062) // Duplicate entry
            {
                MessageBox.Show("Username is already taken");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registration failed: {ex.Message}");
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(bunifuMetroTextbox1.Text) ||
                string.IsNullOrWhiteSpace(bunifuMetroTextbox2.Text) ||
                string.IsNullOrWhiteSpace(bunifuMetroTextbox3.Text) ||
                string.IsNullOrWhiteSpace(bunifuMetroTextbox4.Text) ||
                string.IsNullOrWhiteSpace(bunifuMetroTextbox5.Text) ||
                string.IsNullOrWhiteSpace(bunifuMetroTextbox6.Text))
            {
                MessageBox.Show("Please fill all fields");
                return false;
            }
            return true;
        }

        private bool ValidatePasswordMatch()
        {
            if (bunifuMetroTextbox5.Text != bunifuMetroTextbox6.Text)
            {
                MessageBox.Show("Passwords don't match");
                return false;
            }
            return true;
        }

        public static string MD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();

                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // User registration model
    public class UserRegistration
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
    }

    // Extended UserRepository from Login form
    public partial class UserRepository : IUserRepository
    {
        public bool RegisterUser(UserRegistration user)
        {
            using (var conn = _dbConnection.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO users 
                          (first, last, username, phone, password, usertype) 
                          VALUES (@firstName, @lastName, @username, @phone, @password, 'member')";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@firstName", user.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", user.LastName);
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@phone", user.Phone);
                    cmd.Parameters.AddWithValue("@password", user.Password);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }

    // Form navigation interface
    public interface IFormNavigator
    {
        void NavigateTo<T>(Form currentForm) where T : Form, new();
    }

    public class FormNavigator : IFormNavigator
    {
        public void NavigateTo<T>(Form currentForm) where T : Form, new()
        {
            var newForm = new T();
            newForm.FormClosed += (s, args) => currentForm.Close();
            currentForm.Hide();
            newForm.Show();
        }
    }
}
