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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseWork_OOP
{
    public partial class CarPage : Form
    {
        private BaseCar car;
        ShopForm shopForm;

        public CarPage(BaseCar car, ShopForm shopForm)
        {
            this.CenterToScreen();
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
            labelHP.Text = "HP:" + car.HP.ToString();
            labelGear.Text = "Gear:" + car.Gear.ToString();
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
        private void AddToBasket(BaseCar selectedCar)
        {
            string user = Session.LoggedInUsername;
            string email = Session.LoggedInEmail;
            bool isSUV = false;
            bool isLightCar = false;
            string basketPath = $@"userBaskets\{user}_basket.json";
            string approvingPath = $@"dataBase\carsWaitingApprove.json";

            foreach (var car in shopForm.allCars)
            {
                if (car.ID == selectedCar.ID)
                {
                    if (car is SUV)
                    {
                        isSUV = true;
                    }
                    else if (car is LightCars)
                    {
                        isLightCar = true;
                    }
                }
            }

            BaseCar newCar;
            if (isLightCar)
            {
                newCar = new LightCars
                {
                    ID = selectedCar.ID,
                    Make = selectedCar.Make,
                    Model = selectedCar.Model,
                    Year = selectedCar.Year,
                    HP = selectedCar.HP,
                    Gear = selectedCar.Gear,
                    Color = selectedCar.Color,
                    Price = selectedCar.Price,
                    Condition = selectedCar.Condition,
                    Country = selectedCar.Country,
                    ImagePath = selectedCar.ImagePath,
                    Description = selectedCar.Description,
                };
            }
            else if (isSUV)
            {
                newCar = new SUV
                {
                    ID = selectedCar.ID,
                    Make = selectedCar.Make,
                    Model = selectedCar.Model,
                    Year = selectedCar.Year,
                    HP = selectedCar.HP,
                    Gear = selectedCar.Gear,
                    Color = selectedCar.Color,
                    Price = selectedCar.Price,
                    Condition = selectedCar.Condition,
                    Country = selectedCar.Country,
                    ImagePath = selectedCar.ImagePath,
                    Description = selectedCar.Description,
                };
            }
            else
            {
                MessageBox.Show("Invalid car type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            VehiclesData userBasket;
            if (File.Exists(basketPath))
            {
                string jsonText = File.ReadAllText(basketPath);
                userBasket = JsonSerializer.Deserialize<VehiclesData>(jsonText) ?? new VehiclesData();
            }
            else
            {
                userBasket = new VehiclesData();
            }

            if (newCar is LightCars lightCar)
            {
                userBasket.lightcars.Add(lightCar);
            }
            else if (newCar is SUV suvCar)
            {
                userBasket.suv.Add(suvCar);
            }

            string updatedBasketJson = JsonSerializer.Serialize(userBasket, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(basketPath, updatedBasketJson);

            List<SellerRequest> approvalRequests = new List<SellerRequest>();
            if (File.Exists(approvingPath))
            {
                string approveJson = File.ReadAllText(approvingPath);
                approvalRequests = JsonSerializer.Deserialize<List<SellerRequest>>(approveJson) ?? new List<SellerRequest>();
            }

            if (!approvalRequests.Any(r => r.CarId == newCar.ID && r.RequestedBy == user && r.Email == email))
            {
                approvalRequests.Add(new SellerRequest
                {
                    CarId = newCar.ID,
                    RequestedBy = user,
                    Email = email,
                    RequestDate = DateTime.Now
                });

                string approveJson = JsonSerializer.Serialize(approvalRequests, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(approvingPath, approveJson);
            }

            MessageBox.Show("Car has been added to your basket and sent for approval.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void buttonBuy_Click(object sender, EventArgs e)
        {
            AddToBasket(car);
            this.Close();
            shopForm.Show();
        }
    }
}
