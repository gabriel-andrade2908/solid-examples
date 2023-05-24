namespace SOLIDExamples._3___LSP.Second_Example
{
    public class Address
    {
        public Address(string street, string neighborhood, string city, int number)
        {
            Street = street;
            Neighborhood = neighborhood;
            City = city;
            Number = number;
        }

        public string Street { get; protected set; }
        public string Neighborhood { get; protected set; }
        public string City { get; protected set; }
        public int Number { get; protected set; }
    }
}
