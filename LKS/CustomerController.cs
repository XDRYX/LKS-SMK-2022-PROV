using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace LKS
{
    public class CustomerController
    {
        private string customerDataPath = Application.StartupPath + "/customerData.appdata";

        public CustomerData GetAppData()
        {
            var appDataFile = File.ReadAllText(customerDataPath);
            CustomerData appDataJSONObject = JsonSerializer.Deserialize<CustomerData>(appDataFile);

            return appDataJSONObject;
        }

        public void SaveData(CustomerData data)
        {
            File.WriteAllText(customerDataPath, JsonSerializer.Serialize(data));
        }

        public void CreateCustomerDataFile()
        {
            if(!File.Exists(customerDataPath)) {
                var JSONObj = new CustomerData()
                {
                    LoginCustomerID = -1,
                    CartList = new List<CartModel>(),
                };
                SaveData(JSONObj);
            }
        }

        public void CustomerLogin(int customerID)
        {
            var customerData = GetAppData();
            customerData.LoginCustomerID = customerID;
            SaveData(customerData);
        }

        public void CustomerLogout()
        {
            var customerData = GetAppData();
            customerData.LoginCustomerID = -1;
            SaveData(customerData);
        }

        private void AddToCart(int ProductID, int quantity)
        {
            var customerData = GetAppData();
            customerData.CartList.Add(new CartModel()
            {
                ProductID = ProductID,
                ProductQty = quantity,
            });
            SaveData(customerData);
        }

        public void RemoveFromCart(int ProductID)
        {
            var customerData = GetAppData();
            var query = customerData.CartList.Where(col => col.ProductID == ProductID).ToArray();
            customerData.CartList.Remove(query[0]);
            SaveData(customerData);
        }

        public void ClarAllCart()
        {
            var customerData = GetAppData();
            customerData.CartList = new List<CartModel>();
            SaveData(customerData);
        }

    }
}
