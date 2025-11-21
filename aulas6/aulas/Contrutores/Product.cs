using System.Globalization;
namespace Contrutores
{
    public class Product
    {
        private string _name;
        private double _price;
        private int _quantity;
        
        public Product(string name, double price, int quantity)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
        }

        public Product(string name, double price)
        {
            _name = name;
            _price = price;
        }

        public Product()
        {
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public double GetPrice()
        {
            return _price;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public double TotalValueInStock()
        {
            return _price * _quantity;
        }

        public void AddProducts(int quantity)
        {
            _quantity += quantity;
        }

        public void RemoveProducts(int quantity)
        {
            _quantity -= quantity;
        }

        public override string ToString()
        {
            return _name
                + ", $ "
                + _price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantity
                + " units, Total: $ "
                + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}