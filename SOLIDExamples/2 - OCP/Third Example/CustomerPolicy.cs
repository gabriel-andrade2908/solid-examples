namespace SOLIDExamples._2___OCP.Third_Example
{
    public class CustomerExtension : ICustomerPolicy
    {
        public double GetAmountRequiredForCustomerToReceiveDiscount()
        {
            return 500;
        }
    }
}
