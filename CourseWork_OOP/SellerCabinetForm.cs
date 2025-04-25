using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace CourseWork_OOP
{
    public partial class SellerCabinetForm : Form, IControls
    {
        private string jsonFilePath = @"dataBase\cars.json";
        private string jsonAproveListFilePath = @"dataBase\carsWaitingApprove.json";
        private List<SellerRequest> approvalRequests = new List<SellerRequest>();

        private List<BaseCar> tempID = new List<BaseCar>();
        public List<int> IDIES = new List<int>();
        VehiclesData vehicles;
        private List<BaseCar> allCars = new List<BaseCar>();

        public SellerCabinetForm()
        {
            InitializeComponent();
            Initialize();
            LoadCarIDs();
            LoadApprovalRequests();
            this.CenterToScreen();
        }
        private void LoadApprovalRequests()
        {
            if (!File.Exists(jsonAproveListFilePath))
            {
                MessageBox.Show("Approval request file not found!");
                return;
            }

            try
            {
                string jsonText = File.ReadAllText(jsonAproveListFilePath);
                approvalRequests = JsonSerializer.Deserialize<List<SellerRequest>>(jsonText);

                UpdateApprovalVisual(approvalRequests);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading approval file: " + ex.Message);
            }
        }
        private void UpdateApprovalVisual(List<SellerRequest> requests)
        {
            flowLayoutPanelOrders.Controls.Clear();

            foreach (var req in requests)
            {
                Panel panel = new Panel
                {
                    Width = 250,
                    Height = 100,
                    BackColor = Color.LightYellow,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                Label lblId = new Label
                {
                    Text = $"Car ID: {req.CarId}",
                    Location = new Point(10, 10),
                    AutoSize = true
                };

                Label lblUser = new Label
                {
                    Text = $"Requested By: {req.RequestedBy}",
                    Location = new Point(10, 30),
                    AutoSize = true
                };

                Label lblEmail = new Label
                {
                    Text = $"Email: {req.Email}",
                    Location = new Point(10, 50),
                    AutoSize = true
                };

                Label lblDate = new Label
                {
                    Text = $"Date: {req.RequestDate:G}",
                    Location = new Point(10, 70),
                    AutoSize = true
                };

                panel.Controls.Add(lblId);
                panel.Controls.Add(lblUser);
                panel.Controls.Add(lblEmail);
                panel.Controls.Add(lblDate);

                flowLayoutPanelOrders.Controls.Add(panel);
            }
        }

        private void Initialize()
        {
            this.CenterToScreen();
            flowLayoutPanelCars.AutoScroll = true;
            if (!File.Exists(jsonFilePath))
            {
                MessageBox.Show("Cars JSON file not found!");
                return;
            }
            string jsonText = File.ReadAllText(jsonFilePath);
            vehicles = JsonSerializer.Deserialize<VehiclesData>(jsonText);
            allCars = new List<BaseCar>();
            CombineCars(vehicles);
            foreach (var car in allCars)
            {
                if (File.Exists(car.ImagePath))
                {
                    car.Image = Image.FromFile(car.ImagePath);
                }
                else
                {
                    car.Image = null;
                }
            }
            UpdateCarVisual(allCars);
        }

        private void LoadCarIDs()
        {
            if (!File.Exists(jsonFilePath))
            {
                MessageBox.Show("Car database file not found!");
                return;
            }

            try
            {
                string jsonText = File.ReadAllText(jsonFilePath);
                VehiclesData vehicles = JsonSerializer.Deserialize<VehiclesData>(jsonText);

                if (vehicles != null)
                {
                    IDIES = vehicles.lightcars.Select(car => car.ID).ToList();
                    IDIES.AddRange(vehicles.suv.Select(car => car.ID));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load car IDs: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SellForm form = new SellForm(jsonFilePath, IDIES);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        public void CombineCars(VehiclesData vehicles)
        {
            foreach (var car in vehicles.lightcars)
            {
                allCars.Add(car);
            }
            foreach (var car in vehicles.suv)
            {
                allCars.Add(car);
            }
        }
        private void UpdateCarVisual(List<BaseCar> list)
        {
            flowLayoutPanelCars.Controls.Clear();

            foreach (var car in list)
            {
                AddCarPanel(car);
            }

            flowLayoutPanelCars.Refresh();
        }

        private void Edit(BaseCar car)
        {

        }

        public void AddCarPanel(BaseCar car)
        {
            Panel carPanel = new Panel
            {
                Width = 400,
                Height = 140,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                BackColor = Color.White,
            };

            Label lblMake = new Label
            {
                Text = $"Make: {car.Make}",
                AutoSize = true,
                Location = new Point(10, 10)
            };
            Label lblModel = new Label
            {
                Text = $"Model: {car.Model}",
                AutoSize = true,
                Location = new Point(10, 30)
            };
            Label lblYear = new Label
            {
                Text = $"Year: {car.Year}",
                AutoSize = true,
                Location = new Point(10, 50)
            };

            Label lblHP = new Label
            {
                Text = $"HP: {car.HP}",
                AutoSize = true,
                Location = new Point(10, 90)
            };
            Label lblGear = new Label
            {
                Text = $"Gear: {car.Gear}",
                AutoSize = true,
                Location = new Point(145, 90)
            };

            Label lblColor = new Label
            {
                Text = $"Color: {car.Color}",
                AutoSize = true,
                Location = new Point(10, 70)
            };
            Label lblCountry = new Label
            {
                Text = $"Country: {car.Country}",
                AutoSize = true,
                Location = new Point(10, 110)
            };
            Label lblCondition = new Label
            {
                Text = $"Condition: {car.Condition}",
                AutoSize = true,
                Location = new Point(145, 110)
            };

            Label lblPrice = new Label
            {
                Text = $"Price: {car.Price}",
                AutoSize = true,
                Location = new Point(300, 120)
            };
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, car.ImagePath);
            PictureBox pictureBox = new PictureBox
            {
                Image = File.Exists(imagePath) ? Image.FromFile(imagePath) : null,
                Location = new Point(250, 20),
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(150, 100)
            };
            Button btnEdit = new Button
            {
                Text = "Edit",
                Location = new Point(110, 50),
                Size = new Size(100, 30),
                BackColor = Color.LightGray
            };
            btnEdit.Click += (sender, e) => Edit(car);

            carPanel.Controls.Add(lblMake);
            carPanel.Controls.Add(lblModel);
            carPanel.Controls.Add(lblYear);
            carPanel.Controls.Add(lblColor);
            carPanel.Controls.Add(lblPrice);
            carPanel.Controls.Add(pictureBox);
            carPanel.Controls.Add(btnEdit);
            carPanel.Controls.Add(lblCountry);

            carPanel.Controls.Add(lblGear);
            carPanel.Controls.Add(lblHP);

            carPanel.Controls.Add(lblCondition);

            flowLayoutPanelCars.Controls.Add(carPanel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tempID.Clear();
            if (string.IsNullOrEmpty(textBoxID.Text))
            {
                UpdateCarVisual(allCars);
                return;
            }
            bool isNumber = int.TryParse(textBoxID.Text, out int result);

            if (isNumber)
            {
                SearchByID(result);
                if (tempID.Count == 1)
                {
                    UpdateCarVisual(tempID);
                }
                else
                {
                    MessageBox.Show("There is no car with this ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Its not ID format text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchByID(int id)
        {
            foreach (var car in allCars)
            {
                if (car.ID == id)
                {
                    tempID.Add(car);
                    break;
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadApprovalRequests();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
