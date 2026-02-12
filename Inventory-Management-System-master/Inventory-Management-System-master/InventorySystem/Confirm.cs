using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace InventorySystemCsharp
{
    public partial class Confirm : Form
    {
        private readonly ICommandExecutor _commandExecutor;
        public Home MyParent { get; set; }

        public Confirm() : this(new CommandExecutor()) { }

        public Confirm(ICommandExecutor commandExecutor)
        {
            InitializeComponent();
            _commandExecutor = commandExecutor;
        }

        private void Confirm_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = MyParent.ItemList;
        }

        private void Confirm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyParent.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _commandExecutor.Execute(new ResetParentStateCommand(MyParent));
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new userdetail();
                var query = $"INSERT INTO `orders`(`user`,`details`,`price`) VALUES('{user.getUname()}','{MyParent.ItemList}',{MyParent.TotalPrice});{MyParent.UpdateQuery}";

                _commandExecutor.Execute(new UpdateDatabaseCommand(query));
                MessageBox.Show("Success");

                button1_Click(sender, e); // Reset parent state and close
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    // Command Pattern Interfaces and Implementations
    public interface ICommand
    {
        void Execute();
    }

    public class ResetParentStateCommand : ICommand
    {
        private readonly Home _parent;

        public ResetParentStateCommand(Home parent)
        {
            _parent = parent;
        }

        public void Execute()
        {
            _parent.ItemList = "";
            _parent.TotalPrice = 0;
            _parent.UpdateQuery = "";
        }
    }

    public class UpdateDatabaseCommand : ICommand
    {
        private readonly string _query;

        public UpdateDatabaseCommand(string query)
        {
            _query = query;
        }

        public void Execute()
        {
            using (var conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=inventorymgcsharp;"))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(_query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

    public interface ICommandExecutor
    {
        void Execute(ICommand command);
    }

    public class CommandExecutor : ICommandExecutor
    {
        public void Execute(ICommand command)
        {
            command.Execute();
        }
    }
}
