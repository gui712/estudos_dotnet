namespace Produto
{
    public class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public double TotalValueInStock()
        {
            return Price * Quantity;
        }

        public void AddProducts(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoveProducts(int quantity)
        {
            Quantity -= quantity;
        }

        public override string ToString()
        {
            return Name
                + ", $ "
                + Price.ToString("F2")
                + ", "
                + Quantity
                + " units, Total: $ "
                + TotalValueInStock().ToString("F2");
        }
    }
}