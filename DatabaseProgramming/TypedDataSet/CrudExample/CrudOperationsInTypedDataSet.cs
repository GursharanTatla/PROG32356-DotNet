using System;

namespace TypedDataSetExample
{
    public class CrudOperationsInTypedDataSet
    {
        // fields
        private NorthwindDataSetTableAdapters.ProductsTableAdapter _adpProducts;
        private NorthwindDataSet.ProductsDataTable _tblProducts;

        // constructor
        public CrudOperationsInTypedDataSet()
        {
            _adpProducts = new NorthwindDataSetTableAdapters.ProductsTableAdapter();
            _tblProducts = new NorthwindDataSet.ProductsDataTable();
        }

        // method to get all the products
        public void GetAllProducts()
        {
            // using Fill() method
            //_adpProducts.FillProducts(_tblProducts);

            // using Get() method
            _tblProducts = _adpProducts.GetProducts();

            //Console.WriteLine("\n\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
            foreach (var row in _tblProducts)
            {
                Console.WriteLine($"{row.ProductID,5} {row.ProductName,-40} {row.UnitPrice,10} {row.UnitsInStock,10}");
            }
        }

        // method to get a product by ID
        public void GetProductById(int id)
        {
            _tblProducts = _adpProducts.GetProducts();

            var row = _tblProducts.FindByProductID(id);

            if (row != null)
                Console.WriteLine($"{row.ProductID,5} {row.ProductName,-40} {row.UnitPrice,10} {row.UnitsInStock,10}");
            else
                Console.WriteLine("Invalid Product ID. Please try again.");
        }

        // method to insert a new product
        public void InsertProduct(string name, decimal price, short quantity)
        {
            _adpProducts.Insert(name, price, quantity);
        }

        // method to update a product
        public void UpdateProduct(int id, string name, decimal price, short quantity)
        {
            _adpProducts.Update(name, price, quantity, id);
        }

        // method to delete a product
        public void DeleteProduct(int id)
        {
            _adpProducts.Delete(id);
        }
    }
}
