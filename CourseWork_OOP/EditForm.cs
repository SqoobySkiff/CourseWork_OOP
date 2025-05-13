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
    public partial class EditForm : Form
    {
        private string imageFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images");
        private string newImagePath = null;
        private string jsonFilePath;
        private BaseCar car;
        private VehiclesData vehicles;
        private SellerCabinetForm _sellerCabinetForm;
        public EditForm(BaseCar car, string json, SellerCabinetForm form)
        {
            InitializeComponent();
            this.car = car;
            InitializeForm();
            jsonFilePath = json;
            CenterToScreen();
            _sellerCabinetForm = form;
        }

        private void InitializeForm()
        {
            if (car == null)
            {
                MessageBox.Show("Car data is missing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            car.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, car.ImagePath));
            textBoxColor.Text = car.Color;
            textBoxDescription.Text = car.Description;
            textBoxHP.Text = car.HP.ToString();
            textBoxMake.Text = car.Make;
            textBoxModel.Text = car.Model;
            textBoxPrice.Text = car.Price.ToString();
            textBoxYear.Text = car.Year.ToString();
            pictureBox1.Image = car.Image;

            comboBoxCondition.Items.AddRange(new string[] { "New", "Used" });
            comboBoxCountry.Items.AddRange(new string[] { "Homemade", "Foregin" });
            comboBoxGear.Items.AddRange(new string[] { "Automatic", "Manual", "HalfAuto" });

            comboBoxCondition.SelectedItem = car.Condition;
            comboBoxCountry.SelectedItem = car.Country;
            comboBoxGear.SelectedItem = car.Gear;
            InitializeDragDrop();
        }
        private void InitializeDragDrop()
        {
            pictureBox1.AllowDrop = true;
            pictureBox1.DragEnter += PictureBox1_DragEnter;
            pictureBox1.DragDrop += PictureBox1_DragDrop;
        }

        private void PictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void PictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                string filePath = files[0];
                string extension = Path.GetExtension(filePath).ToLower();
                string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".bmp" };

                if (!allowedExtensions.Contains(extension))
                {
                    MessageBox.Show("Wrong format, allowed only JPG, JPEG, PNG, BMP.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Directory.Exists(imageFolderPath))
                {
                    Directory.CreateDirectory(imageFolderPath);
                }

                string name = Path.GetFileNameWithoutExtension(filePath);
                string fileName = name + extension;
                string savePath = Path.Combine(imageFolderPath, fileName);

                int counter = 1;
                while (File.Exists(savePath))
                {
                    savePath = Path.Combine(imageFolderPath, $"{name}_{counter++}{extension}");
                }

                File.Copy(filePath, savePath, true);
                pictureBox1.Image = Image.FromFile(savePath);
                newImagePath = savePath;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool UpdateCarInList<T>(List<T> cars) where T : BaseCar
        {
            var carToUpdate = cars.FirstOrDefault(c => c.ID == car.ID);
            if (carToUpdate != null)
            {
                carToUpdate.Color = car.Color;
                carToUpdate.Description = car.Description;
                carToUpdate.HP = car.HP;
                carToUpdate.Make = car.Make;
                carToUpdate.Model = car.Model;
                carToUpdate.Price = car.Price;
                carToUpdate.Year = car.Year;
                carToUpdate.Condition = car.Condition;
                carToUpdate.Country = car.Country;
                carToUpdate.Gear = car.Gear;
                carToUpdate.ImagePath = car.ImagePath;
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                car.Color = textBoxColor.Text;
                car.Description = textBoxDescription.Text;
                car.HP = int.Parse(textBoxHP.Text);
                car.Make = textBoxMake.Text;
                car.Model = textBoxModel.Text;
                car.Price = decimal.Parse(textBoxPrice.Text);
                car.Year = int.Parse(textBoxYear.Text);
                car.Condition = comboBoxCondition.SelectedItem?.ToString();
                car.Country = comboBoxCountry.SelectedItem?.ToString();
                car.Gear = comboBoxGear.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(newImagePath))
                {
                    car.ImagePath = Path.GetRelativePath(AppDomain.CurrentDomain.BaseDirectory, newImagePath);
                }

                VehiclesData vehiclesData;
                if (File.Exists(jsonFilePath))
                {
                    string jsonData = File.ReadAllText(jsonFilePath);
                    vehiclesData = JsonSerializer.Deserialize<VehiclesData>(jsonData);
                }
                else
                {
                    MessageBox.Show("Car database file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (vehiclesData == null)
                {
                    MessageBox.Show("Failed to load cars!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool updated = false;

                if (car is LightCars lightCar)
                {
                    updated = vehiclesData.UpdateLightCar(lightCar);
                }
                else if (car is SUV suvCar)
                {
                    updated = vehiclesData.UpdateSUV(suvCar);
                }
                else if (car is Sportcar sportCar)
                {
                    updated = vehiclesData.UpdateSportcar(sportCar);
                }
                else if (car is Pickup pickupCar)
                {
                    updated = vehiclesData.UpdatePickup(pickupCar);
                }

                if (!updated)
                {
                    MessageBox.Show("Car not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var options = new JsonSerializerOptions { WriteIndented = true };
                string updatedJson = JsonSerializer.Serialize(vehiclesData, options);
                File.WriteAllText(jsonFilePath, updatedJson);

                MessageBox.Show("Car information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _sellerCabinetForm.UpdateCarVisual(_sellerCabinetForm.allCars);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving changes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
