﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CourseWork_OOP
{
    public partial class BacketForm : Form, IControls
    {
        private ShopForm ShopForm;
        public List<BaseCar> allCars;
        VehiclesData vehicles;
        public BacketForm(ShopForm shopForm)
        {
            ShopForm = shopForm;
            InitializeComponent();
            LoadBasket();
            this.CenterToScreen();
            flowLayoutPanelBacket.AutoScroll = true;
        }
        private void LoadBasket()
        {
            string user = Session.LoggedInUsername;
            string basketPath = $@"userBaskets\{user}_basket.json";

            if (File.Exists(basketPath))
            {
                string json = File.ReadAllText(basketPath);
                vehicles = JsonSerializer.Deserialize<VehiclesData>(json);
                allCars = new List<BaseCar>();
                allCars = vehicles.CombineCars();

                foreach (var car in allCars)
                {
                    AddCarPanel(car);
                }

            }
            else
            {
                MessageBox.Show("No basket found.");
            }
        }

        public void AddCarPanel(BaseCar car)
        {
            Panel carPanel;
            if (car.ID == 222222)
            {
                carPanel = new Panel
                {
                    Width = 600,
                    Height = 140,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10),
                    BackColor = Color.Red,
                };
            }
            else
            {
                carPanel = new Panel
                {
                    Width = 600,
                    Height = 140,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10),
                    BackColor = Color.White,
                };
                Button buttonDelete = new Button
                {
                    Text = "Decline order",
                    Location = new Point(460, 70),
                    Size = new Size(100, 50),
                    BackColor = Color.LightGray
                };
                buttonDelete.Click += (sender, e) => DeleteCarFromBascket(car);
                carPanel.Controls.Add(buttonDelete);
            }


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
                Location = new Point(520, 120)
            };
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, car.ImagePath);
            PictureBox pictureBox = new PictureBox
            {
                Image = File.Exists(imagePath) ? Image.FromFile(imagePath) : null,
                Location = new Point(250, 20),
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(200, 100)
            };

            carPanel.Controls.Add(lblMake);
            carPanel.Controls.Add(lblModel);
            carPanel.Controls.Add(lblYear);
            carPanel.Controls.Add(lblColor);
            carPanel.Controls.Add(lblPrice);
            carPanel.Controls.Add(pictureBox);
            carPanel.Controls.Add(lblCountry);
            carPanel.Controls.Add(lblGear);
            carPanel.Controls.Add(lblHP);

            carPanel.Controls.Add(lblCondition);

            flowLayoutPanelBacket.Controls.Add(carPanel);
        }

        private void DeleteCarFromBascket(BaseCar carInput)
        {
            string user = Session.LoggedInUsername;
            string basketDirectory = @"userBaskets";
            string basketPath = Path.Combine(basketDirectory, $"{user}_basket.json");
            string approvingPath = @"dataBase\carsWaitingApprove.json";

            if (!File.Exists(basketPath) || !File.Exists(approvingPath))
            {
                Console.WriteLine("Basket or approving file not found.");
                return;
            }

            string jsonBasket = File.ReadAllText(basketPath);
            UserBasket basket = JsonSerializer.Deserialize<UserBasket>(jsonBasket);

            int lightCountBefore = basket.lightcars.Count;
            int suvCountBefore = basket.suv.Count;
            int sportcarCountBefore = basket.sportcars.Count;
            int pickupCountBefore = basket.pickups.Count;

            basket.lightcars.RemoveAll(car => car.ID == carInput.ID);
            basket.suv.RemoveAll(car => car.ID == carInput.ID);
            basket.sportcars.RemoveAll(car => car.ID == carInput.ID);
            basket.pickups.RemoveAll(car => car.ID == carInput.ID);

            int totalRemoved = (lightCountBefore - basket.lightcars.Count) + (suvCountBefore - basket.suv.Count) + (sportcarCountBefore - basket.sportcars.Count)
                + (pickupCountBefore - basket.pickups.Count);

            if (totalRemoved > 0)
            {
                string updatedJson = JsonSerializer.Serialize(basket, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(basketPath, updatedJson);

                string jsonApproving = File.ReadAllText(approvingPath);
                List<SellerRequest> approvalRequests = JsonSerializer.Deserialize<List<SellerRequest>>(jsonApproving) ?? new List<SellerRequest>();

                approvalRequests.RemoveAll(request => request.CarId == carInput.ID && request.RequestedBy == user);

                string updatedApprovingJson = JsonSerializer.Serialize(approvalRequests, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(approvingPath, updatedApprovingJson);

                BacketForm form = new BacketForm(ShopForm);
                form.Show();
                this.Close();
            }
            else
            {
                Console.WriteLine($"No car with ID {carInput.ID} found in the basket.");
            }
        }


        private void labelReturn_Click(object sender, EventArgs e)
        {
            ShopForm.Show();
            this.Close();
        }

        private void flowLayoutPanelBacket_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
