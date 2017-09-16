using System;
using System.Collections.Generic;
using System.Linq;
using ContractTesting.Core.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace ContractTesting.Tests
{
    [TestFixture]
    public class RangeProviderTestsDriverWithReflection
    {
        [Test]
        public void AllImplementations_ValidRangeShouldBeBetween10And25()
        {
            var interfaceType = typeof(IDataRangeProvider);

            IList<IDataRangeProvider> providersToTest = new List<IDataRangeProvider>();

            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => t.IsClass && interfaceType.IsAssignableFrom(t));

            foreach (var type in types)
            {
                var provider = (IDataRangeProvider) Activator.CreateInstance(type);
                provider.GetValidRange().Should().BeInRange(10, 25);
            }
        }
    }
}