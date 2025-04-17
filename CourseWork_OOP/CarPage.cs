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
            this.CenterToScreen();
            this.car = car;
            LoadCarDetails();
            this.shopForm = shopForm;
        }

        private void LoadCarDetails()
        {
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, car.ImagePath);

            labelColor.Text = "Color:" + car.Color.ToString();
            labelMake.Text = "Make:" + car.Make.ToString();
            labelModel.Text = "Model:" + car.Model.ToString();
            labelYear.Text = "Year:" + car.Year.ToString();
            labelPrice.Text = "Price:" + car.Price.ToString();
            labelCountry.Text = "Country:" + car.Country.ToString();
            labelCondition.Text = "Condition:" + car.Condition.ToString();
            labelDescription.Text = car.Description.ToString();

            pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImage.Image = File.Exists(imagePath) ? Image.FromFile(imagePath) : null;
        }

        private void CarPage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            shopForm.Show();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {

        }
    }
}
