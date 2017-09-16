using ContractTesting.Core.Interfaces;

namespace ContractTesting.Tests
{
    public class FileDataRangeProviderTest : RangeProviderContractTestBase
    {
        protected override IDataRangeProvider CreateDataRangeProvider()
        {
            return new FileDataRangeProvider();
        }
    }
}