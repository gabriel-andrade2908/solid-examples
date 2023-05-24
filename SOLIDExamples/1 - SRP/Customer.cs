using System;

namespace SOLIDExamples._1___SRP
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public Email Email { get; set; }
        public string CPF { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}