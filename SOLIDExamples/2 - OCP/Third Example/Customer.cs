namespace SOLIDExamples._2___OCP.Third_Example
{
    public class Customer
    {
        public string Name { get; private set; }
        public double TotalPurchaseAmount { get; private set; }

        //If the amount neeeds to be changed, we don't change the class, only the policy
        public bool CanCustomerReceiveADiscount(ICustomerPolicy policy)
        {
            return TotalPurchaseAmount > policy.GetAmountRequiredForCustomerToReceiveDiscount();
        }
    }
}
