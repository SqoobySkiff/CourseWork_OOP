using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork_OOP
{
    public partial class CarPage : Form
    {
        private BaseCar car;
        ShopForm shopForm;

        public CarPage(BaseCar car, ShopForm shopForm)
        {
            InitializeComponent();
            this.car = car;
            LoadCarDetails();
            this.shopForm = shopForm;
        }

        private void LoadCarDetails()
        {
            Label lblMake = new Label
            {
                Text = $"Make: {car.Make}",
                AutoSize = true,
                Location = new Point(20, 20)
            };
            Label lblModel = new Label
            {
                Text = $"Model: {car.Model}",
                AutoSize = true,
                Location = new Point(20, 50)
            };
            Label lblYear = new Label
            {
                Text = $"Year: {car.Year}",
                AutoSize = true,
                Location = new Point(20, 80)
            };
            Label lblColor = new Label
            {
                Text = $"Color: {car.Color}",
                AutoSize = true,
                Location = new Point(20, 110)
            };
            Label lblPrice = new Label
            {
                Text = $"Price: {car.Price}",
                AutoSize = true,
                Location = new Point(20, 140)
            };
            PictureBox pictureBox = new PictureBox
            {
                Image = car.Image,
                Location = new Point(250, 20),
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(300, 200)
            };
            Label lblDescription = new Label
            {
                Text = $"{car.Description}",
                AutoSize = true,
                Location = new Point(20, 160)
            };

            Controls.Add(lblMake);
            Controls.Add(lblModel);
            Controls.Add(lblYear);
            Controls.Add(lblColor);
            Controls.Add(lblPrice);
            Controls.Add(pictureBox);
            Controls.Add(lblDescription);
        }

        private void CarPage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
