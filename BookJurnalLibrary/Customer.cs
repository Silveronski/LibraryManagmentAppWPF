using System.Text.RegularExpressions;
namespace BookJurnalLibrary
{
    public static class Customer
    {
        static List<string> customerIds = new List<string>();
        public static void AddCustomerToClub(string customerId)
        {
            DoesIdExistInClub(customerId);
            customerIds.Add(customerId);
        }

        public static void DoesIdExistInClub(string customerId)
        {
            if (customerIds.Contains(customerId))
            {
                throw new IllegalIdException("This id already exists in the club!");
            }
        }

        public static void ActivateDiscount(string customerId)
        {
            if (!customerIds.Contains(customerId))
            {
                throw new IllegalIdException("This ID does not exist in the club!");
            }
        }

        public static void RemoveCustomerFromClub(string customerId)
        {
            if (!customerIds.Contains(customerId))
            {
                throw new IllegalIdException("This ID does not exist in the club!");
            }
            customerIds.Remove(customerId);
        }

        public static void IsIdValid(string customerId)
        {
            string idPattern = @"^\d{9}$";
            Regex IsIdValid = new Regex(idPattern);

            if (!IsIdValid.IsMatch(customerId)) throw new IllegalIdException("ID must be exactly 9 digits!");         
        }

        public static void SaveCustomer(string customerId)
        {
            string dataBase = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase";
            if (!Directory.Exists(dataBase)) throw new DirectoryNotFoundException("Data base directory could not be found!");
            string customerDirectory = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase\Customers";
            if (!Directory.Exists(customerDirectory)) throw new DirectoryNotFoundException("Customers directory could not be found!");
                   
            string directory = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase\Customers\Customer " + " " + customerId;
            string fileName = "CustomerId.txt";
            Directory.CreateDirectory(directory);
            string filePath = Path.Combine(directory, fileName);           
            File.WriteAllText(filePath, customerId);           
        }

        public static void LoadCustomers()
        {
            string dataBase = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase";
            if (!Directory.Exists(dataBase)) throw new DirectoryNotFoundException("Data base directory could not be found!");

            string customerDirectory = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase\Customers";          
            if (Directory.Exists(customerDirectory))
            {
                foreach (string filePath in Directory.GetFiles(customerDirectory, "CustomerId.txt", SearchOption.AllDirectories))
                {
                    string customerId = File.ReadAllText(filePath);                  
                    AddCustomerToClub(customerId);
                }
            }
            else throw new DirectoryNotFoundException("Customers directory could not be found!");
        }

        public static void DeleteFile(string customerId)
        {
            string dataBase = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase";
            if (!Directory.Exists(dataBase)) throw new DirectoryNotFoundException("Data base directory could not be found!");

            string directory = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase\Customers\Customer " + " " + customerId;           
            if (Directory.Exists(directory)) Directory.Delete(directory, true);
            else throw new DirectoryNotFoundException("The directory could not be found!");
        }

        public static int GetCustomersCount()
        {
            return customerIds.Count;
        }
    }
}