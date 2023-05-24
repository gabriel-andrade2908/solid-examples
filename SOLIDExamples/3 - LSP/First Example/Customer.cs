namespace SOLIDExamples._3___LSP.First_Example
{
    //We use inheritance here because customer is a person
    public class Customer : Person
    {
        public void RegisterCustomer(int age, string address, string name)
        {
            Age = age;
            Address = address;
            Name = name;
        }
    }
}
