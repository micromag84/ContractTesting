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
        private void AssertAllImplementationsOf<T>(Action<T> action)
        {
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => t.IsClass && typeof(T).IsAssignableFrom(t)).ToList();

            types.ForEach(type =>
            {
                var instance = (IDataRangeProvider) Activator.CreateInstance(type);
                action((T) instance);
            });
        }


        [Test]
        public void AllImplementations_ValidRangeShouldBeBetween10And25()
        {
            AssertAllImplementationsOf<IDataRangeProvider>(provider =>
            {
                provider.GetValidRange().Should().BeInRange(10, 25, $"of type '{provider.GetType().Name}'");
            });
        }
    }
}