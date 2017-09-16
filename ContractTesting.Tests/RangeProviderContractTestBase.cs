using ContractTesting.Core.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace ContractTesting.Tests
{
    [TestFixture]
    public abstract class RangeProviderContractTestBase
    {
        protected abstract IDataRangeProvider CreateDataRangeProvider();

        [Test]
        public void ValidRangeShouldBeBetween10And25()
        {
            var dataRangeProvider = CreateDataRangeProvider();

            dataRangeProvider.GetValidRange().Should().BeInRange(10, 25);
        }
    }
}