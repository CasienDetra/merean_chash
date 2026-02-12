using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace InventorySystemCsharp
{
    public partial class Admin_home : Form
    {
        private readonly IFormFactory _formFactory;

        public Admin_home() : this(new FormFactory()) { }

        public Admin_home(IFormFactory formFactory)
        {
            InitializeComponent();
            _formFactory = formFactory;
            slide_panel.Height = dashboard_btn.Height;
            dashboard_panel.BringToFront();
        }

        //logout button
        private void logout_btn_Click(object sender, EventArgs e)
        {
            var login = _formFactory.CreateForm("Login");
            var userlist = _formFactory.CreateForm("User_list");
            userlist.Close();
            this.Close();
            login.Show();
        }

        //close button
        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //------------------------------------navigation pane button events
        //dashboard button
        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            slide_panel.Height = dashboard_btn.Height;
            slide_panel.Top = dashboard_btn.Top;
            dashboard_panel.BringToFront();
        }

        //add manager button
        private void add_manager_btn_Click(object sender, EventArgs e)
        {
            slide_panel.Height = add_manager_btn.Height;
            slide_panel.Top = add_manager_btn.Top;
            add_manager_panel.BringToFront();
            var user = _formFactory.CreateForm("User_list");
            user.Close();
        }

        private void user_list_btn_Click(object sender, EventArgs e)
        {
            slide_panel.Height = user_list_btn.Height;
            slide_panel.Top = user_list_btn.Top;
            var users_list = _formFactory.CreateForm("User_list");
            users_list.Show();
            this.Hide();
        }

        ////////////////////////////////////---------------DASHBOARD PANEL FUNCTIONS----------///////////////////////////////////////

        private void user_home_btn_Click(object sender, EventArgs e)
        {
            var user_home = _formFactory.CreateForm("Home");
            user_home.Show();
        }

        private void manager_home_btn_Click(object sender, EventArgs e)
        {
            var manager = _formFactory.CreateForm("Manager_home");
            manager.Show();
        }

        private void item_check_btn_Click(object sender, EventArgs e)
        {
            var manager = _formFactory.CreateForm("Manager_home");
            manager.Show();
        }

        private void check_orders_btn_Click(object sender, EventArgs e)
        {
            var manager = _formFactory.CreateForm("Manager_home");
            manager.Show();
        }

        ////////////////////////////////////---------------Add manager PANEL FUNCTIONS----------///////////////////////////////////////

        private void Mregister_btn_Click(object sender, EventArgs e)
        {
            if (MfnameTxt.Text != "" && MlnameTxt.Text != "" && MusernameTxt.Text != "" && MphonenumTxt.Text != "" && MpassTxt.Text != "" && MrepassTxt.Text != "" && typecomboTxt.Text != "")
            {
                if (MpassTxt.Text == MrepassTxt.Text)
                {
                    try
                    {
                        MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=inventorymgcsharp;");
                        string query = "insert into `users`(`first`,`last`,`username`,`phone`,`password`,`usertype`) values('" + MfnameTxt.Text.Trim() + "','" + MlnameTxt.Text.Trim() + "','" + MusernameTxt.Text.Trim() + "','" + MphonenumTxt.Text.Trim() + "','" + MD5Hash(MpassTxt.Text.Trim()) + "','" + typecomboTxt.Text.Trim() + "')";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("New Manager account has been created successfully!");
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("This Username is already taken!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Given password doesn't match!!");
                }
            }
            else
                MessageBox.Show("Fill all fields");
        }

        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        private void brnlogout_Click(object sender, EventArgs e)
        {
            var login = _formFactory.CreateForm("Login");
            this.Close();
            login.Show();
        }
    }

    // Factory Pattern for creating forms
    public interface IFormFactory
    {
        Form CreateForm(string formName);
    }

    public class FormFactory : IFormFactory
    {
        public Form CreateForm(string formName)
        {
            switch (formName)
            {
                case "Login":
                    return new Login();
                case "User_list":
                    return new User_list();
                case "Home":
                    return new Home();
                case "Manager_home":
                    return new Manager_home();
                default:
                    throw new ArgumentException($"Form '{formName}' not recognized.");
            }
        }
    }
}
