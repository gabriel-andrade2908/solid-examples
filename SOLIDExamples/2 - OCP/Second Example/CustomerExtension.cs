namespace SOLIDExamples._2___OCP.Second_Example
{
    //New implementetation without changing the already created class  
    public static class CustomerExtension
    {
        public static int GetCustomerNameLegth(this Customer customer)
        {
            return customer.GetCustomerFullName().Length;
        }
    }
}
