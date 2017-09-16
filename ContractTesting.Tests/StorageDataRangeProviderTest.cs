using ContractTesting.Core;
using ContractTesting.Core.Interfaces;

namespace ContractTesting.Tests
{
    public class StorageDataRangeProviderTest : RangeProviderContractTestBase
    {
        protected override IDataRangeProvider CreateDataRangeProvider()
        {
            return new StorageDataRangeProvider();
        }
    }
}