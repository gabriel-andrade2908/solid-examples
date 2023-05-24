namespace SOLIDExamples._3___LSP.Third_Example
{
    //*VIOLATION*
    //Here we should use composition instead of inheritance, because customer is not a shopping cart
    public class Customer : ShoppingCart
    {
        public void RegisterCustomerShoppingCart(double totalValue, int productsQuantity)
        {
            TotalValue = totalValue;
            ProductsQuantity = productsQuantity;
        }
    }
}
