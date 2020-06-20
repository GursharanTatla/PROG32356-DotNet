using System;

namespace DisconnectedModel
{
    class Program
    {
        static void Main(string[] args)
        {
            CrudOperationsInDataSet crud = new CrudOperationsInDataSet();

            do
            {
                int choice = DisplayMenu();

                switch (choice)
                {
                    case 1: // Get All Products
                        crud.GetAllProducts();
                        break;

                    case 2: // Get Product by ID
                        Console.Write("\nEnter Product ID: ");
                        int id = int.Parse(Console.ReadLine());
                        crud.GetProductById(id);
                        break;

                    case 3: // Insert Product
                        Console.Write("\nEnter Product Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Product Price: ");
                        decimal price = decimal.Parse(Console.ReadLine());

                        Console.Write("Enter Product Quantity: ");
                        short quantity = short.Parse(Console.ReadLine());

                        crud.InsertProduct(name, price, quantity);
                        break;

                    case 4: // Update Product
                        Console.Write("\nEnter Product Id: ");
                        id = int.Parse(Console.ReadLine());
                        crud.GetProductById(id);

                        Console.Write("\nEnter Product Name: ");
                        name = Console.ReadLine();

                        Console.Write("Enter Product Price: ");
                        price = decimal.Parse(Console.ReadLine());

                        Console.Write("Enter Product Quantity: ");
                        quantity = short.Parse(Console.ReadLine());

                        crud.UpdateProduct(id, name, price, quantity);
                        break;

                    case 5: // Delete Product
                        Console.Write("\nEnter Product Id: ");
                        id = int.Parse(Console.ReadLine());

                        crud.DeleteProduct(id);
                        break;

                    case 6: // Exit
                        Environment.Exit(0);
                        break;
                }
            } while (true);
        }


        // method to display the menu
        static int DisplayMenu()
        {
            Console.WriteLine("\n\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
            Console.WriteLine("\t1 - Get all Products");
            Console.WriteLine("\t2 - Get Product by ID");
            Console.WriteLine("\t3 - Insert Product");
            Console.WriteLine("\t4 - Update Product");
            Console.WriteLine("\t5 - Delete Product");
            Console.WriteLine("\t6 - Exit");

            Console.Write("\nEnter your choice: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
