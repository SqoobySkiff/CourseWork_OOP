using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CourseWork_OOP
{
    public partial class Form1 : Form
    {
        private string jsonPath = @"dataBase\users.json";
        public List<Seller> sellers = new List<Seller>();
        public List<Customer> customers = new List<Customer>();
        ListOfUsers listOfUsers;
        public Form1()
        {
            InitializeComponent();
            InitializeForm();
        }
        public void InitializeForm()
        {
            if (!File.Exists(jsonPath))
            {
                MessageBox.Show("Users JSON file not found!");
                return;
            }

            string jsonText = File.ReadAllText(jsonPath);
            listOfUsers = JsonSerializer.Deserialize<ListOfUsers>(jsonText);

            foreach (var user in listOfUsers.Sellers)
            {
                sellers.Add(user);
            }
            foreach (var user in listOfUsers.Customers)
            {
                customers.Add(user);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            foreach (var user in customers)
            {
                if (login_password.Text == user.Password && login_username.Text == user.Login)
                {
                    string email = FindEmail(user.Login);
                    Session.SetUser(user.Login, email);
                    ShopForm shopForm = new ShopForm();
                    shopForm.Show();
                    this.Hide();
                    return;
                }
            }
            foreach (var user in sellers)
            {
                if (login_password.Text == user.Password && login_username.Text == user.Login)
                {
                    SellerCabinetForm sellerForm = new SellerCabinetForm(this);
                    sellerForm.Show();
                    this.Hide();
                    return;
                }
            }
            //3232323
            MessageBox.Show("Entry incorrect");
        }

        private string FindEmail(string login)
        {
            var user = customers.FirstOrDefault(u => u.Login == login);

            return user?.Email ?? string.Empty;
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm(this);
            registrationForm.Show();
            this.Hide();
        }
    }
}
