using ContractTesting.Core;
using ContractTesting.Core.Interfaces;

namespace ContractTesting.Tests._1_Inheritance
{
    public class StorageDataRangeProviderTest : RangeProviderContractTestBase
    {
        protected override IDataRangeProvider CreateDataRangeProvider()
        {
            return new StorageDataRangeProvider();
        }
    }
}