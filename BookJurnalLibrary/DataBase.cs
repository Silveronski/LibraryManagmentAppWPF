﻿using System.Text;
using System.Text.Json;
namespace BookJurnalLibrary
{
    public static class DataBase
    {
        static List<AbstractItem> libraryItems = new List<AbstractItem>();

        public static void SaveItemInformation(AbstractItem item)
        {
            string dataBase = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase";
            if (!Directory.Exists(dataBase)) throw new DirectoryNotFoundException("Data base directory could not be found!");
            string bookDirectory = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase\Books";
            if (!Directory.Exists(bookDirectory)) throw new DirectoryNotFoundException("Book data base directory could not be found!");
            string journalDirectory = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase\Journals";
            if (!Directory.Exists(journalDirectory)) throw new DirectoryNotFoundException("Journal data base directory could not be found!");

            string directory = "";
            string fileName = "";

            if (item.GetType() == typeof(Book))
            {
                directory = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase\Books\Book" + " " + item.Isbn;
                fileName = "BookInfo.json";
                Directory.CreateDirectory(directory);
                string filePath = Path.Combine(directory, fileName);
                string itemSerialized = JsonSerializer.Serialize((Book)item);
                File.WriteAllText(filePath, itemSerialized);
            }
            else
            {
                directory = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase\Journals\Journal" + " " + item.Isbn;
                fileName = "JournalInfo.json";
                Directory.CreateDirectory(directory);
                string filePath = Path.Combine(directory, fileName);
                string itemSerialized = JsonSerializer.Serialize((Journal)item);
                File.WriteAllText(filePath, itemSerialized);
            }                                         
        }
        
        public static void LoadItems()
        {
            string dataBase = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase";
            if (!Directory.Exists(dataBase)) throw new DirectoryNotFoundException("Data base directory could not be found!");

            string directoryPathBooks = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase\Books";
            string directoryPathJournals = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase\Journals";

            if (Directory.Exists(directoryPathBooks))
            {
                foreach (string filePath in Directory.GetFiles(directoryPathBooks, "BookInfo.json", SearchOption.AllDirectories))
                {
                    string txtString = File.ReadAllText(filePath);
                    Book book = JsonSerializer.Deserialize<Book>(txtString);
                    AddItem(book);
                }
            }
            else throw new DirectoryNotFoundException("Books directory could not be found!");

            if (Directory.Exists(directoryPathJournals))
            {
                foreach (string filePath in Directory.GetFiles(directoryPathJournals, "JournalInfo.json", SearchOption.AllDirectories))
                {
                    string txtString = File.ReadAllText(filePath);
                    Journal journal = JsonSerializer.Deserialize<Journal>(txtString);
                    AddItem(journal);
                }
            }
            else throw new DirectoryNotFoundException("Journals directory could not be found!");
        }

        public static void DeleteFile(AbstractItem item)
        {
            string directory = "";           
            if (item.GetType() == typeof(Book))
            {
                directory = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase\Books\Book" + " " + item.Isbn;               
            }
            else
            {
                directory = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase\Journals\Journal" + " " + item.Isbn;                
            }
            if (Directory.Exists(directory)) Directory.Delete(directory, true);
            else throw new DirectoryNotFoundException("The directory could not be found!");
        }

        public static void SaveReceipt(List<AbstractItem> items , double totalPrice, bool ClubDiscount = false)
        {
            string dataBase = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase";
            if (!Directory.Exists(dataBase)) throw new DirectoryNotFoundException("Data base directory could not be found!");            
            
            string itemReceiptsDirectory = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase\ItemReceipts";
            if (!Directory.Exists(itemReceiptsDirectory)) throw new DirectoryNotFoundException("Receipts directory could not be found!");

            string directory = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase\ItemReceipts\Receipt " + " " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
            string fileName = $"Receipt.txt";
                                       
            Directory.CreateDirectory(directory);
            string filePath = Path.Combine(directory, fileName);
            
            StringBuilder receipt = new StringBuilder();
            receipt.AppendLine(DateTime.Now.ToString());
            receipt.AppendLine("Items Bought:");

            foreach (var item in items)
            {               
                string itemInfo = item.PartialToString();
                receipt.AppendLine(itemInfo);               
            }
            if (ClubDiscount == false) receipt.AppendLine($"Total Price: {totalPrice:C}");
            else receipt.AppendLine($"Total Price After Club Discount: {totalPrice:C}");

            File.WriteAllText(filePath, receipt.ToString());
        }

        public static List<string> GetReceipts()
        {
            var receipts = new List<string>();
            string dataBase = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase";
            if (!Directory.Exists(dataBase)) throw new DirectoryNotFoundException("Data base directory could not be found!");

            string directoryPath = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase\ItemReceipts";

            if (Directory.Exists(directoryPath))
            {
                foreach (string filePath in Directory.GetFiles(directoryPath, "Receipt.txt", SearchOption.AllDirectories))
                {
                    string receipt = File.ReadAllText(filePath);
                    receipts.Add(receipt);
                }
                return receipts;
            }
            else throw new DirectoryNotFoundException("Receipts directory could not be found!");
        }

        public static List<string> GetExceptions()
        {
            var exceptions = new List<string>();
            string dataBase = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase";
            if (!Directory.Exists(dataBase)) throw new DirectoryNotFoundException("Data base directory could not be found!");

            string directoryPath = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase\Exceptions";

            if (Directory.Exists(directoryPath))
            {
                foreach (string filePath in Directory.GetFiles(directoryPath, "exception.txt", SearchOption.AllDirectories))
                {
                    string exception = File.ReadAllText(filePath);
                    exceptions.Add(exception);
                }
                return exceptions;
            }
            else throw new DirectoryNotFoundException("Exceptions directory could not be found!");
        }

        public static List<string> GetCustomers()
        {
            var customers = new List<string>();
            string dataBase = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase";                            
            if (!Directory.Exists(dataBase)) throw new DirectoryNotFoundException("Data base directory could not be found!");

            string directoryPath = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase\Customers";

            if (Directory.Exists(directoryPath))
            {
                foreach (string filePath in Directory.GetFiles(directoryPath, "CustomerId.txt", SearchOption.AllDirectories))
                {
                    string customerId = File.ReadAllText(filePath);
                    customers.Add(customerId);
                }
                return customers;
            }
            else throw new DirectoryNotFoundException("Customers directory could not be found!");
        }

      
        public static AbstractItem GetItemByIndex(int index)
        {
            return libraryItems[index];
        }
       
        public static void LogException(Exception exception)
        {
            string dataBase = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase";
            if (!Directory.Exists(dataBase)) return;

            string directoryPath = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase\Exceptions\Exception " + exception.GetType().Name + " " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
            string fileName = "exception.txt";
            string directoryPathExceptions = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase\Exceptions";
            if (Directory.Exists(directoryPathExceptions))
            {
                Directory.CreateDirectory(directoryPath);
                string filePath = Path.Combine(directoryPath, fileName);
                string exceptionText = $"Exception: {exception} \nDate: {DateTime.Now}";
                File.WriteAllText(filePath, exceptionText);
            }
            else return;
        }

        public static void DoesReceiptsDirExist()
        {
            string dataBase = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase";
            if (!Directory.Exists(dataBase)) throw new DirectoryNotFoundException("Data base directory could not be found!");

            string directoryPath = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase\ItemReceipts";
            if (Directory.Exists(directoryPath))
            {
                int length = Directory.GetDirectories(directoryPath).Length;
                if (length == 0)
                {
                    throw new DirectoryNotFoundException("There are currently no receipts available for display");
                }
            }
            else throw new DirectoryNotFoundException("Receipts directory could not be found!");
        }

        public static void DoesExceptionsDirExist()
        {
            string dataBase = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase";
            if (!Directory.Exists(dataBase)) throw new DirectoryNotFoundException("Data base directory could not be found!");

            string directoryPath = @"C:\Users\Ron\Desktop\projects\Projects\LibraryProject\DataBase\Exceptions";
            if (Directory.Exists(directoryPath))
            {
                int length = Directory.GetDirectories(directoryPath).Length;
                if (length == 0)
                {
                    throw new DirectoryNotFoundException("There are currently no Exceptions available for display");
                }
            }
            else throw new DirectoryNotFoundException("Exceptions directory could not be found!");
        }

        public static List<AbstractItem> FilterItemsByName(string name)
        {
            var itemsFoundWithName = new List<AbstractItem>();
            foreach (var item in libraryItems)
            {
                if (HasContinuousSubstring(item.Name,name)) itemsFoundWithName.Add(item); 
            }

            if (itemsFoundWithName.Count == 0) throw new ArgumentException("The name you entered does not relate to any of the items in the library!");
            return itemsFoundWithName;
        }

        public static bool HasContinuousSubstring(string itemName, string name)
        {
            int nameIndex = 0;
            int counter = 0;
            for (int i = 0; i < itemName.Length; i++)
            {
                if (counter == name.Length) return true;
                if (name[nameIndex] == itemName[i])
                {
                    counter++;
                    nameIndex++;
                }
                else
                {
                    counter = 0;
                    nameIndex = 0;
                }
            }
            return counter == name.Length;
        }

        public static List<AbstractItem> GetItems()
        {
            return libraryItems;
        }

        public static List<AbstractItem> GetBooks()
        {
            return libraryItems.Where(item => item is Book).ToList();
        }

        public static List<AbstractItem> GetJournals()
        {
            return libraryItems.Where(item => item is Journal).ToList();
        }

        public static int ItemCount()
        {
            return libraryItems.Count;
        }

        public static int BookCount()
        {
            int count = 0;
            foreach (var item in libraryItems)
            {
                if (item.GetType() == typeof(Book)) count++;
            }
            return count;
        }

        public static int JournalCount()
        {
            int count = 0;
            foreach (var item in libraryItems)
            {
                if (item.GetType() == typeof(Journal)) count++;
            }
            return count;
        }

        public static void AddItem(AbstractItem item)
        {
            foreach (var existingItem in libraryItems)
            {
                if (existingItem.Isbn == item.Isbn)
                {
                    throw new ItemAlreadyExistsException("This item already exists in the library!");
                }
            }
            libraryItems.Add(item);           
        }

        public static void IsIsbnAvailable(string isbn)
        {
            foreach (var existingItem in libraryItems)
            {
                if (existingItem.Isbn == isbn)
                {
                    throw new IllegalIsbnException("This ISBN already exists in the library!");
                }
            }
        }

        public static void IsIsbnValid(string isbn)
        {
            foreach (var existingItem in libraryItems)
            {
                if (existingItem.Isbn == isbn)
                {
                    return;
                }
            }
            throw new IllegalIsbnException("The ISBN you entered does not match an existing item!");
        }

        public static AbstractItem FindItem(string isbn)
        {
            foreach (var existingItem in libraryItems)
            {
                if (existingItem.Isbn == isbn)
                {
                    return existingItem;
                }
            }
            throw new IllegalIsbnException("The ISBN you entered does not match an existing item!");
        }

        public static void RemoveItem(string isbn)
        {
            foreach (var existingItem in libraryItems)
            {
                if (existingItem.Isbn == isbn)
                {
                    libraryItems.Remove(existingItem);
                    return;
                }
            }
            throw new IllegalIsbnException("The ISBN you entered does not match an existing item!");
        }
    }
}