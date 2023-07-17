namespace ConsoleApp1
{
    internal class Program
    {

        // Product category enum
        enum ProductCategory
        {
            Electronics,
            Clothing,
            Food,
            Home,
            Beauty
        }

        // Product class
        class Product
        {
            public string Code { get; }
            public string Name { get; set; }
            public double Price { get; set; }
            public ProductCategory Category { get; set; }
            public int Count { get; set; }

            public Product(string code, string name, double price, ProductCategory category, int count)
            {
                Code = code;
                Name = name;
                Price = price;
                Category = category;
                Count = count;
            }

            public override string ToString()
            {
                return $"Code: {Code}, Name: {Name}, Category: {Category}, Quantity: {Count}, Price: ${Price}";
            }
        }

        // SaleItem class
        class SaleItem
        {
            public int Number { get; }
            public Product Product { get; }
            public int Quantity { get; }

            public SaleItem(int number, Product product, int quantity)
            {
                Number = number;
                Product = product;
                Quantity = quantity;
            }

            public override string ToString()
            {
                return $"Number: {Number}, Product: {Product.Name}, Quantity: {Quantity}";
            }
        }

        // Sale class
        class Sale
        {
            public int Number { get; }
            public double Amount { get; }
            public List<SaleItem> SoldItems { get; }
            public DateTime Date { get; }

            public Sale(int number, DateTime date)
            {
                Number = number;
                SoldItems = new List<SaleItem>();
                Date = date;
                Amount = 0;
            }

            public void AddItem(Product product, int quantity)
            {
                AddItem(product, quantity, Amount);
            }

            public void AddItem(Product product, int quantity, double amount)
            {
                SoldItems.Add(new SaleItem(SoldItems.Count + 1, product, quantity));
#pragma warning disable IDE0059 // Unnecessary assignment of a value
                amount += product.Price * quantity;
#pragma warning restore IDE0059 // Unnecessary assignment of a value
                product.Count -= quantity;
            }


            public double GetAmount()
            {
                return Amount;
            }

            public void RemoveItem(Product product, int quantity, double amount)
            {
                SaleItem itemToRemove = SoldItems.Find(item => item.Product == product && item.Quantity == quantity);
                if (itemToRemove != null)
                {
                    SoldItems.Remove(itemToRemove);
                    amount -= product.Price * quantity;
                    product.Count += quantity;
                }
            }

            public override string ToString()
            {
                return $"Sale Number: {Number}, Amount: ${Amount}, Date: {Date.ToShortDateString()}, Sold Items: {SoldItems.Count}";
            }
        }

        // Interface for Market Management System
        interface IMarketable
        {
            void SellProduct(Product product, int quantity);
            void ReturnProductSale(int saleNumber, string productCode, int quantity);
            void RefundSale(int saleNumber);
            List<Sale> GetSalesByDateRange(DateTime startDate, DateTime endDate);
            List<Sale> GetSalesByDate(DateTime date);
            List<Sale> GetSalesByAmountRange(double minAmount, double maxAmount);
            Sale GetSaleByNumber(int saleNumber);
            void AddProduct(string name, double price, ProductCategory category, int count, string code);
            void UpdateProduct(string code, string name, double price, ProductCategory category, int count);
            List<Product> GetProductsByCategory(ProductCategory category);
            List<Product> GetProductsByPriceRange(double minPrice, double maxPrice);
            List<Product> SearchProductsByName(string search);
        }

        // Market Management System class
        private class MarketManagementSystem : IMarketable
        {
            private List<Product> products;
            private List<Sale> sales;

            public MarketManagementSystem()
            {
                products = new List<Product>();
                sales = new List<Sale>();
            }

            // Implementation of IMarketable interface methods...

            // Add your implementation for each method here...

            // Main method to display the console interface
            static void Main()
            {
                MarketManagementSystem marketSystem = new MarketManagementSystem();

                int choice;
                do
                {
                    Console.WriteLine("1. Operate on Products");
                    Console.WriteLine("2. Conduct Sales");
                    Console.WriteLine("3. Exit");

                    Console.Write("Enter your choice: ");
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            // Display options for product operations
                            Console.WriteLine("1. Add a new product");
                            Console.WriteLine("2. Make a correction on the product");
                            Console.WriteLine("3. Delete product");
                            Console.WriteLine("4. Show all products");
                            Console.WriteLine("5. Show products by category");
                            Console.WriteLine("6. Show products according to the price range");
                            Console.WriteLine("7. Search products by name");

                            // Add your code here to handle product operations...

                            break;
                        case 2:
                            // Display options for sales operations
                            Console.WriteLine("1. Add a new sale");
                            Console.WriteLine("2. Return any product on sale (withdrawal from sale)");
                            Console.WriteLine("3. Delete sale");
                            Console.WriteLine("4. Display all sales");
                            Console.WriteLine("5. Display sales according to the date range");
                            Console.WriteLine("6. Display sales according to the amount range");
                            Console.WriteLine("7. Display sales on a given date");
                            Console.WriteLine("8. Display information about a sale by number");

                            // Add your code here to handle sales operations...

                            break;
                        case 3:
                            Console.WriteLine("Exiting the system...");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }

                    Console.WriteLine();
                } while (choice != 3);
            }

            void IMarketable.AddProduct(string name, double price, ProductCategory category, int count, string code)
            {
                throw new NotImplementedException();
            }

            List<Product> IMarketable.GetProductsByCategory(ProductCategory category)
            {
                throw new NotImplementedException();
            }

            List<Product> IMarketable.GetProductsByPriceRange(double minPrice, double maxPrice)
            {
                throw new NotImplementedException();
            }

            Sale IMarketable.GetSaleByNumber(int saleNumber)
            {
                throw new NotImplementedException();
            }

            List<Sale> IMarketable.GetSalesByAmountRange(double minAmount, double maxAmount)
            {
                throw new NotImplementedException();
            }

            List<Sale> IMarketable.GetSalesByDate(DateTime date)
            {
                throw new NotImplementedException();
            }

            List<Sale> IMarketable.GetSalesByDateRange(DateTime startDate, DateTime endDate)
            {
                throw new NotImplementedException();
            }

            void IMarketable.RefundSale(int saleNumber)
            {
                throw new NotImplementedException();
            }

            void IMarketable.ReturnProductSale(int saleNumber, string productCode, int quantity)
            {
                throw new NotImplementedException();
            }

            List<Product> IMarketable.SearchProductsByName(string search)
            {
                throw new NotImplementedException();
            }

            void IMarketable.SellProduct(Product product, int quantity)
            {
                throw new NotImplementedException();
            }

            void IMarketable.UpdateProduct(string code, string name, double price, ProductCategory category, int count)
            {
                throw new NotImplementedException();
            }
        }
    }
    }
