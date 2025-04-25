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
        private Form1 mainForm;

        public RegistrationForm(Form1 form)
        {
            mainForm = form;
            InitializeComponent();
            InitializeForm();
            this.CenterToScreen();
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

            if (!File.Exists(jsonPath) || new FileInfo(jsonPath).Length == 0)
            {
                File.WriteAllText(jsonPath, JsonSerializer.Serialize(new ListOfUsers(), new JsonSerializerOptions { WriteIndented = true }));
            }

            string jsonText = File.ReadAllText(jsonPath);
            ListOfUsers users = JsonSerializer.Deserialize<ListOfUsers>(jsonText) ?? new ListOfUsers();

            if (users.Sellers.Any(u => u.Login == textBoxLogin.Text || u.Email == textBoxEmail.Text) ||
                users.Customers.Any(u => u.Login == textBoxLogin.Text || u.Email == textBoxEmail.Text))
            {
                MessageBox.Show("A user with this login/email already exists!");
                return;
            }

            if (checkBoxUser.Checked)
            {
                users.Customers.Add(new Customer
                {
                    Login = textBoxLogin.Text,
                    Email = textBoxEmail.Text,
                    Password = textBoxPassword.Text
                });
                mainForm.customers.Add(new Customer
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
                mainForm.sellers.Add(new Seller
                {
                    Login = textBoxLogin.Text,
                    Email = textBoxEmail.Text,
                    Password = textBoxPassword.Text
                });
            }
            string updatedJson = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(jsonPath, updatedJson);

            MessageBox.Show("User has been created!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void checkBoxSeller_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUser.Checked)
            {
                checkBoxUser.Checked = false;
            }
        }

        private void checkBoxUser_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSeller.Checked)
            {
                checkBoxSeller.Checked = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
