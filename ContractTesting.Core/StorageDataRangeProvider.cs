using ContractTesting.Core.Interfaces;

namespace ContractTesting.Core
{
    public class StorageDataRangeProvider : IDataRangeProvider
    {
        public int GetValidRange()
        {
            return 15;
        }
    }
}