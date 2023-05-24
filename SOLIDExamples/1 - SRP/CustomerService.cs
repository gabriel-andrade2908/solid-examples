namespace SOLIDExamples._1___SRP
{
    //All classes and methods have a single responsibility
    public static class CustomerService
    {
        public static string AddCustomer(Customer customer)
        {
            CustomerRepository.AddCustomer(customer);

            EmailServices.Send("company@company.com", customer.Email.Address, "Welcome",
                "Congratulations! You are registered.");

            return "Customer registered successfully!";
        }
    }
}