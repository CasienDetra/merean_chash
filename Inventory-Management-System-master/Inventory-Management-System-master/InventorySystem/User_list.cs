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

namespace InventorySystemCsharp
{
    public partial class User_list : Form 
    {
        private readonly UserController _userController;

        public User_list()
        {
            InitializeComponent();
            _userController = new UserController();
        }

        private void FillUserList()
        {
            DataTable userList = _userController.GetUserList();
            users_list.DataSource = userList;
        }

        private void User_list_Load(object sender, EventArgs e)
        {
            FillUserList();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Admin_home admin = new Admin_home();
            admin.Show();
            this.Close();
        }
    }

    //Create a UserModel class to handle database operations.
    public class UserModel
    {
        private readonly string _connectionString = @"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=inventorymgcsharp;";

        public DataTable GetUsers()
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                MySqlDataAdapter list = new MySqlDataAdapter("SELECT first, last, username, phone, usertype FROM users", conn);
                DataTable dtlist = new DataTable();
                list.Fill(dtlist);
                return dtlist;
            }
        }
    }
    public class UserController
    {
        private readonly UserModel _userModel;

        public UserController()
        {
            _userModel = new UserModel();
        }

        public DataTable GetUserList()
        {
            return _userModel.GetUsers();
        }
    }
}
