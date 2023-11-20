namespace Recipies
{
    public class ProductCreator
    {
        public static Product CreateProduct(string description, double unitCost)
        {
            return new Product(description, unitCost);
        }
    }
}