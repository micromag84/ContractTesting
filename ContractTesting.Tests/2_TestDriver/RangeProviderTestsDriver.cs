using System.Collections.Generic;
using ContractTesting.Core;
using ContractTesting.Core.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace ContractTesting.Tests._2_TestDriver
{
    [TestFixture]
    public class RangeProviderTestsDriver
    {
        [Test]
        public void AllImplementations_ValidRangeShouldBeBetween10And25()
        {
            IList<IDataRangeProvider> providersToTest = new List<IDataRangeProvider>();
            providersToTest.Add(new FileDataRangeProvider());
            providersToTest.Add(new StorageDataRangeProvider());

            foreach (var provider in providersToTest)
                provider.GetValidRange().Should().BeInRange(10, 25, $"of type '{provider.GetType().Name}'");
        }
    }
}