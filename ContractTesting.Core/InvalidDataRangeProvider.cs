using ContractTesting.Core.Interfaces;

namespace ContractTesting.Core
{
    public class InvalidDataRangeProvider : IDataRangeProvider
    {
        public int GetValidRange()
        {
            return -10;
        }
    }
}