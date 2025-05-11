using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_OOP
{
    public class Receipt
    {
        const string Header = "PRIVATE CAR SALES RECEIPT";
        const string CarShopLine = "SOLD BY CARSHOP";
        public void CreateReceipt(SellerRequest request, BaseCar car)
        {
            var FileFolderPath = Path.Combine(AppContext.BaseDirectory, "ReceiptFolder");
            if (Directory.Exists(FileFolderPath) == false)
            {
                Directory.CreateDirectory(FileFolderPath);
            }
            var fileName = $"{request.RequestedBy}_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            var fullPath = Path.Combine(FileFolderPath, fileName);
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.WriteLine(Header);
                writer.WriteLine(CarShopLine);
                writer.WriteLine($"Buyer name: {request.RequestedBy}");
                writer.WriteLine($"Mailing address: {request.Email}");
                writer.WriteLine($"Date of sell: {DateTime.Now}");
                writer.WriteLine($"Car make and model: {car.Make}/{car.Model}");
                writer.WriteLine($"Car color: {car.Color}");
                writer.WriteLine($"Car price: {car.Price}");
            }
        }
    }
}
