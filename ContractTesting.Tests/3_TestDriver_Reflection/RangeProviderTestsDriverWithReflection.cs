using System;
using System.Linq;
using ContractTesting.Core.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace ContractTesting.Tests._3_TestDriver_Reflection
{
    [TestFixture]
    public class RangeProviderTestsDriverWithReflection
    {
        [Test]
        public void AllImplementations_ValidRangeShouldBeBetween10And25()
        {
            var interfaceType = typeof(IDataRangeProvider);

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