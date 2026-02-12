using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystemCsharp
{
    public partial class Login : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly IHomeFormFactory _homeFormFactory;

        public Login()
        {
            InitializeComponent();
            _userRepository = new UserRepository(DatabaseConnection.Instance);
            _homeFormFactory = new HomeFormFactory();
        }

        public Login(IUserRepository userRepository, IHomeFormFactory homeFormFactory) // For testing
        {
            InitializeComponent();
            _userRepository = userRepository;
            _homeFormFactory = homeFormFactory;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigateToForm(new SignUp());
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string username = bunifuMetroTextbox1.Text.Trim();
            string password = MD5Hash(bunifuMetroTextbox2.Text.Trim());

            try
            {
                var user = _userRepository.Authenticate(username, password);

                if (user != null)
                {
                    var homeForm = _homeFormFactory.CreateHomeForm(user.UserType);
                    NavigateToForm(homeForm);
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login failed: {ex.Message}");
            }
        }

        private void NavigateToForm(Form form)
        {
            form.FormClosed += (s, args) => this.Close();
            this.Hide();
            form.Show();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

    // Repository Pattern
    public interface IUserRepository
    {
        User Authenticate(string username, string password);
        bool RegisterUser(UserRegistration user); // Uncomment if needed
    }

    public partial class UserRepository : IUserRepository
    {
        private readonly DatabaseConnection _dbConnection;

        public UserRepository(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public User Authenticate(string username, string password)
        {
            using (var conn = _dbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT username, usertype FROM users WHERE username = @username AND password = @password";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                Username = reader["username"].ToString(),
                                UserType = reader["usertype"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }
    }

    // Singleton Pattern for database connection
    public sealed class DatabaseConnection
    {
        private static readonly Lazy<DatabaseConnection> instance =
            new Lazy<DatabaseConnection>(() => new DatabaseConnection());

        public static DatabaseConnection Instance => instance.Value;

        private readonly string _connectionString;

        private DatabaseConnection()
        {
            _connectionString = @"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=inventorymgcsharp;";
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }

    // User model
    public class User
    {
        public string Username { get; set; }
        public string UserType { get; set; }
    }

    // Factory Pattern for creating home forms
    public interface IHomeFormFactory
    {
        Form CreateHomeForm(string userType);
    }

    public class HomeFormFactory : IHomeFormFactory
    {
        public Form CreateHomeForm(string userType)
        {
            switch (userType.ToLower())
            {
                case "admin":
                    return new Admin_home();
                case "manager":
                    return new Manager_home();
                case "member":
                default:
                    return new Home();
            }
        }
    }
}
