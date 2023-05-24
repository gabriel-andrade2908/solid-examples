using SOLIDExamples._5___DIP.Interfaces;

namespace SOLIDExamples._5___DIP
{
    public class CostumerService : ICostumerService
    {
        private readonly IReadingRepository _readingRepository;

        //Using dependency injection with constructor
        public CostumerService(IReadingRepository readingRepository)
        {
            _readingRepository = readingRepository;
        }

        public void GetAllCustomers()
        {
            _readingRepository.GetAllCostumers();
        }
    }
}
