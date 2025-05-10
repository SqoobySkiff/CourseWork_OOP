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
    public partial class ShopForm : Form, IControls, IComboBoxes
    {
        private string jsonFilePath = @"dataBase\cars.json";
        VehiclesData vehicles;
        public List<BaseCar> allCars;
        public List<BaseCar> tempCarList;
        public ShopForm()
        {
            InitializeComponent();
            InitializeForm();
            InitializeComboBox();
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
            allCars = vehicles.CombineCars();
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

        private void UpdateCarVisual(List<BaseCar> list)
        {
            foreach (Control control in flowLayoutPanelContent.Controls)
            {
                if (control is Panel panel)
                {
                    foreach (Control innerControl in panel.Controls)
                    {
                        if (innerControl is PictureBox pictureBox && pictureBox.Image != null)
                        {
                            pictureBox.Image.Dispose();
                        }
                    }
                }
            }

            flowLayoutPanelContent.Controls.Clear();

            foreach (var car in list)
            {
                AddCarPanel(car);
            }

            flowLayoutPanelContent.Refresh();
        }


        public void AddCarPanel(BaseCar car)
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
            Image image = null;
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, car.ImagePath);
            if (File.Exists(imagePath))
            {
                using (var tempImage = Image.FromFile(imagePath))
                {
                    image = new Bitmap(tempImage);
                }
            }
            PictureBox pictureBox = new PictureBox
            {
                Image = image,
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

            int fromPrice = 0;
            int toPrice = int.MaxValue;
            int fromHP = 0;
            int toHP = int.MaxValue;
            int fromYear = 0;
            int toYear = int.MaxValue;

            if(!string.IsNullOrWhiteSpace(textBoxFromHP.Text) && !int.TryParse(textBoxFromHP.Text, out fromHP))
            {
                MessageBox.Show("Enter propper 'HP from' ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrWhiteSpace(textBoxToHP.Text) && !int.TryParse(textBoxToHP.Text, out toHP))
            {
                MessageBox.Show("Enter propper 'HP to' ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(textBoxFrom.Text) && !int.TryParse(textBoxFrom.Text, out fromPrice))
            {
                MessageBox.Show("Enter propper 'price from'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(textBoxTo.Text) && !int.TryParse(textBoxTo.Text, out toPrice))
            {
                MessageBox.Show("Enter propper 'price to' ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(textBoxFromYear.Text) && !int.TryParse(textBoxFromYear.Text, out fromYear))
            {
                MessageBox.Show("Enter propper 'year from' ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(textBoxToYear.Text) && !int.TryParse(textBoxToYear.Text, out toYear))
            {
                MessageBox.Show("Enter propper 'year to' ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var car in allCars)
            {
                if (!string.IsNullOrWhiteSpace(comboBoxType.Text) && CheckType(car) is false)
                    continue;

                if (!string.IsNullOrWhiteSpace(textBoxMake.Text) && !car.Make.Contains(textBoxMake.Text, StringComparison.OrdinalIgnoreCase))
                    continue;

                if (!string.IsNullOrWhiteSpace(comboBoxCondition.Text) && !car.Condition.Contains(comboBoxCondition.Text, StringComparison.OrdinalIgnoreCase))
                    continue;

                if (!string.IsNullOrWhiteSpace(comboBoxCountry.Text) && !car.Country.Contains(comboBoxCountry.Text, StringComparison.OrdinalIgnoreCase))
                    continue;

                if (!string.IsNullOrWhiteSpace(comboBoxGear.Text) && !car.Gear.Contains(comboBoxGear.Text, StringComparison.OrdinalIgnoreCase))
                    continue;

                if (!string.IsNullOrWhiteSpace(textBoxModel.Text) && !car.Model.Contains(textBoxModel.Text, StringComparison.OrdinalIgnoreCase))
                    continue;

                if (!string.IsNullOrWhiteSpace(textBoxColor.Text) && !car.Color.Contains(textBoxColor.Text, StringComparison.OrdinalIgnoreCase))
                    continue;

                if (FindByPriceMath(car, fromPrice, toPrice) is false)
                    continue;
                if (FindByYearMath(car, fromYear, toYear) is false)
                    continue;
                if (FindByHPMath(car, fromHP, toHP) is false)
                    continue;

                tempCarList.Add(car);
            }

            UpdateCarVisual(tempCarList);
        }

        private bool FindByYearMath(BaseCar car, int fromYear, int toYear)
        {
            return car.Year >= fromYear && car.Year <= toYear;
        }

        private bool FindByHPMath(BaseCar car, int fromHP, int toHP)
        {
            return car.HP >= fromHP && car.HP <= toHP;
        }

        private bool CheckType(BaseCar car)
        {
            string type = comboBoxType.Text;
            if (type.ToLower() == car.GetType().Name.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonClearSearchSettings_Click_1(object sender, EventArgs e)
        {
            UpdateCarVisual(allCars);
            comboBoxGear.SelectedIndex = 0;
            comboBoxCondition.SelectedIndex = 0;
            comboBoxCountry.SelectedIndex = 0;
            comboBoxType.SelectedIndex = 0;
            textBoxFrom.Text = "";
            textBoxTo.Text = "";
            textBoxMake.Text = "";
            textBoxModel.Text = "";
            textBoxFromYear.Text = "";
            textBoxToYear.Text = "";
            textBoxColor.Text = "";
            textBoxFromHP.Text = "";
            textBoxToHP.Text = "";
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
            else if (car is Sportcar)
            {
                carPage = new CarPage((Sportcar)car, this);
                carPage.Show();
            }
            else if (car is Pickup)
            {
                carPage = new CarPage((Pickup)car, this);
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

        private void textBoxModel_TextChanged(object sender, EventArgs e)
        {

        }

        public void InitializeComboBox()
        {
            comboBoxType.Items.Add("");
            comboBoxType.Items.Add("LightCars");
            comboBoxType.Items.Add("Pickup");
            comboBoxType.Items.Add("Sportcar");
            comboBoxType.Items.Add("Suv");

            comboBoxCondition.Items.Add("");
            comboBoxCondition.Items.Add("New");
            comboBoxCondition.Items.Add("Used");

            comboBoxCountry.Items.Add("");
            comboBoxCountry.Items.Add("Homemade");
            comboBoxCountry.Items.Add("Foregin");

            comboBoxGear.Items.Add("");
            comboBoxGear.Items.Add("Automatic");
            comboBoxGear.Items.Add("Manual");
            comboBoxGear.Items.Add("HalfAuto");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
