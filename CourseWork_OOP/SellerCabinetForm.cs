using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace CourseWork_OOP
{
    public partial class SellerCabinetForm : Form
    {
        private string jsonFilePath = @"dataBase\cars.json";
        public List<int> IDIES = new List<int>();

        public SellerCabinetForm()
        {
            InitializeComponent();
            LoadCarIDs(); 
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
            Form1 form = new Form1();
            form.Show();
        }
    }
}
