namespace SOLIDExamples._2___OCP.Second_Example
{
    //Class already created and tested
    public class Customer
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }

        public string GetCustomerFullName()
        {
            return Name + " " + LastName;
        }
    }
}
