namespace SOLIDExamples._3___LSP.Second_Example
{
    public class Customer
    {
        public Address Address { get; private set; } //We use composition here because customer is not an address

        public void RegisterCustomerAddress(string street, string neighborhood, string city, int number)
        {
            Address = new Address(street, neighborhood, city, number);
        }
    }
}
