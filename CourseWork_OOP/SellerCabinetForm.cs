using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork_OOP
{
    public partial class SellerCabinetForm : Form
    {
        private string jsonFilePath = @"dataBase\cars.json";
        public SellerCabinetForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SellForm form = new SellForm(jsonFilePath);
            form.Show();
        }
    }
}
