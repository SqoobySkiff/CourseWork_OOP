using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CourseWork_OOP
{
    public static class Session
    {
        public static string LoggedInUsername;
        public static string LoggedInEmail;

        public static void SetUser(string username, string email)
        {
            LoggedInUsername = username;
            LoggedInEmail = email;

            string basketDirectory = @"userBaskets";
            string basketPath = Path.Combine(basketDirectory, $"{username}_basket.json");

            if (!Directory.Exists(basketDirectory))
            {
                Directory.CreateDirectory(basketDirectory);
            }

            if (!File.Exists(basketPath))
            {
                UserBasket emptyBasket = new UserBasket(); 
                string json = JsonSerializer.Serialize(emptyBasket, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(basketPath, json);
            }
        }

    }

}
