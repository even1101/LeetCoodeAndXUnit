using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xunit.Sdk;

namespace MyLeetCode_XUnitTests.TestData
{
    public class TestDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { -123, -321 };
            yield return new object[] { 1230, 321 };
            yield return new object[] { -320, -23 };
            yield return new object[] { 990, 99 };
        }
    }
}
