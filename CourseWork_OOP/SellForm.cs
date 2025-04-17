using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace CourseWork_OOP
{
    public partial class SellForm : Form
    {
        //private ShopForm mainForm;

        private string jsonFilePath;
        private string imagePath;
        private Random rnd;
        private List<int> IDIES;
        private int ID = 0;

        private string imageFolderPath = @"images";

        public SellForm(string jsonFilePath, List<int> IDIES)
        {
            InitializeComponent();
            InitializeDragDrop();
            this.jsonFilePath = jsonFilePath;
            this.IDIES = IDIES;
            this.rnd = new Random(); 

            comboBoxCondition.Items.Add("New");
            comboBoxCondition.Items.Add("Used");
            comboBoxCountry.Items.Add("Homemade");
            comboBoxCountry.Items.Add("Foregin");
        }

        private void InitializeDragDrop()
        {
            pictureBox1.AllowDrop = true;
            pictureBox1.DragEnter += PictureBoxDrop_DragEnter;
            pictureBox1.DragDrop += PictureBoxDrop_DragDrop;
        }

        private void PictureBoxDrop_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                string filePath = files[0];
                string extension = Path.GetExtension(filePath).ToLower();

                string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".bmp" };

                if (!allowedExtensions.Contains(extension))
                {
                    MessageBox.Show("Wrong formatm allowed only JPG, JPEG, PNG, BMP.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string name = Path.GetFileNameWithoutExtension(filePath);
                string fileExtension = Path.GetExtension(filePath);

                string fileName = name + fileExtension;

                string savePath = Path.Combine(imageFolderPath, fileName);

                int counter = 0;
                while (File.Exists(savePath))
                {
                    name = name + "_" + counter++;
                    fileName = name + extension;
                    savePath = Path.Combine(imageFolderPath, fileName);
                }
                File.Copy(filePath, savePath, true);
                imagePath = savePath;
                pictureBox1.Image = Image.FromFile(savePath);

            }
        }
        private void PictureBoxDrop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewCar();
        }

        private void AddNewCar()
        {
            if (checkBoxLightCars.Checked == checkBoxSUV.Checked)
            {
                MessageBox.Show("Choose only one category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxMake.Text) ||
                string.IsNullOrWhiteSpace(textBoxModel.Text) ||
                string.IsNullOrWhiteSpace(textBoxYear.Text) ||
                string.IsNullOrWhiteSpace(textBoxColor.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrice.Text) ||
                string.IsNullOrWhiteSpace(textBoxDescription.Text))
            {
                MessageBox.Show("All fields should contains info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(comboBoxCondition.Text) || string.IsNullOrWhiteSpace(comboBoxCountry.Text))
            {
                MessageBox.Show("Please select both Condition and Country options.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Add photo of car", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BaseCar newCar;
            if (checkBoxLightCars.Checked)
            {
                newCar = new LightCars
                {
                    ID = SetID(),
                    Make = textBoxMake.Text,
                    Model = textBoxModel.Text,
                    Year = int.Parse(textBoxYear.Text),
                    Color = textBoxColor.Text,
                    Price = decimal.Parse(textBoxPrice.Text),
                    Condition = comboBoxCondition.Text,
                    Country = comboBoxCountry.Text,
                    ImagePath = imagePath,
                    Description = textBoxDescription.Text
                };
            }
            else
            {
                newCar = new SUV
                {
                    ID = SetID(),
                    Make = textBoxMake.Text,
                    Model = textBoxModel.Text,
                    Year = int.Parse(textBoxYear.Text),
                    Color = textBoxColor.Text,
                    Price = decimal.Parse(textBoxPrice.Text),
                    Condition = comboBoxCondition.Text,
                    Country = comboBoxCountry.Text,
                    ImagePath = imagePath,
                    Description = textBoxDescription.Text
                };
            }

            VehiclesData vehicles;
            if (File.Exists(jsonFilePath))
            {
                string jsonText = File.ReadAllText(jsonFilePath);
                vehicles = JsonSerializer.Deserialize<VehiclesData>(jsonText) ?? new VehiclesData();

                if (newCar is LightCars lightCar)
                    vehicles.lightcars.Add(lightCar);
                else if (newCar is SUV suvCar)
                    vehicles.suv.Add(suvCar);

                string updatedJson = JsonSerializer.Serialize(vehicles, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(jsonFilePath, updatedJson);

                //mainForm.allCars.Add(newCar);

                MessageBox.Show("Car has been added!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private int SetID()
        {
            HashSet<int> idSet = new HashSet<int>(IDIES); 

            int newId;
            do
            {
                newId = rnd.Next(1, 100000); 
            } while (idSet.Contains(newId));

            IDIES.Add(newId); 
            return newId;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
