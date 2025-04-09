using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork_OOP
{
    public partial class RegistrationForm : Form
    {
        private string jsonPath = @"dataBase\users.json";
        private List<Seller> sellers = new List<Seller>();
        private List<Customer> customers = new List<Customer>();

        public RegistrationForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public void InitializeForm()
        {
            if (!File.Exists(jsonPath))
            {
                MessageBox.Show("Cars JSON file not found!");
                return;
            }

            string jsonText = File.ReadAllText(jsonPath);
            ListOfUsers listOfUsers = JsonSerializer.Deserialize<ListOfUsers>(jsonText);

            foreach (var user in listOfUsers.Sellers)
            {
                sellers.Add(user);
            }
            foreach (var user in listOfUsers.Customers)
            {
                customers.Add(user);
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void AddUser()
        {
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text) ||
                string.IsNullOrWhiteSpace(textBoxConfirmPassword.Text))
            {
                MessageBox.Show("One of the fields is empty!");
                return;
            }

            if (textBoxPassword.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            // Ensure file exists and is properly formatted
            if (!File.Exists(jsonPath) || new FileInfo(jsonPath).Length == 0)
            {
                File.WriteAllText(jsonPath, JsonSerializer.Serialize(new ListOfUsers(), new JsonSerializerOptions { WriteIndented = true }));
            }

            // Load users from JSON
            string jsonText = File.ReadAllText(jsonPath);
            ListOfUsers users = JsonSerializer.Deserialize<ListOfUsers>(jsonText) ?? new ListOfUsers();

            // Check for duplicate users
            if (users.Sellers.Any(u => u.Login == textBoxLogin.Text || u.Email == textBoxEmail.Text) ||
                users.Customers.Any(u => u.Login == textBoxLogin.Text || u.Email == textBoxEmail.Text))
            {
                MessageBox.Show("A user with this login/email already exists!");
                return;
            }

            // Add new user
            if (checkBoxUser.Checked)
            {
                users.Customers.Add(new Customer
                {
                    Login = textBoxLogin.Text,
                    Email = textBoxEmail.Text,
                    Password = textBoxPassword.Text
                });
            }

            if (checkBoxSeller.Checked)
            {
                users.Sellers.Add(new Seller
                {
                    Login = textBoxLogin.Text,
                    Email = textBoxEmail.Text,
                    Password = textBoxPassword.Text
                });
            }
            // Save updated data to JSON
            string updatedJson = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(jsonPath, updatedJson);

            MessageBox.Show("User has been created!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

    }
}
