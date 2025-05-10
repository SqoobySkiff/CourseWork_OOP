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
        public List<BaseCar> allCars = new List<BaseCar>();
        private Form1 form1;

        public SellerCabinetForm(Form1 form)
        {
            InitializeComponent();
            Initialize();
            LoadCarIDs();
            LoadApprovalRequests();
            this.CenterToScreen();
            form1 = form;
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
                if(req.CarId == 222222)
                {
                    continue;
                }
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

                Button buttonApprove = new Button
                {
                    Text = "Approve",
                    Location = new Point(160,30),
                    BackColor = Color.LightGreen,
                    AutoSize = true
                };
                buttonApprove.Click += (sender, e) => ApproveRequest(req);

                Button buttonDecline = new Button
                {
                    Text = "Decline",
                    Location = new Point(160, 60),
                    BackColor = Color.Red,
                    AutoSize = true
                };
                buttonDecline.Click += (sender, e) => DeclineRequest(req);

                panel.Controls.Add(buttonDecline);
                panel.Controls.Add(buttonApprove);
                panel.Controls.Add(lblId);
                panel.Controls.Add(lblUser);
                panel.Controls.Add(lblEmail);
                panel.Controls.Add(lblDate);

                flowLayoutPanelOrders.Controls.Add(panel);
            }
        }

        private void ApproveRequest(SellerRequest request)
        {
            try
            {
                if (File.Exists(jsonFilePath))
                {
                    var mainJson = File.ReadAllText(jsonFilePath);
                    var vehiclesData = JsonSerializer.Deserialize<VehiclesData>(mainJson);

                    if (vehiclesData != null)
                    {
                        vehiclesData.lightcars.RemoveAll(c => c.ID == request.CarId);
                        vehiclesData.suv.RemoveAll(c => c.ID == request.CarId);
                        vehiclesData.sportcars.RemoveAll(c => c.ID == request.CarId);
                        vehiclesData.pickups.RemoveAll(c => c.ID == request.CarId);

                        File.WriteAllText(jsonFilePath, JsonSerializer.Serialize(vehiclesData, new JsonSerializerOptions { WriteIndented = true }));
                    }
                }

                string requesterPath = $@"userBaskets\{request.RequestedBy}_basket.json";
                if (File.Exists(requesterPath))
                {
                    var userJson = File.ReadAllText(requesterPath);
                    var basket = JsonSerializer.Deserialize<VehiclesData>(userJson);
                    if (basket != null)
                    {
                        basket.lightcars.RemoveAll(c => c.ID == request.CarId);
                        basket.suv.RemoveAll(c => c.ID == request.CarId);
                        basket.sportcars.RemoveAll(c => c.ID == request.CarId);
                        basket.pickups.RemoveAll(c => c.ID == request.CarId);

                        File.WriteAllText(requesterPath, JsonSerializer.Serialize(basket, new JsonSerializerOptions { WriteIndented = true }));
                    }
                }
                approvalRequests.RemoveAll(r => r.CarId == request.CarId);

                string basketsFolder = @"userBaskets";
                if (Directory.Exists(basketsFolder))
                {
                    var basketFiles = Directory.GetFiles(basketsFolder, "*_basket.json");

                    foreach (var file in basketFiles)
                    {
                        string user = Path.GetFileName(file).Split('_')[0];
                        if (user == request.RequestedBy) continue; 

                        var userJson = File.ReadAllText(file);
                        var basket = JsonSerializer.Deserialize<VehiclesData>(userJson);

                        bool modified = false;
                        foreach (var car in basket.lightcars) { if (car.ID == request.CarId) { car.ID = 222222; modified = true; } }
                        foreach (var car in basket.suv) { if (car.ID == request.CarId) { car.ID = 222222; modified = true; } }
                        foreach (var car in basket.sportcars) { if (car.ID == request.CarId) { car.ID = 222222; modified = true; } }
                        foreach (var car in basket.pickups) { if (car.ID == request.CarId) { car.ID = 222222; modified = true; } }

                        if (modified)
                        {
                            File.WriteAllText(file, JsonSerializer.Serialize(basket, new JsonSerializerOptions { WriteIndented = true }));
                        }
                    }
                }
                File.WriteAllText(jsonAproveListFilePath, JsonSerializer.Serialize(approvalRequests, new JsonSerializerOptions { WriteIndented = true }));

                LoadApprovalRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error approving request: {ex.Message}");
            }
        }

        private void DeclineRequest(SellerRequest request)
        {
            try
            {
                approvalRequests.RemoveAll(r => r.CarId == request.CarId && r.RequestedBy == request.RequestedBy);
                File.WriteAllText(jsonAproveListFilePath, JsonSerializer.Serialize(approvalRequests, new JsonSerializerOptions { WriteIndented = true }));

                string userBasketPath = $@"userBaskets\{request.RequestedBy}_basket.json";
                if (File.Exists(userBasketPath))
                {
                    var basketJson = File.ReadAllText(userBasketPath);
                    var basket = JsonSerializer.Deserialize<VehiclesData>(basketJson);

                    if (basket != null)
                    {
                        basket.lightcars.RemoveAll(c => c.ID == request.CarId);
                        basket.suv.RemoveAll(c => c.ID == request.CarId);
                        basket.sportcars.RemoveAll(c => c.ID == request.CarId);
                        basket.pickups.RemoveAll(c => c.ID == request.CarId);

                        File.WriteAllText(userBasketPath, JsonSerializer.Serialize(basket, new JsonSerializerOptions { WriteIndented = true }));
                    }
                }

                LoadApprovalRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while declining request: {ex.Message}");
            }
        }


        private void Initialize()
        {
            this.CenterToScreen();
            flowLayoutPanelCars.AutoScroll = true;
            flowLayoutPanelOrders.AutoScroll = true;
            if (!File.Exists(jsonFilePath))
            {
                MessageBox.Show("Cars JSON file not found!");
                return;
            }
            string jsonText = File.ReadAllText(jsonFilePath);
            vehicles = JsonSerializer.Deserialize<VehiclesData>(jsonText);
            allCars = new List<BaseCar>();
            allCars = vehicles.CombineCars();
            foreach (var car in allCars)
            {
                if (File.Exists(car.ImagePath))
                {
                    using (var stream = new FileStream(car.ImagePath, FileMode.Open, FileAccess.Read))
                    {
                        car.Image = Image.FromStream(stream);
                    }
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
                    IDIES.AddRange(vehicles.sportcars.Select(car => car.ID));
                    IDIES.AddRange(vehicles.pickups.Select(car => car.ID));
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
            form1.Show();
        }
        public void UpdateCarVisual(List<BaseCar> list)
        {
            foreach (Control control in flowLayoutPanelCars.Controls)
            {

                if (control is Panel panel)
                {
                    foreach (Control innerControl in panel.Controls)
                    {
                        if (innerControl is PictureBox pb && pb.Image != null)
                        {
                            pb.Image.Dispose();
                        }
                    }
                }
            }


            flowLayoutPanelCars.Controls.Clear();

            foreach (var car in list)
            {
                AddCarPanel(car);
            }

            flowLayoutPanelCars.Refresh();
        }

        private void Edit(BaseCar car)
        {
            EditForm editForm = new EditForm(car, jsonFilePath, this);
            editForm.Show();
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
            Image img = null;
            if (File.Exists(imagePath))
            {
                using (var tempStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    img = Image.FromStream(tempStream); 
                }
            }

            PictureBox pictureBox = new PictureBox
            {
                Image = img,
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
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            foreach (Control control in flowLayoutPanelCars.Controls)
            {
                if (control is Panel panel)
                {
                    foreach (Control innerControl in panel.Controls)
                    {
                        if (innerControl is PictureBox pb)
                        {
                            if (pb.Image != null)
                            {
                                pb.Image.Dispose();
                                pb.Image = null;
                            }
                            pb.Dispose();
                        }
                    }
                }
            }

            foreach (Control control in flowLayoutPanelOrders.Controls)
            {
                if (control is Panel panel)
                {
                    foreach (Control innerControl in panel.Controls)
                    {
                        if (innerControl is PictureBox pb)
                        {
                            if (pb.Image != null)
                            {
                                pb.Image.Dispose();
                                pb.Image = null;
                            }
                            pb.Dispose();
                        }
                    }
                }
            }

            flowLayoutPanelCars.Controls.Clear();
            flowLayoutPanelOrders.Controls.Clear();
        }
    }
}
