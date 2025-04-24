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
    public partial class BacketForm : Form
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
                CombineCars(vehicles);

                foreach (var car in allCars)
                {
                    DisplayCars(car);
                }
    
            }
            else
            {
                MessageBox.Show("No basket found.");
            }
        }

        private void DisplayCars(BaseCar car)
        {
            Panel carPanel = new Panel
            {
                Width = 600,
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

        private void labelReturn_Click(object sender, EventArgs e)
        {
            ShopForm.Show();
            this.Close();
        }
        private void CombineCars(VehiclesData vehicles)
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
    }
}
