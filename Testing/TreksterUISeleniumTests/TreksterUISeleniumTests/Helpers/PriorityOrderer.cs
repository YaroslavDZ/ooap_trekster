using Xunit.Abstractions;
using Xunit.Sdk;

namespace TreksterUISeleniumTests.Helpers
{
    public class PriorityOrderer : ITestCaseOrderer
    {
        public IEnumerable<TTestCase> OrderTestCases<TTestCase>(
        IEnumerable<TTestCase> testCases) where TTestCase : ITestCase
        {
            var sorted = testCases.OrderBy(tc =>
            {
                var attr = tc.TestMethod.Method
                    .GetCustomAttributes(typeof(TestPriorityAttribute).AssemblyQualifiedName)
                    .FirstOrDefault();

                return attr == null ? 0 : attr.GetNamedArgument<int>("Priority");
            });

            return sorted;
        }
    }
}
