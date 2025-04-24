using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork_OOP
{
    public partial class ShopForm : Form, IControls
    {
        private string jsonFilePath = @"dataBase\cars.json";
        VehiclesData vehicles;
        public List<BaseCar> allCars;
        public List<BaseCar> tempCarList;
        public ShopForm()
        {
            InitializeComponent();
            InitializeForm();
        }
        private void InitializeForm()
        {
            this.CenterToScreen();
            pictureBoxBacket.Image = Image.FromFile(@"backetImage\backet.png");
            pictureBoxBacket.SizeMode = PictureBoxSizeMode.Zoom;
            flowLayoutPanelContent.AutoScroll = true;
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

        private void UpdateCarVisual(List<BaseCar> list)
        {
            flowLayoutPanelContent.Controls.Clear();

            foreach (var car in list)
            {
                AddCarPanel(car);
            }

            flowLayoutPanelContent.Refresh();
        }


        private void AddCarPanel(BaseCar car)
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
            Button btnDetails = new Button
            {
                Text = "Show",
                Location = new Point(460, 70),
                Size = new Size(100, 30),
                BackColor = Color.LightGray
            };
            btnDetails.Click += (sender, e) => OpenCarPage(car);

            carPanel.Controls.Add(lblMake);
            carPanel.Controls.Add(lblModel);
            carPanel.Controls.Add(lblYear);
            carPanel.Controls.Add(lblColor);
            carPanel.Controls.Add(lblPrice);
            carPanel.Controls.Add(pictureBox);
            carPanel.Controls.Add(btnDetails);
            carPanel.Controls.Add(lblCountry);

            carPanel.Controls.Add(lblGear);
            carPanel.Controls.Add(lblHP);

            carPanel.Controls.Add(lblCondition);

            flowLayoutPanelContent.Controls.Add(carPanel);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            Find();
        }

        private void Find()
        {
            tempCarList = new List<BaseCar>();

            int fromPrice = string.IsNullOrWhiteSpace(textBoxFrom.Text) ? 0 : Convert.ToInt32(textBoxFrom.Text);
            int toPrice = string.IsNullOrWhiteSpace(textBoxTo.Text) ? int.MaxValue : Convert.ToInt32(textBoxTo.Text);

            foreach (var car in allCars)
            {
                if (!string.IsNullOrWhiteSpace(textBoxMake.Text) && !car.Make.Contains(textBoxMake.Text, StringComparison.OrdinalIgnoreCase))
                    continue;

                if (!string.IsNullOrWhiteSpace(textBoxModel.Text) && !car.Model.Contains(textBoxModel.Text, StringComparison.OrdinalIgnoreCase))
                    continue;

                if (FindByPriceMath(car, fromPrice, toPrice) is false)
                    continue;

                tempCarList.Add(car);
            }

            UpdateCarVisual(tempCarList);
        }

        private void buttonClearSearchSettings_Click_1(object sender, EventArgs e)
        {
            UpdateCarVisual(allCars);
            textBoxFrom.Text = "";
            textBoxTo.Text = "";
            textBoxMake.Text = "";
            textBoxModel.Text = "";
        }

        public bool FindByPriceMath(BaseCar car, int from, int to)
        {
            return car.Price >= from && car.Price <= to;
        }

        private void OpenCarPage(BaseCar car)
        {
            this.Hide();
            CarPage carPage;
            if (car is SUV)
            {
               carPage = new CarPage((SUV)car, this);
                carPage.Show();
            }
            else if (car is LightCars)
            {
                carPage = new CarPage((LightCars)car, this);
                carPage.Show();
            }
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void pictureBoxBacket_Click(object sender, EventArgs e)
        {
            BacketForm backetForm = new BacketForm(this);
            backetForm.Show();
            this.Hide();
        }
    }
}
