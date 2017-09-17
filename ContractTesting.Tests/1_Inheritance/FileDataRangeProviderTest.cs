using ContractTesting.Core;
using ContractTesting.Core.Interfaces;

namespace ContractTesting.Tests._1_Inheritance
{
    public class FileDataRangeProviderTest : RangeProviderContractTestBase
    {
        protected override IDataRangeProvider CreateDataRangeProvider()
        {
            return new FileDataRangeProvider();
        }
    }
}